// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Automation key which is used to register a DSC Node. </summary>
    public partial class AutomationKey
    {
        /// <summary> Initializes a new instance of <see cref="AutomationKey"/>. </summary>
        internal AutomationKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationKey"/>. </summary>
        /// <param name="keyName"> Automation key name. </param>
        /// <param name="permissions"> Automation key permissions. </param>
        /// <param name="value"> Value of the Automation Key used for registration. </param>
        internal AutomationKey(AutomationKeyName? keyName, AutomationKeyPermission? permissions, string value)
        {
            KeyName = keyName;
            Permissions = permissions;
            Value = value;
        }

        /// <summary> Automation key name. </summary>
        public AutomationKeyName? KeyName { get; }
        /// <summary> Automation key permissions. </summary>
        public AutomationKeyPermission? Permissions { get; }
        /// <summary> Value of the Automation Key used for registration. </summary>
        public string Value { get; }
    }
}
