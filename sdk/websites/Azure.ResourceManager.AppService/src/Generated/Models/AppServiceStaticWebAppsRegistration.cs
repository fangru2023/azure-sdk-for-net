// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the registration for the Azure Static Web Apps provider. </summary>
    internal partial class AppServiceStaticWebAppsRegistration
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceStaticWebAppsRegistration"/>. </summary>
        public AppServiceStaticWebAppsRegistration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceStaticWebAppsRegistration"/>. </summary>
        /// <param name="clientId"> The Client ID of the app used for login. </param>
        internal AppServiceStaticWebAppsRegistration(string clientId)
        {
            ClientId = clientId;
        }

        /// <summary> The Client ID of the app used for login. </summary>
        public string ClientId { get; set; }
    }
}
