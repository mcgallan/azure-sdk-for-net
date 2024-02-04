// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class TextTrack : IUtf8JsonSerializable, IJsonModel<TextTrack>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextTrack>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TextTrack>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextTrack>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextTrack)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(LanguageCode))
            {
                writer.WritePropertyName("languageCode"u8);
                writer.WriteStringValue(LanguageCode);
            }
            if (Optional.IsDefined(PlayerVisibility))
            {
                writer.WritePropertyName("playerVisibility"u8);
                writer.WriteStringValue(PlayerVisibility.Value.ToString());
            }
            if (Optional.IsDefined(HlsSettings))
            {
                writer.WritePropertyName("hlsSettings"u8);
                writer.WriteObjectValue(HlsSettings);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        TextTrack IJsonModel<TextTrack>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextTrack>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextTrack)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextTrack(document.RootElement, options);
        }

        internal static TextTrack DeserializeTextTrack(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fileName = default;
            Optional<string> displayName = default;
            Optional<string> languageCode = default;
            Optional<PlayerVisibility> playerVisibility = default;
            Optional<HlsSettings> hlsSettings = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("languageCode"u8))
                {
                    languageCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("playerVisibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    playerVisibility = new PlayerVisibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hlsSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hlsSettings = HlsSettings.DeserializeHlsSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TextTrack(odataType, serializedAdditionalRawData, fileName.Value, displayName.Value, languageCode.Value, Optional.ToNullable(playerVisibility), hlsSettings.Value);
        }

        BinaryData IPersistableModel<TextTrack>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextTrack>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TextTrack)} does not support '{options.Format}' format.");
            }
        }

        TextTrack IPersistableModel<TextTrack>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextTrack>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTextTrack(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextTrack)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextTrack>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
