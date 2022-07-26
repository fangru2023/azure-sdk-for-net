// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a DataWarehouseUserActivity along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataWarehouseUserActivityResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataWarehouseUserActivityResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlDatabaseResource" /> using the GetDataWarehouseUserActivity method.
    /// </summary>
    public partial class DataWarehouseUserActivityResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataWarehouseUserActivityResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string databaseName, DataWarehouseUserActivityName dataWarehouseUserActivityName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataWarehouseUserActivityClientDiagnostics;
        private readonly DataWarehouseUserActivitiesRestOperations _dataWarehouseUserActivityRestClient;
        private readonly DataWarehouseUserActivityData _data;

        /// <summary> Initializes a new instance of the <see cref="DataWarehouseUserActivityResource"/> class for mocking. </summary>
        protected DataWarehouseUserActivityResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataWarehouseUserActivityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataWarehouseUserActivityResource(ArmClient client, DataWarehouseUserActivityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataWarehouseUserActivityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataWarehouseUserActivityResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataWarehouseUserActivityClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataWarehouseUserActivityApiVersion);
            _dataWarehouseUserActivityRestClient = new DataWarehouseUserActivitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataWarehouseUserActivityApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/databases/dataWarehouseUserActivities";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataWarehouseUserActivityData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the user activities of a data warehouse which includes running and suspended queries
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}
        /// Operation Id: DataWarehouseUserActivities_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataWarehouseUserActivityResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivityClientDiagnostics.CreateScope("DataWarehouseUserActivityResource.Get");
            scope.Start();
            try
            {
                var response = await _dataWarehouseUserActivityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataWarehouseUserActivityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the user activities of a data warehouse which includes running and suspended queries
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}
        /// Operation Id: DataWarehouseUserActivities_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataWarehouseUserActivityResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivityClientDiagnostics.CreateScope("DataWarehouseUserActivityResource.Get");
            scope.Start();
            try
            {
                var response = _dataWarehouseUserActivityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataWarehouseUserActivityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
