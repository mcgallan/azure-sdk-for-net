// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> OAuth2 grant type options. </summary>
    public readonly partial struct OAuth2GrantType : IEquatable<OAuth2GrantType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OAuth2GrantType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OAuth2GrantType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuthorizationCodeValue = "AuthorizationCode";
        private const string ClientCredentialsValue = "ClientCredentials";

        /// <summary> Authorization Code grant. </summary>
        public static OAuth2GrantType AuthorizationCode { get; } = new OAuth2GrantType(AuthorizationCodeValue);
        /// <summary> Client Credential grant. </summary>
        public static OAuth2GrantType ClientCredentials { get; } = new OAuth2GrantType(ClientCredentialsValue);
        /// <summary> Determines if two <see cref="OAuth2GrantType"/> values are the same. </summary>
        public static bool operator ==(OAuth2GrantType left, OAuth2GrantType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OAuth2GrantType"/> values are not the same. </summary>
        public static bool operator !=(OAuth2GrantType left, OAuth2GrantType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OAuth2GrantType"/>. </summary>
        public static implicit operator OAuth2GrantType(string value) => new OAuth2GrantType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OAuth2GrantType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OAuth2GrantType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
