// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.WorkloadMonitor;

namespace Azure.ResourceManager.WorkloadMonitor.Models
{
    /// <summary> Information about the current health statuses of the monitors. </summary>
    internal partial class HealthMonitorList
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

        /// <summary> Initializes a new instance of <see cref="HealthMonitorList"/>. </summary>
        internal HealthMonitorList()
        {
            Value = new ChangeTrackingList<HealthMonitorData>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthMonitorList"/>. </summary>
        /// <param name="value"> Array of health monitors of the virtual machine. </param>
        /// <param name="nextLink"> Link to next page if the list is too long. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthMonitorList(IReadOnlyList<HealthMonitorData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of health monitors of the virtual machine. </summary>
        public IReadOnlyList<HealthMonitorData> Value { get; }
        /// <summary> Link to next page if the list is too long. </summary>
        public string NextLink { get; }
    }
}
