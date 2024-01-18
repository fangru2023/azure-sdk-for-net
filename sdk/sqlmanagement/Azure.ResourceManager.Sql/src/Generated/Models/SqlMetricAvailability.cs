// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A metric availability value. </summary>
    public partial class SqlMetricAvailability
    {
        /// <summary> Initializes a new instance of <see cref="SqlMetricAvailability"/>. </summary>
        internal SqlMetricAvailability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlMetricAvailability"/>. </summary>
        /// <param name="retention"> The length of retention for the database metric. </param>
        /// <param name="timeGrain"> The granularity of the database metric. </param>
        internal SqlMetricAvailability(string retention, string timeGrain)
        {
            Retention = retention;
            TimeGrain = timeGrain;
        }

        /// <summary> The length of retention for the database metric. </summary>
        public string Retention { get; }
        /// <summary> The granularity of the database metric. </summary>
        public string TimeGrain { get; }
    }
}
