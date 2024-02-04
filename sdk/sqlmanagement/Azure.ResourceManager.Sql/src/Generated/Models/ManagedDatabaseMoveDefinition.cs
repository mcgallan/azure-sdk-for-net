// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Contains the information necessary to perform a managed database move. </summary>
    public partial class ManagedDatabaseMoveDefinition
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

        /// <summary> Initializes a new instance of <see cref="ManagedDatabaseMoveDefinition"/>. </summary>
        /// <param name="destinationManagedDatabaseId"> The destination managed database ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="destinationManagedDatabaseId"/> is null. </exception>
        public ManagedDatabaseMoveDefinition(ResourceIdentifier destinationManagedDatabaseId)
        {
            Argument.AssertNotNull(destinationManagedDatabaseId, nameof(destinationManagedDatabaseId));

            DestinationManagedDatabaseId = destinationManagedDatabaseId;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedDatabaseMoveDefinition"/>. </summary>
        /// <param name="destinationManagedDatabaseId"> The destination managed database ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedDatabaseMoveDefinition(ResourceIdentifier destinationManagedDatabaseId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DestinationManagedDatabaseId = destinationManagedDatabaseId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedDatabaseMoveDefinition"/> for deserialization. </summary>
        internal ManagedDatabaseMoveDefinition()
        {
        }

        /// <summary> The destination managed database ID. </summary>
        public ResourceIdentifier DestinationManagedDatabaseId { get; }
    }
}
