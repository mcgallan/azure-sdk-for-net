// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Represents a policy option. </summary>
    public partial class ContentKeyPolicyOption
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

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyOption"/>. </summary>
        /// <param name="configuration">
        /// The key delivery configuration.
        /// Please note <see cref="ContentKeyPolicyConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyClearKeyConfiguration"/>, <see cref="ContentKeyPolicyFairPlayConfiguration"/>, <see cref="ContentKeyPolicyPlayReadyConfiguration"/>, <see cref="ContentKeyPolicyUnknownConfiguration"/> and <see cref="ContentKeyPolicyWidevineConfiguration"/>.
        /// </param>
        /// <param name="restriction">
        /// The requirements that must be met to deliver keys with this configuration
        /// Please note <see cref="ContentKeyPolicyRestriction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyOpenRestriction"/>, <see cref="ContentKeyPolicyTokenRestriction"/> and <see cref="ContentKeyPolicyUnknownRestriction"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configuration"/> or <paramref name="restriction"/> is null. </exception>
        public ContentKeyPolicyOption(ContentKeyPolicyConfiguration configuration, ContentKeyPolicyRestriction restriction)
        {
            Argument.AssertNotNull(configuration, nameof(configuration));
            Argument.AssertNotNull(restriction, nameof(restriction));

            Configuration = configuration;
            Restriction = restriction;
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyOption"/>. </summary>
        /// <param name="policyOptionId"> The legacy Policy Option ID. </param>
        /// <param name="name"> The Policy Option description. </param>
        /// <param name="configuration">
        /// The key delivery configuration.
        /// Please note <see cref="ContentKeyPolicyConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyClearKeyConfiguration"/>, <see cref="ContentKeyPolicyFairPlayConfiguration"/>, <see cref="ContentKeyPolicyPlayReadyConfiguration"/>, <see cref="ContentKeyPolicyUnknownConfiguration"/> and <see cref="ContentKeyPolicyWidevineConfiguration"/>.
        /// </param>
        /// <param name="restriction">
        /// The requirements that must be met to deliver keys with this configuration
        /// Please note <see cref="ContentKeyPolicyRestriction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyOpenRestriction"/>, <see cref="ContentKeyPolicyTokenRestriction"/> and <see cref="ContentKeyPolicyUnknownRestriction"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentKeyPolicyOption(Guid? policyOptionId, string name, ContentKeyPolicyConfiguration configuration, ContentKeyPolicyRestriction restriction, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyOptionId = policyOptionId;
            Name = name;
            Configuration = configuration;
            Restriction = restriction;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyOption"/> for deserialization. </summary>
        internal ContentKeyPolicyOption()
        {
        }

        /// <summary> The legacy Policy Option ID. </summary>
        public Guid? PolicyOptionId { get; }
        /// <summary> The Policy Option description. </summary>
        public string Name { get; set; }
        /// <summary>
        /// The key delivery configuration.
        /// Please note <see cref="ContentKeyPolicyConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyClearKeyConfiguration"/>, <see cref="ContentKeyPolicyFairPlayConfiguration"/>, <see cref="ContentKeyPolicyPlayReadyConfiguration"/>, <see cref="ContentKeyPolicyUnknownConfiguration"/> and <see cref="ContentKeyPolicyWidevineConfiguration"/>.
        /// </summary>
        public ContentKeyPolicyConfiguration Configuration { get; set; }
        /// <summary>
        /// The requirements that must be met to deliver keys with this configuration
        /// Please note <see cref="ContentKeyPolicyRestriction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContentKeyPolicyOpenRestriction"/>, <see cref="ContentKeyPolicyTokenRestriction"/> and <see cref="ContentKeyPolicyUnknownRestriction"/>.
        /// </summary>
        public ContentKeyPolicyRestriction Restriction { get; set; }
    }
}
