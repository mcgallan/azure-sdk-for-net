// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class RoutingEnrichments : IUtf8JsonSerializable, IJsonModel<RoutingEnrichments>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingEnrichments>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoutingEnrichments>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingEnrichments>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingEnrichments)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Static))
            {
                writer.WritePropertyName("static"u8);
                writer.WriteStartArray();
                foreach (var item in Static)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Dynamic))
            {
                writer.WritePropertyName("dynamic"u8);
                writer.WriteStartArray();
                foreach (var item in Dynamic)
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

        RoutingEnrichments IJsonModel<RoutingEnrichments>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingEnrichments>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingEnrichments)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingEnrichments(document.RootElement, options);
        }

        internal static RoutingEnrichments DeserializeRoutingEnrichments(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<StaticRoutingEnrichment>> @static = default;
            Optional<IList<DynamicRoutingEnrichment>> @dynamic = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("static"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRoutingEnrichment> array = new List<StaticRoutingEnrichment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticRoutingEnrichment.DeserializeStaticRoutingEnrichment(item));
                    }
                    @static = array;
                    continue;
                }
                if (property.NameEquals("dynamic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DynamicRoutingEnrichment> array = new List<DynamicRoutingEnrichment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DynamicRoutingEnrichment.DeserializeDynamicRoutingEnrichment(item));
                    }
                    @dynamic = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoutingEnrichments(Optional.ToList(@static), Optional.ToList(@dynamic), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingEnrichments>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingEnrichments>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoutingEnrichments)} does not support '{options.Format}' format.");
            }
        }

        RoutingEnrichments IPersistableModel<RoutingEnrichments>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingEnrichments>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoutingEnrichments(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingEnrichments)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingEnrichments>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
