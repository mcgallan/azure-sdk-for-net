// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationJobStream : IUtf8JsonSerializable, IJsonModel<AutomationJobStream>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationJobStream>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationJobStream>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationJobStream>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationJobStream)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(JobStreamId))
            {
                writer.WritePropertyName("jobStreamId"u8);
                writer.WriteStringValue(JobStreamId);
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time.Value, "O");
            }
            if (Optional.IsDefined(StreamType))
            {
                writer.WritePropertyName("streamType"u8);
                writer.WriteStringValue(StreamType.Value.ToString());
            }
            if (Optional.IsDefined(StreamText))
            {
                writer.WritePropertyName("streamText"u8);
                writer.WriteStringValue(StreamText);
            }
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartObject();
                foreach (var item in Value)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
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

        AutomationJobStream IJsonModel<AutomationJobStream>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationJobStream>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationJobStream)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationJobStream(document.RootElement, options);
        }

        internal static AutomationJobStream DeserializeAutomationJobStream(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> jobStreamId = default;
            Optional<DateTimeOffset> time = default;
            Optional<AutomationJobStreamType> streamType = default;
            Optional<string> streamText = default;
            Optional<string> summary = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("jobStreamId"u8))
                        {
                            jobStreamId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            time = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("streamType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            streamType = new AutomationJobStreamType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("streamText"u8))
                        {
                            streamText = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("summary"u8))
                        {
                            summary = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("value"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            value = dictionary;
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
            return new AutomationJobStream(id.Value, jobStreamId.Value, Optional.ToNullable(time), Optional.ToNullable(streamType), streamText.Value, summary.Value, Optional.ToDictionary(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationJobStream>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationJobStream>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationJobStream)} does not support '{options.Format}' format.");
            }
        }

        AutomationJobStream IPersistableModel<AutomationJobStream>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationJobStream>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationJobStream(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationJobStream)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationJobStream>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
