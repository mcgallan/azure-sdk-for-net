// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterClientCertificateCommonName : IUtf8JsonSerializable, IJsonModel<ClusterClientCertificateCommonName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterClientCertificateCommonName>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterClientCertificateCommonName>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterClientCertificateCommonName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterClientCertificateCommonName)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("isAdmin"u8);
            writer.WriteBooleanValue(IsAdmin);
            writer.WritePropertyName("certificateCommonName"u8);
            writer.WriteStringValue(CertificateCommonName);
            writer.WritePropertyName("certificateIssuerThumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CertificateIssuerThumbprint);
#else
            using (JsonDocument document = JsonDocument.Parse(CertificateIssuerThumbprint))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
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

        ClusterClientCertificateCommonName IJsonModel<ClusterClientCertificateCommonName>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterClientCertificateCommonName>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterClientCertificateCommonName)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterClientCertificateCommonName(document.RootElement, options);
        }

        internal static ClusterClientCertificateCommonName DeserializeClusterClientCertificateCommonName(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isAdmin = default;
            string certificateCommonName = default;
            BinaryData certificateIssuerThumbprint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAdmin"u8))
                {
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificateCommonName"u8))
                {
                    certificateCommonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateIssuerThumbprint"u8))
                {
                    certificateIssuerThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterClientCertificateCommonName(isAdmin, certificateCommonName, certificateIssuerThumbprint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterClientCertificateCommonName>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterClientCertificateCommonName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterClientCertificateCommonName)} does not support '{options.Format}' format.");
            }
        }

        ClusterClientCertificateCommonName IPersistableModel<ClusterClientCertificateCommonName>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterClientCertificateCommonName>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterClientCertificateCommonName(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterClientCertificateCommonName)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterClientCertificateCommonName>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
