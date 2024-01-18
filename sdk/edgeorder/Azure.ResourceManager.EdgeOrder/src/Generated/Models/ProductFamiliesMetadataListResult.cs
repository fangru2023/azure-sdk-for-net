// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Holds details about product family metadata. </summary>
    internal partial class ProductFamiliesMetadataListResult
    {
        /// <summary> Initializes a new instance of <see cref="ProductFamiliesMetadataListResult"/>. </summary>
        internal ProductFamiliesMetadataListResult()
        {
            Value = new ChangeTrackingList<ProductFamiliesMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="ProductFamiliesMetadataListResult"/>. </summary>
        /// <param name="value"> List of product family metadata details. </param>
        /// <param name="nextLink"> Link for the next set of product families. </param>
        internal ProductFamiliesMetadataListResult(IReadOnlyList<ProductFamiliesMetadata> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of product family metadata details. </summary>
        public IReadOnlyList<ProductFamiliesMetadata> Value { get; }
        /// <summary> Link for the next set of product families. </summary>
        public string NextLink { get; }
    }
}
