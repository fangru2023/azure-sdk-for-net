// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class NumberLessThanOrEqualsAdvancedFilter : IUtf8JsonSerializable, IJsonModel<NumberLessThanOrEqualsAdvancedFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NumberLessThanOrEqualsAdvancedFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NumberLessThanOrEqualsAdvancedFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberLessThanOrEqualsAdvancedFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumberLessThanOrEqualsAdvancedFilter)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteNumberValue(Value.Value);
            }
            writer.WritePropertyName("operatorType"u8);
            writer.WriteStringValue(OperatorType.ToString());
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
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

        NumberLessThanOrEqualsAdvancedFilter IJsonModel<NumberLessThanOrEqualsAdvancedFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberLessThanOrEqualsAdvancedFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumberLessThanOrEqualsAdvancedFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNumberLessThanOrEqualsAdvancedFilter(document.RootElement, options);
        }

        internal static NumberLessThanOrEqualsAdvancedFilter DeserializeNumberLessThanOrEqualsAdvancedFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? value = default;
            AdvancedFilterOperatorType operatorType = default;
            string key = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("operatorType"u8))
                {
                    operatorType = new AdvancedFilterOperatorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NumberLessThanOrEqualsAdvancedFilter(operatorType, key, serializedAdditionalRawData, value);
        }

        BinaryData IPersistableModel<NumberLessThanOrEqualsAdvancedFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberLessThanOrEqualsAdvancedFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NumberLessThanOrEqualsAdvancedFilter)} does not support writing '{options.Format}' format.");
            }
        }

        NumberLessThanOrEqualsAdvancedFilter IPersistableModel<NumberLessThanOrEqualsAdvancedFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumberLessThanOrEqualsAdvancedFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNumberLessThanOrEqualsAdvancedFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NumberLessThanOrEqualsAdvancedFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NumberLessThanOrEqualsAdvancedFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
