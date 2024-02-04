// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Filters limit replication to a subset of blobs within the storage account. A logical OR is performed on values in the filter. If multiple filters are defined, a logical AND is performed on all filters. </summary>
    public partial class ObjectReplicationPolicyFilter
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

        /// <summary> Initializes a new instance of <see cref="ObjectReplicationPolicyFilter"/>. </summary>
        public ObjectReplicationPolicyFilter()
        {
            PrefixMatch = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ObjectReplicationPolicyFilter"/>. </summary>
        /// <param name="prefixMatch"> Optional. Filters the results to replicate only blobs whose names begin with the specified prefix. </param>
        /// <param name="minCreationTime"> Blobs created after the time will be replicated to the destination. It must be in datetime format 'yyyy-MM-ddTHH:mm:ssZ'. Example: 2020-02-19T16:05:00Z. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ObjectReplicationPolicyFilter(IList<string> prefixMatch, string minCreationTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrefixMatch = prefixMatch;
            MinCreationTime = minCreationTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Optional. Filters the results to replicate only blobs whose names begin with the specified prefix. </summary>
        public IList<string> PrefixMatch { get; }
        /// <summary> Blobs created after the time will be replicated to the destination. It must be in datetime format 'yyyy-MM-ddTHH:mm:ssZ'. Example: 2020-02-19T16:05:00Z. </summary>
        public string MinCreationTime { get; set; }
    }
}
