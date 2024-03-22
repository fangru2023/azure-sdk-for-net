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
    public partial class MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError : IUtf8JsonSerializable, IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(document.RootElement, options);
        }

        internal static MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string errorMessage = default;
            IReadOnlyList<SyncMigrationDatabaseErrorEvent> events = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncMigrationDatabaseErrorEvent> array = new List<SyncMigrationDatabaseErrorEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncMigrationDatabaseErrorEvent.DeserializeSyncMigrationDatabaseErrorEvent(item, options));
                    }
                    events = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(id, resultType, serializedAdditionalRawData, errorMessage, events ?? new ChangeTrackingList<SyncMigrationDatabaseErrorEvent>());
        }

        BinaryData IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
