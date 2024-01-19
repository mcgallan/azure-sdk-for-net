// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClusterPropertiesAutoScalerProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BalanceSimilarNodeGroups))
            {
                writer.WritePropertyName("balance-similar-node-groups"u8);
                writer.WriteStringValue(BalanceSimilarNodeGroups);
            }
            if (Optional.IsDefined(Expander))
            {
                writer.WritePropertyName("expander"u8);
                writer.WriteStringValue(Expander.Value.ToString());
            }
            if (Optional.IsDefined(MaxEmptyBulkDelete))
            {
                writer.WritePropertyName("max-empty-bulk-delete"u8);
                writer.WriteStringValue(MaxEmptyBulkDelete);
            }
            if (Optional.IsDefined(MaxGracefulTerminationSec))
            {
                writer.WritePropertyName("max-graceful-termination-sec"u8);
                writer.WriteStringValue(MaxGracefulTerminationSec);
            }
            if (Optional.IsDefined(MaxNodeProvisionTime))
            {
                writer.WritePropertyName("max-node-provision-time"u8);
                writer.WriteStringValue(MaxNodeProvisionTime);
            }
            if (Optional.IsDefined(MaxTotalUnreadyPercentage))
            {
                writer.WritePropertyName("max-total-unready-percentage"u8);
                writer.WriteStringValue(MaxTotalUnreadyPercentage);
            }
            if (Optional.IsDefined(NewPodScaleUpDelay))
            {
                writer.WritePropertyName("new-pod-scale-up-delay"u8);
                writer.WriteStringValue(NewPodScaleUpDelay);
            }
            if (Optional.IsDefined(OkTotalUnreadyCount))
            {
                writer.WritePropertyName("ok-total-unready-count"u8);
                writer.WriteStringValue(OkTotalUnreadyCount);
            }
            if (Optional.IsDefined(ScanInterval))
            {
                writer.WritePropertyName("scan-interval"u8);
                writer.WriteStringValue(ScanInterval);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterAdd))
            {
                writer.WritePropertyName("scale-down-delay-after-add"u8);
                writer.WriteStringValue(ScaleDownDelayAfterAdd);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterDelete))
            {
                writer.WritePropertyName("scale-down-delay-after-delete"u8);
                writer.WriteStringValue(ScaleDownDelayAfterDelete);
            }
            if (Optional.IsDefined(ScaleDownDelayAfterFailure))
            {
                writer.WritePropertyName("scale-down-delay-after-failure"u8);
                writer.WriteStringValue(ScaleDownDelayAfterFailure);
            }
            if (Optional.IsDefined(ScaleDownUnneededTime))
            {
                writer.WritePropertyName("scale-down-unneeded-time"u8);
                writer.WriteStringValue(ScaleDownUnneededTime);
            }
            if (Optional.IsDefined(ScaleDownUnreadyTime))
            {
                writer.WritePropertyName("scale-down-unready-time"u8);
                writer.WriteStringValue(ScaleDownUnreadyTime);
            }
            if (Optional.IsDefined(ScaleDownUtilizationThreshold))
            {
                writer.WritePropertyName("scale-down-utilization-threshold"u8);
                writer.WriteStringValue(ScaleDownUtilizationThreshold);
            }
            if (Optional.IsDefined(SkipNodesWithLocalStorage))
            {
                writer.WritePropertyName("skip-nodes-with-local-storage"u8);
                writer.WriteStringValue(SkipNodesWithLocalStorage);
            }
            if (Optional.IsDefined(SkipNodesWithSystemPods))
            {
                writer.WritePropertyName("skip-nodes-with-system-pods"u8);
                writer.WriteStringValue(SkipNodesWithSystemPods);
            }
            writer.WriteEndObject();
        }

        internal static ProvisionedClusterPropertiesAutoScalerProfile DeserializeProvisionedClusterPropertiesAutoScalerProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> balanceSimilarNodeGroups = default;
            Optional<HybridContainerServiceExpander> expander = default;
            Optional<string> maxEmptyBulkDelete = default;
            Optional<string> maxGracefulTerminationSec = default;
            Optional<string> maxNodeProvisionTime = default;
            Optional<string> maxTotalUnreadyPercentage = default;
            Optional<string> newPodScaleUpDelay = default;
            Optional<string> okTotalUnreadyCount = default;
            Optional<string> scanInterval = default;
            Optional<string> scaleDownDelayAfterAdd = default;
            Optional<string> scaleDownDelayAfterDelete = default;
            Optional<string> scaleDownDelayAfterFailure = default;
            Optional<string> scaleDownUnneededTime = default;
            Optional<string> scaleDownUnreadyTime = default;
            Optional<string> scaleDownUtilizationThreshold = default;
            Optional<string> skipNodesWithLocalStorage = default;
            Optional<string> skipNodesWithSystemPods = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("balance-similar-node-groups"u8))
                {
                    balanceSimilarNodeGroups = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expander"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expander = new HybridContainerServiceExpander(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("max-empty-bulk-delete"u8))
                {
                    maxEmptyBulkDelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-graceful-termination-sec"u8))
                {
                    maxGracefulTerminationSec = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-node-provision-time"u8))
                {
                    maxNodeProvisionTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("max-total-unready-percentage"u8))
                {
                    maxTotalUnreadyPercentage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("new-pod-scale-up-delay"u8))
                {
                    newPodScaleUpDelay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ok-total-unready-count"u8))
                {
                    okTotalUnreadyCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scan-interval"u8))
                {
                    scanInterval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-add"u8))
                {
                    scaleDownDelayAfterAdd = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-delete"u8))
                {
                    scaleDownDelayAfterDelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-delay-after-failure"u8))
                {
                    scaleDownDelayAfterFailure = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-unneeded-time"u8))
                {
                    scaleDownUnneededTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-unready-time"u8))
                {
                    scaleDownUnreadyTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scale-down-utilization-threshold"u8))
                {
                    scaleDownUtilizationThreshold = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip-nodes-with-local-storage"u8))
                {
                    skipNodesWithLocalStorage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip-nodes-with-system-pods"u8))
                {
                    skipNodesWithSystemPods = property.Value.GetString();
                    continue;
                }
            }
            return new ProvisionedClusterPropertiesAutoScalerProfile(balanceSimilarNodeGroups.Value, Optional.ToNullable(expander), maxEmptyBulkDelete.Value, maxGracefulTerminationSec.Value, maxNodeProvisionTime.Value, maxTotalUnreadyPercentage.Value, newPodScaleUpDelay.Value, okTotalUnreadyCount.Value, scanInterval.Value, scaleDownDelayAfterAdd.Value, scaleDownDelayAfterDelete.Value, scaleDownDelayAfterFailure.Value, scaleDownUnneededTime.Value, scaleDownUnreadyTime.Value, scaleDownUtilizationThreshold.Value, skipNodesWithLocalStorage.Value, skipNodesWithSystemPods.Value);
        }
    }
}
