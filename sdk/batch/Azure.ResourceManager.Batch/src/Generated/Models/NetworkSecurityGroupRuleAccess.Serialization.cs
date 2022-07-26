// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class NetworkSecurityGroupRuleAccessExtensions
    {
        public static string ToSerialString(this NetworkSecurityGroupRuleAccess value) => value switch
        {
            NetworkSecurityGroupRuleAccess.Allow => "Allow",
            NetworkSecurityGroupRuleAccess.Deny => "Deny",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NetworkSecurityGroupRuleAccess value.")
        };

        public static NetworkSecurityGroupRuleAccess ToNetworkSecurityGroupRuleAccess(this string value)
        {
            if (string.Equals(value, "Allow", StringComparison.InvariantCultureIgnoreCase)) return NetworkSecurityGroupRuleAccess.Allow;
            if (string.Equals(value, "Deny", StringComparison.InvariantCultureIgnoreCase)) return NetworkSecurityGroupRuleAccess.Deny;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown NetworkSecurityGroupRuleAccess value.");
        }
    }
}
