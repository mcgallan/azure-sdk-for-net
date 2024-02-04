// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerEditionCapability : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerEditionCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerEditionCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerEditionCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerEditionCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerEditionCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedStorageEditions))
            {
                writer.WritePropertyName("supportedStorageEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedStorageEditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedServerVersions))
            {
                writer.WritePropertyName("supportedServerVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedServerVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        MySqlFlexibleServerEditionCapability IJsonModel<MySqlFlexibleServerEditionCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerEditionCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerEditionCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerEditionCapability(document.RootElement, options);
        }

        internal static MySqlFlexibleServerEditionCapability DeserializeMySqlFlexibleServerEditionCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<MySqlFlexibleServerStorageEditionCapability>> supportedStorageEditions = default;
            Optional<IReadOnlyList<MySqlFlexibleServerServerVersionCapability>> supportedServerVersions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedStorageEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerStorageEditionCapability> array = new List<MySqlFlexibleServerStorageEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerStorageEditionCapability.DeserializeMySqlFlexibleServerStorageEditionCapability(item));
                    }
                    supportedStorageEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedServerVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerServerVersionCapability> array = new List<MySqlFlexibleServerServerVersionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerServerVersionCapability.DeserializeMySqlFlexibleServerServerVersionCapability(item));
                    }
                    supportedServerVersions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerEditionCapability(name.Value, Optional.ToList(supportedStorageEditions), Optional.ToList(supportedServerVersions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerEditionCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerEditionCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerEditionCapability)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerEditionCapability IPersistableModel<MySqlFlexibleServerEditionCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerEditionCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerEditionCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerEditionCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerEditionCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
