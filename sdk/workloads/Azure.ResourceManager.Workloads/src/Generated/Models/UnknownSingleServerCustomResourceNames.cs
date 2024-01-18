// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The UnknownSingleServerCustomResourceNames. </summary>
    internal partial class UnknownSingleServerCustomResourceNames : SingleServerCustomResourceNames
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSingleServerCustomResourceNames"/>. </summary>
        /// <param name="namingPatternType"> The pattern type to be used for resource naming. </param>
        internal UnknownSingleServerCustomResourceNames(SapNamingPatternType namingPatternType) : base(namingPatternType)
        {
            NamingPatternType = namingPatternType;
        }
    }
}
