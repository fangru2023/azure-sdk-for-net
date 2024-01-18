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

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A class representing a collection of <see cref="ReservationDetailResource"/> and their operations.
    /// Each <see cref="ReservationDetailResource"/> in the collection will belong to the same instance of <see cref="ReservationOrderResource"/>.
    /// To get a <see cref="ReservationDetailCollection"/> instance call the GetReservationDetails method from an instance of <see cref="ReservationOrderResource"/>.
    /// </summary>
    public partial class ReservationDetailCollection : ArmCollection, IEnumerable<ReservationDetailResource>, IAsyncEnumerable<ReservationDetailResource>
    {
        private readonly ClientDiagnostics _reservationDetailReservationClientDiagnostics;
        private readonly ReservationRestOperations _reservationDetailReservationRestClient;

        /// <summary> Initializes a new instance of the <see cref="ReservationDetailCollection"/> class for mocking. </summary>
        protected ReservationDetailCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationDetailCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ReservationDetailCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reservationDetailReservationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationDetailResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReservationDetailResource.ResourceType, out string reservationDetailReservationApiVersion);
            _reservationDetailReservationRestClient = new ReservationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reservationDetailReservationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ReservationOrderResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ReservationOrderResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get specific `Reservation` details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ReservationDetailResource>> GetAsync(Guid reservationId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailCollection.Get");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.GetAsync(Guid.Parse(Id.Name), reservationId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get specific `Reservation` details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReservationDetailResource> Get(Guid reservationId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailCollection.Get");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Get(Guid.Parse(Id.Name), reservationId, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List `Reservation`s within a single `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationDetailResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationDetailResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationDetailReservationRestClient.CreateListRequest(Guid.Parse(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationDetailReservationRestClient.CreateListNextPageRequest(nextLink, Guid.Parse(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReservationDetailResource(Client, ReservationDetailData.DeserializeReservationDetailData(e)), _reservationDetailReservationClientDiagnostics, Pipeline, "ReservationDetailCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List `Reservation`s within a single `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationDetailResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationDetailResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationDetailReservationRestClient.CreateListRequest(Guid.Parse(Id.Name));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationDetailReservationRestClient.CreateListNextPageRequest(nextLink, Guid.Parse(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReservationDetailResource(Client, ReservationDetailData.DeserializeReservationDetailData(e)), _reservationDetailReservationClientDiagnostics, Pipeline, "ReservationDetailCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of all the revisions for the `Reservation`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}/revisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_ListRevisions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationDetailResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationDetailResource> GetRevisionsAsync(Guid reservationId, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationDetailReservationRestClient.CreateListRevisionsRequest(Guid.Parse(Id.Name), reservationId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationDetailReservationRestClient.CreateListRevisionsNextPageRequest(nextLink, Guid.Parse(Id.Name), reservationId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReservationDetailResource(Client, ReservationDetailData.DeserializeReservationDetailData(e)), _reservationDetailReservationClientDiagnostics, Pipeline, "ReservationDetailCollection.GetRevisions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of all the revisions for the `Reservation`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}/revisions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_ListRevisions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationDetailResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationDetailResource> GetRevisions(Guid reservationId, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationDetailReservationRestClient.CreateListRevisionsRequest(Guid.Parse(Id.Name), reservationId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationDetailReservationRestClient.CreateListRevisionsNextPageRequest(nextLink, Guid.Parse(Id.Name), reservationId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReservationDetailResource(Client, ReservationDetailData.DeserializeReservationDetailData(e)), _reservationDetailReservationClientDiagnostics, Pipeline, "ReservationDetailCollection.GetRevisions", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid reservationId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.GetAsync(Guid.Parse(Id.Name), reservationId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid reservationId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Get(Guid.Parse(Id.Name), reservationId, expand, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ReservationDetailResource>> GetIfExistsAsync(Guid reservationId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _reservationDetailReservationRestClient.GetAsync(Guid.Parse(Id.Name), reservationId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ReservationDetailResource>(response.GetRawResponse());
                return Response.FromValue(new ReservationDetailResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationId"> Id of the reservation item. </param>
        /// <param name="expand"> Supported value of this query is renewProperties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ReservationDetailResource> GetIfExists(Guid reservationId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationDetailReservationClientDiagnostics.CreateScope("ReservationDetailCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _reservationDetailReservationRestClient.Get(Guid.Parse(Id.Name), reservationId, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ReservationDetailResource>(response.GetRawResponse());
                return Response.FromValue(new ReservationDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ReservationDetailResource> IEnumerable<ReservationDetailResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ReservationDetailResource> IAsyncEnumerable<ReservationDetailResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
