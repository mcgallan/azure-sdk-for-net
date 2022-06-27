// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The resource reference. </summary>
    public partial class ResourceReference
    {
        /// <summary> Initializes a new instance of ResourceReference. </summary>
        public ResourceReference()
        {
        }

        /// <summary> Initializes a new instance of ResourceReference. </summary>
        /// <param name="id"> The resource id. </param>
        /// <param name="name"> Gets the resource name. </param>
        /// <param name="resourceType"> Gets the resource type. </param>
        internal ResourceReference(string id, string name, string resourceType)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> The resource id. </summary>
        public string Id { get; set; }
        /// <summary> Gets the resource name. </summary>
        public string Name { get; }
        /// <summary> Gets the resource type. </summary>
        public string ResourceType { get; }
    }
}
