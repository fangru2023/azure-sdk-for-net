// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentReportProperties : IUtf8JsonSerializable, IJsonModel<GuestConfigurationAssignmentReportProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuestConfigurationAssignmentReportProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GuestConfigurationAssignmentReportProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ComplianceStatus))
            {
                writer.WritePropertyName("complianceStatus"u8);
                writer.WriteStringValue(ComplianceStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReportId))
            {
                writer.WritePropertyName("reportId"u8);
                writer.WriteStringValue(ReportId.Value);
            }
            if (Optional.IsDefined(Assignment))
            {
                writer.WritePropertyName("assignment"u8);
                writer.WriteObjectValue(Assignment);
            }
            if (Optional.IsDefined(Vm))
            {
                writer.WritePropertyName("vm"u8);
                writer.WriteObjectValue(Vm);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Details))
            {
                if (Details != null)
                {
                    writer.WritePropertyName("details"u8);
                    writer.WriteObjectValue(Details);
                }
                else
                {
                    writer.WriteNull("details");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(VmssResourceId))
            {
                writer.WritePropertyName("vmssResourceId"u8);
                writer.WriteStringValue(VmssResourceId);
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

        GuestConfigurationAssignmentReportProperties IJsonModel<GuestConfigurationAssignmentReportProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationAssignmentReportProperties(document.RootElement, options);
        }

        internal static GuestConfigurationAssignmentReportProperties DeserializeGuestConfigurationAssignmentReportProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AssignedGuestConfigurationMachineComplianceStatus? complianceStatus = default;
            Guid? reportId = default;
            GuestConfigurationAssignmentInfo assignment = default;
            GuestConfigurationVmInfo vm = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            GuestConfigurationAssignmentReportDetails details = default;
            string vmssResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reportId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("assignment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignment = GuestConfigurationAssignmentInfo.DeserializeGuestConfigurationAssignmentInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vm = GuestConfigurationVmInfo.DeserializeGuestConfigurationVmInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        details = null;
                        continue;
                    }
                    details = GuestConfigurationAssignmentReportDetails.DeserializeGuestConfigurationAssignmentReportDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vmssResourceId"u8))
                {
                    vmssResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GuestConfigurationAssignmentReportProperties(
                complianceStatus,
                reportId,
                assignment,
                vm,
                startTime,
                endTime,
                details,
                vmssResourceId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GuestConfigurationAssignmentReportProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportProperties)} does not support writing '{options.Format}' format.");
            }
        }

        GuestConfigurationAssignmentReportProperties IPersistableModel<GuestConfigurationAssignmentReportProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentReportProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuestConfigurationAssignmentReportProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentReportProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuestConfigurationAssignmentReportProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
