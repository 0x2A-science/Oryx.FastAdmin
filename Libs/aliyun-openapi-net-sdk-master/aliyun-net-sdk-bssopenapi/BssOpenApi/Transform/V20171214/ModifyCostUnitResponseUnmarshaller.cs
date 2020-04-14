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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class ModifyCostUnitResponseUnmarshaller
    {
        public static ModifyCostUnitResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyCostUnitResponse modifyCostUnitResponse = new ModifyCostUnitResponse();

			modifyCostUnitResponse.HttpResponse = context.HttpResponse;
			modifyCostUnitResponse.RequestId = context.StringValue("ModifyCostUnit.RequestId");
			modifyCostUnitResponse.Success = context.BooleanValue("ModifyCostUnit.Success");
			modifyCostUnitResponse.Code = context.StringValue("ModifyCostUnit.Code");
			modifyCostUnitResponse.Message = context.StringValue("ModifyCostUnit.Message");

			List<ModifyCostUnitResponse.ModifyCostUnit_DataItem> modifyCostUnitResponse_data = new List<ModifyCostUnitResponse.ModifyCostUnit_DataItem>();
			for (int i = 0; i < context.Length("ModifyCostUnit.Data.Length"); i++) {
				ModifyCostUnitResponse.ModifyCostUnit_DataItem dataItem = new ModifyCostUnitResponse.ModifyCostUnit_DataItem();
				dataItem.OwnerUid = context.LongValue("ModifyCostUnit.Data["+ i +"].OwnerUid");
				dataItem.UnitId = context.LongValue("ModifyCostUnit.Data["+ i +"].UnitId");
				dataItem.IsSuccess = context.BooleanValue("ModifyCostUnit.Data["+ i +"].IsSuccess");

				modifyCostUnitResponse_data.Add(dataItem);
			}
			modifyCostUnitResponse.Data = modifyCostUnitResponse_data;
        
			return modifyCostUnitResponse;
        }
    }
}
