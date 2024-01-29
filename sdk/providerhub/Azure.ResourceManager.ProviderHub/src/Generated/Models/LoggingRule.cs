// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The LoggingRule. </summary>
    public partial class LoggingRule
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

        /// <summary> Initializes a new instance of <see cref="LoggingRule"/>. </summary>
        /// <param name="action"></param>
        /// <param name="direction"></param>
        /// <param name="detailLevel"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="action"/> is null. </exception>
        public LoggingRule(string action, LoggingDirection direction, LoggingDetail detailLevel)
        {
            Argument.AssertNotNull(action, nameof(action));

            Action = action;
            Direction = direction;
            DetailLevel = detailLevel;
        }

        /// <summary> Initializes a new instance of <see cref="LoggingRule"/>. </summary>
        /// <param name="action"></param>
        /// <param name="direction"></param>
        /// <param name="detailLevel"></param>
        /// <param name="hiddenPropertyPaths"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoggingRule(string action, LoggingDirection direction, LoggingDetail detailLevel, LoggingHiddenPropertyPaths hiddenPropertyPaths, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Action = action;
            Direction = direction;
            DetailLevel = detailLevel;
            HiddenPropertyPaths = hiddenPropertyPaths;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LoggingRule"/> for deserialization. </summary>
        internal LoggingRule()
        {
        }

        /// <summary> Gets or sets the action. </summary>
        public string Action { get; set; }
        /// <summary> Gets or sets the direction. </summary>
        public LoggingDirection Direction { get; set; }
        /// <summary> Gets or sets the detail level. </summary>
        public LoggingDetail DetailLevel { get; set; }
        /// <summary> Gets or sets the hidden property paths. </summary>
        public LoggingHiddenPropertyPaths HiddenPropertyPaths { get; set; }
    }
}
