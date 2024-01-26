// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class KerberosKeytabCredentials : IUtf8JsonSerializable, IJsonModel<KerberosKeytabCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KerberosKeytabCredentials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KerberosKeytabCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KerberosKeytabCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KerberosKeytabCredentials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("secrets"u8);
            writer.WriteObjectValue(Secrets);
            writer.WritePropertyName("kerberosKdcAddress"u8);
            writer.WriteStringValue(KerberosKdcAddress);
            writer.WritePropertyName("kerberosPrincipal"u8);
            writer.WriteStringValue(KerberosPrincipal);
            writer.WritePropertyName("kerberosRealm"u8);
            writer.WriteStringValue(KerberosRealm);
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
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

        KerberosKeytabCredentials IJsonModel<KerberosKeytabCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KerberosKeytabCredentials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KerberosKeytabCredentials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKerberosKeytabCredentials(document.RootElement, options);
        }

        internal static KerberosKeytabCredentials DeserializeKerberosKeytabCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KerberosKeytabSecrets secrets = default;
            string kerberosKdcAddress = default;
            string kerberosPrincipal = default;
            string kerberosRealm = default;
            CredentialsType credentialsType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secrets"u8))
                {
                    secrets = KerberosKeytabSecrets.DeserializeKerberosKeytabSecrets(property.Value);
                    continue;
                }
                if (property.NameEquals("kerberosKdcAddress"u8))
                {
                    kerberosKdcAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kerberosPrincipal"u8))
                {
                    kerberosPrincipal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kerberosRealm"u8))
                {
                    kerberosRealm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentialsType"u8))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KerberosKeytabCredentials(credentialsType, serializedAdditionalRawData, secrets, kerberosKdcAddress, kerberosPrincipal, kerberosRealm);
        }

        BinaryData IPersistableModel<KerberosKeytabCredentials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KerberosKeytabCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KerberosKeytabCredentials)} does not support '{options.Format}' format.");
            }
        }

        KerberosKeytabCredentials IPersistableModel<KerberosKeytabCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KerberosKeytabCredentials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKerberosKeytabCredentials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KerberosKeytabCredentials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KerberosKeytabCredentials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
