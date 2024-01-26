// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Return plan with request details. </summary>
    public partial class PrivateStorePlanDetails
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

        /// <summary> Initializes a new instance of <see cref="PrivateStorePlanDetails"/>. </summary>
        public PrivateStorePlanDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateStorePlanDetails"/>. </summary>
        /// <param name="planId"> Gets or sets Plan Id. </param>
        /// <param name="status"> Gets the plan status. </param>
        /// <param name="requestDate"> Gets request date. </param>
        /// <param name="justification"> Gets or sets user's justification for the plan's request. </param>
        /// <param name="subscriptionId"> Gets or sets the subscription id that the user is requesting to add the plan to. </param>
        /// <param name="subscriptionName"> Gets or sets the subscription name that the user is requesting to add the plan to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateStorePlanDetails(string planId, PrivateStorePlanStatus? status, BinaryData requestDate, string justification, string subscriptionId, string subscriptionName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PlanId = planId;
            Status = status;
            RequestDate = requestDate;
            Justification = justification;
            SubscriptionId = subscriptionId;
            SubscriptionName = subscriptionName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets Plan Id. </summary>
        public string PlanId { get; set; }
        /// <summary> Gets the plan status. </summary>
        public PrivateStorePlanStatus? Status { get; }
        /// <summary>
        /// Gets request date
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData RequestDate { get; }
        /// <summary> Gets or sets user's justification for the plan's request. </summary>
        public string Justification { get; set; }
        /// <summary> Gets or sets the subscription id that the user is requesting to add the plan to. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> Gets or sets the subscription name that the user is requesting to add the plan to. </summary>
        public string SubscriptionName { get; set; }
    }
}
