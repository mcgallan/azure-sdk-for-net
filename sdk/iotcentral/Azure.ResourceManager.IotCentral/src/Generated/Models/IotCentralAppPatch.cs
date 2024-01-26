// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.IotCentral;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> The description of the IoT Central application. </summary>
    public partial class IotCentralAppPatch
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

        /// <summary> Initializes a new instance of <see cref="IotCentralAppPatch"/>. </summary>
        public IotCentralAppPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<IotCentralPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralAppPatch"/>. </summary>
        /// <param name="tags"> Instance tags. </param>
        /// <param name="sku"> A valid instance SKU. </param>
        /// <param name="identity"> The managed identities for the IoT Central application. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="provisioningState"> The provisioning state of the application. </param>
        /// <param name="applicationId"> The ID of the application. </param>
        /// <param name="displayName"> The display name of the application. </param>
        /// <param name="subdomain"> The subdomain of the application. </param>
        /// <param name="template"> The ID of the application template, which is a blueprint that defines the characteristics and behaviors of an application. Optional; if not specified, defaults to a blank blueprint and allows the application to be defined from scratch. </param>
        /// <param name="state"> The current state of the application. </param>
        /// <param name="publicNetworkAccess"> Whether requests from the public network are allowed. </param>
        /// <param name="networkRuleSets"> Network Rule Set Properties of this IoT Central application. </param>
        /// <param name="privateEndpointConnections"> Private endpoint connections created on this IoT Central application. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotCentralAppPatch(IDictionary<string, string> tags, IotCentralAppSkuInfo sku, ManagedServiceIdentity identity, IotCentralProvisioningState? provisioningState, Guid? applicationId, string displayName, string subdomain, string template, IotCentralAppState? state, IotCentralPublicNetworkAccess? publicNetworkAccess, IotCentralNetworkRuleSets networkRuleSets, IReadOnlyList<IotCentralPrivateEndpointConnectionData> privateEndpointConnections, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Sku = sku;
            Identity = identity;
            ProvisioningState = provisioningState;
            ApplicationId = applicationId;
            DisplayName = displayName;
            Subdomain = subdomain;
            Template = template;
            State = state;
            PublicNetworkAccess = publicNetworkAccess;
            NetworkRuleSets = networkRuleSets;
            PrivateEndpointConnections = privateEndpointConnections;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Instance tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> A valid instance SKU. </summary>
        internal IotCentralAppSkuInfo Sku { get; set; }
        /// <summary> The name of the SKU. </summary>
        public IotCentralAppSku? SkuName
        {
            get => Sku is null ? default(IotCentralAppSku?) : Sku.Name;
            set
            {
                Sku = value.HasValue ? new IotCentralAppSkuInfo(value.Value) : null;
            }
        }

        /// <summary> The managed identities for the IoT Central application. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The provisioning state of the application. </summary>
        public IotCentralProvisioningState? ProvisioningState { get; }
        /// <summary> The ID of the application. </summary>
        public Guid? ApplicationId { get; }
        /// <summary> The display name of the application. </summary>
        public string DisplayName { get; set; }
        /// <summary> The subdomain of the application. </summary>
        public string Subdomain { get; set; }
        /// <summary> The ID of the application template, which is a blueprint that defines the characteristics and behaviors of an application. Optional; if not specified, defaults to a blank blueprint and allows the application to be defined from scratch. </summary>
        public string Template { get; set; }
        /// <summary> The current state of the application. </summary>
        public IotCentralAppState? State { get; }
        /// <summary> Whether requests from the public network are allowed. </summary>
        public IotCentralPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Network Rule Set Properties of this IoT Central application. </summary>
        public IotCentralNetworkRuleSets NetworkRuleSets { get; set; }
        /// <summary> Private endpoint connections created on this IoT Central application. </summary>
        public IReadOnlyList<IotCentralPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
