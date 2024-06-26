// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Deletion Info. </summary>
    public partial class BackupInstanceDeletionInfo
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

        /// <summary> Initializes a new instance of <see cref="BackupInstanceDeletionInfo"/>. </summary>
        internal BackupInstanceDeletionInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupInstanceDeletionInfo"/>. </summary>
        /// <param name="deleteOn"> Specifies time of deletion. </param>
        /// <param name="billingEndOn"> Specifies billing end date. </param>
        /// <param name="scheduledPurgeOn"> Specifies purge time. </param>
        /// <param name="deleteActivityId"> Delete activity ID for troubleshooting purpose. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupInstanceDeletionInfo(DateTimeOffset? deleteOn, DateTimeOffset? billingEndOn, DateTimeOffset? scheduledPurgeOn, string deleteActivityId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeleteOn = deleteOn;
            BillingEndOn = billingEndOn;
            ScheduledPurgeOn = scheduledPurgeOn;
            DeleteActivityId = deleteActivityId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies time of deletion. </summary>
        public DateTimeOffset? DeleteOn { get; }
        /// <summary> Specifies billing end date. </summary>
        public DateTimeOffset? BillingEndOn { get; }
        /// <summary> Specifies purge time. </summary>
        public DateTimeOffset? ScheduledPurgeOn { get; }
        /// <summary> Delete activity ID for troubleshooting purpose. </summary>
        public string DeleteActivityId { get; }
    }
}
