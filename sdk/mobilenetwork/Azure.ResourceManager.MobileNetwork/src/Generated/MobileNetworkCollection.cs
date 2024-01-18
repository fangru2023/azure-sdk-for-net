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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="MobileNetworkResource"/> and their operations.
    /// Each <see cref="MobileNetworkResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="MobileNetworkCollection"/> instance call the GetMobileNetworks method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class MobileNetworkCollection : ArmCollection, IEnumerable<MobileNetworkResource>, IAsyncEnumerable<MobileNetworkResource>
    {
        private readonly ClientDiagnostics _mobileNetworkClientDiagnostics;
        private readonly MobileNetworksRestOperations _mobileNetworkRestClient;

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkCollection"/> class for mocking. </summary>
        protected MobileNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MobileNetworkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", MobileNetworkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MobileNetworkResource.ResourceType, out string mobileNetworkApiVersion);
            _mobileNetworkRestClient = new MobileNetworksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="data"> Parameters supplied to the create or update mobile network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MobileNetworkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string mobileNetworkName, MobileNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkClientDiagnostics.CreateScope("MobileNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mobileNetworkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation<MobileNetworkResource>(new MobileNetworkOperationSource(Client), _mobileNetworkClientDiagnostics, Pipeline, _mobileNetworkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="data"> Parameters supplied to the create or update mobile network operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MobileNetworkResource> CreateOrUpdate(WaitUntil waitUntil, string mobileNetworkName, MobileNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mobileNetworkClientDiagnostics.CreateScope("MobileNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mobileNetworkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, data, cancellationToken);
                var operation = new MobileNetworkArmOperation<MobileNetworkResource>(new MobileNetworkOperationSource(Client), _mobileNetworkClientDiagnostics, Pipeline, _mobileNetworkRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkResource>> GetAsync(string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var scope = _mobileNetworkClientDiagnostics.CreateScope("MobileNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> is null. </exception>
        public virtual Response<MobileNetworkResource> Get(string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var scope = _mobileNetworkClientDiagnostics.CreateScope("MobileNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the mobile networks in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MobileNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MobileNetworkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MobileNetworkResource(Client, MobileNetworkData.DeserializeMobileNetworkData(e)), _mobileNetworkClientDiagnostics, Pipeline, "MobileNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the mobile networks in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MobileNetworkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MobileNetworkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mobileNetworkRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mobileNetworkRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MobileNetworkResource(Client, MobileNetworkData.DeserializeMobileNetworkData(e)), _mobileNetworkClientDiagnostics, Pipeline, "MobileNetworkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var scope = _mobileNetworkClientDiagnostics.CreateScope("MobileNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var scope = _mobileNetworkClientDiagnostics.CreateScope("MobileNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = _mobileNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> is null. </exception>
        public virtual async Task<NullableResponse<MobileNetworkResource>> GetIfExistsAsync(string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var scope = _mobileNetworkClientDiagnostics.CreateScope("MobileNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mobileNetworkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MobileNetworkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> is null. </exception>
        public virtual NullableResponse<MobileNetworkResource> GetIfExists(string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mobileNetworkName, nameof(mobileNetworkName));

            using var scope = _mobileNetworkClientDiagnostics.CreateScope("MobileNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mobileNetworkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, mobileNetworkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MobileNetworkResource>(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MobileNetworkResource> IEnumerable<MobileNetworkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MobileNetworkResource> IAsyncEnumerable<MobileNetworkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
