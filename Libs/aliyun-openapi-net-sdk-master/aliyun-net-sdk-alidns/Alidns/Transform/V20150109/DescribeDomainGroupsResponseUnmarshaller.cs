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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDomainGroupsResponseUnmarshaller
    {
        public static DescribeDomainGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainGroupsResponse describeDomainGroupsResponse = new DescribeDomainGroupsResponse();

			describeDomainGroupsResponse.HttpResponse = context.HttpResponse;
			describeDomainGroupsResponse.RequestId = context.StringValue("DescribeDomainGroups.RequestId");
			describeDomainGroupsResponse.TotalCount = context.LongValue("DescribeDomainGroups.TotalCount");
			describeDomainGroupsResponse.PageNumber = context.LongValue("DescribeDomainGroups.PageNumber");
			describeDomainGroupsResponse.PageSize = context.LongValue("DescribeDomainGroups.PageSize");

			List<DescribeDomainGroupsResponse.DescribeDomainGroups_DomainGroup> describeDomainGroupsResponse_domainGroups = new List<DescribeDomainGroupsResponse.DescribeDomainGroups_DomainGroup>();
			for (int i = 0; i < context.Length("DescribeDomainGroups.DomainGroups.Length"); i++) {
				DescribeDomainGroupsResponse.DescribeDomainGroups_DomainGroup domainGroup = new DescribeDomainGroupsResponse.DescribeDomainGroups_DomainGroup();
				domainGroup.GroupId = context.StringValue("DescribeDomainGroups.DomainGroups["+ i +"].GroupId");
				domainGroup.GroupName = context.StringValue("DescribeDomainGroups.DomainGroups["+ i +"].GroupName");
				domainGroup.DomainCount = context.LongValue("DescribeDomainGroups.DomainGroups["+ i +"].DomainCount");

				describeDomainGroupsResponse_domainGroups.Add(domainGroup);
			}
			describeDomainGroupsResponse.DomainGroups = describeDomainGroupsResponse_domainGroups;
        
			return describeDomainGroupsResponse;
        }
    }
}
