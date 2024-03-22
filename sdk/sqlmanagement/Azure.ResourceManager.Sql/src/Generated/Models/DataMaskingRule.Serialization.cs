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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class DataMaskingRule : IUtf8JsonSerializable, IJsonModel<DataMaskingRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataMaskingRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataMaskingRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMaskingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMaskingRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (Optional.IsDefined(AliasName))
            {
                writer.WritePropertyName("aliasName"u8);
                writer.WriteStringValue(AliasName);
            }
            if (Optional.IsDefined(RuleState))
            {
                writer.WritePropertyName("ruleState"u8);
                writer.WriteStringValue(RuleState.Value.ToSerialString());
            }
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName"u8);
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(ColumnName))
            {
                writer.WritePropertyName("columnName"u8);
                writer.WriteStringValue(ColumnName);
            }
            if (Optional.IsDefined(MaskingFunction))
            {
                writer.WritePropertyName("maskingFunction"u8);
                writer.WriteStringValue(MaskingFunction.Value.ToSerialString());
            }
            if (Optional.IsDefined(NumberFrom))
            {
                writer.WritePropertyName("numberFrom"u8);
                writer.WriteStringValue(NumberFrom);
            }
            if (Optional.IsDefined(NumberTo))
            {
                writer.WritePropertyName("numberTo"u8);
                writer.WriteStringValue(NumberTo);
            }
            if (Optional.IsDefined(PrefixSize))
            {
                writer.WritePropertyName("prefixSize"u8);
                writer.WriteStringValue(PrefixSize);
            }
            if (Optional.IsDefined(SuffixSize))
            {
                writer.WritePropertyName("suffixSize"u8);
                writer.WriteStringValue(SuffixSize);
            }
            if (Optional.IsDefined(ReplacementString))
            {
                writer.WritePropertyName("replacementString"u8);
                writer.WriteStringValue(ReplacementString);
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

        DataMaskingRule IJsonModel<DataMaskingRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMaskingRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataMaskingRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataMaskingRule(document.RootElement, options);
        }

        internal static DataMaskingRule DeserializeDataMaskingRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string aliasName = default;
            DataMaskingRuleState? ruleState = default;
            string schemaName = default;
            string tableName = default;
            string columnName = default;
            DataMaskingFunction? maskingFunction = default;
            string numberFrom = default;
            string numberTo = default;
            string prefixSize = default;
            string suffixSize = default;
            string replacementString = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("aliasName"u8))
                        {
                            aliasName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ruleState = property0.Value.GetString().ToDataMaskingRuleState();
                            continue;
                        }
                        if (property0.NameEquals("schemaName"u8))
                        {
                            schemaName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"u8))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("columnName"u8))
                        {
                            columnName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maskingFunction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maskingFunction = property0.Value.GetString().ToDataMaskingFunction();
                            continue;
                        }
                        if (property0.NameEquals("numberFrom"u8))
                        {
                            numberFrom = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("numberTo"u8))
                        {
                            numberTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefixSize"u8))
                        {
                            prefixSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("suffixSize"u8))
                        {
                            suffixSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("replacementString"u8))
                        {
                            replacementString = property0.Value.GetString();
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
            return new DataMaskingRule(
                id,
                name,
                type,
                systemData,
                location,
                kind,
                aliasName,
                ruleState,
                schemaName,
                tableName,
                columnName,
                maskingFunction,
                numberFrom,
                numberTo,
                prefixSize,
                suffixSize,
                replacementString,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataMaskingRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMaskingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataMaskingRule)} does not support writing '{options.Format}' format.");
            }
        }

        DataMaskingRule IPersistableModel<DataMaskingRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataMaskingRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataMaskingRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataMaskingRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataMaskingRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
