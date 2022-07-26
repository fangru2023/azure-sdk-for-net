// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DigitalTwinsInstance endpoint resource.
    /// </summary>
    public partial class DigitalTwinsEndpointResource : ExternalResource
    {
        /// <summary>
        /// Initializes a new instance of the DigitalTwinsEndpointResource
        /// class.
        /// </summary>
        public DigitalTwinsEndpointResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DigitalTwinsEndpointResource
        /// class.
        /// </summary>
        /// <param name="properties">DigitalTwinsInstance endpoint resource
        /// properties.</param>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">Extension resource name.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        public DigitalTwinsEndpointResource(DigitalTwinsEndpointResourceProperties properties, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, systemData)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets digitalTwinsInstance endpoint resource properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DigitalTwinsEndpointResourceProperties Properties { get; set; }

    }
}
