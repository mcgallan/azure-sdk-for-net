// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class LatencyScorecard : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LatencyMetrics))
            {
                writer.WritePropertyName("latencyMetrics");
                writer.WriteStartArray();
                foreach (var item in LatencyMetrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LatencyScorecard DeserializeLatencyScorecard(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> id0 = default;
            Optional<string> name0 = default;
            Optional<string> description = default;
            Optional<string> endpointA = default;
            Optional<string> endpointB = default;
            Optional<DateTimeOffset> startDateTimeUTC = default;
            Optional<DateTimeOffset> endDateTimeUTC = default;
            Optional<string> country = default;
            Optional<IList<LatencyMetric>> latencyMetrics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new Core.ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"))
                        {
                            id0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("name"))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointA"))
                        {
                            endpointA = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointB"))
                        {
                            endpointB = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startDateTimeUTC"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startDateTimeUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTimeUTC"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endDateTimeUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("country"))
                        {
                            country = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("latencyMetrics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<LatencyMetric> array = new List<LatencyMetric>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LatencyMetric.DeserializeLatencyMetric(item));
                            }
                            latencyMetrics = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LatencyScorecard(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, id0.Value, name0.Value, description.Value, endpointA.Value, endpointB.Value, Optional.ToNullable(startDateTimeUTC), Optional.ToNullable(endDateTimeUTC), country.Value, Optional.ToList(latencyMetrics));
        }
    }
}
