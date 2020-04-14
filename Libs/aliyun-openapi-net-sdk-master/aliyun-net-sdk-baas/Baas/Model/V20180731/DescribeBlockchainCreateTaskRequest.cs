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
using Aliyun.Acs.Baas.Transform;
using Aliyun.Acs.Baas.Transform.V20180731;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
    public class DescribeBlockchainCreateTaskRequest : RpcAcsRequest<DescribeBlockchainCreateTaskResponse>
    {
        public DescribeBlockchainCreateTaskRequest()
            : base("Baas", "2018-07-31", "DescribeBlockchainCreateTask")
        {
        }

		private int? current;

		private int? pageSize;

		public int? Current
		{
			get
			{
				return current;
			}
			set	
			{
				current = value;
				DictionaryUtil.Add(BodyParameters, "Current", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

        public override DescribeBlockchainCreateTaskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeBlockchainCreateTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}