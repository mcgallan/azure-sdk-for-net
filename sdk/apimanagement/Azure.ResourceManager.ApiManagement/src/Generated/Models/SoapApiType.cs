// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary>
    /// Type of API to create.
    ///  * `http` creates a REST API
    ///  * `soap` creates a SOAP pass-through API
    ///  * `websocket` creates websocket API
    ///  * `graphql` creates GraphQL API.
    ///  New types can be added in the future.
    /// </summary>
    public readonly partial struct SoapApiType : IEquatable<SoapApiType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SoapApiType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SoapApiType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SoapToRestValue = "http";
        private const string SoapPassThroughValue = "soap";
        private const string WebSocketValue = "websocket";
        private const string GraphQLValue = "graphql";
        private const string ODataValue = "odata";

        /// <summary> Imports a SOAP API having a RESTful front end. </summary>
        public static SoapApiType SoapToRest { get; } = new SoapApiType(SoapToRestValue);
        /// <summary> Imports the SOAP API having a SOAP front end. </summary>
        public static SoapApiType SoapPassThrough { get; } = new SoapApiType(SoapPassThroughValue);
        /// <summary> Imports the API having a Websocket front end. </summary>
        public static SoapApiType WebSocket { get; } = new SoapApiType(WebSocketValue);
        /// <summary> Imports the API having a GraphQL front end. </summary>
        public static SoapApiType GraphQL { get; } = new SoapApiType(GraphQLValue);
        /// <summary> Imports the API having a OData front end. </summary>
        public static SoapApiType OData { get; } = new SoapApiType(ODataValue);
        /// <summary> Determines if two <see cref="SoapApiType"/> values are the same. </summary>
        public static bool operator ==(SoapApiType left, SoapApiType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SoapApiType"/> values are not the same. </summary>
        public static bool operator !=(SoapApiType left, SoapApiType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SoapApiType"/>. </summary>
        public static implicit operator SoapApiType(string value) => new SoapApiType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SoapApiType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SoapApiType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
