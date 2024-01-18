// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of integration account schemas. </summary>
    internal partial class IntegrationAccountSchemaListResult
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationAccountSchemaListResult"/>. </summary>
        internal IntegrationAccountSchemaListResult()
        {
            Value = new ChangeTrackingList<IntegrationAccountSchemaData>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountSchemaListResult"/>. </summary>
        /// <param name="value"> The list of integration account schemas. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal IntegrationAccountSchemaListResult(IReadOnlyList<IntegrationAccountSchemaData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of integration account schemas. </summary>
        public IReadOnlyList<IntegrationAccountSchemaData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
