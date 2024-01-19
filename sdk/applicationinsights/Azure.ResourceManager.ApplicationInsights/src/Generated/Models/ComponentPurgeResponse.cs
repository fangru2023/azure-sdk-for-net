// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Response containing operationId for a specific purge action. </summary>
    public partial class ComponentPurgeResponse
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

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeResponse"/>. </summary>
        /// <param name="operationId"> Id to use when querying for status for a particular purge operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        internal ComponentPurgeResponse(string operationId)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));

            OperationId = operationId;
        }

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeResponse"/>. </summary>
        /// <param name="operationId"> Id to use when querying for status for a particular purge operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentPurgeResponse(string operationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OperationId = operationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeResponse"/> for deserialization. </summary>
        internal ComponentPurgeResponse()
        {
        }

        /// <summary> Id to use when querying for status for a particular purge operation. </summary>
        public string OperationId { get; }
    }
}
