// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Instance view status. </summary>
    public partial class MachineExtensionInstanceViewStatus
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

        /// <summary> Initializes a new instance of <see cref="MachineExtensionInstanceViewStatus"/>. </summary>
        public MachineExtensionInstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineExtensionInstanceViewStatus"/>. </summary>
        /// <param name="code"> The status code. </param>
        /// <param name="level"> The level code. </param>
        /// <param name="displayStatus"> The short localizable label for the status. </param>
        /// <param name="message"> The detailed status message, including for alerts and error messages. </param>
        /// <param name="time"> The time of the status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineExtensionInstanceViewStatus(string code, HybridComputeStatusLevelType? level, string displayStatus, string message, DateTimeOffset? time, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Level = level;
            DisplayStatus = displayStatus;
            Message = message;
            Time = time;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status code. </summary>
        public string Code { get; set; }
        /// <summary> The level code. </summary>
        public HybridComputeStatusLevelType? Level { get; set; }
        /// <summary> The short localizable label for the status. </summary>
        public string DisplayStatus { get; set; }
        /// <summary> The detailed status message, including for alerts and error messages. </summary>
        public string Message { get; set; }
        /// <summary> The time of the status. </summary>
        public DateTimeOffset? Time { get; set; }
    }
}
