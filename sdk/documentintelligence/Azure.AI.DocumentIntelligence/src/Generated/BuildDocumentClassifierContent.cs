// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Request body to build a new custom document classifier. </summary>
    public partial class BuildDocumentClassifierContent
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

        /// <summary> Initializes a new instance of <see cref="BuildDocumentClassifierContent"/>. </summary>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="docTypes"> List of document types to classify against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classifierId"/> or <paramref name="docTypes"/> is null. </exception>
        public BuildDocumentClassifierContent(string classifierId, IDictionary<string, ClassifierDocumentTypeDetails> docTypes)
        {
            Argument.AssertNotNull(classifierId, nameof(classifierId));
            Argument.AssertNotNull(docTypes, nameof(docTypes));

            ClassifierId = classifierId;
            DocTypes = docTypes;
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentClassifierContent"/>. </summary>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="description"> Document classifier description. </param>
        /// <param name="docTypes"> List of document types to classify against. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildDocumentClassifierContent(string classifierId, string description, IDictionary<string, ClassifierDocumentTypeDetails> docTypes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClassifierId = classifierId;
            Description = description;
            DocTypes = docTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentClassifierContent"/> for deserialization. </summary>
        internal BuildDocumentClassifierContent()
        {
        }

        /// <summary> Unique document classifier name. </summary>
        public string ClassifierId { get; }
        /// <summary> Document classifier description. </summary>
        public string Description { get; set; }
        /// <summary> List of document types to classify against. </summary>
        public IDictionary<string, ClassifierDocumentTypeDetails> DocTypes { get; }
    }
}
