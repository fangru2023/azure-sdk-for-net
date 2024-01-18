// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> Microsoft.Elastic SKU. </summary>
    internal partial class ResourceSku
    {
        /// <summary> Initializes a new instance of <see cref="ResourceSku"/>. </summary>
        /// <param name="name"> Name of the SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ResourceSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Name of the SKU. </summary>
        public string Name { get; set; }
    }
}
