// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Aggregated property of each type. </summary>
    public partial class SmartGroupAggregatedProperty
    {
        /// <summary> Initializes a new instance of <see cref="SmartGroupAggregatedProperty"/>. </summary>
        public SmartGroupAggregatedProperty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SmartGroupAggregatedProperty"/>. </summary>
        /// <param name="name"> Name of the type. </param>
        /// <param name="count"> Total number of items of type. </param>
        internal SmartGroupAggregatedProperty(string name, long? count)
        {
            Name = name;
            Count = count;
        }

        /// <summary> Name of the type. </summary>
        public string Name { get; set; }
        /// <summary> Total number of items of type. </summary>
        public long? Count { get; set; }
    }
}
