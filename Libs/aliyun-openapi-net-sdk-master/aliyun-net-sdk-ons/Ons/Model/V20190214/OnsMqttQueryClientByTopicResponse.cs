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

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsMqttQueryClientByTopicResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsMqttQueryClientByTopic_MqttClientSetDo mqttClientSetDo;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public OnsMqttQueryClientByTopic_MqttClientSetDo MqttClientSetDo
		{
			get
			{
				return mqttClientSetDo;
			}
			set	
			{
				mqttClientSetDo = value;
			}
		}

		public class OnsMqttQueryClientByTopic_MqttClientSetDo
		{

			private long? onlineCount;

			private long? persistCount;

			public long? OnlineCount
			{
				get
				{
					return onlineCount;
				}
				set	
				{
					onlineCount = value;
				}
			}

			public long? PersistCount
			{
				get
				{
					return persistCount;
				}
				set	
				{
					persistCount = value;
				}
			}
		}
	}
}