// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ServiceFabricManagedClusters;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableServiceFabricManagedClustersResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricManagedClustersResourceGroupResource"/> class for mocking. </summary>
        protected MockableServiceFabricManagedClustersResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricManagedClustersResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceFabricManagedClustersResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ServiceFabricManagedClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ServiceFabricManagedClusterResources and their operations over a ServiceFabricManagedClusterResource. </returns>
        public virtual ServiceFabricManagedClusterCollection GetServiceFabricManagedClusters()
        {
            return GetCachedClient(client => new ServiceFabricManagedClusterCollection(client, Id));
        }

        /// <summary>
        /// Get a Service Fabric managed cluster resource created or in the process of being created in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceFabricManagedClusterResource>> GetServiceFabricManagedClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetServiceFabricManagedClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Service Fabric managed cluster resource created or in the process of being created in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceFabric/managedClusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceFabricManagedClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServiceFabricManagedClusterResource> GetServiceFabricManagedCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetServiceFabricManagedClusters().Get(clusterName, cancellationToken);
        }
    }
}
