// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Routing.Models
{
    /// <summary> An item returned from Batch API. Extend with 'response' property. </summary>
    internal partial class BatchResultItem
    {
        /// <summary> Initializes a new instance of <see cref="BatchResultItem"/>. </summary>
        internal BatchResultItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchResultItem"/>. </summary>
        /// <param name="statusCode"> HTTP request status code. </param>
        internal BatchResultItem(int? statusCode)
        {
            StatusCode = statusCode;
        }

        /// <summary> HTTP request status code. </summary>
        public int? StatusCode { get; }
    }
}
