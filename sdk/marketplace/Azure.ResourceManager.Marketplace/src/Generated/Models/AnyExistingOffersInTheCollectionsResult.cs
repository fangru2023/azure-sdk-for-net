// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Response object of query if are there existing offers in the collections. </summary>
    public partial class AnyExistingOffersInTheCollectionsResult
    {
        /// <summary> Initializes a new instance of <see cref="AnyExistingOffersInTheCollectionsResult"/>. </summary>
        internal AnyExistingOffersInTheCollectionsResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnyExistingOffersInTheCollectionsResult"/>. </summary>
        /// <param name="value"> Boolean answer, true if exists at least a single offer in an enabled collection, otherwise, false. </param>
        internal AnyExistingOffersInTheCollectionsResult(bool? value)
        {
            Value = value;
        }

        /// <summary> Boolean answer, true if exists at least a single offer in an enabled collection, otherwise, false. </summary>
        public bool? Value { get; }
    }
}
