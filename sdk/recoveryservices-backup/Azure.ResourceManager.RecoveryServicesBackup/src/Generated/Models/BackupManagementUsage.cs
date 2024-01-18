// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Backup management usages of a vault. </summary>
    public partial class BackupManagementUsage
    {
        /// <summary> Initializes a new instance of <see cref="BackupManagementUsage"/>. </summary>
        internal BackupManagementUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupManagementUsage"/>. </summary>
        /// <param name="unit"> Unit of the usage. </param>
        /// <param name="quotaPeriod"> Quota period of usage. </param>
        /// <param name="nextResetOn"> Next reset time of usage. </param>
        /// <param name="currentValue"> Current value of usage. </param>
        /// <param name="limit"> Limit of usage. </param>
        /// <param name="name"> Name of usage. </param>
        internal BackupManagementUsage(BackupUsagesUnit? unit, string quotaPeriod, DateTimeOffset? nextResetOn, long? currentValue, long? limit, BackupNameInfo name)
        {
            Unit = unit;
            QuotaPeriod = quotaPeriod;
            NextResetOn = nextResetOn;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> Unit of the usage. </summary>
        public BackupUsagesUnit? Unit { get; }
        /// <summary> Quota period of usage. </summary>
        public string QuotaPeriod { get; }
        /// <summary> Next reset time of usage. </summary>
        public DateTimeOffset? NextResetOn { get; }
        /// <summary> Current value of usage. </summary>
        public long? CurrentValue { get; }
        /// <summary> Limit of usage. </summary>
        public long? Limit { get; }
        /// <summary> Name of usage. </summary>
        public BackupNameInfo Name { get; }
    }
}
