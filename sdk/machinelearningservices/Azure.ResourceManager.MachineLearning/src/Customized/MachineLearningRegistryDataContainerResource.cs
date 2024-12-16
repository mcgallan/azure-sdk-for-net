// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    // Override the "ValidateResourceId" method since the resource id is not correctly formatted
    public partial class MachineLearningRegistryDataContainerResource
    {
        internal static void ValidateResourceId(ResourceIdentifier id)
        {
        }
    }
}
