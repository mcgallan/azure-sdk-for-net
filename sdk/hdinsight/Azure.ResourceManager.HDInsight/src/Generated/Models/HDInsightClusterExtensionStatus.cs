// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The cluster monitoring status response. </summary>
    public partial class HDInsightClusterExtensionStatus
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

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterExtensionStatus"/>. </summary>
        internal HDInsightClusterExtensionStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterExtensionStatus"/>. </summary>
        /// <param name="isClusterMonitoringEnabled"> The status of the monitor on the HDInsight cluster. </param>
        /// <param name="workspaceId"> The workspace ID of the monitor on the HDInsight cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterExtensionStatus(bool? isClusterMonitoringEnabled, string workspaceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsClusterMonitoringEnabled = isClusterMonitoringEnabled;
            WorkspaceId = workspaceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the monitor on the HDInsight cluster. </summary>
        public bool? IsClusterMonitoringEnabled { get; }
        /// <summary> The workspace ID of the monitor on the HDInsight cluster. </summary>
        public string WorkspaceId { get; }
    }
}
