// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A list of NSX Segments. </summary>
    internal partial class WorkloadNetworkSegmentsList
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkSegmentsList"/>. </summary>
        internal WorkloadNetworkSegmentsList()
        {
            Value = new ChangeTrackingList<WorkloadNetworkSegmentData>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkSegmentsList"/>. </summary>
        /// <param name="value"> The items on the page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal WorkloadNetworkSegmentsList(IReadOnlyList<WorkloadNetworkSegmentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on the page. </summary>
        public IReadOnlyList<WorkloadNetworkSegmentData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
