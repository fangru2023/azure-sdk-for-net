// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> ApplyRecoveryPoint input specific to InMageRcm provider. </summary>
    public partial class InMageRcmApplyRecoveryPointContent : SiteRecoveryApplyRecoveryPointProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmApplyRecoveryPointContent"/>. </summary>
        /// <param name="recoveryPointId"> The recovery point Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPointId"/> is null. </exception>
        public InMageRcmApplyRecoveryPointContent(ResourceIdentifier recoveryPointId)
        {
            Argument.AssertNotNull(recoveryPointId, nameof(recoveryPointId));

            RecoveryPointId = recoveryPointId;
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmApplyRecoveryPointContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="recoveryPointId"> The recovery point Id. </param>
        internal InMageRcmApplyRecoveryPointContent(string instanceType, ResourceIdentifier recoveryPointId) : base(instanceType)
        {
            RecoveryPointId = recoveryPointId;
            InstanceType = instanceType ?? "InMageRcm";
        }

        /// <summary> The recovery point Id. </summary>
        public ResourceIdentifier RecoveryPointId { get; }
    }
}
