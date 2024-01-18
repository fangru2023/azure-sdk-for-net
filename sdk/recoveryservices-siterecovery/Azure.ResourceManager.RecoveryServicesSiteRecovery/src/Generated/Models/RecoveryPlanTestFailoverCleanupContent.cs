// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan test failover cleanup input. </summary>
    public partial class RecoveryPlanTestFailoverCleanupContent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanTestFailoverCleanupContent"/>. </summary>
        /// <param name="properties"> The recovery plan test failover cleanup input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public RecoveryPlanTestFailoverCleanupContent(RecoveryPlanTestFailoverCleanupProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> The recovery plan test failover cleanup input properties. </summary>
        internal RecoveryPlanTestFailoverCleanupProperties Properties { get; }
        /// <summary> The test failover cleanup comments. </summary>
        public string RecoveryPlanTestFailoverCleanupComments
        {
            get => Properties?.Comments;
        }
    }
}
