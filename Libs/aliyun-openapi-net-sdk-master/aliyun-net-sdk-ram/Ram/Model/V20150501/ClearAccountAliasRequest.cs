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
using Aliyun.Acs.Ram.Transform;
using Aliyun.Acs.Ram.Transform.V20150501;

namespace Aliyun.Acs.Ram.Model.V20150501
{
    public class ClearAccountAliasRequest : RpcAcsRequest<ClearAccountAliasResponse>
    {
        public ClearAccountAliasRequest()
            : base("Ram", "2015-05-01", "ClearAccountAlias")
        {
			Protocol = ProtocolType.HTTPS;
        }

        public override ClearAccountAliasResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ClearAccountAliasResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
