// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The authentication info when authType is servicePrincipal secret. </summary>
    public partial class ServicePrincipalSecretAuthInfo : AuthBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="ServicePrincipalSecretAuthInfo"/>. </summary>
        /// <param name="clientId"> ServicePrincipal application clientId for servicePrincipal auth. </param>
        /// <param name="principalId"> Principal Id for servicePrincipal auth. </param>
        /// <param name="secret"> Secret for servicePrincipal auth. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientId"/> or <paramref name="secret"/> is null. </exception>
        public ServicePrincipalSecretAuthInfo(string clientId, Guid principalId, string secret)
        {
            Argument.AssertNotNull(clientId, nameof(clientId));
            Argument.AssertNotNull(secret, nameof(secret));

            ClientId = clientId;
            PrincipalId = principalId;
            Secret = secret;
            AuthType = LinkerAuthType.ServicePrincipalSecret;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalSecretAuthInfo"/>. </summary>
        /// <param name="authType"> The authentication type. </param>
        /// <param name="clientId"> ServicePrincipal application clientId for servicePrincipal auth. </param>
        /// <param name="principalId"> Principal Id for servicePrincipal auth. </param>
        /// <param name="secret"> Secret for servicePrincipal auth. </param>
        internal ServicePrincipalSecretAuthInfo(LinkerAuthType authType, string clientId, Guid principalId, string secret) : base(authType)
        {
            ClientId = clientId;
            PrincipalId = principalId;
            Secret = secret;
            AuthType = authType;
        }

        /// <summary> ServicePrincipal application clientId for servicePrincipal auth. </summary>
        public string ClientId { get; set; }
        /// <summary> Principal Id for servicePrincipal auth. </summary>
        public Guid PrincipalId { get; set; }
        /// <summary> Secret for servicePrincipal auth. </summary>
        public string Secret { get; set; }
    }
}
