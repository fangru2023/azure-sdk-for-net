// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentStyle : IUtf8JsonSerializable, IJsonModel<DocumentStyle>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentStyle>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentStyle>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStyle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentStyle)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsHandwritten))
            {
                writer.WritePropertyName("isHandwritten"u8);
                writer.WriteBooleanValue(IsHandwritten.Value);
            }
            if (Optional.IsDefined(SimilarFontFamily))
            {
                writer.WritePropertyName("similarFontFamily"u8);
                writer.WriteStringValue(SimilarFontFamily);
            }
            if (Optional.IsDefined(FontStyle))
            {
                writer.WritePropertyName("fontStyle"u8);
                writer.WriteStringValue(FontStyle.Value.ToString());
            }
            if (Optional.IsDefined(FontWeight))
            {
                writer.WritePropertyName("fontWeight"u8);
                writer.WriteStringValue(FontWeight.Value.ToString());
            }
            if (Optional.IsDefined(Color))
            {
                writer.WritePropertyName("color"u8);
                writer.WriteStringValue(Color);
            }
            if (Optional.IsDefined(BackgroundColor))
            {
                writer.WritePropertyName("backgroundColor"u8);
                writer.WriteStringValue(BackgroundColor);
            }
            writer.WritePropertyName("spans"u8);
            writer.WriteStartArray();
            foreach (var item in Spans)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        DocumentStyle IJsonModel<DocumentStyle>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStyle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentStyle)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentStyle(document.RootElement, options);
        }

        internal static DocumentStyle DeserializeDocumentStyle(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isHandwritten = default;
            Optional<string> similarFontFamily = default;
            Optional<FontStyle> fontStyle = default;
            Optional<FontWeight> fontWeight = default;
            Optional<string> color = default;
            Optional<string> backgroundColor = default;
            IReadOnlyList<DocumentSpan> spans = default;
            float confidence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isHandwritten"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHandwritten = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("similarFontFamily"u8))
                {
                    similarFontFamily = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fontStyle"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fontStyle = new FontStyle(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fontWeight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fontWeight = new FontWeight(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("color"u8))
                {
                    color = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backgroundColor"u8))
                {
                    backgroundColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
                    }
                    spans = array;
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
            return new DocumentStyle(Optional.ToNullable(isHandwritten), similarFontFamily.Value, Optional.ToNullable(fontStyle), Optional.ToNullable(fontWeight), color.Value, backgroundColor.Value, spans, confidence, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentStyle>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStyle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentStyle)} does not support '{options.Format}' format.");
            }
        }

        DocumentStyle IPersistableModel<DocumentStyle>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStyle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentStyle(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentStyle)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentStyle>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentStyle FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentStyle(document.RootElement);
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
