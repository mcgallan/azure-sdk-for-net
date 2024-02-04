// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class EMachineLearningStudioFunctionBinding : IUtf8JsonSerializable, IJsonModel<EMachineLearningStudioFunctionBinding>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EMachineLearningStudioFunctionBinding>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EMachineLearningStudioFunctionBinding>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EMachineLearningStudioFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EMachineLearningStudioFunctionBinding)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionBindingType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteObjectValue(Inputs);
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize"u8);
                writer.WriteNumberValue(BatchSize.Value);
            }
            writer.WriteEndObject();
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

        EMachineLearningStudioFunctionBinding IJsonModel<EMachineLearningStudioFunctionBinding>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EMachineLearningStudioFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EMachineLearningStudioFunctionBinding)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEMachineLearningStudioFunctionBinding(document.RootElement, options);
        }

        internal static EMachineLearningStudioFunctionBinding DeserializeEMachineLearningStudioFunctionBinding(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> endpoint = default;
            Optional<string> apiKey = default;
            Optional<MachineLearningStudioInputs> inputs = default;
            Optional<IList<MachineLearningStudioOutputColumn>> outputs = default;
            Optional<int> batchSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiKey"u8))
                        {
                            apiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inputs = MachineLearningStudioInputs.DeserializeMachineLearningStudioInputs(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineLearningStudioOutputColumn> array = new List<MachineLearningStudioOutputColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineLearningStudioOutputColumn.DeserializeMachineLearningStudioOutputColumn(item));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("batchSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            batchSize = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EMachineLearningStudioFunctionBinding(type, serializedAdditionalRawData, endpoint.Value, apiKey.Value, inputs.Value, Optional.ToList(outputs), Optional.ToNullable(batchSize));
        }

        BinaryData IPersistableModel<EMachineLearningStudioFunctionBinding>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EMachineLearningStudioFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EMachineLearningStudioFunctionBinding)} does not support '{options.Format}' format.");
            }
        }

        EMachineLearningStudioFunctionBinding IPersistableModel<EMachineLearningStudioFunctionBinding>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EMachineLearningStudioFunctionBinding>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEMachineLearningStudioFunctionBinding(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EMachineLearningStudioFunctionBinding)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EMachineLearningStudioFunctionBinding>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
