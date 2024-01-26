// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The network endpoint. </summary>
    public partial class IntegrationServiceEnvironmentNetworkEndpoint
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

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentNetworkEndpoint"/>. </summary>
        internal IntegrationServiceEnvironmentNetworkEndpoint()
        {
            Ports = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentNetworkEndpoint"/>. </summary>
        /// <param name="accessibility"> The accessibility state. </param>
        /// <param name="domainName"> The domain name. </param>
        /// <param name="ports"> The ports. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationServiceEnvironmentNetworkEndpoint(IntegrationServiceEnvironmentNetworkEndPointAccessibilityState? accessibility, string domainName, IReadOnlyList<string> ports, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Accessibility = accessibility;
            DomainName = domainName;
            Ports = ports;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The accessibility state. </summary>
        public IntegrationServiceEnvironmentNetworkEndPointAccessibilityState? Accessibility { get; }
        /// <summary> The domain name. </summary>
        public string DomainName { get; }
        /// <summary> The ports. </summary>
        public IReadOnlyList<string> Ports { get; }
    }
}
