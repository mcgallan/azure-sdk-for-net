// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The UnknownEventSubscriptionDestination. </summary>
    internal partial class UnknownEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary> Initializes a new instance of <see cref="UnknownEventSubscriptionDestination"/>. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownEventSubscriptionDestination(EndpointType endpointType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(endpointType, serializedAdditionalRawData)
        {
            EndpointType = endpointType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownEventSubscriptionDestination"/> for deserialization. </summary>
        internal UnknownEventSubscriptionDestination()
        {
        }
    }
}
