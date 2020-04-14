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
using Aliyun.Acs.Green;
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateAuditSettingRequest : RpcAcsRequest<UpdateAuditSettingResponse>
    {
        public UpdateAuditSettingRequest()
            : base("Green", "2017-08-23", "UpdateAuditSetting")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string seed;

		private string auditRange;

		private string sourceIp;

		private string callback;

		public string Seed
		{
			get
			{
				return seed;
			}
			set	
			{
				seed = value;
				DictionaryUtil.Add(QueryParameters, "Seed", value);
			}
		}

		public string AuditRange
		{
			get
			{
				return auditRange;
			}
			set	
			{
				auditRange = value;
				DictionaryUtil.Add(QueryParameters, "AuditRange", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string Callback
		{
			get
			{
				return callback;
			}
			set	
			{
				callback = value;
				DictionaryUtil.Add(QueryParameters, "Callback", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateAuditSettingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateAuditSettingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
