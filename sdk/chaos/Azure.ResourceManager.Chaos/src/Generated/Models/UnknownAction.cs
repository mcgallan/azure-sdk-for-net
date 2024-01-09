// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> The UnknownAction. </summary>
    internal partial class UnknownAction : Action
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAction"/>. </summary>
        /// <param name="actionType"> Enum that discriminates between action models. </param>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAction(string actionType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(actionType, name, serializedAdditionalRawData)
        {
            ActionType = actionType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAction"/> for deserialization. </summary>
        internal UnknownAction()
        {
        }
    }
}
