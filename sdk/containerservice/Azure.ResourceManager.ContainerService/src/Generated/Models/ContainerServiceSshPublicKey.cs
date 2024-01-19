// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Contains information about SSH certificate public key data. </summary>
    public partial class ContainerServiceSshPublicKey
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceSshPublicKey"/>. </summary>
        /// <param name="keyData"> Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or without headers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyData"/> is null. </exception>
        public ContainerServiceSshPublicKey(string keyData)
        {
            Argument.AssertNotNull(keyData, nameof(keyData));

            KeyData = keyData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceSshPublicKey"/>. </summary>
        /// <param name="keyData"> Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or without headers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceSshPublicKey(string keyData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyData = keyData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceSshPublicKey"/> for deserialization. </summary>
        internal ContainerServiceSshPublicKey()
        {
        }

        /// <summary> Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or without headers. </summary>
        public string KeyData { get; set; }
    }
}
