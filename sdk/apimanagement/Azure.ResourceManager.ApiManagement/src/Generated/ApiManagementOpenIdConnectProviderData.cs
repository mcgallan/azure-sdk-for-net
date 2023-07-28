// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiManagementOpenIdConnectProvider data model.
    /// OpenId Connect Provider details.
    /// </summary>
    public partial class ApiManagementOpenIdConnectProviderData : ResourceData
    {
        /// <summary> Initializes a new instance of ApiManagementOpenIdConnectProviderData. </summary>
        public ApiManagementOpenIdConnectProviderData()
        {
        }

        /// <summary> Initializes a new instance of ApiManagementOpenIdConnectProviderData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> User-friendly OpenID Connect Provider name. </param>
        /// <param name="description"> User-friendly description of OpenID Connect Provider. </param>
        /// <param name="metadataEndpoint"> Metadata endpoint URI. </param>
        /// <param name="clientId"> Client ID of developer console which is the client application. </param>
        /// <param name="clientSecret"> Client Secret of developer console which is the client application. </param>
        /// <param name="useInTestConsole"> If true, the Open ID Connect provider may be used in the developer portal test console. True by default if no value is provided. </param>
        /// <param name="useInApiDocumentation"> If true, the Open ID Connect provider will be used in the API documentation in the developer portal. False by default if no value is provided. </param>
        internal ApiManagementOpenIdConnectProviderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description, string metadataEndpoint, string clientId, string clientSecret, bool? useInTestConsole, bool? useInApiDocumentation) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
            MetadataEndpoint = metadataEndpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseInTestConsole = useInTestConsole;
            UseInApiDocumentation = useInApiDocumentation;
        }

        /// <summary> User-friendly OpenID Connect Provider name. </summary>
        public string DisplayName { get; set; }
        /// <summary> User-friendly description of OpenID Connect Provider. </summary>
        public string Description { get; set; }
        /// <summary> Metadata endpoint URI. </summary>
        public string MetadataEndpoint { get; set; }
        /// <summary> Client ID of developer console which is the client application. </summary>
        public string ClientId { get; set; }
        /// <summary> Client Secret of developer console which is the client application. </summary>
        public string ClientSecret { get; set; }
        /// <summary> If true, the Open ID Connect provider may be used in the developer portal test console. True by default if no value is provided. </summary>
        public bool? UseInTestConsole { get; set; }
        /// <summary> If true, the Open ID Connect provider will be used in the API documentation in the developer portal. False by default if no value is provided. </summary>
        public bool? UseInApiDocumentation { get; set; }
    }
}
