// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanHyperVReplicaAzureFailoverContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanHyperVReplicaAzureFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanHyperVReplicaAzureFailoverContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPlanHyperVReplicaAzureFailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanHyperVReplicaAzureFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanHyperVReplicaAzureFailoverContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKekCertificatePfx))
            {
                writer.WritePropertyName("primaryKekCertificatePfx"u8);
                writer.WriteStringValue(PrimaryKekCertificatePfx);
            }
            if (Optional.IsDefined(SecondaryKekCertificatePfx))
            {
                writer.WritePropertyName("secondaryKekCertificatePfx"u8);
                writer.WriteStringValue(SecondaryKekCertificatePfx);
            }
            if (Optional.IsDefined(RecoveryPointType))
            {
                writer.WritePropertyName("recoveryPointType"u8);
                writer.WriteStringValue(RecoveryPointType.Value.ToString());
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        RecoveryPlanHyperVReplicaAzureFailoverContent IJsonModel<RecoveryPlanHyperVReplicaAzureFailoverContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanHyperVReplicaAzureFailoverContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPlanHyperVReplicaAzureFailoverContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanHyperVReplicaAzureFailoverContent(document.RootElement, options);
        }

        internal static RecoveryPlanHyperVReplicaAzureFailoverContent DeserializeRecoveryPlanHyperVReplicaAzureFailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryKekCertificatePfx = default;
            Optional<string> secondaryKekCertificatePfx = default;
            Optional<HyperVReplicaAzureRpRecoveryPointType> recoveryPointType = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKekCertificatePfx"u8))
                {
                    primaryKekCertificatePfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKekCertificatePfx"u8))
                {
                    secondaryKekCertificatePfx = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointType = new HyperVReplicaAzureRpRecoveryPointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPlanHyperVReplicaAzureFailoverContent(instanceType, serializedAdditionalRawData, primaryKekCertificatePfx.Value, secondaryKekCertificatePfx.Value, Optional.ToNullable(recoveryPointType));
        }

        BinaryData IPersistableModel<RecoveryPlanHyperVReplicaAzureFailoverContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanHyperVReplicaAzureFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanHyperVReplicaAzureFailoverContent)} does not support '{options.Format}' format.");
            }
        }

        RecoveryPlanHyperVReplicaAzureFailoverContent IPersistableModel<RecoveryPlanHyperVReplicaAzureFailoverContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPlanHyperVReplicaAzureFailoverContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryPlanHyperVReplicaAzureFailoverContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPlanHyperVReplicaAzureFailoverContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPlanHyperVReplicaAzureFailoverContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
