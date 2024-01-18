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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseLibraryResource"/> and their operations.
    /// Each <see cref="SynapseLibraryResource"/> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource"/>.
    /// To get a <see cref="SynapseLibraryCollection"/> instance call the GetSynapseLibraries method from an instance of <see cref="SynapseWorkspaceResource"/>.
    /// </summary>
    public partial class SynapseLibraryCollection : ArmCollection, IEnumerable<SynapseLibraryResource>, IAsyncEnumerable<SynapseLibraryResource>
    {
        private readonly ClientDiagnostics _synapseLibraryLibraryClientDiagnostics;
        private readonly LibraryRestOperations _synapseLibraryLibraryRestClient;
        private readonly ClientDiagnostics _synapseLibraryLibrariesClientDiagnostics;
        private readonly LibrariesRestOperations _synapseLibraryLibrariesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseLibraryCollection"/> class for mocking. </summary>
        protected SynapseLibraryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseLibraryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseLibraryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseLibraryLibraryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseLibraryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseLibraryResource.ResourceType, out string synapseLibraryLibraryApiVersion);
            _synapseLibraryLibraryRestClient = new LibraryRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseLibraryLibraryApiVersion);
            _synapseLibraryLibrariesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseLibraryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseLibraryResource.ResourceType, out string synapseLibraryLibrariesApiVersion);
            _synapseLibraryLibrariesRestClient = new LibrariesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseLibraryLibrariesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get library by name in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/libraries/{libraryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Library_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseLibraryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="libraryName"> Library name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="libraryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public virtual async Task<Response<SynapseLibraryResource>> GetAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(libraryName, nameof(libraryName));

            using var scope = _synapseLibraryLibraryClientDiagnostics.CreateScope("SynapseLibraryCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseLibraryLibraryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, libraryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseLibraryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get library by name in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/libraries/{libraryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Library_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseLibraryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="libraryName"> Library name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="libraryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public virtual Response<SynapseLibraryResource> Get(string libraryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(libraryName, nameof(libraryName));

            using var scope = _synapseLibraryLibraryClientDiagnostics.CreateScope("SynapseLibraryCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseLibraryLibraryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, libraryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseLibraryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List libraries in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/libraries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Libraries_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseLibraryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseLibraryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseLibraryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseLibraryLibrariesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseLibraryLibrariesRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseLibraryResource(Client, SynapseLibraryData.DeserializeSynapseLibraryData(e)), _synapseLibraryLibrariesClientDiagnostics, Pipeline, "SynapseLibraryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List libraries in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/libraries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Libraries_ListByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseLibraryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseLibraryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseLibraryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseLibraryLibrariesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseLibraryLibrariesRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseLibraryResource(Client, SynapseLibraryData.DeserializeSynapseLibraryData(e)), _synapseLibraryLibrariesClientDiagnostics, Pipeline, "SynapseLibraryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/libraries/{libraryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Library_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseLibraryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="libraryName"> Library name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="libraryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(libraryName, nameof(libraryName));

            using var scope = _synapseLibraryLibraryClientDiagnostics.CreateScope("SynapseLibraryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseLibraryLibraryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, libraryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/libraries/{libraryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Library_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseLibraryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="libraryName"> Library name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="libraryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public virtual Response<bool> Exists(string libraryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(libraryName, nameof(libraryName));

            using var scope = _synapseLibraryLibraryClientDiagnostics.CreateScope("SynapseLibraryCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseLibraryLibraryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, libraryName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/libraries/{libraryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Library_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseLibraryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="libraryName"> Library name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="libraryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public virtual async Task<NullableResponse<SynapseLibraryResource>> GetIfExistsAsync(string libraryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(libraryName, nameof(libraryName));

            using var scope = _synapseLibraryLibraryClientDiagnostics.CreateScope("SynapseLibraryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseLibraryLibraryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, libraryName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseLibraryResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseLibraryResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/libraries/{libraryName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Library_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SynapseLibraryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="libraryName"> Library name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="libraryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="libraryName"/> is null. </exception>
        public virtual NullableResponse<SynapseLibraryResource> GetIfExists(string libraryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(libraryName, nameof(libraryName));

            using var scope = _synapseLibraryLibraryClientDiagnostics.CreateScope("SynapseLibraryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseLibraryLibraryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, libraryName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseLibraryResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseLibraryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseLibraryResource> IEnumerable<SynapseLibraryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseLibraryResource> IAsyncEnumerable<SynapseLibraryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
