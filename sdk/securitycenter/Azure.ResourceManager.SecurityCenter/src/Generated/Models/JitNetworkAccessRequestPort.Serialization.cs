// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessRequestPort : IUtf8JsonSerializable, IJsonModel<JitNetworkAccessRequestPort>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JitNetworkAccessRequestPort>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JitNetworkAccessRequestPort>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessRequestPort>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessRequestPort)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("number"u8);
            writer.WriteNumberValue(Number);
            if (Optional.IsDefined(AllowedSourceAddressPrefix))
            {
                writer.WritePropertyName("allowedSourceAddressPrefix"u8);
                writer.WriteStringValue(AllowedSourceAddressPrefix);
            }
            if (Optional.IsCollectionDefined(AllowedSourceAddressPrefixes))
            {
                writer.WritePropertyName("allowedSourceAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedSourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("endTimeUtc"u8);
            writer.WriteStringValue(EndOn, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("statusReason"u8);
            writer.WriteStringValue(StatusReason.ToString());
            if (Optional.IsDefined(MappedPort))
            {
                writer.WritePropertyName("mappedPort"u8);
                writer.WriteNumberValue(MappedPort.Value);
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

        JitNetworkAccessRequestPort IJsonModel<JitNetworkAccessRequestPort>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessRequestPort>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessRequestPort)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJitNetworkAccessRequestPort(document.RootElement, options);
        }

        internal static JitNetworkAccessRequestPort DeserializeJitNetworkAccessRequestPort(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int number = default;
            Optional<string> allowedSourceAddressPrefix = default;
            Optional<IList<string>> allowedSourceAddressPrefixes = default;
            DateTimeOffset endTimeUtc = default;
            JitNetworkAccessPortStatus status = default;
            JitNetworkAccessPortStatusReason statusReason = default;
            Optional<int> mappedPort = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("number"u8))
                {
                    number = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowedSourceAddressPrefix"u8))
                {
                    allowedSourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedSourceAddressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedSourceAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("endTimeUtc"u8))
                {
                    endTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new JitNetworkAccessPortStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusReason"u8))
                {
                    statusReason = new JitNetworkAccessPortStatusReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mappedPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mappedPort = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JitNetworkAccessRequestPort(number, allowedSourceAddressPrefix.Value, Optional.ToList(allowedSourceAddressPrefixes), endTimeUtc, status, statusReason, Optional.ToNullable(mappedPort), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JitNetworkAccessRequestPort>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessRequestPort>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessRequestPort)} does not support '{options.Format}' format.");
            }
        }

        JitNetworkAccessRequestPort IPersistableModel<JitNetworkAccessRequestPort>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessRequestPort>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJitNetworkAccessRequestPort(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessRequestPort)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JitNetworkAccessRequestPort>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
