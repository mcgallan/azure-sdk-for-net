// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> A piece of clinical information, expressed as a code in a clinical coding system. </summary>
    public partial class ClinicalCodedElement
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

        /// <summary> Initializes a new instance of <see cref="ClinicalCodedElement"/>. </summary>
        /// <param name="system"> The clinical coding system, e.g. ICD-10, SNOMED-CT, UMLS. </param>
        /// <param name="code"> The code within the given clinical coding system. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="system"/> or <paramref name="code"/> is null. </exception>
        public ClinicalCodedElement(string system, string code)
        {
            Argument.AssertNotNull(system, nameof(system));
            Argument.AssertNotNull(code, nameof(code));

            System = system;
            Code = code;
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalCodedElement"/>. </summary>
        /// <param name="system"> The clinical coding system, e.g. ICD-10, SNOMED-CT, UMLS. </param>
        /// <param name="code"> The code within the given clinical coding system. </param>
        /// <param name="name"> The name of this coded concept in the coding system. </param>
        /// <param name="value"> A value associated with the code within the given clinical coding system. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClinicalCodedElement(string system, string code, string name, string value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            System = system;
            Code = code;
            Name = name;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalCodedElement"/> for deserialization. </summary>
        internal ClinicalCodedElement()
        {
        }

        /// <summary> The clinical coding system, e.g. ICD-10, SNOMED-CT, UMLS. </summary>
        public string System { get; set; }
        /// <summary> The code within the given clinical coding system. </summary>
        public string Code { get; set; }
        /// <summary> The name of this coded concept in the coding system. </summary>
        public string Name { get; set; }
        /// <summary> A value associated with the code within the given clinical coding system. </summary>
        public string Value { get; set; }
    }
}
