// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SyncMigrationDatabaseErrorEvent : IUtf8JsonSerializable, IJsonModel<SyncMigrationDatabaseErrorEvent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncMigrationDatabaseErrorEvent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncMigrationDatabaseErrorEvent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMigrationDatabaseErrorEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncMigrationDatabaseErrorEvent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TimestampString))
            {
                writer.WritePropertyName("timestampString"u8);
                writer.WriteStringValue(TimestampString);
            }
            if (options.Format != "W" && Optional.IsDefined(EventTypeString))
            {
                writer.WritePropertyName("eventTypeString"u8);
                writer.WriteStringValue(EventTypeString);
            }
            if (options.Format != "W" && Optional.IsDefined(EventText))
            {
                writer.WritePropertyName("eventText"u8);
                writer.WriteStringValue(EventText);
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

        SyncMigrationDatabaseErrorEvent IJsonModel<SyncMigrationDatabaseErrorEvent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMigrationDatabaseErrorEvent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncMigrationDatabaseErrorEvent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncMigrationDatabaseErrorEvent(document.RootElement, options);
        }

        internal static SyncMigrationDatabaseErrorEvent DeserializeSyncMigrationDatabaseErrorEvent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string timestampString = default;
            string eventTypeString = default;
            string eventText = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestampString"u8))
                {
                    timestampString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventTypeString"u8))
                {
                    eventTypeString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventText"u8))
                {
                    eventText = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyncMigrationDatabaseErrorEvent(timestampString, eventTypeString, eventText, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SyncMigrationDatabaseErrorEvent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMigrationDatabaseErrorEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SyncMigrationDatabaseErrorEvent)} does not support writing '{options.Format}' format.");
            }
        }

        SyncMigrationDatabaseErrorEvent IPersistableModel<SyncMigrationDatabaseErrorEvent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMigrationDatabaseErrorEvent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncMigrationDatabaseErrorEvent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncMigrationDatabaseErrorEvent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncMigrationDatabaseErrorEvent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
