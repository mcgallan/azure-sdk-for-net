// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Attestation.Models
{
    /// <summary> The JsonWebKeySet. </summary>
    internal partial class JsonWebKeySet
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

        /// <summary> Initializes a new instance of <see cref="JsonWebKeySet"/>. </summary>
        public JsonWebKeySet()
        {
            Keys = new ChangeTrackingList<JsonWebKey>();
        }

        /// <summary> Initializes a new instance of <see cref="JsonWebKeySet"/>. </summary>
        /// <param name="keys">
        /// The value of the "keys" parameter is an array of JWK values.  By
        /// default, the order of the JWK values within the array does not imply
        /// an order of preference among them, although applications of JWK Sets
        /// can choose to assign a meaning to the order for their purposes, if
        /// desired.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JsonWebKeySet(IList<JsonWebKey> keys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Keys = keys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The value of the "keys" parameter is an array of JWK values.  By
        /// default, the order of the JWK values within the array does not imply
        /// an order of preference among them, although applications of JWK Sets
        /// can choose to assign a meaning to the order for their purposes, if
        /// desired.
        /// </summary>
        public IList<JsonWebKey> Keys { get; }
    }
}
