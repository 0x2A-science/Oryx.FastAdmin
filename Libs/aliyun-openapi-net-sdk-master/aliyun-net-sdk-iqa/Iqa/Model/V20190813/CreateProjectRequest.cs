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
using Aliyun.Acs.iqa.Transform;
using Aliyun.Acs.iqa.Transform.V20190813;

namespace Aliyun.Acs.iqa.Model.V20190813
{
    public class CreateProjectRequest : RpcAcsRequest<CreateProjectResponse>
    {
        public CreateProjectRequest()
            : base("iqa", "2019-08-13", "CreateProject", "iqa", "openAPI")
        {
        }

		private string projectName;

		private string modelId;

		private string projectType;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(BodyParameters, "ProjectName", value);
			}
		}

		public string ModelId
		{
			get
			{
				return modelId;
			}
			set	
			{
				modelId = value;
				DictionaryUtil.Add(BodyParameters, "ModelId", value);
			}
		}

		public string ProjectType
		{
			get
			{
				return projectType;
			}
			set	
			{
				projectType = value;
				DictionaryUtil.Add(BodyParameters, "ProjectType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateProjectResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateProjectResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
