// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Managed identity settings for upstream. </summary>
    internal partial class ManagedIdentitySettings
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

        /// <summary> Initializes a new instance of <see cref="ManagedIdentitySettings"/>. </summary>
        public ManagedIdentitySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedIdentitySettings"/>. </summary>
        /// <param name="resource">
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedIdentitySettings(string resource, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Resource = resource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        public string Resource { get; set; }
    }
}
