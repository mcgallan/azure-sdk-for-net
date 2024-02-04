// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ProcessThreadInfo : IUtf8JsonSerializable, IJsonModel<ProcessThreadInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProcessThreadInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProcessThreadInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessThreadInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcessThreadInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteNumberValue(Identifier.Value);
            }
            if (Optional.IsDefined(Href))
            {
                writer.WritePropertyName("href"u8);
                writer.WriteStringValue(Href);
            }
            if (Optional.IsDefined(Process))
            {
                writer.WritePropertyName("process"u8);
                writer.WriteStringValue(Process);
            }
            if (Optional.IsDefined(StartAddress))
            {
                writer.WritePropertyName("start_address"u8);
                writer.WriteStringValue(StartAddress);
            }
            if (Optional.IsDefined(CurrentPriority))
            {
                writer.WritePropertyName("current_priority"u8);
                writer.WriteNumberValue(CurrentPriority.Value);
            }
            if (Optional.IsDefined(PriorityLevel))
            {
                writer.WritePropertyName("priority_level"u8);
                writer.WriteStringValue(PriorityLevel);
            }
            if (Optional.IsDefined(BasePriority))
            {
                writer.WritePropertyName("base_priority"u8);
                writer.WriteNumberValue(BasePriority.Value);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("start_time"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(TotalProcessorTime))
            {
                writer.WritePropertyName("total_processor_time"u8);
                writer.WriteStringValue(TotalProcessorTime);
            }
            if (Optional.IsDefined(UserProcessorTime))
            {
                writer.WritePropertyName("user_processor_time"u8);
                writer.WriteStringValue(UserProcessorTime);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Optional.IsDefined(WaitReason))
            {
                writer.WritePropertyName("wait_reason"u8);
                writer.WriteStringValue(WaitReason);
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

        ProcessThreadInfo IJsonModel<ProcessThreadInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessThreadInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProcessThreadInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProcessThreadInfo(document.RootElement, options);
        }

        internal static ProcessThreadInfo DeserializeProcessThreadInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> identifier = default;
            Optional<string> href = default;
            Optional<string> process = default;
            Optional<string> startAddress = default;
            Optional<int> currentPriority = default;
            Optional<string> priorityLevel = default;
            Optional<int> basePriority = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> totalProcessorTime = default;
            Optional<string> userProcessorTime = default;
            Optional<string> state = default;
            Optional<string> waitReason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("identifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            identifier = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("href"u8))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("process"u8))
                        {
                            process = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("start_address"u8))
                        {
                            startAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("current_priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentPriority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("priority_level"u8))
                        {
                            priorityLevel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("base_priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            basePriority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("start_time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("total_processor_time"u8))
                        {
                            totalProcessorTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user_processor_time"u8))
                        {
                            userProcessorTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("wait_reason"u8))
                        {
                            waitReason = property0.Value.GetString();
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
            return new ProcessThreadInfo(id, name, type, systemData.Value, Optional.ToNullable(identifier), href.Value, process.Value, startAddress.Value, Optional.ToNullable(currentPriority), priorityLevel.Value, Optional.ToNullable(basePriority), Optional.ToNullable(startTime), totalProcessorTime.Value, userProcessorTime.Value, state.Value, waitReason.Value, kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProcessThreadInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessThreadInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProcessThreadInfo)} does not support '{options.Format}' format.");
            }
        }

        ProcessThreadInfo IPersistableModel<ProcessThreadInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProcessThreadInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProcessThreadInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProcessThreadInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProcessThreadInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
