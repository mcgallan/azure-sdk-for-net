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
    public partial class WorkflowRunData
    {
        internal static WorkflowRunData DeserializeWorkflowRunData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> waitEndTime = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<WorkflowStatus> status = default;
            Optional<string> code = default;
            Optional<BinaryData> error = default;
            Optional<string> correlationId = default;
            Optional<Correlation> correlation = default;
            Optional<ResourceReference> workflow = default;
            Optional<WorkflowRunTrigger> trigger = default;
            Optional<IReadOnlyDictionary<string, WorkflowOutputParameter>> outputs = default;
            Optional<WorkflowRunTrigger> response = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("waitEndTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            waitEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new WorkflowStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("code"))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            error = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("correlationId"))
                        {
                            correlationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            correlation = Correlation.DeserializeCorrelation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workflow"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            workflow = ResourceReference.DeserializeResourceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("trigger"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trigger = WorkflowRunTrigger.DeserializeWorkflowRunTrigger(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, WorkflowOutputParameter> dictionary = new Dictionary<string, WorkflowOutputParameter>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, WorkflowOutputParameter.DeserializeWorkflowOutputParameter(property1.Value));
                            }
                            outputs = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("response"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            response = WorkflowRunTrigger.DeserializeWorkflowRunTrigger(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkflowRunData(id, name, type, systemData.Value, Optional.ToNullable(waitEndTime), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(status), code.Value, error.Value, correlationId.Value, correlation.Value, workflow.Value, trigger.Value, Optional.ToDictionary(outputs), response.Value);
        }
    }
}
