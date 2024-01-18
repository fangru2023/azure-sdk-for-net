// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Container for code asset versions. </summary>
    public partial class MachineLearningCodeContainerProperties : MachineLearningAssetContainer
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningCodeContainerProperties"/>. </summary>
        public MachineLearningCodeContainerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCodeContainerProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="latestVersion"> The latest version inside this container. </param>
        /// <param name="nextVersion"> The next auto incremental version. </param>
        /// <param name="provisioningState"> Provisioning state for the code container. </param>
        internal MachineLearningCodeContainerProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isArchived, string latestVersion, string nextVersion, RegistryAssetProvisioningState? provisioningState) : base(description, properties, tags, isArchived, latestVersion, nextVersion)
        {
            ProvisioningState = provisioningState;
        }

        /// <summary> Provisioning state for the code container. </summary>
        public RegistryAssetProvisioningState? ProvisioningState { get; }
    }
}
