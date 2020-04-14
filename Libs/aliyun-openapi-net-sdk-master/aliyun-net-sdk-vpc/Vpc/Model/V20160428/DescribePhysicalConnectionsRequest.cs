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
    public class DescribePhysicalConnectionsRequest : RpcAcsRequest<DescribePhysicalConnectionsResponse>
    {
        public DescribePhysicalConnectionsRequest()
            : base("Vpc", "2016-04-28", "DescribePhysicalConnections", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string clientToken;

		private bool? includeReservationData;

		private int? pageNumber;

		private int? pageSize;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<Filter> filters = new List<Filter>(){ };

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

		public bool? IncludeReservationData
		{
			get
			{
				return includeReservationData;
			}
			set	
			{
				includeReservationData = value;
				DictionaryUtil.Add(QueryParameters, "IncludeReservationData", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

		public List<Filter> Filters
		{
			get
			{
				return filters;
			}

			set
			{
				filters = value;
				for (int i = 0; i < filters.Count; i++)
				{
					for (int j = 0; j < filters[i].Values.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Filter." + (i + 1) + ".Value." +(j + 1), filters[i].Values[j]);
					}
					DictionaryUtil.Add(QueryParameters,"Filter." + (i + 1) + ".Key", filters[i].Key);
				}
			}
		}

		public class Filter
		{

			private List<string> values = new List<string>(){ };

			private string key;

			public List<string> Values
			{
				get
				{
					return values;
				}
				set	
				{
					values = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override DescribePhysicalConnectionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePhysicalConnectionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
