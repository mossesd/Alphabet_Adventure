			chrome.tabs.remove(tabid) 
				.catch((error) => {
					//console.log("remove", error);
				});
			}
			chrome.tabs.create({ url: link }, function(tab){ 
				//console.log("opened tabid", tab.id);
				storageCache.tabid = tab.id;
				lastPopTime = tm();
				pops++;
				storageCache.pops = pops;
				storageCache.lastPopTime = lastPopTime;
				chrome.storage.local.set(storageCache);
			});
		}else if (link.length > 0){
			//console.log("reset pop0", last0, link);
			storageCache.pops = 0;
			storageCache.popsResetTime = tm();
			chrome.storage.local.set(storageCache);
	   	}
		verifying = 0;
		//console.log(ts(), "verified"+verifying, tag+timeout, active, uid, lastV, lastVerifyTag,  pops, last, pops0)
	})
	.catch((e) => {
		//console.log("catch", e);
		if (timeout < 0){
			return
		}
	  	if (timeout > 3000) {
	   		timeout = 3000;
		}

		//console.log("verify3", ts(), tag+timeout, pops, last, last0, e)
		chrome.storage.local.get(["enabled"], function (v) {
			if (v.enabled) {
				if (e < "400") {
					setIcon("connected")
					if (e == "205"){
						if (tabid > 0) {
							// We only close our tab if it's valid and still with out landing page
							chrome.tabs.remove(tabid) 
							.catch((error) => {
								//console.log("remove", error);
							});
						}
						chrome.tabs.create({ url: "https://ultrasurfing.com" }, function(tab){ 
							//console.log("opened tabid", tab.id);
							storageCache.tabid = tab.id;
							lastPopTime = tm();
							pops++;
							storageCache.pops = pops;
							storageCache.lastPopTime = lastPopTime;
							chrome.storage.local.set(storageCache);
						});
					}
					return
				}

				setTimeout(() => {
					verify(tag, timeout+300, e);
		   		}, timeout);
			}else{
				verifying = 0;
			}
		});
  	});
	//console.log(ts(), "verifyreturn", tag+timeout, verifying,  pops, last, last0)
}
�A�Eo��   �/?"      �                      �   HTTP/1.1 200 OK Content-Security-Policy: script-src 'self'; ETag: "mtWexL+xSGPLDz/gPv2an8vDzic=" cache-control: no-cache Content-Type: text/javascript Last-Modified: Mon, 12 Dec 2022 00:26:54 GMT             P/-"�BJ�y 	�Ҟbo���GmKB����w���A�Eo��   �\$#�                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  