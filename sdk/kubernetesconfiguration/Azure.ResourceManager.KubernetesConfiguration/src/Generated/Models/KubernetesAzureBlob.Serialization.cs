// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesAzureBlob : IUtf8JsonSerializable, IJsonModel<KubernetesAzureBlob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesAzureBlob>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesAzureBlob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesAzureBlob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesAzureBlob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            if (Optional.IsDefined(ContainerName))
            {
                if (ContainerName != null)
                {
                    writer.WritePropertyName("containerName"u8);
                    writer.WriteStringValue(ContainerName);
                }
                else
                {
                    writer.WriteNull("containerName");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(ServicePrincipal))
            {
                if (ServicePrincipal != null)
                {
                    writer.WritePropertyName("servicePrincipal"u8);
                    writer.WriteObjectValue(ServicePrincipal);
                }
                else
                {
                    writer.WriteNull("servicePrincipal");
                }
            }
            if (Optional.IsDefined(AccountKey))
            {
                if (AccountKey != null)
                {
                    writer.WritePropertyName("accountKey"u8);
                    writer.WriteStringValue(AccountKey);
                }
                else
                {
                    writer.WriteNull("accountKey");
                }
            }
            if (Optional.IsDefined(SasToken))
            {
                if (SasToken != null)
                {
                    writer.WritePropertyName("sasToken"u8);
                    writer.WriteStringValue(SasToken);
                }
                else
                {
                    writer.WriteNull("sasToken");
                }
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                if (ManagedIdentity != null)
                {
                    writer.WritePropertyName("managedIdentity"u8);
                    writer.WriteObjectValue(ManagedIdentity);
                }
                else
                {
                    writer.WriteNull("managedIdentity");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef"u8);
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
                }
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

        KubernetesAzureBlob IJsonModel<KubernetesAzureBlob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesAzureBlob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesAzureBlob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesAzureBlob(document.RootElement, options);
        }

        internal static KubernetesAzureBlob DeserializeKubernetesAzureBlob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> url = default;
            Optional<string> containerName = default;
            Optional<long?> timeoutInSeconds = default;
            Optional<long?> syncIntervalInSeconds = default;
            Optional<KubernetesServicePrincipal> servicePrincipal = default;
            Optional<string> accountKey = default;
            Optional<string> sasToken = default;
            Optional<KubernetesAzureBlobManagedIdentity> managedIdentity = default;
            Optional<string> localAuthRef = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        containerName = null;
                        continue;
                    }
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("servicePrincipal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        servicePrincipal = null;
                        continue;
                    }
                    servicePrincipal = KubernetesServicePrincipal.DeserializeKubernetesServicePrincipal(property.Value);
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accountKey = null;
                        continue;
                    }
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sasToken = null;
                        continue;
                    }
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managedIdentity = null;
                        continue;
                    }
                    managedIdentity = KubernetesAzureBlobManagedIdentity.DeserializeKubernetesAzureBlobManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("localAuthRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        localAuthRef = null;
                        continue;
                    }
                    localAuthRef = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesAzureBlob(url.Value, containerName.Value, Optional.ToNullable(timeoutInSeconds), Optional.ToNullable(syncIntervalInSeconds), servicePrincipal.Value, accountKey.Value, sasToken.Value, managedIdentity.Value, localAuthRef.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesAzureBlob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesAzureBlob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesAzureBlob)} does not support '{options.Format}' format.");
            }
        }

        KubernetesAzureBlob IPersistableModel<KubernetesAzureBlob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesAzureBlob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesAzureBlob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesAzureBlob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesAzureBlob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
