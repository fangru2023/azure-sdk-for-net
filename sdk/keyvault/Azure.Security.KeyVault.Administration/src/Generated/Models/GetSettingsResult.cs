// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> The settings list result. </summary>
    public partial class GetSettingsResult
    {
        /// <summary> Initializes a new instance of <see cref="GetSettingsResult"/>. </summary>
        internal GetSettingsResult()
        {
            Settings = new ChangeTrackingList<KeyVaultSetting>();
        }

        /// <summary> Initializes a new instance of <see cref="GetSettingsResult"/>. </summary>
        /// <param name="settings"> A response message containing a list of account settings with their associated value. </param>
        internal GetSettingsResult(IReadOnlyList<KeyVaultSetting> settings)
        {
            Settings = settings;
        }

        /// <summary> A response message containing a list of account settings with their associated value. </summary>
        public IReadOnlyList<KeyVaultSetting> Settings { get; }
    }
}
