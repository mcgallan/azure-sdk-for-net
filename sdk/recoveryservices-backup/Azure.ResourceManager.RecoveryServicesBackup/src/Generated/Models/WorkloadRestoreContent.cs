// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// AzureWorkload-specific restore.
    /// Please note <see cref="WorkloadRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WorkloadPointInTimeRestoreContent"/>, <see cref="WorkloadSapHanaPointInTimeRestoreContent"/>, <see cref="WorkloadSapHanaPointInTimeRestoreWithRehydrateContent"/>, <see cref="WorkloadSapHanaRestoreContent"/>, <see cref="WorkloadSapHanaRestoreWithRehydrateContent"/>, <see cref="WorkloadSqlPointInTimeRestoreContent"/>, <see cref="WorkloadSqlPointInTimeRestoreWithRehydrateContent"/>, <see cref="WorkloadSqlRestoreContent"/> and <see cref="WorkloadSqlRestoreWithRehydrateContent"/>.
    /// </summary>
    public partial class WorkloadRestoreContent : RestoreContent
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadRestoreContent"/>. </summary>
        public WorkloadRestoreContent()
        {
            PropertyBag = new ChangeTrackingDictionary<string, string>();
            ObjectType = "AzureWorkloadRestoreRequest";
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadRestoreContent"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryType"> Type of this recovery. </param>
        /// <param name="sourceResourceId"> Fully qualified ARM ID of the VM on which workload that was running is being recovered. </param>
        /// <param name="propertyBag"> Workload specific property bag. </param>
        /// <param name="targetInfo"> Details of target database. </param>
        /// <param name="recoveryMode"> Defines whether the current recovery mode is file restore or database restore. </param>
        /// <param name="targetResourceGroupName"> Defines the Resource group of the Target VM. </param>
        /// <param name="userAssignedManagedIdentityDetails">
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </param>
        /// <param name="snapshotRestoreParameters">
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </param>
        /// <param name="targetVirtualMachineId">
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </param>
        internal WorkloadRestoreContent(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, FileShareRecoveryType? recoveryType, ResourceIdentifier sourceResourceId, IDictionary<string, string> propertyBag, TargetRestoreInfo targetInfo, RecoveryMode? recoveryMode, string targetResourceGroupName, UserAssignedManagedIdentityDetails userAssignedManagedIdentityDetails, SnapshotRestoreContent snapshotRestoreParameters, ResourceIdentifier targetVirtualMachineId) : base(objectType, serializedAdditionalRawData)
        {
            RecoveryType = recoveryType;
            SourceResourceId = sourceResourceId;
            PropertyBag = propertyBag;
            TargetInfo = targetInfo;
            RecoveryMode = recoveryMode;
            TargetResourceGroupName = targetResourceGroupName;
            UserAssignedManagedIdentityDetails = userAssignedManagedIdentityDetails;
            SnapshotRestoreParameters = snapshotRestoreParameters;
            TargetVirtualMachineId = targetVirtualMachineId;
            ObjectType = objectType ?? "AzureWorkloadRestoreRequest";
        }

        /// <summary> Type of this recovery. </summary>
        public FileShareRecoveryType? RecoveryType { get; set; }
        /// <summary> Fully qualified ARM ID of the VM on which workload that was running is being recovered. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary> Workload specific property bag. </summary>
        public IDictionary<string, string> PropertyBag { get; }
        /// <summary> Details of target database. </summary>
        public TargetRestoreInfo TargetInfo { get; set; }
        /// <summary> Defines whether the current recovery mode is file restore or database restore. </summary>
        public RecoveryMode? RecoveryMode { get; set; }
        /// <summary> Defines the Resource group of the Target VM. </summary>
        public string TargetResourceGroupName { get; set; }
        /// <summary>
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </summary>
        public UserAssignedManagedIdentityDetails UserAssignedManagedIdentityDetails { get; set; }
        /// <summary>
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </summary>
        public SnapshotRestoreContent SnapshotRestoreParameters { get; set; }
        /// <summary>
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        public ResourceIdentifier TargetVirtualMachineId { get; set; }
    }
}
