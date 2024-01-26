// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class CommonDynamicMatchConfiguration : IUtf8JsonSerializable, IJsonModel<CommonDynamicMatchConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommonDynamicMatchConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommonDynamicMatchConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonDynamicMatchConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonDynamicMatchConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPGroups))
            {
                writer.WritePropertyName("ipGroups"u8);
                writer.WriteStartArray();
                foreach (var item in IPGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VlanGroups))
            {
                writer.WritePropertyName("vlanGroups"u8);
                writer.WriteStartArray();
                foreach (var item in VlanGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PortGroups))
            {
                writer.WritePropertyName("portGroups"u8);
                writer.WriteStartArray();
                foreach (var item in PortGroups)
                {
                    writer.WriteObjectValue(item);
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

        CommonDynamicMatchConfiguration IJsonModel<CommonDynamicMatchConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonDynamicMatchConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommonDynamicMatchConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommonDynamicMatchConfiguration(document.RootElement, options);
        }

        internal static CommonDynamicMatchConfiguration DeserializeCommonDynamicMatchConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MatchConfigurationIPGroupProperties>> ipGroups = default;
            Optional<IList<VlanGroupProperties>> vlanGroups = default;
            Optional<IList<PortGroupProperties>> portGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MatchConfigurationIPGroupProperties> array = new List<MatchConfigurationIPGroupProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MatchConfigurationIPGroupProperties.DeserializeMatchConfigurationIPGroupProperties(item));
                    }
                    ipGroups = array;
                    continue;
                }
                if (property.NameEquals("vlanGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VlanGroupProperties> array = new List<VlanGroupProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VlanGroupProperties.DeserializeVlanGroupProperties(item));
                    }
                    vlanGroups = array;
                    continue;
                }
                if (property.NameEquals("portGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PortGroupProperties> array = new List<PortGroupProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PortGroupProperties.DeserializePortGroupProperties(item));
                    }
                    portGroups = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommonDynamicMatchConfiguration(Optional.ToList(ipGroups), Optional.ToList(vlanGroups), Optional.ToList(portGroups), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommonDynamicMatchConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonDynamicMatchConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommonDynamicMatchConfiguration)} does not support '{options.Format}' format.");
            }
        }

        CommonDynamicMatchConfiguration IPersistableModel<CommonDynamicMatchConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommonDynamicMatchConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommonDynamicMatchConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommonDynamicMatchConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommonDynamicMatchConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
