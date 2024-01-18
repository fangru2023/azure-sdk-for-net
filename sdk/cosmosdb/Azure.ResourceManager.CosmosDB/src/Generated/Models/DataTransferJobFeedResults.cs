// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the Data Transfer jobs and their properties. </summary>
    internal partial class DataTransferJobFeedResults
    {
        /// <summary> Initializes a new instance of <see cref="DataTransferJobFeedResults"/>. </summary>
        internal DataTransferJobFeedResults()
        {
            Value = new ChangeTrackingList<DataTransferJobGetResultData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataTransferJobFeedResults"/>. </summary>
        /// <param name="value"> List of Data Transfer jobs and their properties. </param>
        /// <param name="nextLink"> URL to get the next set of Data Transfer job list results if there are any. </param>
        internal DataTransferJobFeedResults(IReadOnlyList<DataTransferJobGetResultData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Data Transfer jobs and their properties. </summary>
        public IReadOnlyList<DataTransferJobGetResultData> Value { get; }
        /// <summary> URL to get the next set of Data Transfer job list results if there are any. </summary>
        public string NextLink { get; }
    }
}
