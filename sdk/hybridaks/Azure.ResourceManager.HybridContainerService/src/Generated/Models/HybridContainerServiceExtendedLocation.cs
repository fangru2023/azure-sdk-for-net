// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Extended location pointing to the underlying infrastructure. </summary>
    public partial class HybridContainerServiceExtendedLocation
    {
        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceExtendedLocation"/>. </summary>
        public HybridContainerServiceExtendedLocation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceExtendedLocation"/>. </summary>
        /// <param name="extendedLocationType"> The extended location type. Allowed value: 'CustomLocation'. </param>
        /// <param name="name"> ARM Id of the extended location. </param>
        internal HybridContainerServiceExtendedLocation(HybridContainerServiceExtendedLocationType? extendedLocationType, string name)
        {
            ExtendedLocationType = extendedLocationType;
            Name = name;
        }

        /// <summary> The extended location type. Allowed value: 'CustomLocation'. </summary>
        public HybridContainerServiceExtendedLocationType? ExtendedLocationType { get; set; }
        /// <summary> ARM Id of the extended location. </summary>
        public string Name { get; set; }
    }
}
