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
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class ExtendImageStyleResponseUnmarshaller
    {
        public static ExtendImageStyleResponse Unmarshall(UnmarshallerContext context)
        {
			ExtendImageStyleResponse extendImageStyleResponse = new ExtendImageStyleResponse();

			extendImageStyleResponse.HttpResponse = context.HttpResponse;
			extendImageStyleResponse.RequestId = context.StringValue("ExtendImageStyle.RequestId");
			extendImageStyleResponse.Code = context.StringValue("ExtendImageStyle.Code");
			extendImageStyleResponse.Message = context.StringValue("ExtendImageStyle.Message");

			ExtendImageStyleResponse.ExtendImageStyle_Data data = new ExtendImageStyleResponse.ExtendImageStyle_Data();
			data.Url = context.StringValue("ExtendImageStyle.Data.Url");
			data.MajorUrl = context.StringValue("ExtendImageStyle.Data.MajorUrl");
			extendImageStyleResponse.Data = data;
        
			return extendImageStyleResponse;
        }
    }
}
