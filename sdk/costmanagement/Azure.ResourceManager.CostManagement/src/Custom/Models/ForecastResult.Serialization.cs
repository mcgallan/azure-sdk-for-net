﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ForecastResult : IUtf8JsonSerializable, IJsonModel<ForecastResult>
    {
        internal static ForecastResult DeserializeForecastResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<string> sku = default;
            Optional<ETag> eTag = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ResourceManager.Models.SystemData> systemData = default;
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<ForecastColumn>> columns = default;
            Optional<IReadOnlyList<IList<BinaryData>>> rows = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
                if (property.NameEquals("id"u8))
                {
                    // Service may return resource id without '/'.
                    id = property.Value.GetString().StartsWith("/") ? new ResourceIdentifier(property.Value.GetString()) : new ResourceIdentifier($"/{property.Value.GetString()}");
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<ResourceManager.Models.SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("nextLink"u8))
                        {
                            nextLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("columns"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ForecastColumn> array = new List<ForecastColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ForecastColumn.DeserializeForecastColumn(item));
                            }
                            columns = array;
                            continue;
                        }
                        if (property0.NameEquals("rows"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IList<BinaryData>> array = new List<IList<BinaryData>>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    List<BinaryData> array0 = new List<BinaryData>();
                                    foreach (var item0 in item.EnumerateArray())
                                    {
                                        if (item0.ValueKind == JsonValueKind.Null)
                                        {
                                            array0.Add(null);
                                        }
                                        else
                                        {
                                            array0.Add(BinaryData.FromString(item0.GetRawText()));
                                        }
                                    }
                                    array.Add(array0);
                                }
                            }
                            rows = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ForecastResult(id, name, type, systemData.Value, nextLink.Value, Optional.ToList(columns), Optional.ToList(rows), Optional.ToNullable(location), sku.Value, Optional.ToNullable(eTag), Optional.ToDictionary(tags), serializedAdditionalRawData);
        }
    }
}
