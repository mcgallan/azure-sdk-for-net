// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The observed status of the provisioned cluster. </summary>
    public partial class ProvisionedClusterStatus
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

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterStatus"/>. </summary>
        internal ProvisionedClusterStatus()
        {
            ControlPlaneStatus = new ChangeTrackingList<ProvisionedClusterAddonStatusProfile>();
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterStatus"/>. </summary>
        /// <param name="controlPlaneStatus"> The detailed status of the provisioned cluster components including addons. </param>
        /// <param name="currentState"> The current state of the provisioned cluster. </param>
        /// <param name="errorMessage"> Error messages during a provisioned cluster operation or steady state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProvisionedClusterStatus(IReadOnlyList<ProvisionedClusterAddonStatusProfile> controlPlaneStatus, HybridContainerServiceResourceProvisioningState? currentState, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ControlPlaneStatus = controlPlaneStatus;
            CurrentState = currentState;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The detailed status of the provisioned cluster components including addons. </summary>
        public IReadOnlyList<ProvisionedClusterAddonStatusProfile> ControlPlaneStatus { get; }
        /// <summary> The current state of the provisioned cluster. </summary>
        public HybridContainerServiceResourceProvisioningState? CurrentState { get; }
        /// <summary> Error messages during a provisioned cluster operation or steady state. </summary>
        public string ErrorMessage { get; }
    }
}
