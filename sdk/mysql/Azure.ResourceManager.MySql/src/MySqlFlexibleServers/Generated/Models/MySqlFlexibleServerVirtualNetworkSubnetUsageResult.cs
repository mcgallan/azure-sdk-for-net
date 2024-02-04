// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Virtual network subnet usage data. </summary>
    public partial class MySqlFlexibleServerVirtualNetworkSubnetUsageResult
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

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerVirtualNetworkSubnetUsageResult"/>. </summary>
        internal MySqlFlexibleServerVirtualNetworkSubnetUsageResult()
        {
            DelegatedSubnetsUsage = new ChangeTrackingList<MySqlFlexibleServerDelegatedSubnetUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerVirtualNetworkSubnetUsageResult"/>. </summary>
        /// <param name="location"> The location name. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="delegatedSubnetsUsage"> A list of delegated subnet usage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerVirtualNetworkSubnetUsageResult(AzureLocation? location, string subscriptionId, IReadOnlyList<MySqlFlexibleServerDelegatedSubnetUsage> delegatedSubnetsUsage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            SubscriptionId = subscriptionId;
            DelegatedSubnetsUsage = delegatedSubnetsUsage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location name. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The subscription id. </summary>
        public string SubscriptionId { get; }
        /// <summary> A list of delegated subnet usage. </summary>
        public IReadOnlyList<MySqlFlexibleServerDelegatedSubnetUsage> DelegatedSubnetsUsage { get; }
    }
}
