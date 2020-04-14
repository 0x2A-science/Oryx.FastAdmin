/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ModifyBgpPeerAttributeRequest : RpcAcsRequest<ModifyBgpPeerAttributeResponse>
    {
        public ModifyBgpPeerAttributeRequest()
            : base("Vpc", "2016-04-28", "ModifyBgpPeerAttribute", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string bgpGroupId;

		private string peerIpAddress;

		private bool? enableBfd;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string bgpPeerId;

		private long? ownerId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string BgpGroupId
		{
			get
			{
				return bgpGroupId;
			}
			set	
			{
				bgpGroupId = value;
				DictionaryUtil.Add(QueryParameters, "BgpGroupId", value);
			}
		}

		public string PeerIpAddress
		{
			get
			{
				return peerIpAddress;
			}
			set	
			{
				peerIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PeerIpAddress", value);
			}
		}

		public bool? EnableBfd
		{
			get
			{
				return enableBfd;
			}
			set	
			{
				enableBfd = value;
				DictionaryUtil.Add(QueryParameters, "EnableBfd", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string BgpPeerId
		{
			get
			{
				return bgpPeerId;
			}
			set	
			{
				bgpPeerId = value;
				DictionaryUtil.Add(QueryParameters, "BgpPeerId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

        public override ModifyBgpPeerAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyBgpPeerAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
