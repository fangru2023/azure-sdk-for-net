// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Binding resource properties payload. </summary>
    public partial class AppPlatformBindingProperties
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

        /// <summary> Initializes a new instance of <see cref="AppPlatformBindingProperties"/>. </summary>
        public AppPlatformBindingProperties()
        {
            BindingParameters = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformBindingProperties"/>. </summary>
        /// <param name="resourceName"> The name of the bound resource. </param>
        /// <param name="resourceType"> The standard Azure resource type of the bound resource. </param>
        /// <param name="resourceId"> The Azure resource id of the bound resource. </param>
        /// <param name="key"> The key of the bound resource. </param>
        /// <param name="bindingParameters"> Binding parameters of the Binding resource. </param>
        /// <param name="generatedProperties"> The generated Spring Boot property file for this binding. The secret will be deducted. </param>
        /// <param name="createdOn"> Creation time of the Binding resource. </param>
        /// <param name="updatedOn"> Update time of the Binding resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformBindingProperties(string resourceName, string resourceType, ResourceIdentifier resourceId, string key, IDictionary<string, BinaryData> bindingParameters, string generatedProperties, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceName = resourceName;
            ResourceType = resourceType;
            ResourceId = resourceId;
            Key = key;
            BindingParameters = bindingParameters;
            GeneratedProperties = generatedProperties;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the bound resource. </summary>
        public string ResourceName { get; }
        /// <summary> The standard Azure resource type of the bound resource. </summary>
        public string ResourceType { get; }
        /// <summary> The Azure resource id of the bound resource. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The key of the bound resource. </summary>
        public string Key { get; set; }
        /// <summary>
        /// Binding parameters of the Binding resource
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
        public IDictionary<string, BinaryData> BindingParameters { get; }
        /// <summary> The generated Spring Boot property file for this binding. The secret will be deducted. </summary>
        public string GeneratedProperties { get; }
        /// <summary> Creation time of the Binding resource. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Update time of the Binding resource. </summary>
        public DateTimeOffset? UpdatedOn { get; }
    }
}
