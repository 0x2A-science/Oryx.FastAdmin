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
using Aliyun.Acs.MoPen.Transform;
using Aliyun.Acs.MoPen.Transform.V20180211;

namespace Aliyun.Acs.MoPen.Model.V20180211
{
    public class MoPenCreateDeviceRequest : RpcAcsRequest<MoPenCreateDeviceResponse>
    {
        public MoPenCreateDeviceRequest()
            : base("MoPen", "2018-02-11", "MoPenCreateDevice", "mopen", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string deviceName;

		private int? deviceType;

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(BodyParameters, "DeviceName", value);
			}
		}

		public int? DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
				DictionaryUtil.Add(BodyParameters, "DeviceType", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override MoPenCreateDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MoPenCreateDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
