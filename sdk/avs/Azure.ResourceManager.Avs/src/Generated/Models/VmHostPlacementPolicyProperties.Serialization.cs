// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class VmHostPlacementPolicyProperties : IUtf8JsonSerializable, IJsonModel<VmHostPlacementPolicyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmHostPlacementPolicyProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmHostPlacementPolicyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmHostPlacementPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmHostPlacementPolicyProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("vmMembers"u8);
            writer.WriteStartArray();
            foreach (var item in VmMembers)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("hostMembers"u8);
            writer.WriteStartArray();
            foreach (var item in HostMembers)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("affinityType"u8);
            writer.WriteStringValue(AffinityType.ToString());
            if (Optional.IsDefined(AffinityStrength))
            {
                writer.WritePropertyName("affinityStrength"u8);
                writer.WriteStringValue(AffinityStrength.Value.ToString());
            }
            if (Optional.IsDefined(AzureHybridBenefitType))
            {
                writer.WritePropertyName("azureHybridBenefitType"u8);
                writer.WriteStringValue(AzureHybridBenefitType.Value.ToString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(PolicyType.ToString());
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        VmHostPlacementPolicyProperties IJsonModel<VmHostPlacementPolicyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmHostPlacementPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmHostPlacementPolicyProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmHostPlacementPolicyProperties(document.RootElement, options);
        }

        internal static VmHostPlacementPolicyProperties DeserializeVmHostPlacementPolicyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceIdentifier> vmMembers = default;
            IList<string> hostMembers = default;
            AvsPlacementPolicyAffinityType affinityType = default;
            VmHostPlacementPolicyAffinityStrength? affinityStrength = default;
            AzureHybridBenefitType? azureHybridBenefitType = default;
            PlacementPolicyType type = default;
            PlacementPolicyState? state = default;
            string displayName = default;
            PlacementPolicyProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmMembers"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    vmMembers = array;
                    continue;
                }
                if (property.NameEquals("hostMembers"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hostMembers = array;
                    continue;
                }
                if (property.NameEquals("affinityType"u8))
                {
                    affinityType = new AvsPlacementPolicyAffinityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("affinityStrength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    affinityStrength = new VmHostPlacementPolicyAffinityStrength(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureHybridBenefitType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureHybridBenefitType = new AzureHybridBenefitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new PlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PlacementPolicyState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new PlacementPolicyProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmHostPlacementPolicyProperties(
                type,
                state,
                displayName,
                provisioningState,
                serializedAdditionalRawData,
                vmMembers,
                hostMembers,
                affinityType,
                affinityStrength,
                azureHybridBenefitType);
        }

        BinaryData IPersistableModel<VmHostPlacementPolicyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmHostPlacementPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmHostPlacementPolicyProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VmHostPlacementPolicyProperties IPersistableModel<VmHostPlacementPolicyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmHostPlacementPolicyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmHostPlacementPolicyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmHostPlacementPolicyProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmHostPlacementPolicyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
