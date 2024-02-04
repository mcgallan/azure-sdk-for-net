// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class RelayServiceConnectionEntityData : IUtf8JsonSerializable, IJsonModel<RelayServiceConnectionEntityData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RelayServiceConnectionEntityData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RelayServiceConnectionEntityData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelayServiceConnectionEntityData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelayServiceConnectionEntityData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EntityName))
            {
                writer.WritePropertyName("entityName"u8);
                writer.WriteStringValue(EntityName);
            }
            if (Optional.IsDefined(EntityConnectionString))
            {
                writer.WritePropertyName("entityConnectionString"u8);
                writer.WriteStringValue(EntityConnectionString);
            }
            if (Optional.IsDefined(ResourceConnectionString))
            {
                writer.WritePropertyName("resourceConnectionString"u8);
                writer.WriteStringValue(ResourceConnectionString);
            }
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(BiztalkUri))
            {
                writer.WritePropertyName("biztalkUri"u8);
                writer.WriteStringValue(BiztalkUri.AbsoluteUri);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RelayServiceConnectionEntityData IJsonModel<RelayServiceConnectionEntityData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelayServiceConnectionEntityData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RelayServiceConnectionEntityData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRelayServiceConnectionEntityData(document.RootElement, options);
        }

        internal static RelayServiceConnectionEntityData DeserializeRelayServiceConnectionEntityData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> entityName = default;
            Optional<string> entityConnectionString = default;
            Optional<string> resourceConnectionString = default;
            Optional<string> hostname = default;
            Optional<int> port = default;
            Optional<Uri> biztalkUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
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
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("entityName"u8))
                        {
                            entityName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("entityConnectionString"u8))
                        {
                            entityConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceConnectionString"u8))
                        {
                            resourceConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostname"u8))
                        {
                            hostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("biztalkUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            biztalkUri = new Uri(property0.Value.GetString());
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
            return new RelayServiceConnectionEntityData(id, name, type, systemData.Value, entityName.Value, entityConnectionString.Value, resourceConnectionString.Value, hostname.Value, Optional.ToNullable(port), biztalkUri.Value, kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RelayServiceConnectionEntityData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelayServiceConnectionEntityData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RelayServiceConnectionEntityData)} does not support '{options.Format}' format.");
            }
        }

        RelayServiceConnectionEntityData IPersistableModel<RelayServiceConnectionEntityData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RelayServiceConnectionEntityData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRelayServiceConnectionEntityData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RelayServiceConnectionEntityData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RelayServiceConnectionEntityData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
