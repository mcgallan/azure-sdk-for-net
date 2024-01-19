// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    [PersistableModelProxy(typeof(UnknownAdditionalData))]
    public partial class SecuritySubAssessmentAdditionalInfo : IUtf8JsonSerializable, IJsonModel<SecuritySubAssessmentAdditionalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecuritySubAssessmentAdditionalInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecuritySubAssessmentAdditionalInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySubAssessmentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecuritySubAssessmentAdditionalInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("assessedResourceType"u8);
            writer.WriteStringValue(AssessedResourceType.ToString());
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

        SecuritySubAssessmentAdditionalInfo IJsonModel<SecuritySubAssessmentAdditionalInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySubAssessmentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecuritySubAssessmentAdditionalInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecuritySubAssessmentAdditionalInfo(document.RootElement, options);
        }

        internal static SecuritySubAssessmentAdditionalInfo DeserializeSecuritySubAssessmentAdditionalInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("assessedResourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ContainerRegistryVulnerability": return ContainerRegistryVulnerabilityProperties.DeserializeContainerRegistryVulnerabilityProperties(element);
                    case "ServerVulnerabilityAssessment": return ServerVulnerabilityProperties.DeserializeServerVulnerabilityProperties(element);
                    case "SqlServerVulnerability": return SqlServerVulnerabilityProperties.DeserializeSqlServerVulnerabilityProperties(element);
                }
            }
            return UnknownAdditionalData.DeserializeUnknownAdditionalData(element);
        }

        BinaryData IPersistableModel<SecuritySubAssessmentAdditionalInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySubAssessmentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecuritySubAssessmentAdditionalInfo)} does not support '{options.Format}' format.");
            }
        }

        SecuritySubAssessmentAdditionalInfo IPersistableModel<SecuritySubAssessmentAdditionalInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecuritySubAssessmentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecuritySubAssessmentAdditionalInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecuritySubAssessmentAdditionalInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecuritySubAssessmentAdditionalInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
