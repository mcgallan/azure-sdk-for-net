// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FluidRelay.Models
{
    public partial class FluidRelayServerKeys : IUtf8JsonSerializable, IJsonModel<FluidRelayServerKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FluidRelayServerKeys>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FluidRelayServerKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FluidRelayServerKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FluidRelayServerKeys)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("key1"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("key2"u8);
                writer.WriteStringValue(SecondaryKey);
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

        FluidRelayServerKeys IJsonModel<FluidRelayServerKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FluidRelayServerKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FluidRelayServerKeys)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFluidRelayServerKeys(document.RootElement, options);
        }

        internal static FluidRelayServerKeys DeserializeFluidRelayServerKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key1 = default;
            Optional<string> key2 = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key1"u8))
                {
                    key1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FluidRelayServerKeys(key1.Value, key2.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FluidRelayServerKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FluidRelayServerKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FluidRelayServerKeys)} does not support '{options.Format}' format.");
            }
        }

        FluidRelayServerKeys IPersistableModel<FluidRelayServerKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FluidRelayServerKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFluidRelayServerKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FluidRelayServerKeys)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FluidRelayServerKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
