// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Prefix Type. </summary>
    public readonly partial struct IPMatchConditionPrefixType : IEquatable<IPMatchConditionPrefixType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IPMatchConditionPrefixType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPMatchConditionPrefixType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrefixValue = "Prefix";
        private const string LongestPrefixValue = "LongestPrefix";

        /// <summary> Prefix. </summary>
        public static IPMatchConditionPrefixType Prefix { get; } = new IPMatchConditionPrefixType(PrefixValue);
        /// <summary> LongestPrefix. </summary>
        public static IPMatchConditionPrefixType LongestPrefix { get; } = new IPMatchConditionPrefixType(LongestPrefixValue);
        /// <summary> Determines if two <see cref="IPMatchConditionPrefixType"/> values are the same. </summary>
        public static bool operator ==(IPMatchConditionPrefixType left, IPMatchConditionPrefixType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IPMatchConditionPrefixType"/> values are not the same. </summary>
        public static bool operator !=(IPMatchConditionPrefixType left, IPMatchConditionPrefixType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IPMatchConditionPrefixType"/>. </summary>
        public static implicit operator IPMatchConditionPrefixType(string value) => new IPMatchConditionPrefixType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IPMatchConditionPrefixType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IPMatchConditionPrefixType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
