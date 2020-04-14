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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 人员ID。
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。
        /// 人员人脸总数量不可超过5张。
        /// 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。
        /// Url、Image必须提供一个，如果都提供，只使用 Url。  
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// 人员人脸总数量不可超过5张。
        /// 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 只有和该人员已有的人脸相似度超过FaceMatchThreshold值的人脸，才能增加人脸成功。 
        /// 默认值60分。取值范围[0,100] 。
        /// </summary>
        [JsonProperty("FaceMatchThreshold")]
        public float? FaceMatchThreshold{ get; set; }

        /// <summary>
        /// 图片质量控制。 
        /// 0: 不进行控制； 
        /// 1:较低的质量要求，图像存在非常模糊，眼睛鼻子嘴巴遮挡至少其中一种或多种的情况； 
        /// 2: 一般的质量要求，图像存在偏亮，偏暗，模糊或一般模糊，眉毛遮挡，脸颊遮挡，下巴遮挡，至少其中三种的情况； 
        /// 3: 较高的质量要求，图像存在偏亮，偏暗，一般模糊，眉毛遮挡，脸颊遮挡，下巴遮挡，其中一到两种的情况； 
        /// 4: 很高的质量要求，各个维度均为最好或最多在某一维度上存在轻微问题； 
        /// 默认 0。 
        /// 若图片质量不满足要求，则返回结果中会提示图片质量检测不符要求。
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamSimple(map, prefix + "FaceMatchThreshold", this.FaceMatchThreshold);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
        }
    }
}
