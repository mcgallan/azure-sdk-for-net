// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment on error behavior. </summary>
    public partial class ErrorDeployment
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

        /// <summary> Initializes a new instance of <see cref="ErrorDeployment"/>. </summary>
        public ErrorDeployment()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorDeployment"/>. </summary>
        /// <param name="deploymentType"> The deployment on error behavior type. Possible values are LastSuccessful and SpecificDeployment. </param>
        /// <param name="deploymentName"> The deployment to be used on error case. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ErrorDeployment(ErrorDeploymentType? deploymentType, string deploymentName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeploymentType = deploymentType;
            DeploymentName = deploymentName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The deployment on error behavior type. Possible values are LastSuccessful and SpecificDeployment. </summary>
        public ErrorDeploymentType? DeploymentType { get; set; }
        /// <summary> The deployment to be used on error case. </summary>
        public string DeploymentName { get; set; }
    }
}
