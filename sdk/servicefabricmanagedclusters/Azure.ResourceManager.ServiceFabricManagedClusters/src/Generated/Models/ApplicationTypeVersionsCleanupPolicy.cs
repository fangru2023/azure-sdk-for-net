// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The policy used to clean up unused versions. When the policy is not specified explicitly, the default unused application versions to keep will be 3. </summary>
    internal partial class ApplicationTypeVersionsCleanupPolicy
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

        /// <summary> Initializes a new instance of <see cref="ApplicationTypeVersionsCleanupPolicy"/>. </summary>
        /// <param name="maxUnusedVersionsToKeep"> Number of unused versions per application type to keep. </param>
        public ApplicationTypeVersionsCleanupPolicy(int maxUnusedVersionsToKeep)
        {
            MaxUnusedVersionsToKeep = maxUnusedVersionsToKeep;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationTypeVersionsCleanupPolicy"/>. </summary>
        /// <param name="maxUnusedVersionsToKeep"> Number of unused versions per application type to keep. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationTypeVersionsCleanupPolicy(int maxUnusedVersionsToKeep, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxUnusedVersionsToKeep = maxUnusedVersionsToKeep;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationTypeVersionsCleanupPolicy"/> for deserialization. </summary>
        internal ApplicationTypeVersionsCleanupPolicy()
        {
        }

        /// <summary> Number of unused versions per application type to keep. </summary>
        public int MaxUnusedVersionsToKeep { get; set; }
    }
}
