// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The developer portal Content Security Policy (CSP) settings.
    /// </summary>
    public partial class PortalConfigCspProperties
    {
        /// <summary>
        /// Initializes a new instance of the PortalConfigCspProperties class.
        /// </summary>
        public PortalConfigCspProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PortalConfigCspProperties class.
        /// </summary>
        /// <param name="mode">The mode of the developer portal Content
        /// Security Policy (CSP). Possible values include: 'enabled',
        /// 'disabled', 'reportOnly'</param>
        /// <param name="reportUri">The URLs used by the browser to report CSP
        /// violations.</param>
        /// <param name="allowedSources">Allowed sources, e.g. `*.trusted.com`,
        /// `trusted.com`, `https://`.</param>
        public PortalConfigCspProperties(string mode = default(string), IList<string> reportUri = default(IList<string>), IList<string> allowedSources = default(IList<string>))
        {
            Mode = mode;
            ReportUri = reportUri;
            AllowedSources = allowedSources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the mode of the developer portal Content Security
        /// Policy (CSP). Possible values include: 'enabled', 'disabled',
        /// 'reportOnly'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets the URLs used by the browser to report CSP violations.
        /// </summary>
        [JsonProperty(PropertyName = "reportUri")]
        public IList<string> ReportUri { get; set; }

        /// <summary>
        /// Gets or sets allowed sources, e.g. `*.trusted.com`, `trusted.com`,
        /// `https://`.
        /// </summary>
        [JsonProperty(PropertyName = "allowedSources")]
        public IList<string> AllowedSources { get; set; }

    }
}
