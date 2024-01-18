// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> ARM ResourceId of a resource. </summary>
    internal partial class ArmResourceId
    {
        /// <summary> Initializes a new instance of <see cref="ArmResourceId"/>. </summary>
        public ArmResourceId()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArmResourceId"/>. </summary>
        /// <param name="resourceId">
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </param>
        internal ArmResourceId(ResourceIdentifier resourceId)
        {
            ResourceId = resourceId;
        }

        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
