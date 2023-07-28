// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the DocumentationContract data model.
    /// Markdown documentation details.
    /// </summary>
    public partial class DocumentationContractData : ResourceData
    {
        /// <summary> Initializes a new instance of DocumentationContractData. </summary>
        public DocumentationContractData()
        {
        }

        /// <summary> Initializes a new instance of DocumentationContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="title"> documentation title. </param>
        /// <param name="content"> Markdown documentation content. </param>
        internal DocumentationContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string title, string content) : base(id, name, resourceType, systemData)
        {
            Title = title;
            Content = content;
        }

        /// <summary> documentation title. </summary>
        public string Title { get; set; }
        /// <summary> Markdown documentation content. </summary>
        public string Content { get; set; }
    }
}
