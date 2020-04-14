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

namespace Aliyun.Acs.Kms.Model.V20160120
{
	public class ListAliasesByKeyIdResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private string requestId;

		private List<ListAliasesByKeyId_Alias> aliases;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public List<ListAliasesByKeyId_Alias> Aliases
		{
			get
			{
				return aliases;
			}
			set	
			{
				aliases = value;
			}
		}

		public class ListAliasesByKeyId_Alias
		{

			private string keyId;

			private string aliasName;

			private string aliasArn;

			public string KeyId
			{
				get
				{
					return keyId;
				}
				set	
				{
					keyId = value;
				}
			}

			public string AliasName
			{
				get
				{
					return aliasName;
				}
				set	
				{
					aliasName = value;
				}
			}

			public string AliasArn
			{
				get
				{
					return aliasArn;
				}
				set	
				{
					aliasArn = value;
				}
			}
		}
	}
}
