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
using Aliyun.Acs.cr.Transform;
using Aliyun.Acs.cr.Transform.V20160607;

namespace Aliyun.Acs.cr.Model.V20160607
{
    public class CreateNamespaceAuthorizationRequest : RoaAcsRequest<CreateNamespaceAuthorizationResponse>
    {
        public CreateNamespaceAuthorizationRequest()
            : base("cr", "2016-06-07", "CreateNamespaceAuthorization", "cr", "openAPI")
        {
			UriPattern = "/namespace/[Namespace]/authorizations";
			Method = MethodType.PUT;
        }

		private string _namespace;

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(PathParameters, "Namespace", value);
			}
		}

        public override CreateNamespaceAuthorizationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNamespaceAuthorizationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
