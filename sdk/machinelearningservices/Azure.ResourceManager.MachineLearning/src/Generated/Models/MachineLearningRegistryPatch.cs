// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Strictly used in update requests. </summary>
    public partial class MachineLearningRegistryPatch
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningRegistryPatch"/>. </summary>
        public MachineLearningRegistryPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningRegistryPatch"/>. </summary>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="sku"> Sku details required for ARM contract for Autoscaling. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningRegistryPatch(ManagedServiceIdentity identity, MachineLearningSkuPatch sku, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Sku = sku;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Sku details required for ARM contract for Autoscaling. </summary>
        public MachineLearningSkuPatch Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
