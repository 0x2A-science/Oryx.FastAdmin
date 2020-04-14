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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class ListPrivilegesOfUserResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<ListPrivilegesOfUser_Privilege> privileges;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public List<ListPrivilegesOfUser_Privilege> Privileges
		{
			get
			{
				return privileges;
			}
			set	
			{
				privileges = value;
			}
		}

		public class ListPrivilegesOfUser_Privilege
		{

			private string privilegeId;

			private string privilegeName;

			private string privilegeDescription;

			public string PrivilegeId
			{
				get
				{
					return privilegeId;
				}
				set	
				{
					privilegeId = value;
				}
			}

			public string PrivilegeName
			{
				get
				{
					return privilegeName;
				}
				set	
				{
					privilegeName = value;
				}
			}

			public string PrivilegeDescription
			{
				get
				{
					return privilegeDescription;
				}
				set	
				{
					privilegeDescription = value;
				}
			}
		}
	}
}