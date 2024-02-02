// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Network Fabric Controller services. </summary>
    public partial class NetworkFabricControllerServices
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricControllerServices"/>. </summary>
        internal NetworkFabricControllerServices()
        {
            IPv4AddressSpaces = new ChangeTrackingList<string>();
            IPv6AddressSpaces = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricControllerServices"/>. </summary>
        /// <param name="ipv4AddressSpaces"> The IPv4 Address space is optional, if the value is not defined at the time of NFC creation, then the default value 10.0.0.0/19 is considered. The IPV4 address subnet is an optional attribute. </param>
        /// <param name="ipv6AddressSpaces"> The IPv6 is not supported right now. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricControllerServices(IReadOnlyList<string> ipv4AddressSpaces, IReadOnlyList<string> ipv6AddressSpaces, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IPv4AddressSpaces = ipv4AddressSpaces;
            IPv6AddressSpaces = ipv6AddressSpaces;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The IPv4 Address space is optional, if the value is not defined at the time of NFC creation, then the default value 10.0.0.0/19 is considered. The IPV4 address subnet is an optional attribute. </summary>
        public IReadOnlyList<string> IPv4AddressSpaces { get; }
        /// <summary> The IPv6 is not supported right now. </summary>
        public IReadOnlyList<string> IPv6AddressSpaces { get; }
    }
}
