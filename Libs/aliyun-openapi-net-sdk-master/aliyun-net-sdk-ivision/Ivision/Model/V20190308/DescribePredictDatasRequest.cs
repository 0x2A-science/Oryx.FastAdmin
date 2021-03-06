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
using Aliyun.Acs.ivision.Transform;
using Aliyun.Acs.ivision.Transform.V20190308;

namespace Aliyun.Acs.ivision.Model.V20190308
{
    public class DescribePredictDatasRequest : RpcAcsRequest<DescribePredictDatasResponse>
    {
        public DescribePredictDatasRequest()
            : base("ivision", "2019-03-08", "DescribePredictDatas", "ivision", "openAPI")
        {
        }

		private string nextPageToken;

		private long? pageSize;

		private string action;

		private string probabilityThreshold;

		private string overlapThreshold;

		private string projectId;

		private string showLog;

		private string modelId;

		private string tagId;

		private long? currentPage;

		private long? ownerId;

		private string iterationId;

		public string NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
				DictionaryUtil.Add(QueryParameters, "NextPageToken", value);
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string ProbabilityThreshold
		{
			get
			{
				return probabilityThreshold;
			}
			set	
			{
				probabilityThreshold = value;
				DictionaryUtil.Add(QueryParameters, "ProbabilityThreshold", value);
			}
		}

		public string OverlapThreshold
		{
			get
			{
				return overlapThreshold;
			}
			set	
			{
				overlapThreshold = value;
				DictionaryUtil.Add(QueryParameters, "OverlapThreshold", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

		public string ShowLog
		{
			get
			{
				return showLog;
			}
			set	
			{
				showLog = value;
				DictionaryUtil.Add(QueryParameters, "ShowLog", value);
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
				DictionaryUtil.Add(QueryParameters, "ModelId", value);
			}
		}

		public string TagId
		{
			get
			{
				return tagId;
			}
			set	
			{
				tagId = value;
				DictionaryUtil.Add(QueryParameters, "TagId", value);
			}
		}

		public long? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string IterationId
		{
			get
			{
				return iterationId;
			}
			set	
			{
				iterationId = value;
				DictionaryUtil.Add(QueryParameters, "IterationId", value);
			}
		}

        public override DescribePredictDatasResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePredictDatasResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
