// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The storage account blob inventory policy rules. </summary>
    public partial class BlobInventoryPolicySchema
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

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicySchema"/>. </summary>
        /// <param name="isEnabled"> Policy is enabled if set to true. </param>
        /// <param name="ruleType"> The valid value is Inventory. </param>
        /// <param name="rules"> The storage account blob inventory policy rules. The rule is applied when it is enabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rules"/> is null. </exception>
        public BlobInventoryPolicySchema(bool isEnabled, BlobInventoryRuleType ruleType, IEnumerable<BlobInventoryPolicyRule> rules)
        {
            Argument.AssertNotNull(rules, nameof(rules));

            IsEnabled = isEnabled;
            RuleType = ruleType;
            Rules = rules.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicySchema"/>. </summary>
        /// <param name="isEnabled"> Policy is enabled if set to true. </param>
        /// <param name="destination"> Deprecated Property from API version 2021-04-01 onwards, the required destination container name must be specified at the rule level 'policy.rule.destination'. </param>
        /// <param name="ruleType"> The valid value is Inventory. </param>
        /// <param name="rules"> The storage account blob inventory policy rules. The rule is applied when it is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobInventoryPolicySchema(bool isEnabled, string destination, BlobInventoryRuleType ruleType, IList<BlobInventoryPolicyRule> rules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Destination = destination;
            RuleType = ruleType;
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobInventoryPolicySchema"/> for deserialization. </summary>
        internal BlobInventoryPolicySchema()
        {
        }

        /// <summary> Policy is enabled if set to true. </summary>
        public bool IsEnabled { get; set; }
        /// <summary> Deprecated Property from API version 2021-04-01 onwards, the required destination container name must be specified at the rule level 'policy.rule.destination'. </summary>
        public string Destination { get; }
        /// <summary> The valid value is Inventory. </summary>
        public BlobInventoryRuleType RuleType { get; set; }
        /// <summary> The storage account blob inventory policy rules. The rule is applied when it is enabled. </summary>
        public IList<BlobInventoryPolicyRule> Rules { get; }
    }
}
