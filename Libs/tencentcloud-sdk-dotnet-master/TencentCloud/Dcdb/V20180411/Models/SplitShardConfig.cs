/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SplitShardConfig : AbstractModel
    {
        
        /// <summary>
        /// 分片ID数组
        /// </summary>
        [JsonProperty("ShardInstanceIds")]
        public string[] ShardInstanceIds{ get; set; }

        /// <summary>
        /// 数据切分比例
        /// </summary>
        [JsonProperty("SplitRate")]
        public long? SplitRate{ get; set; }

        /// <summary>
        /// 分片内存大小，单位 GB
        /// </summary>
        [JsonProperty("ShardMemory")]
        public long? ShardMemory{ get; set; }

        /// <summary>
        /// 分片存储大小，单位 GB
        /// </summary>
        [JsonProperty("ShardStorage")]
        public long? ShardStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ShardInstanceIds.", this.ShardInstanceIds);
            this.SetParamSimple(map, prefix + "SplitRate", this.SplitRate);
            this.SetParamSimple(map, prefix + "ShardMemory", this.ShardMemory);
            this.SetParamSimple(map, prefix + "ShardStorage", this.ShardStorage);
        }
    }
}

