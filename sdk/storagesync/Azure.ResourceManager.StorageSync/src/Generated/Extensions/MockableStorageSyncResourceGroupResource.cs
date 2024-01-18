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
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableStorageSyncResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStorageSyncResourceGroupResource"/> class for mocking. </summary>
        protected MockableStorageSyncResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStorageSyncResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStorageSyncResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of StorageSyncServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StorageSyncServiceResources and their operations over a StorageSyncServiceResource. </returns>
        public virtual StorageSyncServiceCollection GetStorageSyncServices()
        {
            return GetCachedClient(client => new StorageSyncServiceCollection(client, Id));
        }

        /// <summary>
        /// Get a given StorageSyncService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StorageSyncServiceResource>> GetStorageSyncServiceAsync(string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            return await GetStorageSyncServices().GetAsync(storageSyncServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a given StorageSyncService.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageSync/storageSyncServices/{storageSyncServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageSyncServices_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageSyncServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageSyncServiceName"> Name of Storage Sync Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageSyncServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storageSyncServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<StorageSyncServiceResource> GetStorageSyncService(string storageSyncServiceName, CancellationToken cancellationToken = default)
        {
            return GetStorageSyncServices().Get(storageSyncServiceName, cancellationToken);
        }
    }
}
