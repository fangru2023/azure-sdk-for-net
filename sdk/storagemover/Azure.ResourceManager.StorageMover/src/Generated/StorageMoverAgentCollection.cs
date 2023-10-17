// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageMoverAgentResource" /> and their operations.
    /// Each <see cref="StorageMoverAgentResource" /> in the collection will belong to the same instance of <see cref="StorageMoverResource" />.
    /// To get a <see cref="StorageMoverAgentCollection" /> instance call the GetStorageMoverAgents method from an instance of <see cref="StorageMoverResource" />.
    /// </summary>
    public partial class StorageMoverAgentCollection : ArmCollection, IEnumerable<StorageMoverAgentResource>, IAsyncEnumerable<StorageMoverAgentResource>
    {
        private readonly ClientDiagnostics _storageMoverAgentAgentsClientDiagnostics;
        private readonly AgentsRestOperations _storageMoverAgentAgentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageMoverAgentCollection"/> class for mocking. </summary>
        protected StorageMoverAgentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageMoverAgentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageMoverAgentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageMoverAgentAgentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageMover", StorageMoverAgentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageMoverAgentResource.ResourceType, out string storageMoverAgentAgentsApiVersion);
            _storageMoverAgentAgentsRestClient = new AgentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageMoverAgentAgentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageMoverResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageMoverResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an Agent resource, which references a hybrid compute machine that can run jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents/{agentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentName"> The name of the Agent resource. </param>
        /// <param name="data"> The StorageMoverAgent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageMoverAgentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string agentName, StorageMoverAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentName, nameof(agentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageMoverAgentAgentsClientDiagnostics.CreateScope("StorageMoverAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageMoverAgentAgentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StorageMoverArmOperation<StorageMoverAgentResource>(Response.FromValue(new StorageMoverAgentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an Agent resource, which references a hybrid compute machine that can run jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents/{agentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="agentName"> The name of the Agent resource. </param>
        /// <param name="data"> The StorageMoverAgent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageMoverAgentResource> CreateOrUpdate(WaitUntil waitUntil, string agentName, StorageMoverAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentName, nameof(agentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageMoverAgentAgentsClientDiagnostics.CreateScope("StorageMoverAgentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageMoverAgentAgentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentName, data, cancellationToken);
                var operation = new StorageMoverArmOperation<StorageMoverAgentResource>(Response.FromValue(new StorageMoverAgentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Agent resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents/{agentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentName"> The name of the Agent resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentName"/> is null. </exception>
        public virtual async Task<Response<StorageMoverAgentResource>> GetAsync(string agentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentName, nameof(agentName));

            using var scope = _storageMoverAgentAgentsClientDiagnostics.CreateScope("StorageMoverAgentCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageMoverAgentAgentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an Agent resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents/{agentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentName"> The name of the Agent resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentName"/> is null. </exception>
        public virtual Response<StorageMoverAgentResource> Get(string agentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentName, nameof(agentName));

            using var scope = _storageMoverAgentAgentsClientDiagnostics.CreateScope("StorageMoverAgentCollection.Get");
            scope.Start();
            try
            {
                var response = _storageMoverAgentAgentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Agents in a Storage Mover.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageMoverAgentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageMoverAgentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageMoverAgentAgentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageMoverAgentAgentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageMoverAgentResource(Client, StorageMoverAgentData.DeserializeStorageMoverAgentData(e)), _storageMoverAgentAgentsClientDiagnostics, Pipeline, "StorageMoverAgentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Agents in a Storage Mover.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageMoverAgentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageMoverAgentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageMoverAgentAgentsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageMoverAgentAgentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageMoverAgentResource(Client, StorageMoverAgentData.DeserializeStorageMoverAgentData(e)), _storageMoverAgentAgentsClientDiagnostics, Pipeline, "StorageMoverAgentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents/{agentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentName"> The name of the Agent resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string agentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentName, nameof(agentName));

            using var scope = _storageMoverAgentAgentsClientDiagnostics.CreateScope("StorageMoverAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageMoverAgentAgentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents/{agentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentName"> The name of the Agent resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentName"/> is null. </exception>
        public virtual Response<bool> Exists(string agentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentName, nameof(agentName));

            using var scope = _storageMoverAgentAgentsClientDiagnostics.CreateScope("StorageMoverAgentCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageMoverAgentAgentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents/{agentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentName"> The name of the Agent resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageMoverAgentResource>> GetIfExistsAsync(string agentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentName, nameof(agentName));

            using var scope = _storageMoverAgentAgentsClientDiagnostics.CreateScope("StorageMoverAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageMoverAgentAgentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageMoverAgentResource>(response.GetRawResponse());
                return Response.FromValue(new StorageMoverAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}/agents/{agentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Agents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentName"> The name of the Agent resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="agentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="agentName"/> is null. </exception>
        public virtual NullableResponse<StorageMoverAgentResource> GetIfExists(string agentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(agentName, nameof(agentName));

            using var scope = _storageMoverAgentAgentsClientDiagnostics.CreateScope("StorageMoverAgentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageMoverAgentAgentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, agentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageMoverAgentResource>(response.GetRawResponse());
                return Response.FromValue(new StorageMoverAgentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageMoverAgentResource> IEnumerable<StorageMoverAgentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageMoverAgentResource> IAsyncEnumerable<StorageMoverAgentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
