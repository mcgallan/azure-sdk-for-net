// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The parameters needed to retrieve the default function definition for a CSharp function. </summary>
    public partial class CSharpFunctionRetrieveDefaultDefinitionContent : FunctionRetrieveDefaultDefinitionContent
    {
        /// <summary> Initializes a new instance of <see cref="CSharpFunctionRetrieveDefaultDefinitionContent"/>. </summary>
        public CSharpFunctionRetrieveDefaultDefinitionContent()
        {
            BindingType = "Microsoft.StreamAnalytics/CLRUdf";
        }

        /// <summary> Initializes a new instance of <see cref="CSharpFunctionRetrieveDefaultDefinitionContent"/>. </summary>
        /// <param name="bindingType"> Indicates the function binding type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="script"> The CSharp code containing a single function definition. </param>
        /// <param name="udfType"> The function type. </param>
        internal CSharpFunctionRetrieveDefaultDefinitionContent(string bindingType, IDictionary<string, BinaryData> serializedAdditionalRawData, string script, StreamingJobFunctionUdfType? udfType) : base(bindingType, serializedAdditionalRawData)
        {
            Script = script;
            UdfType = udfType;
            BindingType = bindingType ?? "Microsoft.StreamAnalytics/CLRUdf";
        }

        /// <summary> The CSharp code containing a single function definition. </summary>
        public string Script { get; set; }
        /// <summary> The function type. </summary>
        public StreamingJobFunctionUdfType? UdfType { get; set; }
    }
}
