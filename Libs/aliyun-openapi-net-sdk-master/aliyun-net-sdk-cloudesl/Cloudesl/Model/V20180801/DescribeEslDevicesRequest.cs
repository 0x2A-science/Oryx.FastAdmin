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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20180801;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
    public class DescribeEslDevicesRequest : RpcAcsRequest<DescribeEslDevicesResponse>
    {
        public DescribeEslDevicesRequest()
            : base("cloudesl", "2018-08-01", "DescribeEslDevices")
        {
        }

		private string eslStatus;

		private int? toBatteryLevel;

		private string storeId;

		private string type;

		private string mac;

		private int? pageNumber;

		private int? fromBatteryLevel;

		private string shelfCode;

		private string eslBarCode;

		private string vendor;

		private int? pageSize;

		private bool? beBind;

		private string itemBarCode;

		public string EslStatus
		{
			get
			{
				return eslStatus;
			}
			set	
			{
				eslStatus = value;
				DictionaryUtil.Add(QueryParameters, "EslStatus", value);
			}
		}

		public int? ToBatteryLevel
		{
			get
			{
				return toBatteryLevel;
			}
			set	
			{
				toBatteryLevel = value;
				DictionaryUtil.Add(QueryParameters, "ToBatteryLevel", value.ToString());
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(QueryParameters, "StoreId", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string Mac
		{
			get
			{
				return mac;
			}
			set	
			{
				mac = value;
				DictionaryUtil.Add(QueryParameters, "Mac", value);
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

		public int? FromBatteryLevel
		{
			get
			{
				return fromBatteryLevel;
			}
			set	
			{
				fromBatteryLevel = value;
				DictionaryUtil.Add(QueryParameters, "FromBatteryLevel", value.ToString());
			}
		}

		public string ShelfCode
		{
			get
			{
				return shelfCode;
			}
			set	
			{
				shelfCode = value;
				DictionaryUtil.Add(QueryParameters, "ShelfCode", value);
			}
		}

		public string EslBarCode
		{
			get
			{
				return eslBarCode;
			}
			set	
			{
				eslBarCode = value;
				DictionaryUtil.Add(QueryParameters, "EslBarCode", value);
			}
		}

		public string Vendor
		{
			get
			{
				return vendor;
			}
			set	
			{
				vendor = value;
				DictionaryUtil.Add(QueryParameters, "Vendor", value);
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

		public bool? BeBind
		{
			get
			{
				return beBind;
			}
			set	
			{
				beBind = value;
				DictionaryUtil.Add(QueryParameters, "BeBind", value.ToString());
			}
		}

		public string ItemBarCode
		{
			get
			{
				return itemBarCode;
			}
			set	
			{
				itemBarCode = value;
				DictionaryUtil.Add(QueryParameters, "ItemBarCode", value);
			}
		}

        public override DescribeEslDevicesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeEslDevicesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}