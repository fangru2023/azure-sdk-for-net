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
    public partial class HealthReportStatus : IUtf8JsonSerializable, IJsonModel<HealthReportStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthReportStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HealthReportStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthReportStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthReportStatus)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (options.Format != "W" && Optional.IsDefined(LastScannedOn))
            {
                writer.WritePropertyName("lastScannedDate"u8);
                writer.WriteStringValue(LastScannedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StatusChangeOn))
            {
                writer.WritePropertyName("statusChangeDate"u8);
                writer.WriteStringValue(StatusChangeOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(FirstEvaluationOn))
            {
                writer.WritePropertyName("firstEvaluationDate"u8);
                writer.WriteStringValue(FirstEvaluationOn.Value, "O");
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

        HealthReportStatus IJsonModel<HealthReportStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthReportStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthReportStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthReportStatus(document.RootElement, options);
        }

        internal static HealthReportStatus DeserializeHealthReportStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthReportStatusName? code = default;
            string reason = default;
            DateTimeOffset? lastScannedDate = default;
            DateTimeOffset? statusChangeDate = default;
            DateTimeOffset? firstEvaluationDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    code = new HealthReportStatusName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastScannedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastScannedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusChangeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusChangeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("firstEvaluationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstEvaluationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HealthReportStatus(
                code,
                reason,
                lastScannedDate,
                statusChangeDate,
                firstEvaluationDate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthReportStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthReportStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthReportStatus)} does not support writing '{options.Format}' format.");
            }
        }

        HealthReportStatus IPersistableModel<HealthReportStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthReportStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthReportStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthReportStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthReportStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
