// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricExternalNetworkData : IUtf8JsonSerializable, IJsonModel<NetworkFabricExternalNetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFabricExternalNetworkData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkFabricExternalNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricExternalNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricExternalNetworkData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(ImportRoutePolicyId))
            {
                writer.WritePropertyName("importRoutePolicyId"u8);
                writer.WriteStringValue(ImportRoutePolicyId);
            }
            if (Optional.IsDefined(ExportRoutePolicyId))
            {
                writer.WritePropertyName("exportRoutePolicyId"u8);
                writer.WriteStringValue(ExportRoutePolicyId);
            }
            if (Optional.IsDefined(ImportRoutePolicy))
            {
                writer.WritePropertyName("importRoutePolicy"u8);
                writer.WriteObjectValue(ImportRoutePolicy);
            }
            if (Optional.IsDefined(ExportRoutePolicy))
            {
                writer.WritePropertyName("exportRoutePolicy"u8);
                writer.WriteObjectValue(ExportRoutePolicy);
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkToNetworkInterconnectId))
            {
                writer.WritePropertyName("networkToNetworkInterconnectId"u8);
                writer.WriteStringValue(NetworkToNetworkInterconnectId);
            }
            writer.WritePropertyName("peeringOption"u8);
            writer.WriteStringValue(PeeringOption.ToString());
            if (Optional.IsDefined(OptionBProperties))
            {
                writer.WritePropertyName("optionBProperties"u8);
                writer.WriteObjectValue(OptionBProperties);
            }
            if (Optional.IsDefined(OptionAProperties))
            {
                writer.WritePropertyName("optionAProperties"u8);
                writer.WriteObjectValue(OptionAProperties);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationState))
            {
                writer.WritePropertyName("configurationState"u8);
                writer.WriteStringValue(ConfigurationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AdministrativeState))
            {
                writer.WritePropertyName("administrativeState"u8);
                writer.WriteStringValue(AdministrativeState.Value.ToString());
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

        NetworkFabricExternalNetworkData IJsonModel<NetworkFabricExternalNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricExternalNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricExternalNetworkData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricExternalNetworkData(document.RootElement, options);
        }

        internal static NetworkFabricExternalNetworkData DeserializeNetworkFabricExternalNetworkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> annotation = default;
            Optional<ResourceIdentifier> importRoutePolicyId = default;
            Optional<ResourceIdentifier> exportRoutePolicyId = default;
            Optional<ImportRoutePolicy> importRoutePolicy = default;
            Optional<ExportRoutePolicy> exportRoutePolicy = default;
            Optional<ResourceIdentifier> networkToNetworkInterconnectId = default;
            PeeringOption peeringOption = default;
            Optional<L3OptionBProperties> optionBProperties = default;
            Optional<ExternalNetworkOptionAProperties> optionAProperties = default;
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicy = ImportRoutePolicy.DeserializeImportRoutePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicy = ExportRoutePolicy.DeserializeExportRoutePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkToNetworkInterconnectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkToNetworkInterconnectId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("peeringOption"u8))
                        {
                            peeringOption = new PeeringOption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("optionBProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optionBProperties = L3OptionBProperties.DeserializeL3OptionBProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("optionAProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optionAProperties = ExternalNetworkOptionAProperties.DeserializeExternalNetworkOptionAProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
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
            return new NetworkFabricExternalNetworkData(id, name, type, systemData.Value, annotation.Value, importRoutePolicyId.Value, exportRoutePolicyId.Value, importRoutePolicy.Value, exportRoutePolicy.Value, networkToNetworkInterconnectId.Value, peeringOption, optionBProperties.Value, optionAProperties.Value, Optional.ToNullable(configurationState), Optional.ToNullable(provisioningState), Optional.ToNullable(administrativeState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkFabricExternalNetworkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricExternalNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricExternalNetworkData)} does not support '{options.Format}' format.");
            }
        }

        NetworkFabricExternalNetworkData IPersistableModel<NetworkFabricExternalNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricExternalNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkFabricExternalNetworkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricExternalNetworkData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFabricExternalNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
