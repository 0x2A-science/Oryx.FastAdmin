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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class QueryXpackRelateDBResponseUnmarshaller
    {
        public static QueryXpackRelateDBResponse Unmarshall(UnmarshallerContext context)
        {
			QueryXpackRelateDBResponse queryXpackRelateDBResponse = new QueryXpackRelateDBResponse();

			queryXpackRelateDBResponse.HttpResponse = context.HttpResponse;
			queryXpackRelateDBResponse.RequestId = context.StringValue("QueryXpackRelateDB.RequestId");

			List<QueryXpackRelateDBResponse.QueryXpackRelateDB_Cluster> queryXpackRelateDBResponse_clusterList = new List<QueryXpackRelateDBResponse.QueryXpackRelateDB_Cluster>();
			for (int i = 0; i < context.Length("QueryXpackRelateDB.ClusterList.Length"); i++) {
				QueryXpackRelateDBResponse.QueryXpackRelateDB_Cluster cluster = new QueryXpackRelateDBResponse.QueryXpackRelateDB_Cluster();
				cluster.ClusterId = context.StringValue("QueryXpackRelateDB.ClusterList["+ i +"].ClusterId");
				cluster.ClusterName = context.StringValue("QueryXpackRelateDB.ClusterList["+ i +"].ClusterName");
				cluster.DBVersion = context.StringValue("QueryXpackRelateDB.ClusterList["+ i +"].DBVersion");
				cluster.Status = context.StringValue("QueryXpackRelateDB.ClusterList["+ i +"].Status");
				cluster.DBType = context.StringValue("QueryXpackRelateDB.ClusterList["+ i +"].DBType");
				cluster.IsRelated = context.BooleanValue("QueryXpackRelateDB.ClusterList["+ i +"].IsRelated");
				cluster.LockMode = context.StringValue("QueryXpackRelateDB.ClusterList["+ i +"].LockMode");

				queryXpackRelateDBResponse_clusterList.Add(cluster);
			}
			queryXpackRelateDBResponse.ClusterList = queryXpackRelateDBResponse_clusterList;
        
			return queryXpackRelateDBResponse;
        }
    }
}
