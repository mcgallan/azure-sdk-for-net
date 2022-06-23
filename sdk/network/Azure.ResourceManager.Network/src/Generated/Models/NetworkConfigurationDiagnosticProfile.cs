// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters to compare with network configuration. </summary>
    public partial class NetworkConfigurationDiagnosticProfile
    {
        /// <summary> Initializes a new instance of NetworkConfigurationDiagnosticProfile. </summary>
        /// <param name="direction"> The direction of the traffic. </param>
        /// <param name="protocol"> Protocol to be verified on. Accepted values are &apos;*&apos;, TCP, UDP. </param>
        /// <param name="source"> Traffic source. Accepted values are &apos;*&apos;, IP Address/CIDR, Service Tag. </param>
        /// <param name="destination"> Traffic destination. Accepted values are: &apos;*&apos;, IP Address/CIDR, Service Tag. </param>
        /// <param name="destinationPort"> Traffic destination port. Accepted values are &apos;*&apos; and a single port in the range (0 - 65535). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="protocol"/>, <paramref name="source"/>, <paramref name="destination"/> or <paramref name="destinationPort"/> is null. </exception>
        public NetworkConfigurationDiagnosticProfile(TrafficDirection direction, string protocol, string source, string destination, string destinationPort)
        {
            if (protocol == null)
            {
                throw new ArgumentNullException(nameof(protocol));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }
            if (destinationPort == null)
            {
                throw new ArgumentNullException(nameof(destinationPort));
            }

            Direction = direction;
            Protocol = protocol;
            Source = source;
            Destination = destination;
            DestinationPort = destinationPort;
        }

        /// <summary> The direction of the traffic. </summary>
        public TrafficDirection Direction { get; set; }
        /// <summary> Protocol to be verified on. Accepted values are &apos;*&apos;, TCP, UDP. </summary>
        public string Protocol { get; set; }
        /// <summary> Traffic source. Accepted values are &apos;*&apos;, IP Address/CIDR, Service Tag. </summary>
        public string Source { get; set; }
        /// <summary> Traffic destination. Accepted values are: &apos;*&apos;, IP Address/CIDR, Service Tag. </summary>
        public string Destination { get; set; }
        /// <summary> Traffic destination port. Accepted values are &apos;*&apos; and a single port in the range (0 - 65535). </summary>
        public string DestinationPort { get; set; }
    }
}
