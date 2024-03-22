// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsPropertyArrayChangedConditionProperties : IUtf8JsonSerializable, IJsonModel<SecurityInsightsPropertyArrayChangedConditionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsPropertyArrayChangedConditionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsPropertyArrayChangedConditionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsPropertyArrayChangedConditionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsPropertyArrayChangedConditionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConditionProperties))
            {
                writer.WritePropertyName("conditionProperties"u8);
                writer.WriteObjectValue(ConditionProperties);
            }
            writer.WritePropertyName("conditionType"u8);
            writer.WriteStringValue(ConditionType.ToString());
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

        SecurityInsightsPropertyArrayChangedConditionProperties IJsonModel<SecurityInsightsPropertyArrayChangedConditionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsPropertyArrayChangedConditionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsPropertyArrayChangedConditionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(document.RootElement, options);
        }

        internal static SecurityInsightsPropertyArrayChangedConditionProperties DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutomationRulePropertyArrayChangedValuesCondition conditionProperties = default;
            ConditionType conditionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conditionProperties = AutomationRulePropertyArrayChangedValuesCondition.DeserializeAutomationRulePropertyArrayChangedValuesCondition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("conditionType"u8))
                {
                    conditionType = new ConditionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsPropertyArrayChangedConditionProperties(conditionType, serializedAdditionalRawData, conditionProperties);
        }

        BinaryData IPersistableModel<SecurityInsightsPropertyArrayChangedConditionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsPropertyArrayChangedConditionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsPropertyArrayChangedConditionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsPropertyArrayChangedConditionProperties IPersistableModel<SecurityInsightsPropertyArrayChangedConditionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsPropertyArrayChangedConditionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsPropertyArrayChangedConditionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsPropertyArrayChangedConditionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsPropertyArrayChangedConditionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
