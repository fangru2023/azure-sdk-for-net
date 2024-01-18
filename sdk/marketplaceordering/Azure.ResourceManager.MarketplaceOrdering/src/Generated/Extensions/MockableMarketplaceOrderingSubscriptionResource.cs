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
using Azure.ResourceManager.MarketplaceOrdering;
using Azure.ResourceManager.MarketplaceOrdering.Models;

namespace Azure.ResourceManager.MarketplaceOrdering.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableMarketplaceOrderingSubscriptionResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMarketplaceOrderingSubscriptionResource"/> class for mocking. </summary>
        protected MockableMarketplaceOrderingSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMarketplaceOrderingSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMarketplaceOrderingSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MarketplaceAgreementTermResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of MarketplaceAgreementTermResources and their operations over a MarketplaceAgreementTermResource. </returns>
        public virtual MarketplaceAgreementTermCollection GetMarketplaceAgreementTerms()
        {
            return GetCachedClient(client => new MarketplaceAgreementTermCollection(client, Id));
        }

        /// <summary>
        /// Get marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MarketplaceAgreementTermResource>> GetMarketplaceAgreementTermAsync(AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            return await GetMarketplaceAgreementTerms().GetAsync(offerType, publisherId, offerId, planId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get marketplace terms.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/offerTypes/{offerType}/publishers/{publisherId}/offers/{offerId}/plans/{planId}/agreements/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementTermResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerType"> Offer Type, currently only virtualmachine type is supported. </param>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MarketplaceAgreementTermResource> GetMarketplaceAgreementTerm(AgreementOfferType offerType, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            return GetMarketplaceAgreementTerms().Get(offerType, publisherId, offerId, planId, cancellationToken);
        }

        /// <summary> Gets a collection of MarketplaceAgreementResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of MarketplaceAgreementResources and their operations over a MarketplaceAgreementResource. </returns>
        public virtual MarketplaceAgreementCollection GetMarketplaceAgreements()
        {
            return GetCachedClient(client => new MarketplaceAgreementCollection(client, Id));
        }

        /// <summary>
        /// Get marketplace agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_GetAgreement</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MarketplaceAgreementResource>> GetMarketplaceAgreementAsync(string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            return await GetMarketplaceAgreements().GetAsync(publisherId, offerId, planId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get marketplace agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MarketplaceOrdering/agreements/{publisherId}/offers/{offerId}/plans/{planId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_GetAgreement</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MarketplaceAgreementResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherId"> Publisher identifier string of image being deployed. </param>
        /// <param name="offerId"> Offer identifier string of image being deployed. </param>
        /// <param name="planId"> Plan identifier string of image being deployed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publisherId"/>, <paramref name="offerId"/> or <paramref name="planId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MarketplaceAgreementResource> GetMarketplaceAgreement(string publisherId, string offerId, string planId, CancellationToken cancellationToken = default)
        {
            return GetMarketplaceAgreements().Get(publisherId, offerId, planId, cancellationToken);
        }
    }
}
