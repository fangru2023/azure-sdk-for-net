// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentBarcode : IUtf8JsonSerializable, IJsonModel<DocumentBarcode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentBarcode>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentBarcode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentBarcode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentBarcode)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            if (Optional.IsCollectionDefined(Polygon))
            {
                writer.WritePropertyName("polygon"u8);
                writer.WriteStartArray();
                foreach (var item in Polygon)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("span"u8);
            writer.WriteObjectValue(Span);
            writer.WritePropertyName("confidence"u8);
            writer.WriteNumberValue(Confidence);
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

        DocumentBarcode IJsonModel<DocumentBarcode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentBarcode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentBarcode)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentBarcode(document.RootElement, options);
        }

        internal static DocumentBarcode DeserializeDocumentBarcode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentBarcodeKind kind = default;
            string value = default;
            IReadOnlyList<float> polygon = default;
            DocumentSpan span = default;
            float confidence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DocumentBarcodeKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("polygon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    polygon = array;
                    continue;
                }
                if (property.NameEquals("span"u8))
                {
                    span = DocumentSpan.DeserializeDocumentSpan(property.Value, options);
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DocumentBarcode(
                kind,
                value,
                polygon ?? new ChangeTrackingList<float>(),
                span,
                confidence,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentBarcode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentBarcode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentBarcode)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentBarcode IPersistableModel<DocumentBarcode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentBarcode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentBarcode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentBarcode)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentBarcode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentBarcode FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentBarcode(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
