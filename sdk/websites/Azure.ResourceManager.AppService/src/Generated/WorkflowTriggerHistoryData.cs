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
    /// <summary> A class representing the WorkflowTriggerHistory data model. </summary>
    public partial class WorkflowTriggerHistoryData : ResourceData
    {
        /// <summary> Initializes a new instance of WorkflowTriggerHistoryData. </summary>
        internal WorkflowTriggerHistoryData()
        {
        }

        /// <summary> Initializes a new instance of WorkflowTriggerHistoryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn"> Gets the start time. </param>
        /// <param name="endOn"> Gets the end time. </param>
        /// <param name="scheduledOn"> The scheduled time. </param>
        /// <param name="status"> Gets the status. </param>
        /// <param name="code"> Gets the code. </param>
        /// <param name="error"> Gets the error. </param>
        /// <param name="trackingId"> Gets the tracking id. </param>
        /// <param name="correlation"> The run correlation. </param>
        /// <param name="inputsLink"> Gets the link to input parameters. </param>
        /// <param name="outputsLink"> Gets the link to output parameters. </param>
        /// <param name="fired"> The value indicating whether trigger was fired. </param>
        /// <param name="run"> Gets the reference to workflow run. </param>
        internal WorkflowTriggerHistoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? startOn, DateTimeOffset? endOn, DateTimeOffset? scheduledOn, WorkflowStatus? status, string code, BinaryData error, string trackingId, Correlation correlation, ContentLink inputsLink, ContentLink outputsLink, bool? fired, ResourceReference run) : base(id, name, resourceType, systemData)
        {
            StartOn = startOn;
            EndOn = endOn;
            ScheduledOn = scheduledOn;
            Status = status;
            Code = code;
            Error = error;
            TrackingId = trackingId;
            Correlation = correlation;
            InputsLink = inputsLink;
            OutputsLink = outputsLink;
            Fired = fired;
            Run = run;
        }

        /// <summary> Gets the start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets the end time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The scheduled time. </summary>
        public DateTimeOffset? ScheduledOn { get; }
        /// <summary> Gets the status. </summary>
        public WorkflowStatus? Status { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the error. </summary>
        public BinaryData Error { get; }
        /// <summary> Gets the tracking id. </summary>
        public string TrackingId { get; }
        /// <summary> The run correlation. </summary>
        internal Correlation Correlation { get; }
        /// <summary> The client tracking id. </summary>
        public string CorrelationClientTrackingId
        {
            get => Correlation?.ClientTrackingId;
        }

        /// <summary> Gets the link to input parameters. </summary>
        public ContentLink InputsLink { get; }
        /// <summary> Gets the link to output parameters. </summary>
        public ContentLink OutputsLink { get; }
        /// <summary> The value indicating whether trigger was fired. </summary>
        public bool? Fired { get; }
        /// <summary> Gets the reference to workflow run. </summary>
        public ResourceReference Run { get; }
    }
}
