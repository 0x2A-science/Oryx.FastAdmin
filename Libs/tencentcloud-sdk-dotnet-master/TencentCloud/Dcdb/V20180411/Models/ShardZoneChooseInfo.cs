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

    public class ShardZoneChooseInfo : AbstractModel
    {
        
        /// <summary>
        /// 主可用区
        /// </summary>
        [JsonProperty("MasterZone")]
        public ZonesInfo MasterZone{ get; set; }

        /// <summary>
        /// 可选的从可用区
        /// </summary>
        [JsonProperty("SlaveZones")]
        public ZonesInfo[] SlaveZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MasterZone.", this.MasterZone);
            this.SetParamArrayObj(map, prefix + "SlaveZones.", this.SlaveZones);
        }
    }
}
