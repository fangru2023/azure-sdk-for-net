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
    public partial class InMageRcmEnableProtectionContent : IUtf8JsonSerializable, IJsonModel<InMageRcmEnableProtectionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmEnableProtectionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmEnableProtectionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmEnableProtectionContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fabricDiscoveryMachineId"u8);
            writer.WriteStringValue(FabricDiscoveryMachineId);
            if (Optional.IsCollectionDefined(DisksToInclude))
            {
                writer.WritePropertyName("disksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToInclude)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisksDefault))
            {
                writer.WritePropertyName("disksDefault"u8);
                writer.WriteObjectValue(DisksDefault);
            }
            writer.WritePropertyName("targetResourceGroupId"u8);
            writer.WriteStringValue(TargetResourceGroupId);
            if (Optional.IsDefined(TargetNetworkId))
            {
                writer.WritePropertyName("targetNetworkId"u8);
                writer.WriteStringValue(TargetNetworkId);
            }
            if (Optional.IsDefined(TestNetworkId))
            {
                writer.WritePropertyName("testNetworkId"u8);
                writer.WriteStringValue(TestNetworkId);
            }
            if (Optional.IsDefined(TargetSubnetName))
            {
                writer.WritePropertyName("targetSubnetName"u8);
                writer.WriteStringValue(TargetSubnetName);
            }
            if (Optional.IsDefined(TestSubnetName))
            {
                writer.WritePropertyName("testSubnetName"u8);
                writer.WriteStringValue(TestSubnetName);
            }
            if (Optional.IsDefined(TargetVmName))
            {
                writer.WritePropertyName("targetVmName"u8);
                writer.WriteStringValue(TargetVmName);
            }
            if (Optional.IsDefined(TargetVmSize))
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
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
            if (Optional.IsDefined(TargetProximityPlacementGroupId))
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (Optional.IsDefined(TargetBootDiagnosticsStorageAccountId))
            {
                writer.WritePropertyName("targetBootDiagnosticsStorageAccountId"u8);
                writer.WriteStringValue(TargetBootDiagnosticsStorageAccountId);
            }
            if (Optional.IsDefined(RunAsAccountId))
            {
                writer.WritePropertyName("runAsAccountId"u8);
                writer.WriteStringValue(RunAsAccountId);
            }
            writer.WritePropertyName("processServerId"u8);
            writer.WriteStringValue(ProcessServerId);
            if (Optional.IsDefined(MultiVmGroupName))
            {
                writer.WritePropertyName("multiVmGroupName"u8);
                writer.WriteStringValue(MultiVmGroupName);
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

        InMageRcmEnableProtectionContent IJsonModel<InMageRcmEnableProtectionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmEnableProtectionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmEnableProtectionContent(document.RootElement, options);
        }

        internal static InMageRcmEnableProtectionContent DeserializeInMageRcmEnableProtectionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fabricDiscoveryMachineId = default;
            IList<InMageRcmDiskContent> disksToInclude = default;
            InMageRcmDisksDefaultContent disksDefault = default;
            ResourceIdentifier targetResourceGroupId = default;
            ResourceIdentifier targetNetworkId = default;
            ResourceIdentifier testNetworkId = default;
            string targetSubnetName = default;
            string testSubnetName = default;
            string targetVmName = default;
            string targetVmSize = default;
            SiteRecoveryLicenseType? licenseType = default;
            ResourceIdentifier targetAvailabilitySetId = default;
            string targetAvailabilityZone = default;
            ResourceIdentifier targetProximityPlacementGroupId = default;
            ResourceIdentifier targetBootDiagnosticsStorageAccountId = default;
            string runAsAccountId = default;
            Guid processServerId = default;
            string multiVmGroupName = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricDiscoveryMachineId"u8))
                {
                    fabricDiscoveryMachineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageRcmDiskContent> array = new List<InMageRcmDiskContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmDiskContent.DeserializeInMageRcmDiskContent(item, options));
                    }
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("disksDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disksDefault = InMageRcmDisksDefaultContent.DeserializeInMageRcmDisksDefaultContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetResourceGroupId"u8))
                {
                    targetResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetSubnetName"u8))
                {
                    targetSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testSubnetName"u8))
                {
                    testSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmName"u8))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
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
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetBootDiagnosticsStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetBootDiagnosticsStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServerId"u8))
                {
                    processServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
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
            return new InMageRcmEnableProtectionContent(
                instanceType,
                serializedAdditionalRawData,
                fabricDiscoveryMachineId,
                disksToInclude ?? new ChangeTrackingList<InMageRcmDiskContent>(),
                disksDefault,
                targetResourceGroupId,
                targetNetworkId,
                testNetworkId,
                targetSubnetName,
                testSubnetName,
                targetVmName,
                targetVmSize,
                licenseType,
                targetAvailabilitySetId,
                targetAvailabilityZone,
                targetProximityPlacementGroupId,
                targetBootDiagnosticsStorageAccountId,
                runAsAccountId,
                processServerId,
                multiVmGroupName);
        }

        BinaryData IPersistableModel<InMageRcmEnableProtectionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmEnableProtectionContent)} does not support writing '{options.Format}' format.");
            }
        }

        InMageRcmEnableProtectionContent IPersistableModel<InMageRcmEnableProtectionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmEnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmEnableProtectionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmEnableProtectionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmEnableProtectionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
