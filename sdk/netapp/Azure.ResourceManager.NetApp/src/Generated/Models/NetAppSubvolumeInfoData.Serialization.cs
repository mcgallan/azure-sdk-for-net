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

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppSubvolumeInfoData : IUtf8JsonSerializable, IJsonModel<NetAppSubvolumeInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppSubvolumeInfoData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppSubvolumeInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppSubvolumeInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppSubvolumeInfoData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Size))
            {
                if (Size != null)
                {
                    writer.WritePropertyName("size"u8);
                    writer.WriteNumberValue(Size.Value);
                }
                else
                {
                    writer.WriteNull("size");
                }
            }
            if (Optional.IsDefined(ParentPath))
            {
                if (ParentPath != null)
                {
                    writer.WritePropertyName("parentPath"u8);
                    writer.WriteStringValue(ParentPath);
                }
                else
                {
                    writer.WriteNull("parentPath");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
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

        NetAppSubvolumeInfoData IJsonModel<NetAppSubvolumeInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppSubvolumeInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppSubvolumeInfoData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppSubvolumeInfoData(document.RootElement, options);
        }

        internal static NetAppSubvolumeInfoData DeserializeNetAppSubvolumeInfoData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> path = default;
            Optional<long?> size = default;
            Optional<string> parentPath = default;
            Optional<string> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                size = null;
                                continue;
                            }
                            size = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("parentPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                parentPath = null;
                                continue;
                            }
                            parentPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
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
            return new NetAppSubvolumeInfoData(id, name, type, systemData.Value, path.Value, Optional.ToNullable(size), parentPath.Value, provisioningState.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppSubvolumeInfoData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppSubvolumeInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppSubvolumeInfoData)} does not support '{options.Format}' format.");
            }
        }

        NetAppSubvolumeInfoData IPersistableModel<NetAppSubvolumeInfoData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppSubvolumeInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppSubvolumeInfoData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppSubvolumeInfoData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppSubvolumeInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
