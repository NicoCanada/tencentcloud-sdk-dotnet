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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照一个或者多个实例ID查询。实例ID形如：`ins-xxxxxxxx`。（此参数的具体格式可参考API[简介](https://cloud.tencent.com/document/api/213/15688)的`id.N`一节）。每次请求的实例的上限为100。参数不支持同时指定`InstanceIds`和`Filters`。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li> zone - String - 是否必填：否 -（过滤条件）按照可用区过滤。</li>
        /// <li> project-id - Integer - 是否必填：否 -（过滤条件）按照项目ID过滤。可通过调用[DescribeProject](https://cloud.tencent.com/document/api/378/4400)查询已创建的项目列表或登录[控制台](https://console.cloud.tencent.com/cvm/index)进行查看；也可以调用[AddProject](https://cloud.tencent.com/document/api/378/4398)创建新的项目。</li>
        /// <li> host-id - String - 是否必填：否 - （过滤条件）按照[CDH](https://cloud.tencent.com/document/product/416) ID过滤。[CDH](https://cloud.tencent.com/document/product/416) ID形如：host-xxxxxxxx。</li>
        /// <li> vpc-id - String - 是否必填：否 - （过滤条件）按照VPC ID进行过滤。VPC ID形如：vpc-xxxxxxxx。</li>
        /// <li> instance-id - String - 是否必填：否 - （过滤条件）按照实例ID过滤。实例ID形如：ins-xxxxxxxx。</li>
        /// <li> security-group-id - String - 是否必填：否 - （过滤条件）按照安全组ID过滤，安全组ID形如: sg-8jlk3f3r。</li>
        /// <li> instance-name - String - 是否必填：否 - （过滤条件）按照实例名称过滤。</li>
        /// <li> instance-charge-type - String - 是否必填：否 -（过滤条件）按照实例计费模式过滤。 (PREPAID：表示预付费，即包年包月 | POSTPAID_BY_HOUR：表示后付费，即按量计费 | CDHPAID：表示[CDH](https://cloud.tencent.com/document/product/416)付费，即只对[CDH](https://cloud.tencent.com/document/product/416)计费，不对[CDH](https://cloud.tencent.com/document/product/416)上的实例计费。 )  </li>
        /// <li> private-ip-address - String - 是否必填：否 - （过滤条件）按照实例主网卡的内网IP过滤。</li>
        /// <li> public-ip-address - String - 是否必填：否 - （过滤条件）按照实例主网卡的公网IP过滤，包含实例创建时自动分配的IP和实例创建后手动绑定的弹性IP。</li>
        /// <li> tag-key - String - 是否必填：否 - （过滤条件）按照标签键进行过滤。</li>
        /// <li> tag-value - String - 是否必填：否 - （过滤条件）按照标签值进行过滤。</li>
        /// <li> tag:tag-key - String - 是否必填：否 - （过滤条件）按照标签键值对进行过滤。 tag-key使用具体的标签键进行替换。使用请参考示例2。</li>
        /// 每次请求的`Filters`的上限为10，`Filter.Values`的上限为5。参数不支持同时指定`InstanceIds`和`Filters`。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

