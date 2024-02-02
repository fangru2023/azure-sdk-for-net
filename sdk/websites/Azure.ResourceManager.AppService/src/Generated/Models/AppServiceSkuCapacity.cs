// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of the App Service plan scale options. </summary>
    public partial class AppServiceSkuCapacity
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceSkuCapacity"/>. </summary>
        public AppServiceSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceSkuCapacity"/>. </summary>
        /// <param name="minimum"> Minimum number of workers for this App Service plan SKU. </param>
        /// <param name="maximum"> Maximum number of workers for this App Service plan SKU. </param>
        /// <param name="elasticMaximum"> Maximum number of Elastic workers for this App Service plan SKU. </param>
        /// <param name="default"> Default number of workers for this App Service plan SKU. </param>
        /// <param name="scaleType"> Available scale configurations for an App Service plan. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceSkuCapacity(int? minimum, int? maximum, int? elasticMaximum, int? @default, string scaleType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            ElasticMaximum = elasticMaximum;
            Default = @default;
            ScaleType = scaleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Minimum number of workers for this App Service plan SKU. </summary>
        public int? Minimum { get; set; }
        /// <summary> Maximum number of workers for this App Service plan SKU. </summary>
        public int? Maximum { get; set; }
        /// <summary> Maximum number of Elastic workers for this App Service plan SKU. </summary>
        public int? ElasticMaximum { get; set; }
        /// <summary> Default number of workers for this App Service plan SKU. </summary>
        public int? Default { get; set; }
        /// <summary> Available scale configurations for an App Service plan. </summary>
        public string ScaleType { get; set; }
    }
}
