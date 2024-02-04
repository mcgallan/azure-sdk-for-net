// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Redis cache access keys. </summary>
    public partial class RedisAccessKeys
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

        /// <summary> Initializes a new instance of <see cref="RedisAccessKeys"/>. </summary>
        internal RedisAccessKeys()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RedisAccessKeys"/>. </summary>
        /// <param name="primaryKey"> The current primary key that clients can use to authenticate with Redis cache. </param>
        /// <param name="secondaryKey"> The current secondary key that clients can use to authenticate with Redis cache. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisAccessKeys(string primaryKey, string secondaryKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The current primary key that clients can use to authenticate with Redis cache. </summary>
        public string PrimaryKey { get; }
        /// <summary> The current secondary key that clients can use to authenticate with Redis cache. </summary>
        public string SecondaryKey { get; }
    }
}
