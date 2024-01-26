// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RoutingStorageContainerProperties : IUtf8JsonSerializable, IJsonModel<RoutingStorageContainerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingStorageContainerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoutingStorageContainerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingStorageContainerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingStorageContainerProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteStringValue(ConnectionString);
            }
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpointUri"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
            if (Optional.IsDefined(FileNameFormat))
            {
                writer.WritePropertyName("fileNameFormat"u8);
                writer.WriteStringValue(FileNameFormat);
            }
            if (Optional.IsDefined(BatchFrequencyInSeconds))
            {
                writer.WritePropertyName("batchFrequencyInSeconds"u8);
                writer.WriteNumberValue(BatchFrequencyInSeconds.Value);
            }
            if (Optional.IsDefined(MaxChunkSizeInBytes))
            {
                writer.WritePropertyName("maxChunkSizeInBytes"u8);
                writer.WriteNumberValue(MaxChunkSizeInBytes.Value);
            }
            if (Optional.IsDefined(Encoding))
            {
                writer.WritePropertyName("encoding"u8);
                writer.WriteStringValue(Encoding.Value.ToString());
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

        RoutingStorageContainerProperties IJsonModel<RoutingStorageContainerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingStorageContainerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingStorageContainerProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingStorageContainerProperties(document.RootElement, options);
        }

        internal static RoutingStorageContainerProperties DeserializeRoutingStorageContainerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> id = default;
            Optional<string> connectionString = default;
            Optional<string> endpointUri = default;
            Optional<IotHubAuthenticationType> authenticationType = default;
            Optional<ManagedIdentity> identity = default;
            string name = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            string containerName = default;
            Optional<string> fileNameFormat = default;
            Optional<int> batchFrequencyInSeconds = default;
            Optional<int> maxChunkSizeInBytes = default;
            Optional<RoutingStorageContainerPropertiesEncoding> encoding = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("connectionString"u8))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointUri"u8))
                {
                    endpointUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new IotHubAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ManagedIdentity.DeserializeManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileNameFormat"u8))
                {
                    fileNameFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("batchFrequencyInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    batchFrequencyInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxChunkSizeInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxChunkSizeInBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("encoding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encoding = new RoutingStorageContainerPropertiesEncoding(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoutingStorageContainerProperties(Optional.ToNullable(id), connectionString.Value, endpointUri.Value, Optional.ToNullable(authenticationType), identity.Value, name, subscriptionId.Value, resourceGroup.Value, containerName, fileNameFormat.Value, Optional.ToNullable(batchFrequencyInSeconds), Optional.ToNullable(maxChunkSizeInBytes), Optional.ToNullable(encoding), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingStorageContainerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingStorageContainerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoutingStorageContainerProperties)} does not support '{options.Format}' format.");
            }
        }

        RoutingStorageContainerProperties IPersistableModel<RoutingStorageContainerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingStorageContainerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoutingStorageContainerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingStorageContainerProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingStorageContainerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
