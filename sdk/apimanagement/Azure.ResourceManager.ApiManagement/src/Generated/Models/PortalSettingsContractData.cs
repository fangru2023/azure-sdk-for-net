// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Portal Settings for the Developer Portal. </summary>
    public partial class PortalSettingsContractData : ResourceData
    {
        /// <summary> Initializes a new instance of PortalSettingsContractData. </summary>
        public PortalSettingsContractData()
        {
        }

        /// <summary> Initializes a new instance of PortalSettingsContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="uri"> A delegation Url. </param>
        /// <param name="validationKey"> A base64-encoded validation key to validate, that a request is coming from Azure API Management. </param>
        /// <param name="subscriptions"> Subscriptions delegation settings. </param>
        /// <param name="userRegistration"> User registration delegation settings. </param>
        /// <param name="enabled"> Redirect Anonymous users to the Sign-In page. </param>
        /// <param name="termsOfService"> Terms of service contract properties. </param>
        internal PortalSettingsContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri uri, string validationKey, SubscriptionsDelegationSettingsProperties subscriptions, RegistrationDelegationSettingsProperties userRegistration, bool? enabled, TermsOfServiceProperties termsOfService) : base(id, name, resourceType, systemData)
        {
            Uri = uri;
            ValidationKey = validationKey;
            Subscriptions = subscriptions;
            UserRegistration = userRegistration;
            Enabled = enabled;
            TermsOfService = termsOfService;
        }

        /// <summary> A delegation Url. </summary>
        public Uri Uri { get; set; }
        /// <summary> A base64-encoded validation key to validate, that a request is coming from Azure API Management. </summary>
        public string ValidationKey { get; set; }
        /// <summary> Subscriptions delegation settings. </summary>
        internal SubscriptionsDelegationSettingsProperties Subscriptions { get; set; }
        /// <summary> Enable or disable delegation for subscriptions. </summary>
        public bool? SubscriptionsEnabled
        {
            get => Subscriptions is null ? default : Subscriptions.Enabled;
            set
            {
                if (Subscriptions is null)
                    Subscriptions = new SubscriptionsDelegationSettingsProperties();
                Subscriptions.Enabled = value;
            }
        }

        /// <summary> User registration delegation settings. </summary>
        internal RegistrationDelegationSettingsProperties UserRegistration { get; set; }
        /// <summary> Enable or disable delegation for user registration. </summary>
        public bool? UserRegistrationEnabled
        {
            get => UserRegistration is null ? default : UserRegistration.Enabled;
            set
            {
                if (UserRegistration is null)
                    UserRegistration = new RegistrationDelegationSettingsProperties();
                UserRegistration.Enabled = value;
            }
        }

        /// <summary> Redirect Anonymous users to the Sign-In page. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Terms of service contract properties. </summary>
        public TermsOfServiceProperties TermsOfService { get; set; }
    }
}
