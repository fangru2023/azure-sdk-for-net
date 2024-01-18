// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.DataBoxEdge.Models;

namespace Azure.ResourceManager.DataBoxEdge.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableDataBoxEdgeSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _availableSkusClientDiagnostics;
        private AvailableSkusRestOperations _availableSkusRestClient;
        private ClientDiagnostics _dataBoxEdgeDeviceDevicesClientDiagnostics;
        private DevicesRestOperations _dataBoxEdgeDeviceDevicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableDataBoxEdgeSubscriptionResource"/> class for mocking. </summary>
        protected MockableDataBoxEdgeSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDataBoxEdgeSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDataBoxEdgeSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AvailableSkusClientDiagnostics => _availableSkusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AvailableSkusRestOperations AvailableSkusRestClient => _availableSkusRestClient ??= new AvailableSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics DataBoxEdgeDeviceDevicesClientDiagnostics => _dataBoxEdgeDeviceDevicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataBoxEdge", DataBoxEdgeDeviceResource.ResourceType.Namespace, Diagnostics);
        private DevicesRestOperations DataBoxEdgeDeviceDevicesRestClient => _dataBoxEdgeDeviceDevicesRestClient ??= new DevicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataBoxEdgeDeviceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the available Skus and information related to them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/availableSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableSkus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableDataBoxEdgeSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableDataBoxEdgeSku> GetAvailableSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableSkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, AvailableDataBoxEdgeSku.DeserializeAvailableDataBoxEdgeSku, AvailableSkusClientDiagnostics, Pipeline, "MockableDataBoxEdgeSubscriptionResource.GetAvailableSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the available Skus and information related to them.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/availableSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableSkus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableDataBoxEdgeSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableDataBoxEdgeSku> GetAvailableSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvailableSkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvailableSkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, AvailableDataBoxEdgeSku.DeserializeAvailableDataBoxEdgeSku, AvailableSkusClientDiagnostics, Pipeline, "MockableDataBoxEdgeSubscriptionResource.GetAvailableSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the Data Box Edge/Data Box Gateway devices in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify $expand=details to populate additional fields related to the resource or Specify $skipToken=&lt;token&gt; to populate the next page in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxEdgeDeviceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevicesAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataBoxEdgeDeviceDevicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataBoxEdgeDeviceDevicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataBoxEdgeDeviceResource(Client, DataBoxEdgeDeviceData.DeserializeDataBoxEdgeDeviceData(e)), DataBoxEdgeDeviceDevicesClientDiagnostics, Pipeline, "MockableDataBoxEdgeSubscriptionResource.GetDataBoxEdgeDevices", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the Data Box Edge/Data Box Gateway devices in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Devices_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxEdgeDeviceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify $expand=details to populate additional fields related to the resource or Specify $skipToken=&lt;token&gt; to populate the next page in the list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxEdgeDeviceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxEdgeDeviceResource> GetDataBoxEdgeDevices(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataBoxEdgeDeviceDevicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataBoxEdgeDeviceDevicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataBoxEdgeDeviceResource(Client, DataBoxEdgeDeviceData.DeserializeDataBoxEdgeDeviceData(e)), DataBoxEdgeDeviceDevicesClientDiagnostics, Pipeline, "MockableDataBoxEdgeSubscriptionResource.GetDataBoxEdgeDevices", "value", "nextLink", cancellationToken);
        }
    }
}
