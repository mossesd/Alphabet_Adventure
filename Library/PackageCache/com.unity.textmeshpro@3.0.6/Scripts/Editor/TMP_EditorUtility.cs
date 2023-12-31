"Bad Client protocol version");
				writeUInt32(0, buf);
				if (socket.isActive)
					socket.write(buf);
				socket.end();
				socket.forceQuit = true;
				return false;
			}
		}
		
		// Write a a file to a temp location and move it in place when it has completed
		if (socket.activePutFile != null)
		{
			var size = data.length;
			if (socket.bytesToBeWritten < size)
				size = socket.bytesToBeWritten;
			socket.activePutFile.write (data.slice(0, size), "binary");
			socket.bytesToBeWritten -= size;
			
			// If we have written all data for this file. We can close the file.
			if (socket.bytesToBeWritten <= 0)
			{
				socket.activePutFile.on('close', function()
				{
					fs.stat(socket.activePutTarget, function (statsErr, stats)
					{
						// We are replacing a file, we need to subtract this from the totalFileSize
						var size = 0;
						if (!statsErr && stats)
						{
							size = stats.size;
						}
						
						fs.rename(socket.tempPath, socket.activePutTarget, function (err)
						{
							if (err)
							{
								log(DBG, "Failed to move file in place " + socket.tempPath + " to " + socket.activePutTarget + err);				
							}
							else
							{
								AddFileToCache (socket.totalFileSize - size);
							}
							
							socket.activePutTarget = null;
							socket.totalFileSize = 0;

							if (socket.isPaused && socket.isActive)
								socket.resume();
						});
					});
				});
				
				socket.activePutFile.end();
				socket.activePutFile.destroySoon();
				socket.activePutFile = null;
				
				data = data.slice(size);
				continue;
			}
			// We need more data to write the file completely
			// Return and wait for the next call to handleData to receive more data.
			else
			{
				return true;
			}
		}
		//  Serve a file from the cache server to the client
		else if (data[idx] == CMD_GET)
		{
			///@TODO: What does this do?
			if (data.length < CMD_SIZE + ID_SIZE)
			{
				socket.pendingData = data;
				return true;
			}
			idx += 1;
			var guid = readHex(GUID_SIZE, data.slice(idx));
			var hash = readHex(HASH_SIZE, data.slice(idx+GUID_SIZE));
			log(DBG, "Get " + guid + "_" + hash);
			
			var resbuf = new buffers.Buffer(CMD_SIZE + LEN_SIZE + ID_SIZE);
			data.copy(resbuf, CMD_SIZE + LEN_SIZE, idx, idx + ID_SIZE); // copy guid+hash
			
			socket.getFileQueue.unshift( { buffer : resbuf, cacheStream : GetCachePath(guid, hash, false) } );
			
			if (!socket.activeGetFile)
			{
				sendNextGetFile(socket);
			}
			
			data = data.slice(idx+GUID_SIZE+HASH_SIZE);
			continue;
		}
		// Put a file from the client to the cache server
		else if (data[idx] == CMD_PUT)
		{ 
			/// * We don't have enough data to start the put request. (wait for more data)
			if (data.length < CMD_SIZE + LEN_SIZE + ID_SIZE)
			{
				socket.pendingData = data;
				return true;
			}

			// We have not completed writing the previous file
			if (socket.activePutTarget != null)
			{
				// If we are using excessive amounts of memory
				if (data.length > maximumHeapSocketBufferSize)
				{
					var sizeMB = data.length / (1024 * 1024);
					log(DBG, "Pausing socket for in progress file to be written in order to keep memory usage low... " + sizeMB + " mb");				
					socket.isPaused = true;
					if (socket.isActive)
						socket.pause();
				}

				// Keep the data in pending for the next handleData call
				socket.pendingData = data;
				
				return true;
			}
			
			idx += 1;
			var size = readUInt64(data.slice(idx));
			var guid = readHex(GUID_SIZE, data.slice(idx+LEN_SIZE));
			var hash = readHex(HASH_SIZE, data.slice(idx+LEN_SIZE+GUID_SIZE));
			log(DBG, "PUT " + guid + "_" + hash + " (size " + size + ")");
			
			socket.activePutTarget = GetCachePath(guid, hash, true);
			socket.tempPath = cacheDir + "/Temp"+uuid();
			socket.activePutFile = fs.createWriteStream(socket.tempPath);			
			
			socket.activePutFile.on ('error', function(err)
			{
				 // Test that this codepath works correctly
				 log(ERR, "Error writing to file " + err + ". Possibly the disk is full? Please adjust --cacheSize with a more accurate maximum cache size");
				 FreeSpace (gTotalDataSize * freeCacheSizeRatioWriteFailure);
				 socket.destroy();
				 return false;
			});
			socket.bytesToBeWritten = size;
			socket.totalFileSize = size;
			
			data = data.slice(idx+LEN_SIZE+GUID_SIZE+HASH_SIZE);
			continue;
		}
		
		// We need more data to write the file completely
		return true;
	}
}

