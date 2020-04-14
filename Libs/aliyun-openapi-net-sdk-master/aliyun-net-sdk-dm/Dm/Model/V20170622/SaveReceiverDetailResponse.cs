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

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class SaveReceiverDetailResponse : AcsResponse
	{

		private string requestId;

		private int? successCount;

		private int? errorCount;

		private List<SaveReceiverDetail_Detail> data;

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

		public int? SuccessCount
		{
			get
			{
				return successCount;
			}
			set	
			{
				successCount = value;
			}
		}

		public int? ErrorCount
		{
			get
			{
				return errorCount;
			}
			set	
			{
				errorCount = value;
			}
		}

		public List<SaveReceiverDetail_Detail> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class SaveReceiverDetail_Detail
		{

			private string email;

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}
		}
	}
}
