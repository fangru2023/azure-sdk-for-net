// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing the EventGridNamespaceClientGroup data model.
    /// The Client group resource.
    /// </summary>
    public partial class EventGridNamespaceClientGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceClientGroupData"/>. </summary>
        public EventGridNamespaceClientGroupData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventGridNamespaceClientGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description for the Client Group resource. </param>
        /// <param name="query">
        /// The grouping query for the clients.
        /// Example : attributes.keyName IN ['a', 'b', 'c'].
        /// </param>
        /// <param name="provisioningState"> Provisioning state of the ClientGroup resource. </param>
        internal EventGridNamespaceClientGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, string query, ClientGroupProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Description = description;
            Query = query;
            ProvisioningState = provisioningState;
        }

        /// <summary> Description for the Client Group resource. </summary>
        public string Description { get; set; }
        /// <summary>
        /// The grouping query for the clients.
        /// Example : attributes.keyName IN ['a', 'b', 'c'].
        /// </summary>
        public string Query { get; set; }
        /// <summary> Provisioning state of the ClientGroup resource. </summary>
        public ClientGroupProvisioningState? ProvisioningState { get; }
    }
}
