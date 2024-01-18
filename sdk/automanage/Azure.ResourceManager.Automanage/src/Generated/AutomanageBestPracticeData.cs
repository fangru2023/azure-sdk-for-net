// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing the AutomanageBestPractice data model.
    /// Definition of the Automanage best practice.
    /// </summary>
    public partial class AutomanageBestPracticeData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AutomanageBestPracticeData"/>. </summary>
        internal AutomanageBestPracticeData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomanageBestPracticeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="configuration"> configuration dictionary of the configuration profile. </param>
        internal AutomanageBestPracticeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BinaryData configuration) : base(id, name, resourceType, systemData)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// configuration dictionary of the configuration profile.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Configuration { get; }
    }
}
