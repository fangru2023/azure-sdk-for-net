// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseRecommendedSensitivityLabelUpdateOperationListResult : IUtf8JsonSerializable, IJsonModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseRecommendedSensitivityLabelUpdateOperationListResult)} does not support writing '{format}' format.");
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

        SynapseRecommendedSensitivityLabelUpdateOperationListResult IJsonModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseRecommendedSensitivityLabelUpdateOperationListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseRecommendedSensitivityLabelUpdateOperationListResult(document.RootElement, options);
        }

        internal static SynapseRecommendedSensitivityLabelUpdateOperationListResult DeserializeSynapseRecommendedSensitivityLabelUpdateOperationListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SynapseRecommendedSensitivityLabelUpdate> operations = default;
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
                    List<SynapseRecommendedSensitivityLabelUpdate> array = new List<SynapseRecommendedSensitivityLabelUpdate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseRecommendedSensitivityLabelUpdate.DeserializeSynapseRecommendedSensitivityLabelUpdate(item, options));
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
            return new SynapseRecommendedSensitivityLabelUpdateOperationListResult(operations ?? new ChangeTrackingList<SynapseRecommendedSensitivityLabelUpdate>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseRecommendedSensitivityLabelUpdateOperationListResult)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseRecommendedSensitivityLabelUpdateOperationListResult IPersistableModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseRecommendedSensitivityLabelUpdateOperationListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseRecommendedSensitivityLabelUpdateOperationListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseRecommendedSensitivityLabelUpdateOperationListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
