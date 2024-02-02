// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlMigrationSecretParameters : IUtf8JsonSerializable, IJsonModel<PostgreSqlMigrationSecretParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlMigrationSecretParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlMigrationSecretParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationSecretParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationSecretParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("adminCredentials"u8);
            writer.WriteObjectValue(AdminCredentials);
            if (Optional.IsDefined(SourceServerUsername))
            {
                writer.WritePropertyName("sourceServerUsername"u8);
                writer.WriteStringValue(SourceServerUsername);
            }
            if (Optional.IsDefined(TargetServerUsername))
            {
                writer.WritePropertyName("targetServerUsername"u8);
                writer.WriteStringValue(TargetServerUsername);
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

        PostgreSqlMigrationSecretParameters IJsonModel<PostgreSqlMigrationSecretParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationSecretParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlMigrationSecretParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationSecretParameters(document.RootElement, options);
        }

        internal static PostgreSqlMigrationSecretParameters DeserializePostgreSqlMigrationSecretParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PostgreSqlMigrationAdminCredentials adminCredentials = default;
            Optional<string> sourceServerUsername = default;
            Optional<string> targetServerUsername = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminCredentials"u8))
                {
                    adminCredentials = PostgreSqlMigrationAdminCredentials.DeserializePostgreSqlMigrationAdminCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceServerUsername"u8))
                {
                    sourceServerUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerUsername"u8))
                {
                    targetServerUsername = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlMigrationSecretParameters(adminCredentials, sourceServerUsername.Value, targetServerUsername.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlMigrationSecretParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationSecretParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlMigrationSecretParameters)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlMigrationSecretParameters IPersistableModel<PostgreSqlMigrationSecretParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlMigrationSecretParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlMigrationSecretParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlMigrationSecretParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlMigrationSecretParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
