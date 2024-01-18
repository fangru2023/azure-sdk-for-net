// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownSparkJobEntry. </summary>
    internal partial class UnknownSparkJobEntry : SparkJobEntry
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSparkJobEntry"/>. </summary>
        /// <param name="sparkJobEntryType"> [Required] Type of the job's entry point. </param>
        internal UnknownSparkJobEntry(SparkJobEntryType sparkJobEntryType) : base(sparkJobEntryType)
        {
            SparkJobEntryType = sparkJobEntryType;
        }
    }
}
