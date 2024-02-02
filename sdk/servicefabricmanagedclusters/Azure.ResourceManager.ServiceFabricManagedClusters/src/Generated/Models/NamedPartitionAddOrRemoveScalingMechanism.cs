// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Represents a scaling mechanism for adding or removing named partitions of a stateless service. Partition names are in the format '0','1'...'N-1'. </summary>
    public partial class NamedPartitionAddOrRemoveScalingMechanism : ManagedServiceScalingMechanism
    {
        /// <summary> Initializes a new instance of <see cref="NamedPartitionAddOrRemoveScalingMechanism"/>. </summary>
        /// <param name="minPartitionCount"> Minimum number of named partitions of the service. </param>
        /// <param name="maxPartitionCount"> Maximum number of named partitions of the service. </param>
        /// <param name="scaleIncrement"> The number of instances to add or remove during a scaling operation. </param>
        public NamedPartitionAddOrRemoveScalingMechanism(int minPartitionCount, int maxPartitionCount, int scaleIncrement)
        {
            MinPartitionCount = minPartitionCount;
            MaxPartitionCount = maxPartitionCount;
            ScaleIncrement = scaleIncrement;
            Kind = ServiceScalingMechanismKind.AddRemoveIncrementalNamedPartition;
        }

        /// <summary> Initializes a new instance of <see cref="NamedPartitionAddOrRemoveScalingMechanism"/>. </summary>
        /// <param name="kind"> Specifies the mechanism associated with this scaling policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="minPartitionCount"> Minimum number of named partitions of the service. </param>
        /// <param name="maxPartitionCount"> Maximum number of named partitions of the service. </param>
        /// <param name="scaleIncrement"> The number of instances to add or remove during a scaling operation. </param>
        internal NamedPartitionAddOrRemoveScalingMechanism(ServiceScalingMechanismKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, int minPartitionCount, int maxPartitionCount, int scaleIncrement) : base(kind, serializedAdditionalRawData)
        {
            MinPartitionCount = minPartitionCount;
            MaxPartitionCount = maxPartitionCount;
            ScaleIncrement = scaleIncrement;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="NamedPartitionAddOrRemoveScalingMechanism"/> for deserialization. </summary>
        internal NamedPartitionAddOrRemoveScalingMechanism()
        {
        }

        /// <summary> Minimum number of named partitions of the service. </summary>
        public int MinPartitionCount { get; set; }
        /// <summary> Maximum number of named partitions of the service. </summary>
        public int MaxPartitionCount { get; set; }
        /// <summary> The number of instances to add or remove during a scaling operation. </summary>
        public int ScaleIncrement { get; set; }
    }
}
