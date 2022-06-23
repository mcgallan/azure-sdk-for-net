// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ServerConnectionPolicy data model. </summary>
    public partial class ServerConnectionPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of ServerConnectionPolicyData. </summary>
        public ServerConnectionPolicyData()
        {
        }

        /// <summary> Initializes a new instance of ServerConnectionPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Metadata used for the Azure portal experience. </param>
        /// <param name="connectionType"> The server connection type. </param>
        internal ServerConnectionPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string kind, ServerConnectionType? connectionType) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Kind = kind;
            ConnectionType = connectionType;
        }

        /// <summary> Resource location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> The server connection type. </summary>
        public ServerConnectionType? ConnectionType { get; set; }
    }
}