var server = net.createServer(function (socket)
{
	socket.getFileQueue = [];
	socket.protocolVersion = null;
	socket.activePutFile = null;
	socket.activeGetFile = null;
	socket.pendingData = null;
	socket.bytesToBeWritten = 0;
	socket.totalFileSize = 0;
	socket.isPaused = 0;
	socket.isActive = true;
	socket.forceQuit = false;

	socket.on('data', function (data)
	{
		socket.isActive = true;
		handleData (socket, data);
	});
	socket.on('close', function (had_errors)
	{
		log(ERR, "Socket closed");
		socket.isActive = false;
		var checkFunc = function () 
		{
			var data = new Buffer (0);
			if (handleData (socket, data))
			{
				setTimeout (checkFunc, 1);
			}
		}
		
		if (!had_errors && !socket.forceQuit)
			checkFunc ();
	});
	socket.on('error', function (err)
	{
		log(ERR, "Socket error " + err);
	});
});

function sendNextGetFile(socket)
{
    if (socket.getFileQueue.length == 0)
	{
	    socket.activeGetFile = null;
		return;
    }
    var next = socket.getFileQueue.pop();
    var resbuf = next.buffer;
    var file = fs.createReadStream(next.cacheStream);
    // make sure no data is read and lost before we have called file.pipe().
    file.pause();
    socket.activeGetFile = file;
    var errfunc = function(err)
	{
		var buf = new buffers.Buffer(CMD_SIZE+ID_SIZE);
		buf[0] = CMD_GETNOK;
		var id_offset = CMD_SIZE + LEN_SIZE;
		resbuf.copy(buf, 1, id_offset, id_offset + ID_SIZE);
		try
		{
			socket.write(buf);
		}
		catch (err)
		{
			log(ERR, "Error sending file data to socket " + err);
		}
		finally
		{
			if (socket.isActive)
			{
				sendNextGetFile(socket);
			}
			else
			{
				log (ERR, "Socket close, close active file");
				file.close();
			}
		};
	}

	file.on ('close', function()
	{
		socket.activeGetFile = null;
		if (socket.isActive)
		{
			sendNextGetFile(socket);
		}
	});
    
	file.on('open', function(fd)
	{
	    fs.fstat(fd, function(err, stats)
		{
		    if (err) 
				errfunc(err);
			else
			{
				resbuf[0] = CMD_GETOK;
				writeUInt64(stats.size, resbuf.slice(1));
				log(INFO, "found: "+next.cacheStream + " size:" + stats.size);
		
				// The ID is already written
				try
				{
					socket.write(resbuf);
					file.resume();
					file.pipe(socket, { end: false });
				}
				catch (err)
				{
					log(ERR, "Error sending file data to socket " + err);
					file.close();
				};
			}
		});
    });

   file.on('error', errfunc);
}

exports.log = log;

exports.ERR = ERR;
exports.WARN = WARN;
exports.INFO = INFO;
exports.DBG = DBG;

/**
 * Get version
 *
 * @return version
 */
exports.GetVersion = function ()
{
	return version;
}

