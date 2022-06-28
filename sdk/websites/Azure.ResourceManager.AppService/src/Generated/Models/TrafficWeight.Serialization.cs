// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class TrafficWeight : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RevisionName))
            {
                writer.WritePropertyName("revisionName");
                writer.WriteStringValue(RevisionName);
            }
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight");
                writer.WriteNumberValue(Weight.Value);
            }
            if (Optional.IsDefined(LatestRevision))
            {
                writer.WritePropertyName("latestRevision");
                writer.WriteBooleanValue(LatestRevision.Value);
            }
            writer.WriteEndObject();
        }

        internal static TrafficWeight DeserializeTrafficWeight(JsonElement element)
        {
            Optional<string> revisionName = default;
            Optional<int> weight = default;
            Optional<bool> latestRevision = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("revisionName"))
                {
                    revisionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weight"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    weight = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("latestRevision"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    latestRevision = property.Value.GetBoolean();
                    continue;
                }
            }
            return new TrafficWeight(revisionName.Value, Optional.ToNullable(weight), Optional.ToNullable(latestRevision));
        }
    }
}
