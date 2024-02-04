// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// A class representing the TrafficManagerHeatMap data model.
    /// Class representing a Traffic Manager HeatMap.
    /// </summary>
    public partial class TrafficManagerHeatMapData : TrafficManagerProxyResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TrafficManagerHeatMapData"/>. </summary>
        public TrafficManagerHeatMapData()
        {
            Endpoints = new ChangeTrackingList<TrafficManagerHeatMapEndpoint>();
            TrafficFlows = new ChangeTrackingList<TrafficManagerHeatMapTrafficFlow>();
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerHeatMapData"/>. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="startOn"> The beginning of the time window for this HeatMap, inclusive. </param>
        /// <param name="endOn"> The ending of the time window for this HeatMap, exclusive. </param>
        /// <param name="endpoints"> The endpoints used in this HeatMap calculation. </param>
        /// <param name="trafficFlows"> The traffic flows produced in this HeatMap calculation. </param>
        internal TrafficManagerHeatMapData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset? startOn, DateTimeOffset? endOn, IList<TrafficManagerHeatMapEndpoint> endpoints, IList<TrafficManagerHeatMapTrafficFlow> trafficFlows) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            StartOn = startOn;
            EndOn = endOn;
            Endpoints = endpoints;
            TrafficFlows = trafficFlows;
        }

        /// <summary> The beginning of the time window for this HeatMap, inclusive. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The ending of the time window for this HeatMap, exclusive. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> The endpoints used in this HeatMap calculation. </summary>
        public IList<TrafficManagerHeatMapEndpoint> Endpoints { get; }
        /// <summary> The traffic flows produced in this HeatMap calculation. </summary>
        public IList<TrafficManagerHeatMapTrafficFlow> TrafficFlows { get; }
    }
}
