// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FluidRelay.Models
{
    /// <summary> Provision states for FluidRelay RP. </summary>
    public readonly partial struct FluidRelayProvisioningState : IEquatable<FluidRelayProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FluidRelayProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FluidRelayProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static FluidRelayProvisioningState Succeeded { get; } = new FluidRelayProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static FluidRelayProvisioningState Failed { get; } = new FluidRelayProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static FluidRelayProvisioningState Canceled { get; } = new FluidRelayProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="FluidRelayProvisioningState"/> values are the same. </summary>
        public static bool operator ==(FluidRelayProvisioningState left, FluidRelayProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FluidRelayProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(FluidRelayProvisioningState left, FluidRelayProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FluidRelayProvisioningState"/>. </summary>
        public static implicit operator FluidRelayProvisioningState(string value) => new FluidRelayProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FluidRelayProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FluidRelayProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
