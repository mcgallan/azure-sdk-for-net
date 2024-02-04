// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
    public partial class NewRelicObservabilityLogRules
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

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityLogRules"/>. </summary>
        public NewRelicObservabilityLogRules()
        {
            FilteringTags = new ChangeTrackingList<NewRelicObservabilityFilteringTag>();
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityLogRules"/>. </summary>
        /// <param name="sendAadLogs"> Flag specifying if AAD logs should be sent for the Monitor resource. </param>
        /// <param name="sendSubscriptionLogs"> Flag specifying if subscription logs should be sent for the Monitor resource. </param>
        /// <param name="sendActivityLogs"> Flag specifying if activity logs from Azure resources should be sent for the Monitor resource. </param>
        /// <param name="filteringTags">
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityLogRules(NewRelicObservabilitySendAadLogsStatus? sendAadLogs, NewRelicObservabilitySendSubscriptionLogsStatus? sendSubscriptionLogs, NewRelicObservabilitySendActivityLogsStatus? sendActivityLogs, IList<NewRelicObservabilityFilteringTag> filteringTags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SendAadLogs = sendAadLogs;
            SendSubscriptionLogs = sendSubscriptionLogs;
            SendActivityLogs = sendActivityLogs;
            FilteringTags = filteringTags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Flag specifying if AAD logs should be sent for the Monitor resource. </summary>
        public NewRelicObservabilitySendAadLogsStatus? SendAadLogs { get; set; }
        /// <summary> Flag specifying if subscription logs should be sent for the Monitor resource. </summary>
        public NewRelicObservabilitySendSubscriptionLogsStatus? SendSubscriptionLogs { get; set; }
        /// <summary> Flag specifying if activity logs from Azure resources should be sent for the Monitor resource. </summary>
        public NewRelicObservabilitySendActivityLogsStatus? SendActivityLogs { get; set; }
        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.
        /// </summary>
        public IList<NewRelicObservabilityFilteringTag> FilteringTags { get; }
    }
}
