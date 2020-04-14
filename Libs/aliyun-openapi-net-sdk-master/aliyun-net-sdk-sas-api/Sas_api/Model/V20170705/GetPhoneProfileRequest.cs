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
using Aliyun.Acs.Sas_api.Transform;
using Aliyun.Acs.Sas_api.Transform.V20170705;

namespace Aliyun.Acs.Sas_api.Model.V20170705
{
    public class GetPhoneProfileRequest : RpcAcsRequest<GetPhoneProfileResponse>
    {
        public GetPhoneProfileRequest()
            : base("Sas_api", "2017-07-05", "GetPhoneProfile", "sas-api", "openAPI")
        {
        }

		private string phone;

		private int? sensType;

		private string dataVersion;

		private int? businessType;

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
				DictionaryUtil.Add(QueryParameters, "Phone", value);
			}
		}

		public int? SensType
		{
			get
			{
				return sensType;
			}
			set	
			{
				sensType = value;
				DictionaryUtil.Add(QueryParameters, "SensType", value.ToString());
			}
		}

		public string DataVersion
		{
			get
			{
				return dataVersion;
			}
			set	
			{
				dataVersion = value;
				DictionaryUtil.Add(QueryParameters, "DataVersion", value);
			}
		}

		public int? BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(QueryParameters, "BusinessType", value.ToString());
			}
		}

        public override GetPhoneProfileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPhoneProfileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
