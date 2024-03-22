// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderCspmGcpOffering : IUtf8JsonSerializable, IJsonModel<DefenderCspmGcpOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmGcpOffering>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderCspmGcpOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmGcpOffering)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CiemDiscovery))
            {
                writer.WritePropertyName("ciemDiscovery"u8);
                writer.WriteObjectValue(CiemDiscovery);
            }
            if (Optional.IsDefined(VmScanners))
            {
                writer.WritePropertyName("vmScanners"u8);
                writer.WriteObjectValue(VmScanners);
            }
            if (Optional.IsDefined(DataSensitivityDiscovery))
            {
                writer.WritePropertyName("dataSensitivityDiscovery"u8);
                writer.WriteObjectValue(DataSensitivityDiscovery);
            }
            if (Optional.IsDefined(MdcContainersImageAssessment))
            {
                writer.WritePropertyName("mdcContainersImageAssessment"u8);
                writer.WriteObjectValue(MdcContainersImageAssessment);
            }
            if (Optional.IsDefined(MdcContainersAgentlessDiscoveryK8S))
            {
                writer.WritePropertyName("mdcContainersAgentlessDiscoveryK8s"u8);
                writer.WriteObjectValue(MdcContainersAgentlessDiscoveryK8S);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        DefenderCspmGcpOffering IJsonModel<DefenderCspmGcpOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmGcpOffering)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmGcpOffering(document.RootElement, options);
        }

        internal static DefenderCspmGcpOffering DeserializeDefenderCspmGcpOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DefenderCspmGcpOfferingCiemDiscovery ciemDiscovery = default;
            DefenderCspmGcpOfferingVmScanners vmScanners = default;
            DefenderCspmGcpOfferingDataSensitivityDiscovery dataSensitivityDiscovery = default;
            DefenderCspmGcpOfferingMdcContainersImageAssessment mdcContainersImageAssessment = default;
            DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S mdcContainersAgentlessDiscoveryK8S = default;
            OfferingType offeringType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ciemDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ciemDiscovery = DefenderCspmGcpOfferingCiemDiscovery.DeserializeDefenderCspmGcpOfferingCiemDiscovery(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vmScanners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmScanners = DefenderCspmGcpOfferingVmScanners.DeserializeDefenderCspmGcpOfferingVmScanners(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataSensitivityDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSensitivityDiscovery = DefenderCspmGcpOfferingDataSensitivityDiscovery.DeserializeDefenderCspmGcpOfferingDataSensitivityDiscovery(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mdcContainersImageAssessment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersImageAssessment = DefenderCspmGcpOfferingMdcContainersImageAssessment.DeserializeDefenderCspmGcpOfferingMdcContainersImageAssessment(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mdcContainersAgentlessDiscoveryK8s"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersAgentlessDiscoveryK8S = DefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S.DeserializeDefenderCspmGcpOfferingMdcContainersAgentlessDiscoveryK8S(property.Value, options);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderCspmGcpOffering(
                offeringType,
                description,
                serializedAdditionalRawData,
                ciemDiscovery,
                vmScanners,
                dataSensitivityDiscovery,
                mdcContainersImageAssessment,
                mdcContainersAgentlessDiscoveryK8S);
        }

        BinaryData IPersistableModel<DefenderCspmGcpOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmGcpOffering)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderCspmGcpOffering IPersistableModel<DefenderCspmGcpOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmGcpOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderCspmGcpOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmGcpOffering)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmGcpOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
