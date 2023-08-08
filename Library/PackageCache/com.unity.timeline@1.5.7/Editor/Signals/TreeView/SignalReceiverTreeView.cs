tream();
				long nodeCount = ChildNodeCount;
				if (nodeCount==0)
				{
					if (data != null)
					{
						xdata.Write(data, 0, data.Length);
					}
				}
				else
				{
					Asn1Node tempNode;
					for (int i=0; i<nodeCount; i++)
					{
						tempNode = GetChildNode(i);
						tempNode.SaveData(xdata);
					}
				}
				byte[] tmpData = new byte[xdata.Length];
				xdata.Position = 0;
				xdata.Read(tmpData, 0, (int)xdata.Length);
				xdata.Close();
				return tmpData;
			}
			set
			{
				SetData(value);
			}
		}

		/// <summary>
		/// Get the deepness of the node.
		/// </summary>
		public long Deepness
		{
			get
			{
				return deepness;
			}
		}

		/// <summary>
		/// Get data offset.
		/// </summary>
		public long DataOffset
		{
			get
			{
				return dataOffset;
			}
		}

		/// <summary>
		/// Get unused bits for BITSTRING.
		/// </summary>
		public byte UnusedBits
		{
			get
			{
				return unusedBits;
			}
			set
			{
				unusedBits = value;
			}
		}


		/// <summary>
		/// Get descendant node by node path.
		/// </summary>
		/// <param name="nodePath">relative node path that refer to current node.</param>
		/// <returns></returns>
		public Asn1Node GetDescendantNodeByPath(string nodePath)
		{
			Asn1Node retval = this;
			if (nodePath == null) return retval;
			nodePath = nodePath.TrimEnd().TrimStart();
			if (nodePath.Length<1) return retval;
			string[] route = nodePath.Split('/');
			try
			{
				for (int i = 1; i<route.Length; i++)
				{
					retval = retval.GetChildNode(Convert.ToInt32(route[i]));
				}
			}
			catch
			{
				retval = null;
			}
			return retval;
		}

		/// <summary>
		/// Get node by OID.
		/// </summary>
		/// <param name="oid">OID.</param>
		/// <param name="startNode">Starting node.</param>
		/// <returns>Null or Asn1Node.</returns>
		static public Asn1Node GetDecendantNodeByOid(string oid, Asn1Node startNode)
		{
			Asn1Node retval = null;
			Oid xoid = new Oid();
			for (int i = 0; i<startNode.ChildNodeCount; i++)
			{
				Asn1Node childNode = startNode.GetChildNode(i);
				int tmpTag = childNode.tag & Asn1Tag.TAG_MASK;
				if (tmpTag == Asn1Tag.OBJECT_IDENTIFIER)
				{
					if (oid == xoid.Decode(childNode.Data))
					{
						retval = childNode;
						break;
					}
				}
				retval = GetDecendantNodeByOid(oid, childNode);
				if (retval != null) break;
			}
			return retval;
		}

		/// <summary>
		/// Constant of tag field length.
		/// </summary>
		public const int TagLength = 1;

		/// <summary>
		/// Constant of unused bits field length.
		/// </summary>
		public const int BitStringUnusedFiledLength = 1;

		/// <summary>
		/// Tag text generation mask definition.
		/// </summary>
		public class TagTextMask
		{
			/// <summary>
			/// Show offset.
			/// </summary>
			public const uint SHOW_OFFSET			= 0x01;

			/// <summary>
			/// Show decoded data.
			/// </summary>
			public const uint SHOW_DATA			    = 0x02;

			/// <summary>
			/// Show offset in hex format.
			/// </summary>
			public const uint USE_HEX_OFFSET		= 0x04;

			/// <summary>
			/// Show tag.
			/// </summary>
			public const uint SHOW_TAG_NUMBER		= 0x08;

			/// <summary>
			/// Show node path.
			/// </summary>
			public const uint SHOW_PATH             = 0x10;
		}

		/// <summary>
		/// Set/Get requireRecalculatePar. RecalculateTreePar function will not do anything
		/// if it is set to false.
		/// </summary>
		protected bool RequireRecalculatePar
		{
			get
			{
				return requireRecalculatePar;
			}
			set
			{
				requireRecalculatePar = value;
			}
		}

		//ProtectedMembers

		/// <summary>
		/// Find root node and recalculate entire tree length field,
		/// path, offset and deepness.
		/// </summary>
		protected void RecalculateTreePar()
		{
			if (!requireRecalculatePar) return;
			Asn1Node rootNode;
			for (rootNode = this; rootNode.ParentNode != null;)
			{
				rootNode = rootNode.ParentNode;
			}
			ResetBranchDataLength(rootNode);
			rootNode.dataOffset = 0;
			rootNode.deepness = 0;
			long subOffset = rootNode.dataOffset + TagLength + rootNode.lengthFieldBytes;
			ResetChildNodePar(rootNode, subOffset);
		}

		/// <summary>
		/// Recursively set all the node data length.
		/// </summary>
		/// <param name="node"></param>
		/// <returns>node data length.</returns>
		protected static long ResetBranchDataLength(Asn1Node node)
		{
			long retval = 0;
			long childDataLength = 0;
			if (node.ChildNodeCount < 1)
			{
				if (node.data != null)
					childDataLength += node.data.Length;
			}
			else
			{
				for (int i=0; i<node.ChildNodeCount; i++)
				{
					childDataLength += ResetBranchDataLength(node.GetChildNode(i));
				}
			}
			node.dataLength = childDataLength;
			if (node.tag == Asn1Tag.BIT_STRING)
				node.dataLength += BitStringUnusedFiledLength;
			ResetDataLengthFieldWidth(node);
			retval = node.dataLength + TagLength + node.lengthFieldBytes;
			return retval;
		}

		/// <summary>
		/// Encode the node data length field and set lengthFieldBytes and dataLength.
		/// </summary>
		/// <param name="node">The node needs to be reset.</param>
		protected static void ResetDataLengthFieldWidth(Asn1Node node)
		{
			MemoryStream tempStream = new MemoryStream();
			Asn1Util.DERLengthEncode(tempStream, (ulong) node.dataLength);
			node.lengthFieldBytes = tempStream.Length;
			tempStream.Close();
		}

		/// <summary>
		/// Recursively set all the child parameters, except dataLength.
		/// dataLength is set by ResetBranchDataLength.
		/// </summary>
		/// <param name="xNode">Starting node.</param>
		/// <param name="subOffset">Starting node offset.</param>
