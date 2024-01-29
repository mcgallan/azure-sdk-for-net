// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the collection of move resources. </summary>
    internal partial class MoverResourceList
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

        /// <summary> Initializes a new instance of <see cref="MoverResourceList"/>. </summary>
        internal MoverResourceList()
        {
            Value = new ChangeTrackingList<MoverResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="MoverResourceList"/>. </summary>
        /// <param name="value"> Gets the list of move resources. </param>
        /// <param name="nextLink"> Gets the value of  next link. </param>
        /// <param name="summaryCollection"> Gets or sets the list of summary items and the field on which summary is done. </param>
        /// <param name="totalCount"> Gets the total count. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MoverResourceList(IReadOnlyList<MoverResourceData> value, string nextLink, MoverSummaryList summaryCollection, long? totalCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            SummaryCollection = summaryCollection;
            TotalCount = totalCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the list of move resources. </summary>
        public IReadOnlyList<MoverResourceData> Value { get; }
        /// <summary> Gets the value of  next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets or sets the list of summary items and the field on which summary is done. </summary>
        public MoverSummaryList SummaryCollection { get; }
        /// <summary> Gets the total count. </summary>
        public long? TotalCount { get; }
    }
}
