// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Private link service proxy details. </summary>
    public partial class DeviceUpdatePrivateLinkServiceProxy
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

        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateLinkServiceProxy"/>. </summary>
        public DeviceUpdatePrivateLinkServiceProxy()
        {
            GroupConnectivityInformation = new ChangeTrackingList<GroupConnectivityInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="DeviceUpdatePrivateLinkServiceProxy"/>. </summary>
        /// <param name="id"> NRP resource ID. </param>
        /// <param name="remotePrivateLinkServiceConnectionState"> Remote private link service connection state. </param>
        /// <param name="remotePrivateEndpointConnection"> Remote private endpoint connection details. </param>
        /// <param name="groupConnectivityInformation"> Group connectivity information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceUpdatePrivateLinkServiceProxy(ResourceIdentifier id, DeviceUpdatePrivateLinkServiceConnectionState remotePrivateLinkServiceConnectionState, SubResource remotePrivateEndpointConnection, IList<GroupConnectivityInformation> groupConnectivityInformation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            RemotePrivateLinkServiceConnectionState = remotePrivateLinkServiceConnectionState;
            RemotePrivateEndpointConnection = remotePrivateEndpointConnection;
            GroupConnectivityInformation = groupConnectivityInformation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> NRP resource ID. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Remote private link service connection state. </summary>
        public DeviceUpdatePrivateLinkServiceConnectionState RemotePrivateLinkServiceConnectionState { get; set; }
        /// <summary> Remote private endpoint connection details. </summary>
        internal SubResource RemotePrivateEndpointConnection { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier RemotePrivateEndpointConnectionId
        {
            get => RemotePrivateEndpointConnection is null ? default : RemotePrivateEndpointConnection.Id;
        }

        /// <summary> Group connectivity information. </summary>
        public IList<GroupConnectivityInformation> GroupConnectivityInformation { get; }
    }
}
