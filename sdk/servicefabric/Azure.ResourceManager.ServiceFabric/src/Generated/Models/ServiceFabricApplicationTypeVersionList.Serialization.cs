// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    internal partial class ServiceFabricApplicationTypeVersionList : IUtf8JsonSerializable, IJsonModel<ServiceFabricApplicationTypeVersionList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceFabricApplicationTypeVersionList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceFabricApplicationTypeVersionList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricApplicationTypeVersionList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricApplicationTypeVersionList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        ServiceFabricApplicationTypeVersionList IJsonModel<ServiceFabricApplicationTypeVersionList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricApplicationTypeVersionList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricApplicationTypeVersionList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricApplicationTypeVersionList(document.RootElement, options);
        }

        internal static ServiceFabricApplicationTypeVersionList DeserializeServiceFabricApplicationTypeVersionList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ServiceFabricApplicationTypeVersionData>> value = default;
            Optional<string> nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceFabricApplicationTypeVersionData> array = new List<ServiceFabricApplicationTypeVersionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceFabricApplicationTypeVersionData.DeserializeServiceFabricApplicationTypeVersionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceFabricApplicationTypeVersionList(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceFabricApplicationTypeVersionList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricApplicationTypeVersionList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricApplicationTypeVersionList)} does not support '{options.Format}' format.");
            }
        }

        ServiceFabricApplicationTypeVersionList IPersistableModel<ServiceFabricApplicationTypeVersionList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricApplicationTypeVersionList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceFabricApplicationTypeVersionList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricApplicationTypeVersionList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceFabricApplicationTypeVersionList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
