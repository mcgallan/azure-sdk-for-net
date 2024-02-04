// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants;

/*
 * CUSTOM CODE DESCRIPTION:
 *
 * Used to superficially combine function tool definitions and their vacuous container tool type.
 *      Before: new FunctionToolDefinition(new FunctionDefinition(name, description, properties))
 *      After : new FunctionToolDefinition(name, description, properties)
 */

[CodeGenSuppress("FunctionToolDefinition", typeof(InternalFunctionDefinition))]
public partial class FunctionToolDefinition
{
    /// <inheritdoc cref="InternalFunctionDefinition.Name"/>
    public string Name => InternalFunction.Name;

    /// <inheritdoc cref="InternalFunctionDefinition.Description"/>
    public string Description => InternalFunction.Description;

    /// <inheritdoc cref="InternalFunctionDefinition.Parameters"/>
    public BinaryData Parameters => InternalFunction.Parameters;

    /// <summary> The definition of the function that the function tool should call. </summary>
    internal InternalFunctionDefinition InternalFunction { get; set; }

    /// <summary>
    /// Initializes a new instance of FunctionToolDefinition.
    /// </summary>
    /// <param name="name"> The name of the function to be called. </param>
    /// <param name="description"> A description of what the function does, used by the model to choose when and how to call the function. </param>
    /// <param name="parameters"> The parameters the functions accepts, described as a JSON Schema object. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="description"/> or <paramref name="parameters"/> is null. </exception>
    public FunctionToolDefinition(string name, string description, BinaryData parameters)
        : this(type: "function", serializedAdditionalRawData: null, new InternalFunctionDefinition(name, description, parameters, serializedAdditionalRawData: null))
    {
    }

    /// <summary>
    /// Initializes a new instance of FunctionTool for a function that requires no explicit function parameters.
    /// </summary>
    /// <param name="name"> The name of the function to be called. </param>
    /// <param name="description"> A description of what the function does, used by the model to choose when and how to call the function. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="description"/> is null. </exception>
    public FunctionToolDefinition(string name, string description)
        : this(name, description, BinaryData.FromObjectAsJson(new { type = "object", properties = new { } }))
    { }
}
