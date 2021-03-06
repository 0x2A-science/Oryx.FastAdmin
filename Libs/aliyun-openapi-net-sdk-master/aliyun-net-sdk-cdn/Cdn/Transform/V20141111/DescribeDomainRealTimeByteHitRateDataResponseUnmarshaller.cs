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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainRealTimeByteHitRateDataResponseUnmarshaller
    {
        public static DescribeDomainRealTimeByteHitRateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainRealTimeByteHitRateDataResponse describeDomainRealTimeByteHitRateDataResponse = new DescribeDomainRealTimeByteHitRateDataResponse();

			describeDomainRealTimeByteHitRateDataResponse.HttpResponse = context.HttpResponse;
			describeDomainRealTimeByteHitRateDataResponse.RequestId = context.StringValue("DescribeDomainRealTimeByteHitRateData.RequestId");

			List<DescribeDomainRealTimeByteHitRateDataResponse.DescribeDomainRealTimeByteHitRateData_ByteHitRateDataModel> describeDomainRealTimeByteHitRateDataResponse_data = new List<DescribeDomainRealTimeByteHitRateDataResponse.DescribeDomainRealTimeByteHitRateData_ByteHitRateDataModel>();
			for (int i = 0; i < context.Length("DescribeDomainRealTimeByteHitRateData.Data.Length"); i++) {
				DescribeDomainRealTimeByteHitRateDataResponse.DescribeDomainRealTimeByteHitRateData_ByteHitRateDataModel byteHitRateDataModel = new DescribeDomainRealTimeByteHitRateDataResponse.DescribeDomainRealTimeByteHitRateData_ByteHitRateDataModel();
				byteHitRateDataModel.ByteHitRate = context.FloatValue("DescribeDomainRealTimeByteHitRateData.Data["+ i +"].ByteHitRate");
				byteHitRateDataModel.TimeStamp = context.StringValue("DescribeDomainRealTimeByteHitRateData.Data["+ i +"].TimeStamp");

				describeDomainRealTimeByteHitRateDataResponse_data.Add(byteHitRateDataModel);
			}
			describeDomainRealTimeByteHitRateDataResponse.Data = describeDomainRealTimeByteHitRateDataResponse_data;
        
			return describeDomainRealTimeByteHitRateDataResponse;
        }
    }
}
