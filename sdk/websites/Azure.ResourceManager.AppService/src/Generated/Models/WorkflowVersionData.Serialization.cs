// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class WorkflowVersionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(EndpointsConfiguration))
            {
                writer.WritePropertyName("endpointsConfiguration");
                writer.WriteObjectValue(EndpointsConfiguration);
            }
            if (Optional.IsDefined(AccessControl))
            {
                writer.WritePropertyName("accessControl");
                writer.WriteObjectValue(AccessControl);
            }
            if (Optional.IsDefined(IntegrationAccount))
            {
                writer.WritePropertyName("integrationAccount");
                writer.WriteObjectValue(IntegrationAccount);
            }
            if (Optional.IsDefined(Definition))
            {
                writer.WritePropertyName("definition");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Definition);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Definition.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkflowVersionData DeserializeWorkflowVersionData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<WorkflowProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<DateTimeOffset> changedTime = default;
            Optional<WorkflowState> state = default;
            Optional<string> version = default;
            Optional<string> accessEndpoint = default;
            Optional<FlowEndpointsConfiguration> endpointsConfiguration = default;
            Optional<FlowAccessControlConfiguration> accessControl = default;
            Optional<WorkflowSku> sku = default;
            Optional<ResourceReference> integrationAccount = default;
            Optional<BinaryData> definition = default;
            Optional<IDictionary<string, WorkflowParameter>> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new WorkflowProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            changedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new WorkflowState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accessEndpoint"))
                        {
                            accessEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointsConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endpointsConfiguration = FlowEndpointsConfiguration.DeserializeFlowEndpointsConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessControl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessControl = FlowAccessControlConfiguration.DeserializeFlowAccessControlConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sku = WorkflowSku.DeserializeWorkflowSku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("integrationAccount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            integrationAccount = ResourceReference.DeserializeResourceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("definition"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            definition = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, WorkflowParameter> dictionary = new Dictionary<string, WorkflowParameter>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, WorkflowParameter.DeserializeWorkflowParameter(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkflowVersionData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToNullable(createdTime), Optional.ToNullable(changedTime), Optional.ToNullable(state), version.Value, accessEndpoint.Value, endpointsConfiguration.Value, accessControl.Value, sku.Value, integrationAccount.Value, definition.Value, Optional.ToDictionary(parameters));
        }
    }
}
