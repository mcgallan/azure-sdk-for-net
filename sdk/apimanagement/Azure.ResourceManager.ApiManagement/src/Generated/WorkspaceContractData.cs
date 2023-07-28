// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the WorkspaceContract data model.
    /// Workspace details.
    /// </summary>
    public partial class WorkspaceContractData : ResourceData
    {
        /// <summary> Initializes a new instance of WorkspaceContractData. </summary>
        public WorkspaceContractData()
        {
        }

        /// <summary> Initializes a new instance of WorkspaceContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Name of the workspace. </param>
        /// <param name="description"> Description of the workspace. </param>
        internal WorkspaceContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, string description) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Description = description;
        }

        /// <summary> Name of the workspace. </summary>
        public string DisplayName { get; set; }
        /// <summary> Description of the workspace. </summary>
        public string Description { get; set; }
    }
}
