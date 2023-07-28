// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ProductApiLinkContract data model.
    /// Product-API link details.
    /// </summary>
    public partial class ProductApiLinkContractData : ResourceData
    {
        /// <summary> Initializes a new instance of ProductApiLinkContractData. </summary>
        public ProductApiLinkContractData()
        {
        }

        /// <summary> Initializes a new instance of ProductApiLinkContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="apiId"> Full resource Id of an API. </param>
        internal ProductApiLinkContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string apiId) : base(id, name, resourceType, systemData)
        {
            ApiId = apiId;
        }

        /// <summary> Full resource Id of an API. </summary>
        public string ApiId { get; set; }
    }
}
