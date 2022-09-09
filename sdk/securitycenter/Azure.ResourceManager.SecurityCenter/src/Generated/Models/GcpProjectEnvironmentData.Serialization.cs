// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpProjectEnvironmentData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OrganizationalData))
            {
                writer.WritePropertyName("organizationalData");
                writer.WriteObjectValue(OrganizationalData);
            }
            if (Optional.IsDefined(ProjectDetails))
            {
                writer.WritePropertyName("projectDetails");
                writer.WriteObjectValue(ProjectDetails);
            }
            writer.WritePropertyName("environmentType");
            writer.WriteStringValue(EnvironmentType.ToString());
            writer.WriteEndObject();
        }

        internal static GcpProjectEnvironmentData DeserializeGcpProjectEnvironmentData(JsonElement element)
        {
            Optional<GcpOrganizationalData> organizationalData = default;
            Optional<GcpProjectDetails> projectDetails = default;
            EnvironmentType environmentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("organizationalData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    organizationalData = GcpOrganizationalData.DeserializeGcpOrganizationalData(property.Value);
                    continue;
                }
                if (property.NameEquals("projectDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    projectDetails = GcpProjectDetails.DeserializeGcpProjectDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentType"))
                {
                    environmentType = new EnvironmentType(property.Value.GetString());
                    continue;
                }
            }
            return new GcpProjectEnvironmentData(environmentType, organizationalData.Value, projectDetails.Value);
        }
    }
}
