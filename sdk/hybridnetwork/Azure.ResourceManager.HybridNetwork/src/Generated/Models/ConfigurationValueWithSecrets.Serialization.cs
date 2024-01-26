// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ConfigurationValueWithSecrets : IUtf8JsonSerializable, IJsonModel<ConfigurationValueWithSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationValueWithSecrets>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfigurationValueWithSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationValueWithSecrets)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SecretConfigurationValue))
            {
                writer.WritePropertyName("secretConfigurationValue"u8);
                writer.WriteStringValue(SecretConfigurationValue);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherScope))
            {
                writer.WritePropertyName("publisherScope"u8);
                writer.WriteStringValue(PublisherScope.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationGroupSchemaName))
            {
                writer.WritePropertyName("configurationGroupSchemaName"u8);
                writer.WriteStringValue(ConfigurationGroupSchemaName);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationGroupSchemaOfferingLocation))
            {
                writer.WritePropertyName("configurationGroupSchemaOfferingLocation"u8);
                writer.WriteStringValue(ConfigurationGroupSchemaOfferingLocation);
            }
            if (Optional.IsDefined(ConfigurationGroupSchemaResourceReference))
            {
                writer.WritePropertyName("configurationGroupSchemaResourceReference"u8);
                writer.WriteObjectValue(ConfigurationGroupSchemaResourceReference);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        ConfigurationValueWithSecrets IJsonModel<ConfigurationValueWithSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationValueWithSecrets)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationValueWithSecrets(document.RootElement, options);
        }

        internal static ConfigurationValueWithSecrets DeserializeConfigurationValueWithSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> secretConfigurationValue = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> publisherName = default;
            Optional<PublisherScope> publisherScope = default;
            Optional<string> configurationGroupSchemaName = default;
            Optional<string> configurationGroupSchemaOfferingLocation = default;
            Optional<DeploymentResourceIdReference> configurationGroupSchemaResourceReference = default;
            ConfigurationGroupValueConfigurationType configurationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretConfigurationValue"u8))
                {
                    secretConfigurationValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaName"u8))
                {
                    configurationGroupSchemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaOfferingLocation"u8))
                {
                    configurationGroupSchemaOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationGroupSchemaResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value);
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new ConfigurationGroupValueConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfigurationValueWithSecrets(Optional.ToNullable(provisioningState), publisherName.Value, Optional.ToNullable(publisherScope), configurationGroupSchemaName.Value, configurationGroupSchemaOfferingLocation.Value, configurationGroupSchemaResourceReference.Value, configurationType, serializedAdditionalRawData, secretConfigurationValue.Value);
        }

        BinaryData IPersistableModel<ConfigurationValueWithSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationValueWithSecrets)} does not support '{options.Format}' format.");
            }
        }

        ConfigurationValueWithSecrets IPersistableModel<ConfigurationValueWithSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationValueWithSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationValueWithSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationValueWithSecrets)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationValueWithSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
