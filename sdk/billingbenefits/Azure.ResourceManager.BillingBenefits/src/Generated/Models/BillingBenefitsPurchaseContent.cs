// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The BillingBenefitsPurchaseContent. </summary>
    public partial class BillingBenefitsPurchaseContent
    {
        /// <summary> Initializes a new instance of <see cref="BillingBenefitsPurchaseContent"/>. </summary>
        public BillingBenefitsPurchaseContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingBenefitsPurchaseContent"/>. </summary>
        /// <param name="sku"> The SKU to be applied for this resource. </param>
        /// <param name="displayName"> Friendly name of the savings plan. </param>
        /// <param name="billingScopeId"> Subscription that will be charged for purchasing the benefit. </param>
        /// <param name="term"> Represent benefit term in ISO 8601 format. </param>
        /// <param name="billingPlan"> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </param>
        /// <param name="appliedScopeType"> Type of the Applied Scope. </param>
        /// <param name="commitment"> Commitment towards the benefit. </param>
        /// <param name="effectOn"> DateTime of the savings plan starts providing benefit from. </param>
        /// <param name="isRenewed"> Setting this to true will automatically purchase a new benefit on the expiration date time. </param>
        /// <param name="appliedScopeProperties"> Properties specific to applied scope type. Not required if not applicable. </param>
        internal BillingBenefitsPurchaseContent(BillingBenefitsSku sku, string displayName, ResourceIdentifier billingScopeId, BillingBenefitsTerm? term, BillingBenefitsBillingPlan? billingPlan, BillingBenefitsAppliedScopeType? appliedScopeType, BillingBenefitsCommitment commitment, DateTimeOffset? effectOn, bool? isRenewed, BillingBenefitsAppliedScopeProperties appliedScopeProperties)
        {
            Sku = sku;
            DisplayName = displayName;
            BillingScopeId = billingScopeId;
            Term = term;
            BillingPlan = billingPlan;
            AppliedScopeType = appliedScopeType;
            Commitment = commitment;
            EffectOn = effectOn;
            IsRenewed = isRenewed;
            AppliedScopeProperties = appliedScopeProperties;
        }

        /// <summary> The SKU to be applied for this resource. </summary>
        internal BillingBenefitsSku Sku { get; set; }
        /// <summary> Name of the SKU to be applied. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new BillingBenefitsSku();
                Sku.Name = value;
            }
        }

        /// <summary> Friendly name of the savings plan. </summary>
        public string DisplayName { get; set; }
        /// <summary> Subscription that will be charged for purchasing the benefit. </summary>
        public ResourceIdentifier BillingScopeId { get; set; }
        /// <summary> Represent benefit term in ISO 8601 format. </summary>
        public BillingBenefitsTerm? Term { get; set; }
        /// <summary> Represents the billing plan in ISO 8601 format. Required only for monthly billing plans. </summary>
        public BillingBenefitsBillingPlan? BillingPlan { get; set; }
        /// <summary> Type of the Applied Scope. </summary>
        public BillingBenefitsAppliedScopeType? AppliedScopeType { get; set; }
        /// <summary> Commitment towards the benefit. </summary>
        public BillingBenefitsCommitment Commitment { get; set; }
        /// <summary> DateTime of the savings plan starts providing benefit from. </summary>
        public DateTimeOffset? EffectOn { get; }
        /// <summary> Setting this to true will automatically purchase a new benefit on the expiration date time. </summary>
        public bool? IsRenewed { get; set; }
        /// <summary> Properties specific to applied scope type. Not required if not applicable. </summary>
        public BillingBenefitsAppliedScopeProperties AppliedScopeProperties { get; set; }
    }
}
