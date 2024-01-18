// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The authentication info when authType is secret. </summary>
    public partial class SecretAuthInfo : AuthBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="SecretAuthInfo"/>. </summary>
        public SecretAuthInfo()
        {
            AuthType = LinkerAuthType.Secret;
        }

        /// <summary> Initializes a new instance of <see cref="SecretAuthInfo"/>. </summary>
        /// <param name="authType"> The authentication type. </param>
        /// <param name="name"> Username or account name for secret auth. </param>
        /// <param name="secretInfo">
        /// Password or key vault secret for secret auth.
        /// Please note <see cref="SecretBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KeyVaultSecretReferenceSecretInfo"/>, <see cref="KeyVaultSecretUriSecretInfo"/> and <see cref="RawValueSecretInfo"/>.
        /// </param>
        internal SecretAuthInfo(LinkerAuthType authType, string name, SecretBaseInfo secretInfo) : base(authType)
        {
            Name = name;
            SecretInfo = secretInfo;
            AuthType = authType;
        }

        /// <summary> Username or account name for secret auth. </summary>
        public string Name { get; set; }
        /// <summary>
        /// Password or key vault secret for secret auth.
        /// Please note <see cref="SecretBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KeyVaultSecretReferenceSecretInfo"/>, <see cref="KeyVaultSecretUriSecretInfo"/> and <see cref="RawValueSecretInfo"/>.
        /// </summary>
        public SecretBaseInfo SecretInfo { get; set; }
    }
}
