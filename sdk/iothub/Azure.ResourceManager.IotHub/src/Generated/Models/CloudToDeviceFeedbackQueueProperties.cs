// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties of the feedback queue for cloud-to-device messages. </summary>
    public partial class CloudToDeviceFeedbackQueueProperties
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

        /// <summary> Initializes a new instance of <see cref="CloudToDeviceFeedbackQueueProperties"/>. </summary>
        public CloudToDeviceFeedbackQueueProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudToDeviceFeedbackQueueProperties"/>. </summary>
        /// <param name="lockDurationAsIso8601"> The lock duration for the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </param>
        /// <param name="ttlAsIso8601"> The period of time for which a message is available to consume before it is expired by the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </param>
        /// <param name="maxDeliveryCount"> The number of times the IoT hub attempts to deliver a message on the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudToDeviceFeedbackQueueProperties(TimeSpan? lockDurationAsIso8601, TimeSpan? ttlAsIso8601, int? maxDeliveryCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LockDurationAsIso8601 = lockDurationAsIso8601;
            TtlAsIso8601 = ttlAsIso8601;
            MaxDeliveryCount = maxDeliveryCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The lock duration for the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </summary>
        public TimeSpan? LockDurationAsIso8601 { get; set; }
        /// <summary> The period of time for which a message is available to consume before it is expired by the IoT hub. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </summary>
        public TimeSpan? TtlAsIso8601 { get; set; }
        /// <summary> The number of times the IoT hub attempts to deliver a message on the feedback queue. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#cloud-to-device-messages. </summary>
        public int? MaxDeliveryCount { get; set; }
    }
}
