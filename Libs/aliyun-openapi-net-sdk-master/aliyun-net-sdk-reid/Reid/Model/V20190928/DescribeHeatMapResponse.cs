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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.reid.Model.V20190928
{
	public class DescribeHeatMapResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string requestId;

		private bool? success;

		private List<DescribeHeatMap_HeatMapPoint> heatMapPoints;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<DescribeHeatMap_HeatMapPoint> HeatMapPoints
		{
			get
			{
				return heatMapPoints;
			}
			set	
			{
				heatMapPoints = value;
			}
		}

		public class DescribeHeatMap_HeatMapPoint
		{

			private float? y;

			private int? weight;

			private float? x;

			public float? Y
			{
				get
				{
					return y;
				}
				set	
				{
					y = value;
				}
			}

			public int? Weight
			{
				get
				{
					return weight;
				}
				set	
				{
					weight = value;
				}
			}

			public float? X
			{
				get
				{
					return x;
				}
				set	
				{
					x = value;
				}
			}
		}
	}
}
