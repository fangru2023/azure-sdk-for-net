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
    public partial class AmlComputeProperties : IUtf8JsonSerializable, IJsonModel<AmlComputeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlComputeProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AmlComputeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlComputeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlComputeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(VmPriority))
            {
                writer.WritePropertyName("vmPriority"u8);
                writer.WriteStringValue(VmPriority.Value.ToString());
            }
            if (Optional.IsDefined(VirtualMachineImage))
            {
                if (VirtualMachineImage != null)
                {
                    writer.WritePropertyName("virtualMachineImage"u8);
                    writer.WriteObjectValue(VirtualMachineImage);
                }
                else
                {
                    writer.WriteNull("virtualMachineImage");
                }
            }
            if (Optional.IsDefined(IsolatedNetwork))
            {
                writer.WritePropertyName("isolatedNetwork"u8);
                writer.WriteBooleanValue(IsolatedNetwork.Value);
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings"u8);
                writer.WriteObjectValue(ScaleSettings);
            }
            if (Optional.IsDefined(UserAccountCredentials))
            {
                if (UserAccountCredentials != null)
                {
                    writer.WritePropertyName("userAccountCredentials"u8);
                    writer.WriteObjectValue(UserAccountCredentials);
                }
                else
                {
                    writer.WriteNull("userAccountCredentials");
                }
            }
            if (Optional.IsDefined(Subnet))
            {
                if (Subnet != null)
                {
                    writer.WritePropertyName("subnet"u8);
                    writer.WriteObjectValue(Subnet);
                }
                else
                {
                    writer.WriteNull("subnet");
                }
            }
            if (Optional.IsDefined(RemoteLoginPortPublicAccess))
            {
                writer.WritePropertyName("remoteLoginPortPublicAccess"u8);
                writer.WriteStringValue(RemoteLoginPortPublicAccess.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AllocationState))
            {
                writer.WritePropertyName("allocationState"u8);
                writer.WriteStringValue(AllocationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AllocationStateTransitionOn))
            {
                writer.WritePropertyName("allocationStateTransitionTime"u8);
                writer.WriteStringValue(AllocationStateTransitionOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Errors))
            {
                if (Errors != null)
                {
                    writer.WritePropertyName("errors"u8);
                    writer.WriteStartArray();
                    foreach (var item in Errors)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("errors");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentNodeCount))
            {
                if (CurrentNodeCount != null)
                {
                    writer.WritePropertyName("currentNodeCount"u8);
                    writer.WriteNumberValue(CurrentNodeCount.Value);
                }
                else
                {
                    writer.WriteNull("currentNodeCount");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(TargetNodeCount))
            {
                if (TargetNodeCount != null)
                {
                    writer.WritePropertyName("targetNodeCount"u8);
                    writer.WriteNumberValue(TargetNodeCount.Value);
                }
                else
                {
                    writer.WriteNull("targetNodeCount");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(NodeStateCounts))
            {
                if (NodeStateCounts != null)
                {
                    writer.WritePropertyName("nodeStateCounts"u8);
                    writer.WriteObjectValue(NodeStateCounts);
                }
                else
                {
                    writer.WriteNull("nodeStateCounts");
                }
            }
            if (Optional.IsDefined(EnableNodePublicIP))
            {
                if (EnableNodePublicIP != null)
                {
                    writer.WritePropertyName("enableNodePublicIp"u8);
                    writer.WriteBooleanValue(EnableNodePublicIP.Value);
                }
                else
                {
                    writer.WriteNull("enableNodePublicIp");
                }
            }
            if (Optional.IsDefined(PropertyBag))
            {
                if (PropertyBag != null)
                {
                    writer.WritePropertyName("propertyBag"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PropertyBag);
#else
                    using (JsonDocument document = JsonDocument.Parse(PropertyBag))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                else
                {
                    writer.WriteNull("propertyBag");
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

        AmlComputeProperties IJsonModel<AmlComputeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlComputeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlComputeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlComputeProperties(document.RootElement, options);
        }

        internal static AmlComputeProperties DeserializeAmlComputeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningOSType? osType = default;
            string vmSize = default;
            MachineLearningVmPriority? vmPriority = default;
            VirtualMachineImage virtualMachineImage = default;
            bool? isolatedNetwork = default;
            AmlComputeScaleSettings scaleSettings = default;
            MachineLearningUserAccountCredentials userAccountCredentials = default;
            ResourceId subnet = default;
            MachineLearningRemoteLoginPortPublicAccess? remoteLoginPortPublicAccess = default;
            MachineLearningAllocationState? allocationState = default;
            DateTimeOffset? allocationStateTransitionTime = default;
            IReadOnlyList<MachineLearningError> errors = default;
            int? currentNodeCount = default;
            int? targetNodeCount = default;
            MachineLearningNodeStateCounts nodeStateCounts = default;
            bool? enableNodePublicIP = default;
            BinaryData propertyBag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new MachineLearningOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmPriority = new MachineLearningVmPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineImage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        virtualMachineImage = null;
                        continue;
                    }
                    virtualMachineImage = VirtualMachineImage.DeserializeVirtualMachineImage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isolatedNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isolatedNetwork = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("scaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleSettings = AmlComputeScaleSettings.DeserializeAmlComputeScaleSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userAccountCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userAccountCredentials = null;
                        continue;
                    }
                    userAccountCredentials = MachineLearningUserAccountCredentials.DeserializeMachineLearningUserAccountCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subnet = null;
                        continue;
                    }
                    subnet = ResourceId.DeserializeResourceId(property.Value, options);
                    continue;
                }
                if (property.NameEquals("remoteLoginPortPublicAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteLoginPortPublicAccess = new MachineLearningRemoteLoginPortPublicAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allocationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationState = new MachineLearningAllocationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allocationStateTransitionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationStateTransitionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errors = null;
                        continue;
                    }
                    List<MachineLearningError> array = new List<MachineLearningError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MachineLearningError.DeserializeMachineLearningError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("currentNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        currentNodeCount = null;
                        continue;
                    }
                    currentNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("targetNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetNodeCount = null;
                        continue;
                    }
                    targetNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeStateCounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nodeStateCounts = null;
                        continue;
                    }
                    nodeStateCounts = MachineLearningNodeStateCounts.DeserializeMachineLearningNodeStateCounts(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enableNodePublicIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableNodePublicIP = null;
                        continue;
                    }
                    enableNodePublicIP = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        propertyBag = null;
                        continue;
                    }
                    propertyBag = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlComputeProperties(
                osType,
                vmSize,
                vmPriority,
                virtualMachineImage,
                isolatedNetwork,
                scaleSettings,
                userAccountCredentials,
                subnet,
                remoteLoginPortPublicAccess,
                allocationState,
                allocationStateTransitionTime,
                errors ?? new ChangeTrackingList<MachineLearningError>(),
                currentNodeCount,
                targetNodeCount,
                nodeStateCounts,
                enableNodePublicIP,
                propertyBag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlComputeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlComputeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmlComputeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AmlComputeProperties IPersistableModel<AmlComputeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlComputeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmlComputeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmlComputeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmlComputeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
