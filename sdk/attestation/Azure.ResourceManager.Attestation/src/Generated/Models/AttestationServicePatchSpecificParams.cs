// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary>
    /// Client supplied parameters used to patch an existing attestation provider.
    /// Serialized Name: AttestationServicePatchSpecificParams
    /// </summary>
    internal partial class AttestationServicePatchSpecificParams
    {
        /// <summary> Initializes a new instance of AttestationServicePatchSpecificParams. </summary>
        public AttestationServicePatchSpecificParams()
        {
        }

        /// <summary>
        /// Controls whether traffic from the public network is allowed to access the Attestation Provider APIs.
        /// Serialized Name: AttestationServicePatchSpecificParams.publicNetworkAccess
        /// </summary>
        public PublicNetworkAccessType? PublicNetworkAccess { get; set; }
    }
}
