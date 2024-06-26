// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal static partial class KeyVaultCreateModeExtensions
    {
        public static string ToSerialString(this KeyVaultCreateMode value) => value switch
        {
            KeyVaultCreateMode.Default => "default",
            KeyVaultCreateMode.Recover => "recover",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyVaultCreateMode value.")
        };

        public static KeyVaultCreateMode ToKeyVaultCreateMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "default")) return KeyVaultCreateMode.Default;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "recover")) return KeyVaultCreateMode.Recover;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyVaultCreateMode value.");
        }
    }
}
