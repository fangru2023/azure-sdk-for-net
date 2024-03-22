// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsTableRestoredLogs : IUtf8JsonSerializable, IJsonModel<OperationalInsightsTableRestoredLogs>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsTableRestoredLogs>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalInsightsTableRestoredLogs>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableRestoredLogs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableRestoredLogs)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StartRestoreOn))
            {
                writer.WritePropertyName("startRestoreTime"u8);
                writer.WriteStringValue(StartRestoreOn.Value, "O");
            }
            if (Optional.IsDefined(EndRestoreOn))
            {
                writer.WritePropertyName("endRestoreTime"u8);
                writer.WriteStringValue(EndRestoreOn.Value, "O");
            }
            if (Optional.IsDefined(SourceTable))
            {
                writer.WritePropertyName("sourceTable"u8);
                writer.WriteStringValue(SourceTable);
            }
            if (options.Format != "W" && Optional.IsDefined(AzureAsyncOperationId))
            {
                writer.WritePropertyName("azureAsyncOperationId"u8);
                writer.WriteStringValue(AzureAsyncOperationId.Value);
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

        OperationalInsightsTableRestoredLogs IJsonModel<OperationalInsightsTableRestoredLogs>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableRestoredLogs>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsTableRestoredLogs)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsTableRestoredLogs(document.RootElement, options);
        }

        internal static OperationalInsightsTableRestoredLogs DeserializeOperationalInsightsTableRestoredLogs(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? startRestoreTime = default;
            DateTimeOffset? endRestoreTime = default;
            string sourceTable = default;
            Guid? azureAsyncOperationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startRestoreTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startRestoreTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endRestoreTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endRestoreTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceTable"u8))
                {
                    sourceTable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureAsyncOperationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureAsyncOperationId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsTableRestoredLogs(startRestoreTime, endRestoreTime, sourceTable, azureAsyncOperationId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsTableRestoredLogs>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableRestoredLogs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsTableRestoredLogs)} does not support writing '{options.Format}' format.");
            }
        }

        OperationalInsightsTableRestoredLogs IPersistableModel<OperationalInsightsTableRestoredLogs>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsTableRestoredLogs>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsTableRestoredLogs(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsTableRestoredLogs)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsTableRestoredLogs>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
