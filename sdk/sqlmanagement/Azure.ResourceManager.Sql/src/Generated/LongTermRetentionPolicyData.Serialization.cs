// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class LongTermRetentionPolicyData : IUtf8JsonSerializable, IJsonModel<LongTermRetentionPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LongTermRetentionPolicyData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LongTermRetentionPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LongTermRetentionPolicyData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MakeBackupsImmutable))
            {
                writer.WritePropertyName("makeBackupsImmutable"u8);
                writer.WriteBooleanValue(MakeBackupsImmutable.Value);
            }
            if (Optional.IsDefined(BackupStorageAccessTier))
            {
                writer.WritePropertyName("backupStorageAccessTier"u8);
                writer.WriteStringValue(BackupStorageAccessTier.Value.ToString());
            }
            if (Optional.IsDefined(WeeklyRetention))
            {
                writer.WritePropertyName("weeklyRetention"u8);
                writer.WriteStringValue(WeeklyRetention);
            }
            if (Optional.IsDefined(MonthlyRetention))
            {
                writer.WritePropertyName("monthlyRetention"u8);
                writer.WriteStringValue(MonthlyRetention);
            }
            if (Optional.IsDefined(YearlyRetention))
            {
                writer.WritePropertyName("yearlyRetention"u8);
                writer.WriteStringValue(YearlyRetention);
            }
            if (Optional.IsDefined(WeekOfYear))
            {
                writer.WritePropertyName("weekOfYear"u8);
                writer.WriteNumberValue(WeekOfYear.Value);
            }
            writer.WriteEndObject();
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

        LongTermRetentionPolicyData IJsonModel<LongTermRetentionPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LongTermRetentionPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLongTermRetentionPolicyData(document.RootElement, options);
        }

        internal static LongTermRetentionPolicyData DeserializeLongTermRetentionPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            bool? makeBackupsImmutable = default;
            SqlBackupStorageAccessTier? backupStorageAccessTier = default;
            string weeklyRetention = default;
            string monthlyRetention = default;
            string yearlyRetention = default;
            int? weekOfYear = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("makeBackupsImmutable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            makeBackupsImmutable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("backupStorageAccessTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupStorageAccessTier = new SqlBackupStorageAccessTier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("weeklyRetention"u8))
                        {
                            weeklyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("monthlyRetention"u8))
                        {
                            monthlyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("yearlyRetention"u8))
                        {
                            yearlyRetention = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("weekOfYear"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weekOfYear = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LongTermRetentionPolicyData(
                id,
                name,
                type,
                systemData,
                makeBackupsImmutable,
                backupStorageAccessTier,
                weeklyRetention,
                monthlyRetention,
                yearlyRetention,
                weekOfYear,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LongTermRetentionPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LongTermRetentionPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        LongTermRetentionPolicyData IPersistableModel<LongTermRetentionPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLongTermRetentionPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LongTermRetentionPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LongTermRetentionPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
