// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownRecoveryResourceGroupCustomDetails))]
    public partial class RecoveryResourceGroupCustomDetails : IUtf8JsonSerializable, IJsonModel<RecoveryResourceGroupCustomDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryResourceGroupCustomDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryResourceGroupCustomDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryResourceGroupCustomDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryResourceGroupCustomDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        RecoveryResourceGroupCustomDetails IJsonModel<RecoveryResourceGroupCustomDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryResourceGroupCustomDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryResourceGroupCustomDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryResourceGroupCustomDetails(document.RootElement, options);
        }

        internal static RecoveryResourceGroupCustomDetails DeserializeRecoveryResourceGroupCustomDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Existing": return ExistingRecoveryResourceGroup.DeserializeExistingRecoveryResourceGroup(element);
                }
            }
            return UnknownRecoveryResourceGroupCustomDetails.DeserializeUnknownRecoveryResourceGroupCustomDetails(element);
        }

        BinaryData IPersistableModel<RecoveryResourceGroupCustomDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryResourceGroupCustomDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryResourceGroupCustomDetails)} does not support '{options.Format}' format.");
            }
        }

        RecoveryResourceGroupCustomDetails IPersistableModel<RecoveryResourceGroupCustomDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryResourceGroupCustomDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryResourceGroupCustomDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryResourceGroupCustomDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryResourceGroupCustomDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
