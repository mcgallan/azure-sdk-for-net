// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServerDnsAliasAcquisition : IUtf8JsonSerializable, IJsonModel<ServerDnsAliasAcquisition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerDnsAliasAcquisition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServerDnsAliasAcquisition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerDnsAliasAcquisition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerDnsAliasAcquisition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("oldServerDnsAliasId"u8);
            writer.WriteStringValue(OldServerDnsAliasId);
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

        ServerDnsAliasAcquisition IJsonModel<ServerDnsAliasAcquisition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerDnsAliasAcquisition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerDnsAliasAcquisition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerDnsAliasAcquisition(document.RootElement, options);
        }

        internal static ServerDnsAliasAcquisition DeserializeServerDnsAliasAcquisition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier oldServerDnsAliasId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oldServerDnsAliasId"u8))
                {
                    oldServerDnsAliasId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServerDnsAliasAcquisition(oldServerDnsAliasId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerDnsAliasAcquisition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerDnsAliasAcquisition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerDnsAliasAcquisition)} does not support '{options.Format}' format.");
            }
        }

        ServerDnsAliasAcquisition IPersistableModel<ServerDnsAliasAcquisition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerDnsAliasAcquisition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerDnsAliasAcquisition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerDnsAliasAcquisition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerDnsAliasAcquisition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
