// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Collection of static site user provided function apps. </summary>
    internal partial class StaticSiteUserProvidedFunctionAppsListResult
    {
        /// <summary> Initializes a new instance of <see cref="StaticSiteUserProvidedFunctionAppsListResult"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal StaticSiteUserProvidedFunctionAppsListResult(IEnumerable<StaticSiteUserProvidedFunctionAppData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteUserProvidedFunctionAppsListResult"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal StaticSiteUserProvidedFunctionAppsListResult(IReadOnlyList<StaticSiteUserProvidedFunctionAppData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<StaticSiteUserProvidedFunctionAppData> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
