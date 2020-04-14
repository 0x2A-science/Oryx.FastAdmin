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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class SaveTaskRequest : RpcAcsRequest<SaveTaskResponse>
    {
        public SaveTaskRequest()
            : base("Trademark", "2018-07-24", "SaveTask", "trademark", "openAPI")
        {
        }

		private string bizType;

		private string request;

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public string Request
		{
			get
			{
				return request;
			}
			set	
			{
				request = value;
				DictionaryUtil.Add(QueryParameters, "Request", value);
			}
		}

        public override SaveTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
