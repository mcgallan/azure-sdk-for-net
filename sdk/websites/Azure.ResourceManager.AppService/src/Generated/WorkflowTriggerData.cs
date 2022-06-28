// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the WorkflowTrigger data model. </summary>
    public partial class WorkflowTriggerData : ResourceData
    {
        /// <summary> Initializes a new instance of WorkflowTriggerData. </summary>
        internal WorkflowTriggerData()
        {
        }

        /// <summary> Initializes a new instance of WorkflowTriggerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Gets the provisioning state. </param>
        /// <param name="createdOn"> Gets the created time. </param>
        /// <param name="changedOn"> Gets the changed time. </param>
        /// <param name="state"> Gets the state. </param>
        /// <param name="status"> Gets the status. </param>
        /// <param name="lastExecutionOn"> Gets the last execution time. </param>
        /// <param name="nextExecutionOn"> Gets the next execution time. </param>
        /// <param name="recurrence"> Gets the workflow trigger recurrence. </param>
        /// <param name="workflow"> Gets the reference to workflow. </param>
        internal WorkflowTriggerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, WorkflowTriggerProvisioningState? provisioningState, DateTimeOffset? createdOn, DateTimeOffset? changedOn, WorkflowState? state, WorkflowStatus? status, DateTimeOffset? lastExecutionOn, DateTimeOffset? nextExecutionOn, WorkflowTriggerRecurrence recurrence, ResourceReference workflow) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            ChangedOn = changedOn;
            State = state;
            Status = status;
            LastExecutionOn = lastExecutionOn;
            NextExecutionOn = nextExecutionOn;
            Recurrence = recurrence;
            Workflow = workflow;
        }

        /// <summary> Gets the provisioning state. </summary>
        public WorkflowTriggerProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets the changed time. </summary>
        public DateTimeOffset? ChangedOn { get; }
        /// <summary> Gets the state. </summary>
        public WorkflowState? State { get; }
        /// <summary> Gets the status. </summary>
        public WorkflowStatus? Status { get; }
        /// <summary> Gets the last execution time. </summary>
        public DateTimeOffset? LastExecutionOn { get; }
        /// <summary> Gets the next execution time. </summary>
        public DateTimeOffset? NextExecutionOn { get; }
        /// <summary> Gets the workflow trigger recurrence. </summary>
        public WorkflowTriggerRecurrence Recurrence { get; }
        /// <summary> Gets the reference to workflow. </summary>
        public ResourceReference Workflow { get; }
    }
}
