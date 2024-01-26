// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class UnknownSapSizingRecommendationResult : IUtf8JsonSerializable, IJsonModel<SapSizingRecommendationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapSizingRecommendationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapSizingRecommendationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSizingRecommendationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSizingRecommendationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
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

        SapSizingRecommendationResult IJsonModel<SapSizingRecommendationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSizingRecommendationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapSizingRecommendationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownSapSizingRecommendationResult(document.RootElement, options);
        }

        internal static UnknownSapSizingRecommendationResult DeserializeUnknownSapSizingRecommendationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SapDeploymentType deploymentType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownSapSizingRecommendationResult(deploymentType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapSizingRecommendationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSizingRecommendationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapSizingRecommendationResult)} does not support '{options.Format}' format.");
            }
        }

        SapSizingRecommendationResult IPersistableModel<SapSizingRecommendationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapSizingRecommendationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownSapSizingRecommendationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapSizingRecommendationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapSizingRecommendationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
