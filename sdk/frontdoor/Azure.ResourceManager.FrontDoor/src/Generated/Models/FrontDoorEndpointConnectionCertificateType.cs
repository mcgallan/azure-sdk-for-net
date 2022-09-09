// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the type of the certificate used for secure connections to a frontendEndpoint. </summary>
    public readonly partial struct FrontDoorEndpointConnectionCertificateType : IEquatable<FrontDoorEndpointConnectionCertificateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorEndpointConnectionCertificateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorEndpointConnectionCertificateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DedicatedValue = "Dedicated";

        /// <summary> Dedicated. </summary>
        public static FrontDoorEndpointConnectionCertificateType Dedicated { get; } = new FrontDoorEndpointConnectionCertificateType(DedicatedValue);
        /// <summary> Determines if two <see cref="FrontDoorEndpointConnectionCertificateType"/> values are the same. </summary>
        public static bool operator ==(FrontDoorEndpointConnectionCertificateType left, FrontDoorEndpointConnectionCertificateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorEndpointConnectionCertificateType"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorEndpointConnectionCertificateType left, FrontDoorEndpointConnectionCertificateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FrontDoorEndpointConnectionCertificateType"/>. </summary>
        public static implicit operator FrontDoorEndpointConnectionCertificateType(string value) => new FrontDoorEndpointConnectionCertificateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorEndpointConnectionCertificateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorEndpointConnectionCertificateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
