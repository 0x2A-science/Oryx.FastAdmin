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
using Aliyun.Acs.Netana.Transform;
using Aliyun.Acs.Netana.Transform.V20181018;

namespace Aliyun.Acs.Netana.Model.V20181018
{
    public class DescribeNetworkAnalyticsDataTransferRequest : RpcAcsRequest<DescribeNetworkAnalyticsDataTransferResponse>
    {
        public DescribeNetworkAnalyticsDataTransferRequest()
            : base("Netana", "2018-10-18", "DescribeNetworkAnalyticsDataTransfer", "Netana", "openAPI")
        {
        }

		private string country;

		private long? resourceOwnerId;

		private string product;

		private string period;

		private string resourceOwnerAccount;

		private string ip;

		private string endTime;

		private string startTime;

		private string pageNumber;

		private string carrier;

		private string instanceId;

		private string province;

		private string internetChargeType;

		private string grade;

		private string pageSize;

		private string direction;

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

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

		public string Product
		{
			get
			{
				return product;
			}
			set	
			{
				product = value;
				DictionaryUtil.Add(QueryParameters, "Product", value);
			}
		}

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
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

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value);
			}
		}

		public string Carrier
		{
			get
			{
				return carrier;
			}
			set	
			{
				carrier = value;
				DictionaryUtil.Add(QueryParameters, "Carrier", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
				DictionaryUtil.Add(QueryParameters, "Province", value);
			}
		}

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
			}
		}

		public string Grade
		{
			get
			{
				return grade;
			}
			set	
			{
				grade = value;
				DictionaryUtil.Add(QueryParameters, "Grade", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value);
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

        public override DescribeNetworkAnalyticsDataTransferResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeNetworkAnalyticsDataTransferResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
