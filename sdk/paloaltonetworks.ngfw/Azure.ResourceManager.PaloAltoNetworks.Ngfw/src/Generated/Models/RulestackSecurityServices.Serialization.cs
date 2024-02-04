// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class RulestackSecurityServices : IUtf8JsonSerializable, IJsonModel<RulestackSecurityServices>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RulestackSecurityServices>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RulestackSecurityServices>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulestackSecurityServices>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RulestackSecurityServices)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VulnerabilityProfile))
            {
                writer.WritePropertyName("vulnerabilityProfile"u8);
                writer.WriteStringValue(VulnerabilityProfile);
            }
            if (Optional.IsDefined(AntiSpywareProfile))
            {
                writer.WritePropertyName("antiSpywareProfile"u8);
                writer.WriteStringValue(AntiSpywareProfile);
            }
            if (Optional.IsDefined(AntiVirusProfile))
            {
                writer.WritePropertyName("antiVirusProfile"u8);
                writer.WriteStringValue(AntiVirusProfile);
            }
            if (Optional.IsDefined(UrlFilteringProfile))
            {
                writer.WritePropertyName("urlFilteringProfile"u8);
                writer.WriteStringValue(UrlFilteringProfile);
            }
            if (Optional.IsDefined(FileBlockingProfile))
            {
                writer.WritePropertyName("fileBlockingProfile"u8);
                writer.WriteStringValue(FileBlockingProfile);
            }
            if (Optional.IsDefined(DnsSubscription))
            {
                writer.WritePropertyName("dnsSubscription"u8);
                writer.WriteStringValue(DnsSubscription);
            }
            if (Optional.IsDefined(OutboundUnTrustCertificate))
            {
                writer.WritePropertyName("outboundUnTrustCertificate"u8);
                writer.WriteStringValue(OutboundUnTrustCertificate);
            }
            if (Optional.IsDefined(OutboundTrustCertificate))
            {
                writer.WritePropertyName("outboundTrustCertificate"u8);
                writer.WriteStringValue(OutboundTrustCertificate);
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

        RulestackSecurityServices IJsonModel<RulestackSecurityServices>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulestackSecurityServices>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RulestackSecurityServices)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRulestackSecurityServices(document.RootElement, options);
        }

        internal static RulestackSecurityServices DeserializeRulestackSecurityServices(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vulnerabilityProfile = default;
            Optional<string> antiSpywareProfile = default;
            Optional<string> antiVirusProfile = default;
            Optional<string> urlFilteringProfile = default;
            Optional<string> fileBlockingProfile = default;
            Optional<string> dnsSubscription = default;
            Optional<string> outboundUnTrustCertificate = default;
            Optional<string> outboundTrustCertificate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vulnerabilityProfile"u8))
                {
                    vulnerabilityProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("antiSpywareProfile"u8))
                {
                    antiSpywareProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("antiVirusProfile"u8))
                {
                    antiVirusProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urlFilteringProfile"u8))
                {
                    urlFilteringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileBlockingProfile"u8))
                {
                    fileBlockingProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsSubscription"u8))
                {
                    dnsSubscription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundUnTrustCertificate"u8))
                {
                    outboundUnTrustCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundTrustCertificate"u8))
                {
                    outboundTrustCertificate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RulestackSecurityServices(vulnerabilityProfile.Value, antiSpywareProfile.Value, antiVirusProfile.Value, urlFilteringProfile.Value, fileBlockingProfile.Value, dnsSubscription.Value, outboundUnTrustCertificate.Value, outboundTrustCertificate.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RulestackSecurityServices>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulestackSecurityServices>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RulestackSecurityServices)} does not support '{options.Format}' format.");
            }
        }

        RulestackSecurityServices IPersistableModel<RulestackSecurityServices>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulestackSecurityServices>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRulestackSecurityServices(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RulestackSecurityServices)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RulestackSecurityServices>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
