// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> The configuration associated with the allocated antenna. </summary>
    public partial class OrbitalContactAntennaConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="OrbitalContactAntennaConfiguration"/>. </summary>
        internal OrbitalContactAntennaConfiguration()
        {
            SourceIPs = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalContactAntennaConfiguration"/>. </summary>
        /// <param name="destinationIP"> The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to. </param>
        /// <param name="sourceIPs"> List of Source IP. </param>
        internal OrbitalContactAntennaConfiguration(IPAddress destinationIP, IReadOnlyList<IPAddress> sourceIPs)
        {
            DestinationIP = destinationIP;
            SourceIPs = sourceIPs;
        }

        /// <summary> The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to. </summary>
        public IPAddress DestinationIP { get; }
        /// <summary> List of Source IP. </summary>
        public IReadOnlyList<IPAddress> SourceIPs { get; }
    }
}
