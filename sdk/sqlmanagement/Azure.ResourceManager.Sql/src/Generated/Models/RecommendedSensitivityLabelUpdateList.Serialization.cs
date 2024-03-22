// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecommendedSensitivityLabelUpdateList : IUtf8JsonSerializable, IJsonModel<RecommendedSensitivityLabelUpdateList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecommendedSensitivityLabelUpdateList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecommendedSensitivityLabelUpdateList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedSensitivityLabelUpdateList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedSensitivityLabelUpdateList)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Operations))
            {
                writer.WritePropertyName("operations"u8);
                writer.WriteStartArray();
                foreach (var item in Operations)
                {
                    writer.WriteObjectValue(item);
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

        RecommendedSensitivityLabelUpdateList IJsonModel<RecommendedSensitivityLabelUpdateList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedSensitivityLabelUpdateList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecommendedSensitivityLabelUpdateList)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecommendedSensitivityLabelUpdateList(document.RootElement, options);
        }

        internal static RecommendedSensitivityLabelUpdateList DeserializeRecommendedSensitivityLabelUpdateList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<RecommendedSensitivityLabelUpdate> operations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecommendedSensitivityLabelUpdate> array = new List<RecommendedSensitivityLabelUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecommendedSensitivityLabelUpdate.DeserializeRecommendedSensitivityLabelUpdate(item, options));
                    }
                    operations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecommendedSensitivityLabelUpdateList(operations ?? new ChangeTrackingList<RecommendedSensitivityLabelUpdate>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecommendedSensitivityLabelUpdateList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedSensitivityLabelUpdateList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecommendedSensitivityLabelUpdateList)} does not support writing '{options.Format}' format.");
            }
        }

        RecommendedSensitivityLabelUpdateList IPersistableModel<RecommendedSensitivityLabelUpdateList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecommendedSensitivityLabelUpdateList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecommendedSensitivityLabelUpdateList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecommendedSensitivityLabelUpdateList)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecommendedSensitivityLabelUpdateList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
