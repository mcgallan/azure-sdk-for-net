// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ResourceProviderManagement : IUtf8JsonSerializable, IJsonModel<ResourceProviderManagement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceProviderManagement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceProviderManagement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManagement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderManagement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SchemaOwners))
            {
                writer.WritePropertyName("schemaOwners"u8);
                writer.WriteStartArray();
                foreach (var item in SchemaOwners)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManifestOwners))
            {
                writer.WritePropertyName("manifestOwners"u8);
                writer.WriteStartArray();
                foreach (var item in ManifestOwners)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IncidentRoutingService))
            {
                writer.WritePropertyName("incidentRoutingService"u8);
                writer.WriteStringValue(IncidentRoutingService);
            }
            if (Optional.IsDefined(IncidentRoutingTeam))
            {
                writer.WritePropertyName("incidentRoutingTeam"u8);
                writer.WriteStringValue(IncidentRoutingTeam);
            }
            if (Optional.IsDefined(IncidentContactEmail))
            {
                writer.WritePropertyName("incidentContactEmail"u8);
                writer.WriteStringValue(IncidentContactEmail);
            }
            if (Optional.IsCollectionDefined(ServiceTreeInfos))
            {
                writer.WritePropertyName("serviceTreeInfos"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceTreeInfos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResourceAccessPolicy))
            {
                writer.WritePropertyName("resourceAccessPolicy"u8);
                writer.WriteStringValue(ResourceAccessPolicy.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(ResourceAccessRoles))
            {
                writer.WritePropertyName("resourceAccessRoles"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceAccessRoles)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
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

        ResourceProviderManagement IJsonModel<ResourceProviderManagement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManagement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderManagement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceProviderManagement(document.RootElement, options);
        }

        internal static ResourceProviderManagement DeserializeResourceProviderManagement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> schemaOwners = default;
            Optional<IList<string>> manifestOwners = default;
            Optional<string> incidentRoutingService = default;
            Optional<string> incidentRoutingTeam = default;
            Optional<string> incidentContactEmail = default;
            Optional<IList<ServiceTreeInfo>> serviceTreeInfos = default;
            Optional<ResourceAccessPolicy> resourceAccessPolicy = default;
            Optional<IList<BinaryData>> resourceAccessRoles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaOwners"u8))
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
                    schemaOwners = array;
                    continue;
                }
                if (property.NameEquals("manifestOwners"u8))
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
                    manifestOwners = array;
                    continue;
                }
                if (property.NameEquals("incidentRoutingService"u8))
                {
                    incidentRoutingService = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("incidentRoutingTeam"u8))
                {
                    incidentRoutingTeam = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("incidentContactEmail"u8))
                {
                    incidentContactEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceTreeInfos"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceTreeInfo> array = new List<ServiceTreeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceTreeInfo.DeserializeServiceTreeInfo(item));
                    }
                    serviceTreeInfos = array;
                    continue;
                }
                if (property.NameEquals("resourceAccessPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceAccessPolicy = property.Value.GetString().ToResourceAccessPolicy();
                    continue;
                }
                if (property.NameEquals("resourceAccessRoles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    resourceAccessRoles = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceProviderManagement(Optional.ToList(schemaOwners), Optional.ToList(manifestOwners), incidentRoutingService.Value, incidentRoutingTeam.Value, incidentContactEmail.Value, Optional.ToList(serviceTreeInfos), Optional.ToNullable(resourceAccessPolicy), Optional.ToList(resourceAccessRoles), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceProviderManagement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManagement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderManagement)} does not support '{options.Format}' format.");
            }
        }

        ResourceProviderManagement IPersistableModel<ResourceProviderManagement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManagement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceProviderManagement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderManagement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceProviderManagement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
