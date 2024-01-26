// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Authentication configuration information. </summary>
    public partial class HealthcareApisServiceAuthenticationConfiguration
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

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceAuthenticationConfiguration"/>. </summary>
        public HealthcareApisServiceAuthenticationConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceAuthenticationConfiguration"/>. </summary>
        /// <param name="authority"> The authority url for the service. </param>
        /// <param name="audience"> The audience url for the service. </param>
        /// <param name="isSmartProxyEnabled"> If the SMART on FHIR proxy is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareApisServiceAuthenticationConfiguration(string authority, string audience, bool? isSmartProxyEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Authority = authority;
            Audience = audience;
            IsSmartProxyEnabled = isSmartProxyEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The authority url for the service. </summary>
        public string Authority { get; set; }
        /// <summary> The audience url for the service. </summary>
        public string Audience { get; set; }
        /// <summary> If the SMART on FHIR proxy is enabled. </summary>
        public bool? IsSmartProxyEnabled { get; set; }
    }
}
