// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the CdnOrigin data model.
    /// CDN origin is the source of the content being delivered via CDN. When the edge nodes represented by an endpoint do not have the requested content cached, they attempt to fetch it from one or more of the configured origins.
    /// </summary>
    public partial class CdnOriginData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CdnOriginData"/>. </summary>
        public CdnOriginData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CdnOriginData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="hostName"> The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint. </param>
        /// <param name="httpPort"> The value of the HTTP port. Must be between 1 and 65535. </param>
        /// <param name="httpsPort"> The value of the HTTPS port. Must be between 1 and 65535. </param>
        /// <param name="originHostHeader"> The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint. </param>
        /// <param name="priority"> Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5. </param>
        /// <param name="weight"> Weight of the origin in given origin group for load balancing. Must be between 1 and 1000. </param>
        /// <param name="enabled"> Origin is enabled for load balancing or not. </param>
        /// <param name="privateLinkAlias"> The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'. </param>
        /// <param name="privateLinkResourceId"> The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'. </param>
        /// <param name="privateLinkLocation"> The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated. </param>
        /// <param name="privateLinkApprovalMessage"> A custom message to be included in the approval request to connect to the Private Link. </param>
        /// <param name="resourceState"> Resource status of the origin. </param>
        /// <param name="provisioningState"> Provisioning status of the origin. </param>
        /// <param name="privateEndpointStatus"> The approval status for the connection to the Private Link. </param>
        internal CdnOriginData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string hostName, int? httpPort, int? httpsPort, string originHostHeader, int? priority, int? weight, bool? enabled, string privateLinkAlias, ResourceIdentifier privateLinkResourceId, string privateLinkLocation, string privateLinkApprovalMessage, OriginResourceState? resourceState, OriginProvisioningState? provisioningState, PrivateEndpointStatus? privateEndpointStatus) : base(id, name, resourceType, systemData)
        {
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            OriginHostHeader = originHostHeader;
            Priority = priority;
            Weight = weight;
            Enabled = enabled;
            PrivateLinkAlias = privateLinkAlias;
            PrivateLinkResourceId = privateLinkResourceId;
            PrivateLinkLocation = privateLinkLocation;
            PrivateLinkApprovalMessage = privateLinkApprovalMessage;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
            PrivateEndpointStatus = privateEndpointStatus;
        }

        /// <summary> The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint. </summary>
        public string HostName { get; set; }
        /// <summary> The value of the HTTP port. Must be between 1 and 65535. </summary>
        public int? HttpPort { get; set; }
        /// <summary> The value of the HTTPS port. Must be between 1 and 65535. </summary>
        public int? HttpsPort { get; set; }
        /// <summary> The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint. </summary>
        public string OriginHostHeader { get; set; }
        /// <summary> Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5. </summary>
        public int? Priority { get; set; }
        /// <summary> Weight of the origin in given origin group for load balancing. Must be between 1 and 1000. </summary>
        public int? Weight { get; set; }
        /// <summary> Origin is enabled for load balancing or not. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'. </summary>
        public string PrivateLinkAlias { get; set; }
        /// <summary> The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'. </summary>
        public ResourceIdentifier PrivateLinkResourceId { get; set; }
        /// <summary> The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated. </summary>
        public string PrivateLinkLocation { get; set; }
        /// <summary> A custom message to be included in the approval request to connect to the Private Link. </summary>
        public string PrivateLinkApprovalMessage { get; set; }
        /// <summary> Resource status of the origin. </summary>
        public OriginResourceState? ResourceState { get; }
        /// <summary> Provisioning status of the origin. </summary>
        public OriginProvisioningState? ProvisioningState { get; }
        /// <summary> The approval status for the connection to the Private Link. </summary>
        public PrivateEndpointStatus? PrivateEndpointStatus { get; }
    }
}
