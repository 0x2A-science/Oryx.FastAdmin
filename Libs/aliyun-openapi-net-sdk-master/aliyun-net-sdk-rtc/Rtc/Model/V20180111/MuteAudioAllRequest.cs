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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class MuteAudioAllRequest : RpcAcsRequest<MuteAudioAllResponse>
    {
        public MuteAudioAllRequest()
            : base("rtc", "2018-01-11", "MuteAudioAll", "rtc", "openAPI")
        {
        }

		private long? ownerId;

		private string participantId;

		private string conferenceId;

		private string appId;

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ParticipantId
		{
			get
			{
				return participantId;
			}
			set	
			{
				participantId = value;
				DictionaryUtil.Add(QueryParameters, "ParticipantId", value);
			}
		}

		public string ConferenceId
		{
			get
			{
				return conferenceId;
			}
			set	
			{
				conferenceId = value;
				DictionaryUtil.Add(QueryParameters, "ConferenceId", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

        public override MuteAudioAllResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MuteAudioAllResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}