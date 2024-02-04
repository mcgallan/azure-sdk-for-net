// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the load balancer resource settings. </summary>
    public partial class LoadBalancerResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="LoadBalancerResourceSettings"/>. </summary>
        public LoadBalancerResourceSettings()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            FrontendIPConfigurations = new ChangeTrackingList<LoadBalancerFrontendIPConfigurationResourceSettings>();
            BackendAddressPools = new ChangeTrackingList<LoadBalancerBackendAddressPoolResourceSettings>();
            ResourceType = "Microsoft.Network/loadBalancers";
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerResourceSettings"/>. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="targetResourceGroupName"> Gets or sets the target resource group name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="sku"> Gets or sets load balancer sku (Basic/Standard). </param>
        /// <param name="frontendIPConfigurations"> Gets or sets the frontend IP configurations of the load balancer. </param>
        /// <param name="backendAddressPools"> Gets or sets the backend address pools of the load balancer. </param>
        /// <param name="zones">
        /// Gets or sets the csv list of zones common for all frontend IP configurations. Note this is given
        ///  precedence only if frontend IP configurations settings are not present.
        /// </param>
        internal LoadBalancerResourceSettings(string resourceType, string targetResourceName, string targetResourceGroupName, IDictionary<string, BinaryData> serializedAdditionalRawData, IDictionary<string, string> tags, string sku, IList<LoadBalancerFrontendIPConfigurationResourceSettings> frontendIPConfigurations, IList<LoadBalancerBackendAddressPoolResourceSettings> backendAddressPools, string zones) : base(resourceType, targetResourceName, targetResourceGroupName, serializedAdditionalRawData)
        {
            Tags = tags;
            Sku = sku;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPools = backendAddressPools;
            Zones = zones;
            ResourceType = resourceType ?? "Microsoft.Network/loadBalancers";
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets load balancer sku (Basic/Standard). </summary>
        public string Sku { get; set; }
        /// <summary> Gets or sets the frontend IP configurations of the load balancer. </summary>
        public IList<LoadBalancerFrontendIPConfigurationResourceSettings> FrontendIPConfigurations { get; }
        /// <summary> Gets or sets the backend address pools of the load balancer. </summary>
        public IList<LoadBalancerBackendAddressPoolResourceSettings> BackendAddressPools { get; }
        /// <summary>
        /// Gets or sets the csv list of zones common for all frontend IP configurations. Note this is given
        ///  precedence only if frontend IP configurations settings are not present.
        /// </summary>
        public string Zones { get; set; }
    }
}
