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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSmartAccessGatewaysResponseUnmarshaller
    {
        public static DescribeSmartAccessGatewaysResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSmartAccessGatewaysResponse describeSmartAccessGatewaysResponse = new DescribeSmartAccessGatewaysResponse();

			describeSmartAccessGatewaysResponse.HttpResponse = context.HttpResponse;
			describeSmartAccessGatewaysResponse.RequestId = context.StringValue("DescribeSmartAccessGateways.RequestId");
			describeSmartAccessGatewaysResponse.TotalCount = context.IntegerValue("DescribeSmartAccessGateways.TotalCount");
			describeSmartAccessGatewaysResponse.PageNumber = context.IntegerValue("DescribeSmartAccessGateways.PageNumber");
			describeSmartAccessGatewaysResponse.PageSize = context.IntegerValue("DescribeSmartAccessGateways.PageSize");

			List<DescribeSmartAccessGatewaysResponse.DescribeSmartAccessGateways_SmartAccessGateway> describeSmartAccessGatewaysResponse_smartAccessGateways = new List<DescribeSmartAccessGatewaysResponse.DescribeSmartAccessGateways_SmartAccessGateway>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGateways.SmartAccessGateways.Length"); i++) {
				DescribeSmartAccessGatewaysResponse.DescribeSmartAccessGateways_SmartAccessGateway smartAccessGateway = new DescribeSmartAccessGatewaysResponse.DescribeSmartAccessGateways_SmartAccessGateway();
				smartAccessGateway.SmartAGId = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].SmartAGId");
				smartAccessGateway.Name = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].Name");
				smartAccessGateway.City = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].City");
				smartAccessGateway.MaxBandwidth = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].MaxBandwidth");
				smartAccessGateway.Status = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].Status");
				smartAccessGateway.CidrBlock = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].CidrBlock");
				smartAccessGateway.AssociatedCcnId = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].AssociatedCcnId");
				smartAccessGateway.AssociatedCcnName = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].AssociatedCcnName");
				smartAccessGateway.Description = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].Description");
				smartAccessGateway.CreateTime = context.LongValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].CreateTime");
				smartAccessGateway.EndTime = context.LongValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].EndTime");
				smartAccessGateway.SoftwareVersion = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].SoftwareVersion");
				smartAccessGateway.HardwareVersion = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].HardwareVersion");
				smartAccessGateway.SerialNumber = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].SerialNumber");
				smartAccessGateway.SecurityLockThreshold = context.IntegerValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].SecurityLockThreshold");
				smartAccessGateway.AclIds = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].AclIds");
				smartAccessGateway.DataPlan = context.LongValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].DataPlan");
				smartAccessGateway.UserCount = context.IntegerValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].UserCount");

				List<DescribeSmartAccessGatewaysResponse.DescribeSmartAccessGateways_SmartAccessGateway.DescribeSmartAccessGateways_SnatEntry> smartAccessGateway_snatEntries = new List<DescribeSmartAccessGatewaysResponse.DescribeSmartAccessGateways_SmartAccessGateway.DescribeSmartAccessGateways_SnatEntry>();
				for (int j = 0; j < context.Length("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].SnatEntries.Length"); j++) {
					DescribeSmartAccessGatewaysResponse.DescribeSmartAccessGateways_SmartAccessGateway.DescribeSmartAccessGateways_SnatEntry snatEntry = new DescribeSmartAccessGatewaysResponse.DescribeSmartAccessGateways_SmartAccessGateway.DescribeSmartAccessGateways_SnatEntry();
					snatEntry.CidrBlock = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].SnatEntries["+ j +"].CidrBlock");
					snatEntry.SnatIp = context.StringValue("DescribeSmartAccessGateways.SmartAccessGateways["+ i +"].SnatEntries["+ j +"].SnatIp");

					smartAccessGateway_snatEntries.Add(snatEntry);
				}
				smartAccessGateway.SnatEntries = smartAccessGateway_snatEntries;

				describeSmartAccessGatewaysResponse_smartAccessGateways.Add(smartAccessGateway);
			}
			describeSmartAccessGatewaysResponse.SmartAccessGateways = describeSmartAccessGatewaysResponse_smartAccessGateways;
        
			return describeSmartAccessGatewaysResponse;
        }
    }
}
