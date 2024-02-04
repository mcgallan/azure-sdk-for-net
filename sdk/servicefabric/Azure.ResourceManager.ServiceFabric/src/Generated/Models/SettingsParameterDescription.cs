// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes a parameter in fabric settings of the cluster. </summary>
    public partial class SettingsParameterDescription
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

        /// <summary> Initializes a new instance of <see cref="SettingsParameterDescription"/>. </summary>
        /// <param name="name"> The parameter name of fabric setting. </param>
        /// <param name="value"> The parameter value of fabric setting. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public SettingsParameterDescription(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="SettingsParameterDescription"/>. </summary>
        /// <param name="name"> The parameter name of fabric setting. </param>
        /// <param name="value"> The parameter value of fabric setting. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SettingsParameterDescription(string name, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SettingsParameterDescription"/> for deserialization. </summary>
        internal SettingsParameterDescription()
        {
        }

        /// <summary> The parameter name of fabric setting. </summary>
        public string Name { get; set; }
        /// <summary> The parameter value of fabric setting. </summary>
        public string Value { get; set; }
    }
}
