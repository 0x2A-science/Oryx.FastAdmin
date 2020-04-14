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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListFlowInstanceResponseUnmarshaller
    {
        public static ListFlowInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowInstanceResponse listFlowInstanceResponse = new ListFlowInstanceResponse();

			listFlowInstanceResponse.HttpResponse = context.HttpResponse;
			listFlowInstanceResponse.RequestId = context.StringValue("ListFlowInstance.RequestId");
			listFlowInstanceResponse.PageNumber = context.IntegerValue("ListFlowInstance.PageNumber");
			listFlowInstanceResponse.PageSize = context.IntegerValue("ListFlowInstance.PageSize");
			listFlowInstanceResponse.Total = context.IntegerValue("ListFlowInstance.Total");

			List<ListFlowInstanceResponse.ListFlowInstance_FlowInstance> listFlowInstanceResponse_flowInstances = new List<ListFlowInstanceResponse.ListFlowInstance_FlowInstance>();
			for (int i = 0; i < context.Length("ListFlowInstance.FlowInstances.Length"); i++) {
				ListFlowInstanceResponse.ListFlowInstance_FlowInstance flowInstance = new ListFlowInstanceResponse.ListFlowInstance_FlowInstance();
				flowInstance.Id = context.StringValue("ListFlowInstance.FlowInstances["+ i +"].Id");
				flowInstance.GmtCreate = context.LongValue("ListFlowInstance.FlowInstances["+ i +"].GmtCreate");
				flowInstance.GmtModified = context.LongValue("ListFlowInstance.FlowInstances["+ i +"].GmtModified");
				flowInstance.FlowId = context.StringValue("ListFlowInstance.FlowInstances["+ i +"].FlowId");
				flowInstance.FlowName = context.StringValue("ListFlowInstance.FlowInstances["+ i +"].FlowName");
				flowInstance.ProjectId = context.StringValue("ListFlowInstance.FlowInstances["+ i +"].ProjectId");
				flowInstance.Status = context.StringValue("ListFlowInstance.FlowInstances["+ i +"].Status");
				flowInstance.ClusterId = context.StringValue("ListFlowInstance.FlowInstances["+ i +"].ClusterId");
				flowInstance.Owner = context.StringValue("ListFlowInstance.FlowInstances["+ i +"].Owner");
				flowInstance.StartTime = context.LongValue("ListFlowInstance.FlowInstances["+ i +"].StartTime");
				flowInstance.EndTime = context.LongValue("ListFlowInstance.FlowInstances["+ i +"].EndTime");
				flowInstance.Duration = context.LongValue("ListFlowInstance.FlowInstances["+ i +"].Duration");
				flowInstance.HasNodeFailed = context.BooleanValue("ListFlowInstance.FlowInstances["+ i +"].HasNodeFailed");

				listFlowInstanceResponse_flowInstances.Add(flowInstance);
			}
			listFlowInstanceResponse.FlowInstances = listFlowInstanceResponse_flowInstances;
        
			return listFlowInstanceResponse;
        }
    }
}
