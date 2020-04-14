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
using Aliyun.Acs.MoPen.Model.V20180211;

namespace Aliyun.Acs.MoPen.Transform.V20180211
{
    public class MoPenAddGroupMemberResponseUnmarshaller
    {
        public static MoPenAddGroupMemberResponse Unmarshall(UnmarshallerContext context)
        {
			MoPenAddGroupMemberResponse moPenAddGroupMemberResponse = new MoPenAddGroupMemberResponse();

			moPenAddGroupMemberResponse.HttpResponse = context.HttpResponse;
			moPenAddGroupMemberResponse.Success = context.BooleanValue("MoPenAddGroupMember.Success");
			moPenAddGroupMemberResponse.Code = context.StringValue("MoPenAddGroupMember.Code");
			moPenAddGroupMemberResponse.Description = context.StringValue("MoPenAddGroupMember.Description");
			moPenAddGroupMemberResponse.Message = context.StringValue("MoPenAddGroupMember.Message");
        
			return moPenAddGroupMemberResponse;
        }
    }
}
