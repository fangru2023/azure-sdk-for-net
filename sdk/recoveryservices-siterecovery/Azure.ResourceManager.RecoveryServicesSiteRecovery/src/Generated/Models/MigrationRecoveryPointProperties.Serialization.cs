// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class MigrationRecoveryPointProperties : IUtf8JsonSerializable, IJsonModel<MigrationRecoveryPointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrationRecoveryPointProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrationRecoveryPointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationRecoveryPointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationRecoveryPointProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RecoveryPointOn))
            {
                writer.WritePropertyName("recoveryPointTime"u8);
                writer.WriteStringValue(RecoveryPointOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RecoveryPointType))
            {
                writer.WritePropertyName("recoveryPointType"u8);
                writer.WriteStringValue(RecoveryPointType.Value.ToString());
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

        MigrationRecoveryPointProperties IJsonModel<MigrationRecoveryPointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationRecoveryPointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrationRecoveryPointProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationRecoveryPointProperties(document.RootElement, options);
        }

        internal static MigrationRecoveryPointProperties DeserializeMigrationRecoveryPointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? recoveryPointTime = default;
            MigrationRecoveryPointType? recoveryPointType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointType = new MigrationRecoveryPointType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrationRecoveryPointProperties(recoveryPointTime, recoveryPointType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrationRecoveryPointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationRecoveryPointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrationRecoveryPointProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MigrationRecoveryPointProperties IPersistableModel<MigrationRecoveryPointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrationRecoveryPointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrationRecoveryPointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrationRecoveryPointProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrationRecoveryPointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
