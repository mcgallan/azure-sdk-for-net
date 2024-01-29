// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class EmergingIssueActiveEventType : IUtf8JsonSerializable, IJsonModel<EmergingIssueActiveEventType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EmergingIssueActiveEventType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EmergingIssueActiveEventType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmergingIssueActiveEventType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EmergingIssueActiveEventType)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TrackingId))
            {
                writer.WritePropertyName("trackingId"u8);
                writer.WriteStringValue(TrackingId);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(Cloud))
            {
                writer.WritePropertyName("cloud"u8);
                writer.WriteStringValue(Cloud);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Stage))
            {
                writer.WritePropertyName("stage"u8);
                writer.WriteStringValue(Stage.Value.ToString());
            }
            if (Optional.IsDefined(IsPublished))
            {
                writer.WritePropertyName("published"u8);
                writer.WriteBooleanValue(IsPublished.Value);
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Impacts))
            {
                writer.WritePropertyName("impacts"u8);
                writer.WriteStartArray();
                foreach (var item in Impacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        EmergingIssueActiveEventType IJsonModel<EmergingIssueActiveEventType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmergingIssueActiveEventType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EmergingIssueActiveEventType)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEmergingIssueActiveEventType(document.RootElement, options);
        }

        internal static EmergingIssueActiveEventType DeserializeEmergingIssueActiveEventType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> title = default;
            Optional<string> description = default;
            Optional<string> trackingId = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> cloud = default;
            Optional<ResourceHealthEventSeverityLevel> severity = default;
            Optional<ResourceHealthEventStageValue> stage = default;
            Optional<bool> published = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<IReadOnlyList<EmergingIssueImpact>> impacts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"u8))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    cloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new ResourceHealthEventSeverityLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stage = new ResourceHealthEventStageValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("published"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    published = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("impacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EmergingIssueImpact> array = new List<EmergingIssueImpact>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EmergingIssueImpact.DeserializeEmergingIssueImpact(item));
                    }
                    impacts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EmergingIssueActiveEventType(title.Value, description.Value, trackingId.Value, Optional.ToNullable(startTime), cloud.Value, Optional.ToNullable(severity), Optional.ToNullable(stage), Optional.ToNullable(published), Optional.ToNullable(lastModifiedTime), Optional.ToList(impacts), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EmergingIssueActiveEventType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmergingIssueActiveEventType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EmergingIssueActiveEventType)} does not support '{options.Format}' format.");
            }
        }

        EmergingIssueActiveEventType IPersistableModel<EmergingIssueActiveEventType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EmergingIssueActiveEventType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEmergingIssueActiveEventType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EmergingIssueActiveEventType)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EmergingIssueActiveEventType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
