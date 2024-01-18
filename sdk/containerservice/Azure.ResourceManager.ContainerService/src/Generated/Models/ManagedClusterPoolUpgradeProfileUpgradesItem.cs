// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The ManagedClusterPoolUpgradeProfileUpgradesItem. </summary>
    public partial class ManagedClusterPoolUpgradeProfileUpgradesItem
    {
        /// <summary> Initializes a new instance of <see cref="ManagedClusterPoolUpgradeProfileUpgradesItem"/>. </summary>
        internal ManagedClusterPoolUpgradeProfileUpgradesItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPoolUpgradeProfileUpgradesItem"/>. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor.patch). </param>
        /// <param name="isPreview"> Whether the Kubernetes version is currently in preview. </param>
        internal ManagedClusterPoolUpgradeProfileUpgradesItem(string kubernetesVersion, bool? isPreview)
        {
            KubernetesVersion = kubernetesVersion;
            IsPreview = isPreview;
        }

        /// <summary> The Kubernetes version (major.minor.patch). </summary>
        public string KubernetesVersion { get; }
        /// <summary> Whether the Kubernetes version is currently in preview. </summary>
        public bool? IsPreview { get; }
    }
}
