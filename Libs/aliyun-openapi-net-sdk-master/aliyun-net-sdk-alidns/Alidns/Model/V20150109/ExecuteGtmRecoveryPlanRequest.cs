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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class ExecuteGtmRecoveryPlanRequest : RpcAcsRequest<ExecuteGtmRecoveryPlanResponse>
    {
        public ExecuteGtmRecoveryPlanRequest()
            : base("Alidns", "2015-01-09", "ExecuteGtmRecoveryPlan", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? recoveryPlanId;

		private string lang;

		public long? RecoveryPlanId
		{
			get
			{
				return recoveryPlanId;
			}
			set	
			{
				recoveryPlanId = value;
				DictionaryUtil.Add(QueryParameters, "RecoveryPlanId", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

        public override ExecuteGtmRecoveryPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExecuteGtmRecoveryPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
