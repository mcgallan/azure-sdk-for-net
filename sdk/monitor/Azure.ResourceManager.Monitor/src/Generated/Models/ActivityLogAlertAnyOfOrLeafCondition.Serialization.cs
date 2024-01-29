// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ActivityLogAlertAnyOfOrLeafCondition : IUtf8JsonSerializable, IJsonModel<ActivityLogAlertAnyOfOrLeafCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActivityLogAlertAnyOfOrLeafCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ActivityLogAlertAnyOfOrLeafCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActivityLogAlertAnyOfOrLeafCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActivityLogAlertAnyOfOrLeafCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AnyOf))
            {
                writer.WritePropertyName("anyOf"u8);
                writer.WriteStartArray();
                foreach (var item in AnyOf)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Field))
            {
                writer.WritePropertyName("field"u8);
                writer.WriteStringValue(Field);
            }
            if (Optional.IsDefined(EqualsValue))
            {
                writer.WritePropertyName("equals"u8);
                writer.WriteStringValue(EqualsValue);
            }
            if (Optional.IsCollectionDefined(ContainsAny))
            {
                writer.WritePropertyName("containsAny"u8);
                writer.WriteStartArray();
                foreach (var item in ContainsAny)
                {
                    writer.WriteStringValue(item);
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

        ActivityLogAlertAnyOfOrLeafCondition IJsonModel<ActivityLogAlertAnyOfOrLeafCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActivityLogAlertAnyOfOrLeafCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActivityLogAlertAnyOfOrLeafCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActivityLogAlertAnyOfOrLeafCondition(document.RootElement, options);
        }

        internal static ActivityLogAlertAnyOfOrLeafCondition DeserializeActivityLogAlertAnyOfOrLeafCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AlertRuleLeafCondition>> anyOf = default;
            Optional<string> field = default;
            Optional<string> @equals = default;
            Optional<IList<string>> containsAny = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anyOf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlertRuleLeafCondition> array = new List<AlertRuleLeafCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeAlertRuleLeafCondition(item));
                    }
                    anyOf = array;
                    continue;
                }
                if (property.NameEquals("field"u8))
                {
                    field = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("equals"u8))
                {
                    @equals = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containsAny"u8))
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
                    containsAny = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ActivityLogAlertAnyOfOrLeafCondition(field.Value, @equals.Value, Optional.ToList(containsAny), serializedAdditionalRawData, Optional.ToList(anyOf));
        }

        BinaryData IPersistableModel<ActivityLogAlertAnyOfOrLeafCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActivityLogAlertAnyOfOrLeafCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ActivityLogAlertAnyOfOrLeafCondition)} does not support '{options.Format}' format.");
            }
        }

        ActivityLogAlertAnyOfOrLeafCondition IPersistableModel<ActivityLogAlertAnyOfOrLeafCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActivityLogAlertAnyOfOrLeafCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeActivityLogAlertAnyOfOrLeafCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActivityLogAlertAnyOfOrLeafCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActivityLogAlertAnyOfOrLeafCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
