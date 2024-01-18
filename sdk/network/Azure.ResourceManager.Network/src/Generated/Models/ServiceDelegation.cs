// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Details the service to which the subnet is delegated. </summary>
    public partial class ServiceDelegation : NetworkWritableResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ServiceDelegation"/>. </summary>
        public ServiceDelegation()
        {
            Actions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceDelegation"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="serviceName"> The name of the service to whom the subnet should be delegated (e.g. Microsoft.Sql/servers). </param>
        /// <param name="actions"> The actions permitted to the service upon delegation. </param>
        /// <param name="provisioningState"> The provisioning state of the service delegation resource. </param>
        internal ServiceDelegation(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, string serviceName, IReadOnlyList<string> actions, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            ServiceName = serviceName;
            Actions = actions;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The name of the service to whom the subnet should be delegated (e.g. Microsoft.Sql/servers). </summary>
        public string ServiceName { get; set; }
        /// <summary> The actions permitted to the service upon delegation. </summary>
        public IReadOnlyList<string> Actions { get; }
        /// <summary> The provisioning state of the service delegation resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
