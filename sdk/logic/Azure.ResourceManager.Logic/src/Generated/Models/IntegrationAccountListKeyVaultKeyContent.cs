// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list key vault keys definition. </summary>
    public partial class IntegrationAccountListKeyVaultKeyContent
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationAccountListKeyVaultKeyContent"/>. </summary>
        /// <param name="keyVault"> The key vault reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVault"/> is null. </exception>
        public IntegrationAccountListKeyVaultKeyContent(IntegrationAccountKeyVaultNameReference keyVault)
        {
            Argument.AssertNotNull(keyVault, nameof(keyVault));

            KeyVault = keyVault;
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountListKeyVaultKeyContent"/>. </summary>
        /// <param name="keyVault"> The key vault reference. </param>
        /// <param name="skipToken"> The skip token. </param>
        internal IntegrationAccountListKeyVaultKeyContent(IntegrationAccountKeyVaultNameReference keyVault, string skipToken)
        {
            KeyVault = keyVault;
            SkipToken = skipToken;
        }

        /// <summary> The key vault reference. </summary>
        public IntegrationAccountKeyVaultNameReference KeyVault { get; }
        /// <summary> The skip token. </summary>
        public string SkipToken { get; set; }
    }
}
