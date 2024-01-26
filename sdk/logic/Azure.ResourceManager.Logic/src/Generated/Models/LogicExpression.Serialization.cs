// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicExpression : IUtf8JsonSerializable, IJsonModel<LogicExpression>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicExpression>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicExpression>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicExpression>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicExpression)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Value);
#else
                using (JsonDocument document = JsonDocument.Parse(Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Subexpressions))
            {
                writer.WritePropertyName("subexpressions"u8);
                writer.WriteStartArray();
                foreach (var item in Subexpressions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        LogicExpression IJsonModel<LogicExpression>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicExpression>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicExpression)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicExpression(document.RootElement, options);
        }

        internal static LogicExpression DeserializeLogicExpression(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> text = default;
            Optional<BinaryData> value = default;
            Optional<IReadOnlyList<LogicExpression>> subexpressions = default;
            Optional<LogicExpressionErrorInfo> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("subexpressions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogicExpression> array = new List<LogicExpression>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeLogicExpression(item));
                    }
                    subexpressions = array;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = LogicExpressionErrorInfo.DeserializeLogicExpressionErrorInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicExpression(text.Value, value.Value, Optional.ToList(subexpressions), error.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicExpression>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicExpression>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicExpression)} does not support '{options.Format}' format.");
            }
        }

        LogicExpression IPersistableModel<LogicExpression>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicExpression>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicExpression(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicExpression)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicExpression>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
