// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Purview;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The account properties. </summary>
    public partial class PurviewAccountProperties
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

        /// <summary> Initializes a new instance of <see cref="PurviewAccountProperties"/>. </summary>
        public PurviewAccountProperties()
        {
            PrivateEndpointConnections = new ChangeTrackingList<PurviewPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountProperties"/>. </summary>
        /// <param name="accountStatus"> Gets or sets the status of the account. </param>
        /// <param name="cloudConnectors"> External Cloud Service connectors. </param>
        /// <param name="createdOn"> Gets the time at which the entity was created. </param>
        /// <param name="createdBy"> Gets the creator of the entity. </param>
        /// <param name="createdByObjectId"> Gets the creators of the entity's object id. </param>
        /// <param name="endpoints"> The URIs that are the public endpoints of the account. </param>
        /// <param name="friendlyName"> Gets or sets the friendly name. </param>
        /// <param name="ingestionStorage"> Ingestion Storage Account Info. </param>
        /// <param name="managedEventHubState"> Gets or sets the state of managed eventhub. If enabled managed eventhub will be created, if disabled the managed eventhub will be removed. </param>
        /// <param name="managedResourceGroupName"> Gets or sets the managed resource group name. </param>
        /// <param name="managedResources"> Gets the resource identifiers of the managed resources. </param>
        /// <param name="managedResourcesPublicNetworkAccess"> Gets or sets the public network access for managed resources. </param>
        /// <param name="privateEndpointConnections"> Gets the private endpoint connections information. </param>
        /// <param name="provisioningState"> Gets or sets the state of the provisioning. </param>
        /// <param name="publicNetworkAccess"> Gets or sets the public network access. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewAccountProperties(PurviewAccountStatus accountStatus, CloudConnectors cloudConnectors, DateTimeOffset? createdOn, string createdBy, string createdByObjectId, PurviewAccountEndpoint endpoints, string friendlyName, PurviewIngestionStorage ingestionStorage, PurviewManagedEventHubState? managedEventHubState, string managedResourceGroupName, PurviewManagedResource managedResources, ManagedResourcesPublicNetworkAccess? managedResourcesPublicNetworkAccess, IReadOnlyList<PurviewPrivateEndpointConnectionData> privateEndpointConnections, PurviewProvisioningState? provisioningState, PurviewPublicNetworkAccess? publicNetworkAccess, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountStatus = accountStatus;
            CloudConnectors = cloudConnectors;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
            CreatedByObjectId = createdByObjectId;
            Endpoints = endpoints;
            FriendlyName = friendlyName;
            IngestionStorage = ingestionStorage;
            ManagedEventHubState = managedEventHubState;
            ManagedResourceGroupName = managedResourceGroupName;
            ManagedResources = managedResources;
            ManagedResourcesPublicNetworkAccess = managedResourcesPublicNetworkAccess;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            PublicNetworkAccess = publicNetworkAccess;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the status of the account. </summary>
        public PurviewAccountStatus AccountStatus { get; }
        /// <summary> External Cloud Service connectors. </summary>
        internal CloudConnectors CloudConnectors { get; set; }
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        public string CloudConnectorsAwsExternalId
        {
            get => CloudConnectors is null ? default : CloudConnectors.AwsExternalId;
        }

        /// <summary> Gets the time at which the entity was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets the creator of the entity. </summary>
        public string CreatedBy { get; }
        /// <summary> Gets the creators of the entity's object id. </summary>
        public string CreatedByObjectId { get; }
        /// <summary> The URIs that are the public endpoints of the account. </summary>
        public PurviewAccountEndpoint Endpoints { get; }
        /// <summary> Gets or sets the friendly name. </summary>
        public string FriendlyName { get; }
        /// <summary> Ingestion Storage Account Info. </summary>
        public PurviewIngestionStorage IngestionStorage { get; set; }
        /// <summary> Gets or sets the state of managed eventhub. If enabled managed eventhub will be created, if disabled the managed eventhub will be removed. </summary>
        public PurviewManagedEventHubState? ManagedEventHubState { get; set; }
        /// <summary> Gets or sets the managed resource group name. </summary>
        public string ManagedResourceGroupName { get; set; }
        /// <summary> Gets the resource identifiers of the managed resources. </summary>
        public PurviewManagedResource ManagedResources { get; }
        /// <summary> Gets or sets the public network access for managed resources. </summary>
        public ManagedResourcesPublicNetworkAccess? ManagedResourcesPublicNetworkAccess { get; set; }
        /// <summary> Gets the private endpoint connections information. </summary>
        public IReadOnlyList<PurviewPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Gets or sets the state of the provisioning. </summary>
        public PurviewProvisioningState? ProvisioningState { get; }
        /// <summary> Gets or sets the public network access. </summary>
        public PurviewPublicNetworkAccess? PublicNetworkAccess { get; set; }
    }
}
