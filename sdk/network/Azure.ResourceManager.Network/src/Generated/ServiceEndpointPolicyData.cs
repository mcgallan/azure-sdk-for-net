// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ServiceEndpointPolicy data model.
    /// Service End point policy resource.
    /// </summary>
    public partial class ServiceEndpointPolicyData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ServiceEndpointPolicyData"/>. </summary>
        public ServiceEndpointPolicyData()
        {
            ServiceEndpointPolicyDefinitions = new ChangeTrackingList<ServiceEndpointPolicyDefinitionData>();
            Subnets = new ChangeTrackingList<SubnetData>();
            ContextualServiceEndpointPolicies = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceEndpointPolicyData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="kind"> Kind of service endpoint policy. This is metadata used for the Azure portal experience. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> A collection of service endpoint policy definitions of the service endpoint policy. </param>
        /// <param name="subnets"> A collection of references to subnets. </param>
        /// <param name="resourceGuid"> The resource GUID property of the service endpoint policy resource. </param>
        /// <param name="provisioningState"> The provisioning state of the service endpoint policy resource. </param>
        /// <param name="serviceAlias"> The alias indicating if the policy belongs to a service. </param>
        /// <param name="contextualServiceEndpointPolicies"> A collection of contextual service endpoint policy. </param>
        internal ServiceEndpointPolicyData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, string kind, IList<ServiceEndpointPolicyDefinitionData> serviceEndpointPolicyDefinitions, IReadOnlyList<SubnetData> subnets, Guid? resourceGuid, NetworkProvisioningState? provisioningState, string serviceAlias, IList<string> contextualServiceEndpointPolicies) : base(id, name, resourceType, location, tags, serializedAdditionalRawData)
        {
            ETag = etag;
            Kind = kind;
            ServiceEndpointPolicyDefinitions = serviceEndpointPolicyDefinitions;
            Subnets = subnets;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            ServiceAlias = serviceAlias;
            ContextualServiceEndpointPolicies = contextualServiceEndpointPolicies;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Kind of service endpoint policy. This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> A collection of service endpoint policy definitions of the service endpoint policy. </summary>
        public IList<ServiceEndpointPolicyDefinitionData> ServiceEndpointPolicyDefinitions { get; }
        /// <summary> A collection of references to subnets. </summary>
        public IReadOnlyList<SubnetData> Subnets { get; }
        /// <summary> The resource GUID property of the service endpoint policy resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the service endpoint policy resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The alias indicating if the policy belongs to a service. </summary>
        public string ServiceAlias { get; set; }
        /// <summary> A collection of contextual service endpoint policy. </summary>
        public IList<string> ContextualServiceEndpointPolicies { get; }
    }
}
