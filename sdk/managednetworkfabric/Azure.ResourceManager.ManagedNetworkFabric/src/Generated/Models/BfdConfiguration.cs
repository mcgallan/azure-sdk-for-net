// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> BFD configuration properties. </summary>
    public partial class BfdConfiguration
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

        /// <summary> Initializes a new instance of <see cref="BfdConfiguration"/>. </summary>
        public BfdConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BfdConfiguration"/>. </summary>
        /// <param name="administrativeState"> Administrative state of the BfdConfiguration. Example: Enabled | Disabled. </param>
        /// <param name="intervalInMilliSeconds"> Interval in milliseconds. Example: 300. </param>
        /// <param name="multiplier"> Multiplier for the Bfd Configuration. Example: 5. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BfdConfiguration(BfdAdministrativeState? administrativeState, int? intervalInMilliSeconds, int? multiplier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AdministrativeState = administrativeState;
            IntervalInMilliSeconds = intervalInMilliSeconds;
            Multiplier = multiplier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Administrative state of the BfdConfiguration. Example: Enabled | Disabled. </summary>
        public BfdAdministrativeState? AdministrativeState { get; }
        /// <summary> Interval in milliseconds. Example: 300. </summary>
        public int? IntervalInMilliSeconds { get; set; }
        /// <summary> Multiplier for the Bfd Configuration. Example: 5. </summary>
        public int? Multiplier { get; set; }
    }
}
