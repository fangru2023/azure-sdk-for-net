// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume Snapshot Properties. </summary>
    internal partial class VolumeSnapshotProperties
    {
        /// <summary> Initializes a new instance of <see cref="VolumeSnapshotProperties"/>. </summary>
        public VolumeSnapshotProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VolumeSnapshotProperties"/>. </summary>
        /// <param name="snapshotPolicyId"> Snapshot Policy ResourceId. </param>
        internal VolumeSnapshotProperties(ResourceIdentifier snapshotPolicyId)
        {
            SnapshotPolicyId = snapshotPolicyId;
        }

        /// <summary> Snapshot Policy ResourceId. </summary>
        public ResourceIdentifier SnapshotPolicyId { get; set; }
    }
}
