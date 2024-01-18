// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> The type used for update operations of the Device. </summary>
    public partial class SphereDevicePatch
    {
        /// <summary> Initializes a new instance of <see cref="SphereDevicePatch"/>. </summary>
        public SphereDevicePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereDevicePatch"/>. </summary>
        /// <param name="deviceGroupId"> Device group id. </param>
        internal SphereDevicePatch(string deviceGroupId)
        {
            DeviceGroupId = deviceGroupId;
        }

        /// <summary> Device group id. </summary>
        public string DeviceGroupId { get; set; }
    }
}
