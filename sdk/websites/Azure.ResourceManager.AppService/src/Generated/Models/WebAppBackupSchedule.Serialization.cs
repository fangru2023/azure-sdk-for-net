// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppBackupSchedule : IUtf8JsonSerializable, IJsonModel<WebAppBackupSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppBackupSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebAppBackupSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppBackupSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("frequencyInterval"u8);
            writer.WriteNumberValue(FrequencyInterval);
            writer.WritePropertyName("frequencyUnit"u8);
            writer.WriteStringValue(FrequencyUnit.ToSerialString());
            writer.WritePropertyName("keepAtLeastOneBackup"u8);
            writer.WriteBooleanValue(ShouldKeepAtLeastOneBackup);
            writer.WritePropertyName("retentionPeriodInDays"u8);
            writer.WriteNumberValue(RetentionPeriodInDays);
            if (StartOn.HasValue)
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && LastExecutedOn.HasValue)
            {
                writer.WritePropertyName("lastExecutionTime"u8);
                writer.WriteStringValue(LastExecutedOn.Value, "O");
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

        WebAppBackupSchedule IJsonModel<WebAppBackupSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppBackupSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppBackupSchedule(document.RootElement, options);
        }

        internal static WebAppBackupSchedule DeserializeWebAppBackupSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int frequencyInterval = default;
            BackupFrequencyUnit frequencyUnit = default;
            bool keepAtLeastOneBackup = default;
            int retentionPeriodInDays = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? lastExecutionTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frequencyInterval"u8))
                {
                    frequencyInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frequencyUnit"u8))
                {
                    frequencyUnit = property.Value.GetString().ToBackupFrequencyUnit();
                    continue;
                }
                if (property.NameEquals("keepAtLeastOneBackup"u8))
                {
                    keepAtLeastOneBackup = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retentionPeriodInDays"u8))
                {
                    retentionPeriodInDays = property.Value.GetInt32();
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
                if (property.NameEquals("lastExecutionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastExecutionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebAppBackupSchedule(
                frequencyInterval,
                frequencyUnit,
                keepAtLeastOneBackup,
                retentionPeriodInDays,
                startTime,
                lastExecutionTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebAppBackupSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebAppBackupSchedule)} does not support '{options.Format}' format.");
            }
        }

        WebAppBackupSchedule IPersistableModel<WebAppBackupSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebAppBackupSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebAppBackupSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppBackupSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