/**
 * Get server port
 *
 * @return server port
 */
exports.GetPort = function ()
{
	return port;
}

/**
 * Get cache directory
 *
 * @return cache directory
 */
exports.GetCacheDir = function ()
{
	return path.resolve (cacheDir);
}

/**
 * start the cache server
 *
 * @param a_cacheSize maximum cache size
 * @param a_path cache path
 * @param a_logFn log function (optional)
 * @param a_errCallback error callback (optional)
 */
exports.Start = function (a_cacheSize, a_path, a_logFn, a_errCallback)
{
	if (a_logFn)
	{
		log = a_logFn;
	}

	maxCacheSize = a_cacheSize || maxCacheSize;
	cacheDir = a_path ||Â cacheDir;

	InitCache ();

	server.on ('error', function (e) 
	{
		if (e.code == 'EADDRINUSE') 
		{
			log (ERR, 'Port ' + port +' is already in use...');
			if (a_errCallback)
			{
				a_errCallback (e);
			}
		}
	});

	server.listen (port);
};
                                                                                                                                                                                                                                                                                                                                                   t               0.0.0 ţ˙˙˙      ˙˙f!ë59Ý4QÁóB   í          7  ˙˙˙˙                 Ś ˛                       E                    Ţ  #                     . ,                     5   a                    Ţ  #                     . ,                      r                    Ţ  #      	               . ,      
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    ń  J   ˙˙˙˙   Ŕ           1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               \     ˙˙˙˙               H r   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H w   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H    ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                     Ţ  #      !               . ,      "                   ˙˙˙˙#   @          1  1  ˙˙˙˙$               Ţ      %               . j     &               Ő    ˙˙˙˙'               1  1  ˙˙˙˙(    Ŕ            Ţ      )                  j  ˙˙˙˙*                H   ˙˙˙˙+               1  1  ˙˙˙˙,   @            Ţ      -                Q  j     .                y 
    /                 Ţ  #      0               . ,      1                 §      2    @            ž ś      3    @            Ţ  #      4               . ,      5               H ť   ˙˙˙˙6              1  1  ˙˙˙˙7   @            Ţ      8                Q  j     9                H Ć   ˙˙˙˙:              1  1  ˙˙˙˙;   @            Ţ      <                Q  j     =                H Ř   ˙˙˙˙>              1  1  ˙˙˙˙?   @            Ţ      @                Q  j     A              MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_UsedFileIDs m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant     s    ˙˙ŁGń×ÜZ56 :!@iÁJ*          7  ˙˙˙˙                 Ś ˛                        E                    Ţ                       .                      (   a                    Ţ                       .                       r                    Ţ        	               .       
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    H ę ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     ń  =   ˙˙˙˙              1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               H   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                    Ţ                       .                      y Q                       Ţ                       .                       Ţ  X      !                H i   ˙˙˙˙"              1  1  ˙˙˙˙#   @            Ţ      $                Q  j     %                H u   ˙˙˙˙&              1  1  ˙˙˙˙'   @            Ţ      (                Q  j     )              PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_DefaultReferences m_Icon m_ExecutionOrder m_ClassName m_Namespace                        \       ŕyŻ     `                                                                                                                                                       ŕyŻ                                                                                    MemberInfoStubWriter  using System.Reflection;

namespace Unity.VisualScripting
{
    public abstract class MemberInfoStubWriter<T> : AotStubWriter where T : MemberInfo
    {
        protected MemberInfoStubWriter(T memberInfo) : base(memberInfo)
        {
            stub = memberInfo;
            manipulator = stub.ToManipulator();
        }

        public new T stub { get; }
        protected Member manipulator { get; }

        public override string stubMethodComment => stub.ReflectedType.CSharpFullName() + "." + stub.Name;

        public override string stubMethodName => stubMethodComment.FilterReplace('_', true, symbols: false, whitespace: false, punctuation: false);
    }
}
                        MemberInfoStubWriter                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      ÝUÁnă6˝÷+\őB4mĹąlËP[ ŮvÓ6ťé%0ZGL$J )gS