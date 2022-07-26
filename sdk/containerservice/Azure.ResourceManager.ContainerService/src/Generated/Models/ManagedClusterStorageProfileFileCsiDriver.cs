// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> AzureFile CSI Driver settings for the storage profile. </summary>
    internal partial class ManagedClusterStorageProfileFileCsiDriver
    {
        /// <summary> Initializes a new instance of ManagedClusterStorageProfileFileCsiDriver. </summary>
        public ManagedClusterStorageProfileFileCsiDriver()
        {
        }

        /// <summary> Initializes a new instance of ManagedClusterStorageProfileFileCsiDriver. </summary>
        /// <param name="enabled"> Whether to enable AzureFile CSI Driver. The default value is true. </param>
        internal ManagedClusterStorageProfileFileCsiDriver(bool? enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Whether to enable AzureFile CSI Driver. The default value is true. </summary>
        public bool? Enabled { get; set; }
    }
}
