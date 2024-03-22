// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class TroubleshooterResult : IUtf8JsonSerializable, IJsonModel<TroubleshooterResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TroubleshooterResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TroubleshooterResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshooterResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TroubleshooterResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(QuestionId))
            {
                writer.WritePropertyName("questionId"u8);
                writer.WriteStringValue(QuestionId);
            }
            if (Optional.IsDefined(QuestionType))
            {
                writer.WritePropertyName("questionType"u8);
                writer.WriteStringValue(QuestionType.Value.ToString());
            }
            if (Optional.IsDefined(Response))
            {
                writer.WritePropertyName("response"u8);
                writer.WriteStringValue(Response);
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

        TroubleshooterResult IJsonModel<TroubleshooterResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshooterResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TroubleshooterResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTroubleshooterResult(document.RootElement, options);
        }

        internal static TroubleshooterResult DeserializeTroubleshooterResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string questionId = default;
            QuestionType? questionType = default;
            string response = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("questionId"u8))
                {
                    questionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("questionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    questionType = new QuestionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("response"u8))
                {
                    response = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TroubleshooterResult(questionId, questionType, response, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TroubleshooterResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshooterResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TroubleshooterResult)} does not support writing '{options.Format}' format.");
            }
        }

        TroubleshooterResult IPersistableModel<TroubleshooterResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TroubleshooterResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTroubleshooterResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TroubleshooterResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TroubleshooterResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
