// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Information to be stored in Vault properties as an element of privateEndpointConnections List. </summary>
    public partial class RecoveryServicesPrivateEndpointConnectionVaultProperties : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesPrivateEndpointConnectionVaultProperties"/>. </summary>
        internal RecoveryServicesPrivateEndpointConnectionVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesPrivateEndpointConnectionVaultProperties"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Private Endpoint Connection Response Properties. </param>
        /// <param name="location"> The location of the private Endpoint connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryServicesPrivateEndpointConnectionVaultProperties(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RecoveryServicesPrivateEndpointConnection properties, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Private Endpoint Connection Response Properties. </summary>
        public RecoveryServicesPrivateEndpointConnection Properties { get; }
        /// <summary> The location of the private Endpoint connection. </summary>
        public AzureLocation? Location { get; }
    }
}
