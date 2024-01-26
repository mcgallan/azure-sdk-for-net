// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class GrafanaAvailablePlugin : IUtf8JsonSerializable, IJsonModel<GrafanaAvailablePlugin>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GrafanaAvailablePlugin>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GrafanaAvailablePlugin>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaAvailablePlugin>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GrafanaAvailablePlugin)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PluginId))
            {
                writer.WritePropertyName("pluginId"u8);
                writer.WriteStringValue(PluginId);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        GrafanaAvailablePlugin IJsonModel<GrafanaAvailablePlugin>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaAvailablePlugin>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GrafanaAvailablePlugin)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGrafanaAvailablePlugin(document.RootElement, options);
        }

        internal static GrafanaAvailablePlugin DeserializeGrafanaAvailablePlugin(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> pluginId = default;
            Optional<string> name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pluginId"u8))
                {
                    pluginId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GrafanaAvailablePlugin(pluginId.Value, name.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GrafanaAvailablePlugin>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaAvailablePlugin>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GrafanaAvailablePlugin)} does not support '{options.Format}' format.");
            }
        }

        GrafanaAvailablePlugin IPersistableModel<GrafanaAvailablePlugin>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaAvailablePlugin>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGrafanaAvailablePlugin(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GrafanaAvailablePlugin)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GrafanaAvailablePlugin>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
