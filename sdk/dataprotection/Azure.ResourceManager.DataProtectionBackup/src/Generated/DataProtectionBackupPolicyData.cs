// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing the DataProtectionBackupPolicy data model.
    /// BaseBackupPolicy resource
    /// </summary>
    public partial class DataProtectionBackupPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupPolicyData"/>. </summary>
        public DataProtectionBackupPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// BaseBackupPolicyResource properties
        /// Please note <see cref="DataProtectionBackupPolicyPropertiesBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleBasedBackupPolicy"/>.
        /// </param>
        internal DataProtectionBackupPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataProtectionBackupPolicyPropertiesBase properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary>
        /// BaseBackupPolicyResource properties
        /// Please note <see cref="DataProtectionBackupPolicyPropertiesBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RuleBasedBackupPolicy"/>.
        /// </summary>
        public DataProtectionBackupPolicyPropertiesBase Properties { get; set; }
    }
}
