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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeCenGeographicSpansResponseUnmarshaller
    {
        public static DescribeCenGeographicSpansResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCenGeographicSpansResponse describeCenGeographicSpansResponse = new DescribeCenGeographicSpansResponse();

			describeCenGeographicSpansResponse.HttpResponse = context.HttpResponse;
			describeCenGeographicSpansResponse.RequestId = context.StringValue("DescribeCenGeographicSpans.RequestId");
			describeCenGeographicSpansResponse.TotalCount = context.IntegerValue("DescribeCenGeographicSpans.TotalCount");
			describeCenGeographicSpansResponse.PageNumber = context.IntegerValue("DescribeCenGeographicSpans.PageNumber");
			describeCenGeographicSpansResponse.PageSize = context.IntegerValue("DescribeCenGeographicSpans.PageSize");

			List<DescribeCenGeographicSpansResponse.DescribeCenGeographicSpans_GeographicSpanModel> describeCenGeographicSpansResponse_geographicSpanModels = new List<DescribeCenGeographicSpansResponse.DescribeCenGeographicSpans_GeographicSpanModel>();
			for (int i = 0; i < context.Length("DescribeCenGeographicSpans.GeographicSpanModels.Length"); i++) {
				DescribeCenGeographicSpansResponse.DescribeCenGeographicSpans_GeographicSpanModel geographicSpanModel = new DescribeCenGeographicSpansResponse.DescribeCenGeographicSpans_GeographicSpanModel();
				geographicSpanModel.GeographicSpanId = context.StringValue("DescribeCenGeographicSpans.GeographicSpanModels["+ i +"].GeographicSpanId");
				geographicSpanModel.LocalGeoRegionId = context.StringValue("DescribeCenGeographicSpans.GeographicSpanModels["+ i +"].LocalGeoRegionId");
				geographicSpanModel.OppositeGeoRegionId = context.StringValue("DescribeCenGeographicSpans.GeographicSpanModels["+ i +"].OppositeGeoRegionId");

				describeCenGeographicSpansResponse_geographicSpanModels.Add(geographicSpanModel);
			}
			describeCenGeographicSpansResponse.GeographicSpanModels = describeCenGeographicSpansResponse_geographicSpanModels;
        
			return describeCenGeographicSpansResponse;
        }
    }
}
