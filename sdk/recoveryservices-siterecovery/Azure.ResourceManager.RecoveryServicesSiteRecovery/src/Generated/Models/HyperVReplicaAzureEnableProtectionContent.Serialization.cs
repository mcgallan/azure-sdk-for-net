// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaAzureEnableProtectionContent : IUtf8JsonSerializable, IJsonModel<HyperVReplicaAzureEnableProtectionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaAzureEnableProtectionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVReplicaAzureEnableProtectionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureEnableProtectionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HyperVHostVmId))
            {
                writer.WritePropertyName("hvHostVmId"u8);
                writer.WriteStringValue(HyperVHostVmId);
            }
            if (Optional.IsDefined(VmName))
            {
                writer.WritePropertyName("vmName"u8);
                writer.WriteStringValue(VmName);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(VhdId))
            {
                writer.WritePropertyName("vhdId"u8);
                writer.WriteStringValue(VhdId);
            }
            if (Optional.IsDefined(TargetStorageAccountId))
            {
                writer.WritePropertyName("targetStorageAccountId"u8);
                writer.WriteStringValue(TargetStorageAccountId);
            }
            if (Optional.IsDefined(TargetAzureNetworkId))
            {
                writer.WritePropertyName("targetAzureNetworkId"u8);
                writer.WriteStringValue(TargetAzureNetworkId);
            }
            if (Optional.IsDefined(TargetAzureSubnetId))
            {
                writer.WritePropertyName("targetAzureSubnetId"u8);
                writer.WriteStringValue(TargetAzureSubnetId);
            }
            if (Optional.IsDefined(EnableRdpOnTargetOption))
            {
                writer.WritePropertyName("enableRdpOnTargetOption"u8);
                writer.WriteStringValue(EnableRdpOnTargetOption);
            }
            if (Optional.IsDefined(TargetAzureVmName))
            {
                writer.WritePropertyName("targetAzureVmName"u8);
                writer.WriteStringValue(TargetAzureVmName);
            }
            if (Optional.IsDefined(LogStorageAccountId))
            {
                writer.WritePropertyName("logStorageAccountId"u8);
                writer.WriteStringValue(LogStorageAccountId);
            }
            if (Optional.IsCollectionDefined(DisksToInclude))
            {
                writer.WritePropertyName("disksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetAzureV1ResourceGroupId))
            {
                writer.WritePropertyName("targetAzureV1ResourceGroupId"u8);
                writer.WriteStringValue(TargetAzureV1ResourceGroupId);
            }
            if (Optional.IsDefined(TargetAzureV2ResourceGroupId))
            {
                writer.WritePropertyName("targetAzureV2ResourceGroupId"u8);
                writer.WriteStringValue(TargetAzureV2ResourceGroupId);
            }
            if (Optional.IsDefined(UseManagedDisks))
            {
                writer.WritePropertyName("useManagedDisks"u8);
                writer.WriteStringValue(UseManagedDisks);
            }
            if (Optional.IsDefined(TargetAvailabilitySetId))
            {
                writer.WritePropertyName("targetAvailabilitySetId"u8);
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            if (Optional.IsDefined(TargetAvailabilityZone))
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(SqlServerLicenseType))
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType.Value.ToString());
            }
            if (Optional.IsDefined(TargetVmSize))
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(UseManagedDisksForReplication))
            {
                writer.WritePropertyName("useManagedDisksForReplication"u8);
                writer.WriteStringValue(UseManagedDisksForReplication);
            }
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DisksToIncludeForManagedDisks))
            {
                writer.WritePropertyName("disksToIncludeForManagedDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToIncludeForManagedDisks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (Optional.IsCollectionDefined(TargetVmTags))
            {
                writer.WritePropertyName("targetVmTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetVmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SeedManagedDiskTags))
            {
                writer.WritePropertyName("seedManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in SeedManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetManagedDiskTags))
            {
                writer.WritePropertyName("targetManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetNicTags))
            {
                writer.WritePropertyName("targetNicTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetNicTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        HyperVReplicaAzureEnableProtectionContent IJsonModel<HyperVReplicaAzureEnableProtectionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureEnableProtectionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureEnableProtectionContent(document.RootElement, options);
        }

        internal static HyperVReplicaAzureEnableProtectionContent DeserializeHyperVReplicaAzureEnableProtectionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hvHostVmId = default;
            Optional<string> vmName = default;
            Optional<string> osType = default;
            Optional<string> vhdId = default;
            Optional<ResourceIdentifier> targetStorageAccountId = default;
            Optional<ResourceIdentifier> targetAzureNetworkId = default;
            Optional<ResourceIdentifier> targetAzureSubnetId = default;
            Optional<string> enableRdpOnTargetOption = default;
            Optional<string> targetAzureVmName = default;
            Optional<ResourceIdentifier> logStorageAccountId = default;
            Optional<IList<string>> disksToInclude = default;
            Optional<ResourceIdentifier> targetAzureV1ResourceGroupId = default;
            Optional<ResourceIdentifier> targetAzureV2ResourceGroupId = default;
            Optional<string> useManagedDisks = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<SiteRecoveryLicenseType> licenseType = default;
            Optional<SiteRecoverySqlServerLicenseType> sqlServerLicenseType = default;
            Optional<string> targetVmSize = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<string> useManagedDisksForReplication = default;
            Optional<SiteRecoveryDiskAccountType> diskType = default;
            Optional<IList<HyperVReplicaAzureDiskDetails>> disksToIncludeForManagedDisks = default;
            Optional<ResourceIdentifier> diskEncryptionSetId = default;
            Optional<IDictionary<string, string>> targetVmTags = default;
            Optional<IDictionary<string, string>> seedManagedDiskTags = default;
            Optional<IDictionary<string, string>> targetManagedDiskTags = default;
            Optional<IDictionary<string, string>> targetNicTags = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hvHostVmId"u8))
                {
                    hvHostVmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmName"u8))
                {
                    vmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdId"u8))
                {
                    vhdId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableRdpOnTargetOption"u8))
                {
                    enableRdpOnTargetOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAzureVmName"u8))
                {
                    targetAzureVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
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
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("targetAzureV1ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureV1ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureV2ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureV2ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useManagedDisks"u8))
                {
                    useManagedDisks = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SiteRecoveryLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlServerLicenseType = new SiteRecoverySqlServerLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useManagedDisksForReplication"u8))
                {
                    useManagedDisksForReplication = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new SiteRecoveryDiskAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disksToIncludeForManagedDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HyperVReplicaAzureDiskDetails> array = new List<HyperVReplicaAzureDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVReplicaAzureDiskDetails.DeserializeHyperVReplicaAzureDiskDetails(item));
                    }
                    disksToIncludeForManagedDisks = array;
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetVmTags = dictionary;
                    continue;
                }
                if (property.NameEquals("seedManagedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    seedManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetManagedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetNicTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetNicTags = dictionary;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVReplicaAzureEnableProtectionContent(instanceType, serializedAdditionalRawData, hvHostVmId.Value, vmName.Value, osType.Value, vhdId.Value, targetStorageAccountId.Value, targetAzureNetworkId.Value, targetAzureSubnetId.Value, enableRdpOnTargetOption.Value, targetAzureVmName.Value, logStorageAccountId.Value, Optional.ToList(disksToInclude), targetAzureV1ResourceGroupId.Value, targetAzureV2ResourceGroupId.Value, useManagedDisks.Value, targetAvailabilitySetId.Value, targetAvailabilityZone.Value, Optional.ToNullable(licenseType), Optional.ToNullable(sqlServerLicenseType), targetVmSize.Value, targetProximityPlacementGroupId.Value, useManagedDisksForReplication.Value, Optional.ToNullable(diskType), Optional.ToList(disksToIncludeForManagedDisks), diskEncryptionSetId.Value, Optional.ToDictionary(targetVmTags), Optional.ToDictionary(seedManagedDiskTags), Optional.ToDictionary(targetManagedDiskTags), Optional.ToDictionary(targetNicTags));
        }

        BinaryData IPersistableModel<HyperVReplicaAzureEnableProtectionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureEnableProtectionContent)} does not support '{options.Format}' format.");
            }
        }

        HyperVReplicaAzureEnableProtectionContent IPersistableModel<HyperVReplicaAzureEnableProtectionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVReplicaAzureEnableProtectionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureEnableProtectionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVReplicaAzureEnableProtectionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
