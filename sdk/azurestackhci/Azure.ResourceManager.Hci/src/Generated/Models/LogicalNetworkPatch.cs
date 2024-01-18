// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The logical network resource patch definition. </summary>
    public partial class LogicalNetworkPatch
    {
        /// <summary> Initializes a new instance of <see cref="LogicalNetworkPatch"/>. </summary>
        public LogicalNetworkPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicalNetworkPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal LogicalNetworkPatch(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
