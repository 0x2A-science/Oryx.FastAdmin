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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeInstanceAutoRenewalAttributeResponseUnmarshaller
    {
        public static DescribeInstanceAutoRenewalAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceAutoRenewalAttributeResponse describeInstanceAutoRenewalAttributeResponse = new DescribeInstanceAutoRenewalAttributeResponse();

			describeInstanceAutoRenewalAttributeResponse.HttpResponse = context.HttpResponse;
			describeInstanceAutoRenewalAttributeResponse.RequestId = context.StringValue("DescribeInstanceAutoRenewalAttribute.RequestId");
			describeInstanceAutoRenewalAttributeResponse.PageNumber = context.IntegerValue("DescribeInstanceAutoRenewalAttribute.PageNumber");
			describeInstanceAutoRenewalAttributeResponse.PageRecordCount = context.IntegerValue("DescribeInstanceAutoRenewalAttribute.PageRecordCount");
			describeInstanceAutoRenewalAttributeResponse.ItemsNumbers = context.IntegerValue("DescribeInstanceAutoRenewalAttribute.ItemsNumbers");

			List<DescribeInstanceAutoRenewalAttributeResponse.DescribeInstanceAutoRenewalAttribute_Item> describeInstanceAutoRenewalAttributeResponse_items = new List<DescribeInstanceAutoRenewalAttributeResponse.DescribeInstanceAutoRenewalAttribute_Item>();
			for (int i = 0; i < context.Length("DescribeInstanceAutoRenewalAttribute.Items.Length"); i++) {
				DescribeInstanceAutoRenewalAttributeResponse.DescribeInstanceAutoRenewalAttribute_Item item = new DescribeInstanceAutoRenewalAttributeResponse.DescribeInstanceAutoRenewalAttribute_Item();
				item.DbInstanceId = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].DbInstanceId");
				item.RegionId = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].RegionId");
				item.Duration = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].Duration");
				item.AutoRenew = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].AutoRenew");
				item.DBInstanceType = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].DBInstanceType");

				describeInstanceAutoRenewalAttributeResponse_items.Add(item);
			}
			describeInstanceAutoRenewalAttributeResponse.Items = describeInstanceAutoRenewalAttributeResponse_items;
        
			return describeInstanceAutoRenewalAttributeResponse;
        }
    }
}
