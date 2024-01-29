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
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServerConfigurationData : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerConfigurationData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(CurrentValue))
            {
                writer.WritePropertyName("currentValue"u8);
                writer.WriteStringValue(CurrentValue);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(DocumentationLink))
            {
                writer.WritePropertyName("documentationLink"u8);
                writer.WriteStringValue(DocumentationLink);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (options.Format != "W" && Optional.IsDefined(DataType))
            {
                writer.WritePropertyName("dataType"u8);
                writer.WriteStringValue(DataType);
            }
            if (options.Format != "W" && Optional.IsDefined(AllowedValues))
            {
                writer.WritePropertyName("allowedValues"u8);
                writer.WriteStringValue(AllowedValues);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsReadOnly))
            {
                writer.WritePropertyName("isReadOnly"u8);
                writer.WriteStringValue(IsReadOnly.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsConfigPendingRestart))
            {
                writer.WritePropertyName("isConfigPendingRestart"u8);
                writer.WriteStringValue(IsConfigPendingRestart.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsDynamicConfig))
            {
                writer.WritePropertyName("isDynamicConfig"u8);
                writer.WriteStringValue(IsDynamicConfig.Value.ToString());
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

        MySqlFlexibleServerConfigurationData IJsonModel<MySqlFlexibleServerConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerConfigurationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerConfigurationData(document.RootElement, options);
        }

        internal static MySqlFlexibleServerConfigurationData DeserializeMySqlFlexibleServerConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> value = default;
            Optional<string> currentValue = default;
            Optional<string> description = default;
            Optional<string> documentationLink = default;
            Optional<string> defaultValue = default;
            Optional<string> dataType = default;
            Optional<string> allowedValues = default;
            Optional<MySqlFlexibleServerConfigurationSource> source = default;
            Optional<MySqlFlexibleServerConfigReadOnlyState> isReadOnly = default;
            Optional<MySqlFlexibleServerConfigPendingRestartState> isConfigPendingRestart = default;
            Optional<MySqlFlexibleServerConfigDynamicState> isDynamicConfig = default;
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
                        if (property0.NameEquals("value"u8))
                        {
                            value = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentValue"u8))
                        {
                            currentValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentationLink"u8))
                        {
                            documentationLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultValue"u8))
                        {
                            defaultValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataType"u8))
                        {
                            dataType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowedValues"u8))
                        {
                            allowedValues = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new MySqlFlexibleServerConfigurationSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isReadOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isReadOnly = new MySqlFlexibleServerConfigReadOnlyState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isConfigPendingRestart"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isConfigPendingRestart = new MySqlFlexibleServerConfigPendingRestartState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isDynamicConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDynamicConfig = new MySqlFlexibleServerConfigDynamicState(property0.Value.GetString());
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
            return new MySqlFlexibleServerConfigurationData(id, name, type, systemData.Value, value.Value, currentValue.Value, description.Value, documentationLink.Value, defaultValue.Value, dataType.Value, allowedValues.Value, Optional.ToNullable(source), Optional.ToNullable(isReadOnly), Optional.ToNullable(isConfigPendingRestart), Optional.ToNullable(isDynamicConfig), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerConfigurationData IPersistableModel<MySqlFlexibleServerConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
