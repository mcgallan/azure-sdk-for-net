// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> The ControllerConnectionDetails. </summary>
    public partial class ControllerConnectionDetails
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

        /// <summary> Initializes a new instance of <see cref="ControllerConnectionDetails"/>. </summary>
        internal ControllerConnectionDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ControllerConnectionDetails"/>. </summary>
        /// <param name="orchestratorSpecificConnectionDetails">
        /// Base class for types that supply values used to connect to container orchestrators
        /// Please note <see cref="Models.OrchestratorSpecificConnectionDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KubernetesConnectionDetails"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ControllerConnectionDetails(OrchestratorSpecificConnectionDetails orchestratorSpecificConnectionDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OrchestratorSpecificConnectionDetails = orchestratorSpecificConnectionDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Base class for types that supply values used to connect to container orchestrators
        /// Please note <see cref="Models.OrchestratorSpecificConnectionDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KubernetesConnectionDetails"/>.
        /// </summary>
        public OrchestratorSpecificConnectionDetails OrchestratorSpecificConnectionDetails { get; }
    }
}
