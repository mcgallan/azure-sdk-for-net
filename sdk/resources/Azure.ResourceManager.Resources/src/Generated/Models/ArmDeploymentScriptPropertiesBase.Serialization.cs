// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ArmDeploymentScriptPropertiesBase : IUtf8JsonSerializable, IJsonModel<ArmDeploymentScriptPropertiesBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmDeploymentScriptPropertiesBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmDeploymentScriptPropertiesBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentScriptPropertiesBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentScriptPropertiesBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ContainerSettings))
            {
                writer.WritePropertyName("containerSettings"u8);
                writer.WriteObjectValue(ContainerSettings);
            }
            if (Optional.IsDefined(StorageAccountSettings))
            {
                writer.WritePropertyName("storageAccountSettings"u8);
                writer.WriteObjectValue(StorageAccountSettings);
            }
            if (Optional.IsDefined(CleanupPreference))
            {
                writer.WritePropertyName("cleanupPreference"u8);
                writer.WriteStringValue(CleanupPreference.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Outputs);
#else
                using (JsonDocument document = JsonDocument.Parse(Outputs))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ArmDeploymentScriptPropertiesBase IJsonModel<ArmDeploymentScriptPropertiesBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentScriptPropertiesBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentScriptPropertiesBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmDeploymentScriptPropertiesBase(document.RootElement, options);
        }

        internal static ArmDeploymentScriptPropertiesBase DeserializeArmDeploymentScriptPropertiesBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerConfiguration> containerSettings = default;
            Optional<ScriptStorageConfiguration> storageAccountSettings = default;
            Optional<ScriptCleanupOptions> cleanupPreference = default;
            Optional<ScriptProvisioningState> provisioningState = default;
            Optional<ScriptStatus> status = default;
            Optional<BinaryData> outputs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerSettings = ContainerConfiguration.DeserializeContainerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("storageAccountSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountSettings = ScriptStorageConfiguration.DeserializeScriptStorageConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("cleanupPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cleanupPreference = new ScriptCleanupOptions(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ScriptProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ScriptStatus.DeserializeScriptStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputs = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmDeploymentScriptPropertiesBase(containerSettings.Value, storageAccountSettings.Value, Optional.ToNullable(cleanupPreference), Optional.ToNullable(provisioningState), status.Value, outputs.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmDeploymentScriptPropertiesBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentScriptPropertiesBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentScriptPropertiesBase)} does not support '{options.Format}' format.");
            }
        }

        ArmDeploymentScriptPropertiesBase IPersistableModel<ArmDeploymentScriptPropertiesBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentScriptPropertiesBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmDeploymentScriptPropertiesBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentScriptPropertiesBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmDeploymentScriptPropertiesBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
