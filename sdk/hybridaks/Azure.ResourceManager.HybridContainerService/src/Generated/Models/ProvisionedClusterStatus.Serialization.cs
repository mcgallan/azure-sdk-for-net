// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClusterStatus
    {
        internal static ProvisionedClusterStatus DeserializeProvisionedClusterStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ProvisionedClusterAddonStatusProfile>> controlPlaneStatus = default;
            Optional<HybridContainerServiceResourceProvisioningState> currentState = default;
            Optional<string> errorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("controlPlaneStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProvisionedClusterAddonStatusProfile> array = new List<ProvisionedClusterAddonStatusProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProvisionedClusterAddonStatusProfile.DeserializeProvisionedClusterAddonStatusProfile(item));
                    }
                    controlPlaneStatus = array;
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = new HybridContainerServiceResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new ProvisionedClusterStatus(Optional.ToList(controlPlaneStatus), Optional.ToNullable(currentState), errorMessage.Value);
        }
    }
}
