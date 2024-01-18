// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The object representing the state of the migration between the backup policies. </summary>
    public partial class BackupPolicyMigrationState
    {
        /// <summary> Initializes a new instance of <see cref="BackupPolicyMigrationState"/>. </summary>
        public BackupPolicyMigrationState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupPolicyMigrationState"/>. </summary>
        /// <param name="status"> Describes the status of migration between backup policy types. </param>
        /// <param name="targetType"> Describes the target backup policy type of the backup policy migration. </param>
        /// <param name="startOn"> Time at which the backup policy migration started (ISO-8601 format). </param>
        internal BackupPolicyMigrationState(BackupPolicyMigrationStatus? status, BackupPolicyType? targetType, DateTimeOffset? startOn)
        {
            Status = status;
            TargetType = targetType;
            StartOn = startOn;
        }

        /// <summary> Describes the status of migration between backup policy types. </summary>
        public BackupPolicyMigrationStatus? Status { get; set; }
        /// <summary> Describes the target backup policy type of the backup policy migration. </summary>
        public BackupPolicyType? TargetType { get; set; }
        /// <summary> Time at which the backup policy migration started (ISO-8601 format). </summary>
        public DateTimeOffset? StartOn { get; set; }
    }
}
