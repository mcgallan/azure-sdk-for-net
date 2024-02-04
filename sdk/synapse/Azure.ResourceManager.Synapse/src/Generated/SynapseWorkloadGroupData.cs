// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseWorkloadGroup data model.
    /// Workload group operations for a sql pool
    /// </summary>
    public partial class SynapseWorkloadGroupData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SynapseWorkloadGroupData"/>. </summary>
        public SynapseWorkloadGroupData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseWorkloadGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="minResourcePercent"> The workload group minimum percentage resource. </param>
        /// <param name="maxResourcePercent"> The workload group cap percentage resource. </param>
        /// <param name="minResourcePercentPerRequest"> The workload group request minimum grant percentage. </param>
        /// <param name="maxResourcePercentPerRequest"> The workload group request maximum grant percentage. </param>
        /// <param name="importance"> The workload group importance level. </param>
        /// <param name="queryExecutionTimeout"> The workload group query execution timeout. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseWorkloadGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? minResourcePercent, int? maxResourcePercent, double? minResourcePercentPerRequest, double? maxResourcePercentPerRequest, string importance, int? queryExecutionTimeout, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            MinResourcePercent = minResourcePercent;
            MaxResourcePercent = maxResourcePercent;
            MinResourcePercentPerRequest = minResourcePercentPerRequest;
            MaxResourcePercentPerRequest = maxResourcePercentPerRequest;
            Importance = importance;
            QueryExecutionTimeout = queryExecutionTimeout;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The workload group minimum percentage resource. </summary>
        public int? MinResourcePercent { get; set; }
        /// <summary> The workload group cap percentage resource. </summary>
        public int? MaxResourcePercent { get; set; }
        /// <summary> The workload group request minimum grant percentage. </summary>
        public double? MinResourcePercentPerRequest { get; set; }
        /// <summary> The workload group request maximum grant percentage. </summary>
        public double? MaxResourcePercentPerRequest { get; set; }
        /// <summary> The workload group importance level. </summary>
        public string Importance { get; set; }
        /// <summary> The workload group query execution timeout. </summary>
        public int? QueryExecutionTimeout { get; set; }
    }
}
