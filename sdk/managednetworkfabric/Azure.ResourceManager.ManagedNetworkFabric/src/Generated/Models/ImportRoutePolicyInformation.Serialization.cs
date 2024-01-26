// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ImportRoutePolicyInformation : IUtf8JsonSerializable, IJsonModel<ImportRoutePolicyInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImportRoutePolicyInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImportRoutePolicyInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRoutePolicyInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportRoutePolicyInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ImportIPv4RoutePolicyId))
            {
                writer.WritePropertyName("importIpv4RoutePolicyId"u8);
                writer.WriteStringValue(ImportIPv4RoutePolicyId);
            }
            if (Optional.IsDefined(ImportIPv6RoutePolicyId))
            {
                writer.WritePropertyName("importIpv6RoutePolicyId"u8);
                writer.WriteStringValue(ImportIPv6RoutePolicyId);
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

        ImportRoutePolicyInformation IJsonModel<ImportRoutePolicyInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRoutePolicyInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportRoutePolicyInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImportRoutePolicyInformation(document.RootElement, options);
        }

        internal static ImportRoutePolicyInformation DeserializeImportRoutePolicyInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> importIPv4RoutePolicyId = default;
            Optional<ResourceIdentifier> importIPv6RoutePolicyId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("importIpv4RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importIPv4RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("importIpv6RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importIPv6RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImportRoutePolicyInformation(importIPv4RoutePolicyId.Value, importIPv6RoutePolicyId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImportRoutePolicyInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRoutePolicyInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImportRoutePolicyInformation)} does not support '{options.Format}' format.");
            }
        }

        ImportRoutePolicyInformation IPersistableModel<ImportRoutePolicyInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRoutePolicyInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImportRoutePolicyInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImportRoutePolicyInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImportRoutePolicyInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
