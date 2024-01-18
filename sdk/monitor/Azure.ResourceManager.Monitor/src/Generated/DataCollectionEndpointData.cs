// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing the DataCollectionEndpoint data model.
    /// Definition of ARM tracked top level resource.
    /// </summary>
    public partial class DataCollectionEndpointData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DataCollectionEndpointData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DataCollectionEndpointData(AzureLocation location) : base(location)
        {
            PrivateLinkScopedResources = new ChangeTrackingList<DataCollectionRulePrivateLinkScopedResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionEndpointData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of the resource. </param>
        /// <param name="identity"> Managed service identity of the resource. </param>
        /// <param name="etag"> Resource entity tag (ETag). </param>
        /// <param name="description"> Description of the data collection endpoint. </param>
        /// <param name="immutableId"> The immutable ID of this data collection endpoint resource. This property is READ-ONLY. </param>
        /// <param name="configurationAccess"> The endpoint used by clients to access their configuration. </param>
        /// <param name="logsIngestion"> The endpoint used by clients to ingest logs. </param>
        /// <param name="metricsIngestion"> The endpoint used by clients to ingest metrics. </param>
        /// <param name="networkAcls"> Network access control rules for the endpoints. </param>
        /// <param name="provisioningState"> The resource provisioning state. This property is READ-ONLY. </param>
        /// <param name="privateLinkScopedResources"> List of Azure Monitor Private Link Scope Resources to which this data collection endpoint resource is associated. This property is READ-ONLY. </param>
        /// <param name="failoverConfiguration"> Failover configuration on this endpoint. This property is READ-ONLY. </param>
        /// <param name="metadata"> Metadata for the resource. This property is READ-ONLY. </param>
        internal DataCollectionEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DataCollectionEndpointResourceKind? kind, ManagedServiceIdentity identity, ETag? etag, string description, string immutableId, DataCollectionEndpointConfigurationAccess configurationAccess, DataCollectionEndpointLogsIngestion logsIngestion, DataCollectionEndpointMetricsIngestion metricsIngestion, DataCollectionEndpointNetworkAcls networkAcls, DataCollectionEndpointProvisioningState? provisioningState, IReadOnlyList<DataCollectionRulePrivateLinkScopedResourceInfo> privateLinkScopedResources, DataCollectionEndpointFailoverConfiguration failoverConfiguration, DataCollectionEndpointMetadata metadata) : base(id, name, resourceType, systemData, tags, location)
        {
            Kind = kind;
            Identity = identity;
            ETag = etag;
            Description = description;
            ImmutableId = immutableId;
            ConfigurationAccess = configurationAccess;
            LogsIngestion = logsIngestion;
            MetricsIngestion = metricsIngestion;
            NetworkAcls = networkAcls;
            ProvisioningState = provisioningState;
            PrivateLinkScopedResources = privateLinkScopedResources;
            FailoverConfiguration = failoverConfiguration;
            Metadata = metadata;
        }

        /// <summary> The kind of the resource. </summary>
        public DataCollectionEndpointResourceKind? Kind { get; set; }
        /// <summary> Managed service identity of the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource entity tag (ETag). </summary>
        public ETag? ETag { get; }
        /// <summary> Description of the data collection endpoint. </summary>
        public string Description { get; set; }
        /// <summary> The immutable ID of this data collection endpoint resource. This property is READ-ONLY. </summary>
        public string ImmutableId { get; set; }
        /// <summary> The endpoint used by clients to access their configuration. </summary>
        internal DataCollectionEndpointConfigurationAccess ConfigurationAccess { get; set; }
        /// <summary> The endpoint. This property is READ-ONLY. </summary>
        public string ConfigurationAccessEndpoint
        {
            get => ConfigurationAccess is null ? default : ConfigurationAccess.Endpoint;
        }

        /// <summary> The endpoint used by clients to ingest logs. </summary>
        internal DataCollectionEndpointLogsIngestion LogsIngestion { get; set; }
        /// <summary> The endpoint. This property is READ-ONLY. </summary>
        public string LogsIngestionEndpoint
        {
            get => LogsIngestion is null ? default : LogsIngestion.Endpoint;
        }

        /// <summary> The endpoint used by clients to ingest metrics. </summary>
        internal DataCollectionEndpointMetricsIngestion MetricsIngestion { get; set; }
        /// <summary> The endpoint. This property is READ-ONLY. </summary>
        public string MetricsIngestionEndpoint
        {
            get => MetricsIngestion is null ? default : MetricsIngestion.Endpoint;
        }

        /// <summary> Network access control rules for the endpoints. </summary>
        internal DataCollectionEndpointNetworkAcls NetworkAcls { get; set; }
        /// <summary> The configuration to set whether network access from public internet to the endpoints are allowed. </summary>
        public MonitorPublicNetworkAccess? PublicNetworkAccess
        {
            get => NetworkAcls is null ? default : NetworkAcls.PublicNetworkAccess;
            set
            {
                if (NetworkAcls is null)
                    NetworkAcls = new DataCollectionEndpointNetworkAcls();
                NetworkAcls.PublicNetworkAccess = value;
            }
        }

        /// <summary> The resource provisioning state. This property is READ-ONLY. </summary>
        public DataCollectionEndpointProvisioningState? ProvisioningState { get; }
        /// <summary> List of Azure Monitor Private Link Scope Resources to which this data collection endpoint resource is associated. This property is READ-ONLY. </summary>
        public IReadOnlyList<DataCollectionRulePrivateLinkScopedResourceInfo> PrivateLinkScopedResources { get; }
        /// <summary> Failover configuration on this endpoint. This property is READ-ONLY. </summary>
        public DataCollectionEndpointFailoverConfiguration FailoverConfiguration { get; }
        /// <summary> Metadata for the resource. This property is READ-ONLY. </summary>
        public DataCollectionEndpointMetadata Metadata { get; }
    }
}
