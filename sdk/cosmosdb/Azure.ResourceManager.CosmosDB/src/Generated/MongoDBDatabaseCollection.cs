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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="MongoDBDatabaseResource"/> and their operations.
    /// Each <see cref="MongoDBDatabaseResource"/> in the collection will belong to the same instance of <see cref="CosmosDBAccountResource"/>.
    /// To get a <see cref="MongoDBDatabaseCollection"/> instance call the GetMongoDBDatabases method from an instance of <see cref="CosmosDBAccountResource"/>.
    /// </summary>
    public partial class MongoDBDatabaseCollection : ArmCollection, IEnumerable<MongoDBDatabaseResource>, IAsyncEnumerable<MongoDBDatabaseResource>
    {
        private readonly ClientDiagnostics _mongoDBDatabaseMongoDBResourcesClientDiagnostics;
        private readonly MongoDBResourcesRestOperations _mongoDBDatabaseMongoDBResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MongoDBDatabaseCollection"/> class for mocking. </summary>
        protected MongoDBDatabaseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MongoDBDatabaseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MongoDBDatabaseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mongoDBDatabaseMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", MongoDBDatabaseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MongoDBDatabaseResource.ResourceType, out string mongoDBDatabaseMongoDBResourcesApiVersion);
            _mongoDBDatabaseMongoDBResourcesRestClient = new MongoDBResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mongoDBDatabaseMongoDBResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or updates Azure Cosmos DB MongoDB database
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_CreateUpdateMongoDBDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="content"> The parameters to provide for the current MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<MongoDBDatabaseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string databaseName, MongoDBDatabaseCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mongoDBDatabaseMongoDBResourcesRestClient.CreateUpdateMongoDBDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, content, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<MongoDBDatabaseResource>(new MongoDBDatabaseOperationSource(Client), _mongoDBDatabaseMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBDatabaseMongoDBResourcesRestClient.CreateCreateUpdateMongoDBDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Create or updates Azure Cosmos DB MongoDB database
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_CreateUpdateMongoDBDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="content"> The parameters to provide for the current MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<MongoDBDatabaseResource> CreateOrUpdate(WaitUntil waitUntil, string databaseName, MongoDBDatabaseCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mongoDBDatabaseMongoDBResourcesRestClient.CreateUpdateMongoDBDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, content, cancellationToken);
                var operation = new CosmosDBArmOperation<MongoDBDatabaseResource>(new MongoDBDatabaseOperationSource(Client), _mongoDBDatabaseMongoDBResourcesClientDiagnostics, Pipeline, _mongoDBDatabaseMongoDBResourcesRestClient.CreateCreateUpdateMongoDBDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the MongoDB databases under an existing Azure Cosmos DB database account with the provided name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoDBDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<MongoDBDatabaseResource>> GetAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = await _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the MongoDB databases under an existing Azure Cosmos DB database account with the provided name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoDBDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<MongoDBDatabaseResource> Get(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.Get");
            scope.Start();
            try
            {
                var response = _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MongoDBDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the MongoDB databases under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_ListMongoDBDatabases</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MongoDBDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MongoDBDatabaseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mongoDBDatabaseMongoDBResourcesRestClient.CreateListMongoDBDatabasesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new MongoDBDatabaseResource(Client, MongoDBDatabaseData.DeserializeMongoDBDatabaseData(e)), _mongoDBDatabaseMongoDBResourcesClientDiagnostics, Pipeline, "MongoDBDatabaseCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the MongoDB databases under an existing Azure Cosmos DB database account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_ListMongoDBDatabases</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MongoDBDatabaseResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MongoDBDatabaseResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mongoDBDatabaseMongoDBResourcesRestClient.CreateListMongoDBDatabasesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new MongoDBDatabaseResource(Client, MongoDBDatabaseData.DeserializeMongoDBDatabaseData(e)), _mongoDBDatabaseMongoDBResourcesClientDiagnostics, Pipeline, "MongoDBDatabaseCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoDBDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoDBDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.Exists");
            scope.Start();
            try
            {
                var response = _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoDBDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual async Task<NullableResponse<MongoDBDatabaseResource>> GetIfExistsAsync(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MongoDBDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new MongoDBDatabaseResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/mongodbDatabases/{databaseName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MongoDBResources_GetMongoDBDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MongoDBDatabaseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseName"> Cosmos DB database name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public virtual NullableResponse<MongoDBDatabaseResource> GetIfExists(string databaseName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));

            using var scope = _mongoDBDatabaseMongoDBResourcesClientDiagnostics.CreateScope("MongoDBDatabaseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mongoDBDatabaseMongoDBResourcesRestClient.GetMongoDBDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, databaseName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MongoDBDatabaseResource>(response.GetRawResponse());
                return Response.FromValue(new MongoDBDatabaseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MongoDBDatabaseResource> IEnumerable<MongoDBDatabaseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MongoDBDatabaseResource> IAsyncEnumerable<MongoDBDatabaseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
