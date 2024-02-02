// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Request metadata of execute request post call payload. </summary>
    public partial class RequestMetadata
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

        /// <summary> Initializes a new instance of <see cref="RequestMetadata"/>. </summary>
        /// <param name="relativePath"> The relative path of the request. </param>
        /// <param name="httpMethod"> The http method of the request. </param>
        /// <param name="serializedBody"> The serialized body of the request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativePath"/> or <paramref name="serializedBody"/> is null. </exception>
        public RequestMetadata(string relativePath, HttpMethod httpMethod, string serializedBody)
        {
            Argument.AssertNotNull(relativePath, nameof(relativePath));
            Argument.AssertNotNull(serializedBody, nameof(serializedBody));

            RelativePath = relativePath;
            HttpMethod = httpMethod;
            SerializedBody = serializedBody;
        }

        /// <summary> Initializes a new instance of <see cref="RequestMetadata"/>. </summary>
        /// <param name="relativePath"> The relative path of the request. </param>
        /// <param name="httpMethod"> The http method of the request. </param>
        /// <param name="serializedBody"> The serialized body of the request. </param>
        /// <param name="apiVersion"> The api version of the request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RequestMetadata(string relativePath, HttpMethod httpMethod, string serializedBody, string apiVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RelativePath = relativePath;
            HttpMethod = httpMethod;
            SerializedBody = serializedBody;
            ApiVersion = apiVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RequestMetadata"/> for deserialization. </summary>
        internal RequestMetadata()
        {
        }

        /// <summary> The relative path of the request. </summary>
        public string RelativePath { get; }
        /// <summary> The http method of the request. </summary>
        public HttpMethod HttpMethod { get; }
        /// <summary> The serialized body of the request. </summary>
        public string SerializedBody { get; }
        /// <summary> The api version of the request. </summary>
        public string ApiVersion { get; set; }
    }
}
