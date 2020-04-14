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
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class CreateKeyRequest : RpcAcsRequest<CreateKeyResponse>
    {
        public CreateKeyRequest()
            : base("Kms", "2016-01-20", "CreateKey", "kms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
        }

		private string protectionLevel;

		private string keyUsage;

		private string origin;

		private string description;

		private string rotationInterval;

		private bool? enableAutomaticRotation;

		public string ProtectionLevel
		{
			get
			{
				return protectionLevel;
			}
			set	
			{
				protectionLevel = value;
				DictionaryUtil.Add(QueryParameters, "ProtectionLevel", value);
			}
		}

		public string KeyUsage
		{
			get
			{
				return keyUsage;
			}
			set	
			{
				keyUsage = value;
				DictionaryUtil.Add(QueryParameters, "KeyUsage", value);
			}
		}

		public string Origin
		{
			get
			{
				return origin;
			}
			set	
			{
				origin = value;
				DictionaryUtil.Add(QueryParameters, "Origin", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string RotationInterval
		{
			get
			{
				return rotationInterval;
			}
			set	
			{
				rotationInterval = value;
				DictionaryUtil.Add(QueryParameters, "RotationInterval", value);
			}
		}

		public bool? EnableAutomaticRotation
		{
			get
			{
				return enableAutomaticRotation;
			}
			set	
			{
				enableAutomaticRotation = value;
				DictionaryUtil.Add(QueryParameters, "EnableAutomaticRotation", value.ToString());
			}
		}

        public override CreateKeyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}