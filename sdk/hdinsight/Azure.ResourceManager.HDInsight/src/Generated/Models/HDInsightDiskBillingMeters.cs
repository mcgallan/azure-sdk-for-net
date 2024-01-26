// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The disk billing meters. </summary>
    public partial class HDInsightDiskBillingMeters
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

        /// <summary> Initializes a new instance of <see cref="HDInsightDiskBillingMeters"/>. </summary>
        internal HDInsightDiskBillingMeters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightDiskBillingMeters"/>. </summary>
        /// <param name="diskRpMeter"> The managed disk meter guid. </param>
        /// <param name="sku"> The managed disk billing sku, P30 or S30. </param>
        /// <param name="tier"> The managed disk billing tier, Standard or Premium. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightDiskBillingMeters(string diskRpMeter, string sku, HDInsightTier? tier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskRpMeter = diskRpMeter;
            Sku = sku;
            Tier = tier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The managed disk meter guid. </summary>
        public string DiskRpMeter { get; }
        /// <summary> The managed disk billing sku, P30 or S30. </summary>
        public string Sku { get; }
        /// <summary> The managed disk billing tier, Standard or Premium. </summary>
        public HDInsightTier? Tier { get; }
    }
}
