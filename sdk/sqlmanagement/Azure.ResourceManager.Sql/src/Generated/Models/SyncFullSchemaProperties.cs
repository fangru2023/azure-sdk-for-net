// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of the database full schema. </summary>
    public partial class SyncFullSchemaProperties
    {
        /// <summary> Initializes a new instance of <see cref="SyncFullSchemaProperties"/>. </summary>
        internal SyncFullSchemaProperties()
        {
            Tables = new ChangeTrackingList<SyncFullSchemaTable>();
        }

        /// <summary> Initializes a new instance of <see cref="SyncFullSchemaProperties"/>. </summary>
        /// <param name="tables"> List of tables in the database full schema. </param>
        /// <param name="lastUpdateOn"> Last update time of the database schema. </param>
        internal SyncFullSchemaProperties(IReadOnlyList<SyncFullSchemaTable> tables, DateTimeOffset? lastUpdateOn)
        {
            Tables = tables;
            LastUpdateOn = lastUpdateOn;
        }

        /// <summary> List of tables in the database full schema. </summary>
        public IReadOnlyList<SyncFullSchemaTable> Tables { get; }
        /// <summary> Last update time of the database schema. </summary>
        public DateTimeOffset? LastUpdateOn { get; }
    }
}
