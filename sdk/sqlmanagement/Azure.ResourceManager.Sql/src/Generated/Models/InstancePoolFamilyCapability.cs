// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The instance pool family capability. </summary>
    public partial class InstancePoolFamilyCapability
    {
        /// <summary> Initializes a new instance of InstancePoolFamilyCapability. </summary>
        internal InstancePoolFamilyCapability()
        {
            SupportedLicenseTypes = new ChangeTrackingList<LicenseTypeCapability>();
            SupportedVcoresValues = new ChangeTrackingList<InstancePoolVcoresCapability>();
        }

        /// <summary> Initializes a new instance of InstancePoolFamilyCapability. </summary>
        /// <param name="name"> Family name. </param>
        /// <param name="supportedLicenseTypes"> List of supported license types. </param>
        /// <param name="supportedVcoresValues"> List of supported virtual cores values. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal InstancePoolFamilyCapability(string name, IReadOnlyList<LicenseTypeCapability> supportedLicenseTypes, IReadOnlyList<InstancePoolVcoresCapability> supportedVcoresValues, SqlCapabilityStatus? status, string reason)
        {
            Name = name;
            SupportedLicenseTypes = supportedLicenseTypes;
            SupportedVcoresValues = supportedVcoresValues;
            Status = status;
            Reason = reason;
        }

        /// <summary> Family name. </summary>
        public string Name { get; }
        /// <summary> List of supported license types. </summary>
        public IReadOnlyList<LicenseTypeCapability> SupportedLicenseTypes { get; }
        /// <summary> List of supported virtual cores values. </summary>
        public IReadOnlyList<InstancePoolVcoresCapability> SupportedVcoresValues { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
