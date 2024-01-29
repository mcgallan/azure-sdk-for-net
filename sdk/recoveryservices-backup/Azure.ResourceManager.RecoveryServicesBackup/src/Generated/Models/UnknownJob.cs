// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownJob. </summary>
    internal partial class UnknownJob : BackupGenericJob
    {
        /// <summary> Initializes a new instance of <see cref="UnknownJob"/>. </summary>
        /// <param name="entityFriendlyName"> Friendly name of the entity on which the current job is executing. </param>
        /// <param name="backupManagementType"> Backup management type to execute the current job. </param>
        /// <param name="operation"> The operation name. </param>
        /// <param name="status"> Job status. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="endOn"> The end time. </param>
        /// <param name="activityId"> ActivityId of job. </param>
        /// <param name="jobType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownJob(string entityFriendlyName, BackupManagementType? backupManagementType, string operation, string status, DateTimeOffset? startOn, DateTimeOffset? endOn, string activityId, string jobType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(entityFriendlyName, backupManagementType, operation, status, startOn, endOn, activityId, jobType, serializedAdditionalRawData)
        {
            JobType = jobType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownJob"/> for deserialization. </summary>
        internal UnknownJob()
        {
        }
    }
}
