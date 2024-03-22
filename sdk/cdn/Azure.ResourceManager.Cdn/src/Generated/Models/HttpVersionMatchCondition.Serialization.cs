// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class HttpVersionMatchCondition : IUtf8JsonSerializable, IJsonModel<HttpVersionMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HttpVersionMatchCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HttpVersionMatchCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpVersionMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HttpVersionMatchCondition)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ConditionType.ToString());
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(HttpVersionOperator.ToString());
            if (Optional.IsDefined(NegateCondition))
            {
                writer.WritePropertyName("negateCondition"u8);
                writer.WriteBooleanValue(NegateCondition.Value);
            }
            if (Optional.IsCollectionDefined(MatchValues))
            {
                writer.WritePropertyName("matchValues"u8);
                writer.WriteStartArray();
                foreach (var item in MatchValues)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Transforms))
            {
                writer.WritePropertyName("transforms"u8);
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        HttpVersionMatchCondition IJsonModel<HttpVersionMatchCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpVersionMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HttpVersionMatchCondition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHttpVersionMatchCondition(document.RootElement, options);
        }

        internal static HttpVersionMatchCondition DeserializeHttpVersionMatchCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HttpVersionMatchConditionType typeName = default;
            HttpVersionOperator @operator = default;
            bool? negateCondition = default;
            IList<string> matchValues = default;
            IList<PreTransformCategory> transforms = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new HttpVersionMatchConditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = new HttpVersionOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    matchValues = array;
                    continue;
                }
                if (property.NameEquals("transforms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PreTransformCategory> array = new List<PreTransformCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PreTransformCategory(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HttpVersionMatchCondition(
                typeName,
                @operator,
                negateCondition,
                matchValues ?? new ChangeTrackingList<string>(),
                transforms ?? new ChangeTrackingList<PreTransformCategory>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HttpVersionMatchCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpVersionMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HttpVersionMatchCondition)} does not support writing '{options.Format}' format.");
            }
        }

        HttpVersionMatchCondition IPersistableModel<HttpVersionMatchCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpVersionMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHttpVersionMatchCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HttpVersionMatchCondition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HttpVersionMatchCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
