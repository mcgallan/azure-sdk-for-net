// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AseV3NetworkingConfigurationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowNewPrivateEndpointConnections))
            {
                writer.WritePropertyName("allowNewPrivateEndpointConnections");
                writer.WriteBooleanValue(AllowNewPrivateEndpointConnections.Value);
            }
            if (Optional.IsDefined(FtpEnabled))
            {
                writer.WritePropertyName("ftpEnabled");
                writer.WriteBooleanValue(FtpEnabled.Value);
            }
            if (Optional.IsDefined(RemoteDebugEnabled))
            {
                writer.WritePropertyName("remoteDebugEnabled");
                writer.WriteBooleanValue(RemoteDebugEnabled.Value);
            }
            if (Optional.IsDefined(InboundIPAddressOverride))
            {
                writer.WritePropertyName("inboundIpAddressOverride");
                writer.WriteStringValue(InboundIPAddressOverride);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AseV3NetworkingConfigurationData DeserializeAseV3NetworkingConfigurationData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<string>> windowsOutboundIpAddresses = default;
            Optional<IReadOnlyList<string>> linuxOutboundIpAddresses = default;
            Optional<IReadOnlyList<string>> externalInboundIpAddresses = default;
            Optional<IReadOnlyList<string>> internalInboundIpAddresses = default;
            Optional<bool> allowNewPrivateEndpointConnections = default;
            Optional<bool> ftpEnabled = default;
            Optional<bool> remoteDebugEnabled = default;
            Optional<string> inboundIpAddressOverride = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("windowsOutboundIpAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            windowsOutboundIpAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("linuxOutboundIpAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            linuxOutboundIpAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("externalInboundIpAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            externalInboundIpAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("internalInboundIpAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            internalInboundIpAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("allowNewPrivateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowNewPrivateEndpointConnections = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ftpEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ftpEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("remoteDebugEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            remoteDebugEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("inboundIpAddressOverride"))
                        {
                            inboundIpAddressOverride = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AseV3NetworkingConfigurationData(id, name, type, systemData.Value, Optional.ToList(windowsOutboundIpAddresses), Optional.ToList(linuxOutboundIpAddresses), Optional.ToList(externalInboundIpAddresses), Optional.ToList(internalInboundIpAddresses), Optional.ToNullable(allowNewPrivateEndpointConnections), Optional.ToNullable(ftpEnabled), Optional.ToNullable(remoteDebugEnabled), inboundIpAddressOverride.Value, kind.Value);
        }
    }
}
