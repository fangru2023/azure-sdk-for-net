// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Part of MultiTenantDiagnosticSettings. Specifies the settings for a particular metric. </summary>
    public partial class MetricSettings
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

        /// <summary> Initializes a new instance of <see cref="MetricSettings"/>. </summary>
        /// <param name="isEnabled"> a value indicating whether this category is enabled. </param>
        public MetricSettings(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="MetricSettings"/>. </summary>
        /// <param name="timeGrain"> the timegrain of the metric in ISO8601 format. </param>
        /// <param name="category"> Name of a Diagnostic Metric category for a resource type this setting is applied to. To obtain the list of Diagnostic metric categories for a resource, first perform a GET diagnostic settings operation. </param>
        /// <param name="isEnabled"> a value indicating whether this category is enabled. </param>
        /// <param name="retentionPolicy"> the retention policy for this category. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricSettings(TimeSpan? timeGrain, string category, bool isEnabled, RetentionPolicy retentionPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TimeGrain = timeGrain;
            Category = category;
            IsEnabled = isEnabled;
            RetentionPolicy = retentionPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MetricSettings"/> for deserialization. </summary>
        internal MetricSettings()
        {
        }

        /// <summary> the timegrain of the metric in ISO8601 format. </summary>
        public TimeSpan? TimeGrain { get; set; }
        /// <summary> Name of a Diagnostic Metric category for a resource type this setting is applied to. To obtain the list of Diagnostic metric categories for a resource, first perform a GET diagnostic settings operation. </summary>
        public string Category { get; set; }
        /// <summary> a value indicating whether this category is enabled. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> the retention policy for this category. </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
    }
}
