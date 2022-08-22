// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    /// <summary> A class representing the SubscriptionAliasResponse data model. </summary>
    public partial class SubscriptionAliasResponseData : ResourceData
    {
        /// <summary> Initializes a new instance of SubscriptionAliasResponseData. </summary>
        internal SubscriptionAliasResponseData()
        {
        }

        /// <summary> Initializes a new instance of SubscriptionAliasResponseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Subscription Alias response properties. </param>
        internal SubscriptionAliasResponseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubscriptionAliasResponseProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Subscription Alias response properties. </summary>
        public SubscriptionAliasResponseProperties Properties { get; }
    }
}
