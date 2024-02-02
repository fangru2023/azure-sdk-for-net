// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkflowResponse : IUtf8JsonSerializable, IJsonModel<LogicWorkflowResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkflowResponse>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicWorkflowResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Headers);
#else
                using (JsonDocument document = JsonDocument.Parse(Headers))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(StatusCode))
            {
                writer.WritePropertyName("statusCode"u8);
                writer.WriteNumberValue(StatusCode.Value);
            }
            if (Optional.IsDefined(BodyLink))
            {
                writer.WritePropertyName("bodyLink"u8);
                writer.WriteObjectValue(BodyLink);
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

        LogicWorkflowResponse IJsonModel<LogicWorkflowResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkflowResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkflowResponse(document.RootElement, options);
        }

        internal static LogicWorkflowResponse DeserializeLogicWorkflowResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> headers = default;
            Optional<int> statusCode = default;
            Optional<LogicContentLink> bodyLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    headers = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bodyLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bodyLink = LogicContentLink.DeserializeLogicContentLink(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWorkflowResponse(headers.Value, Optional.ToNullable(statusCode), bodyLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicWorkflowResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowResponse)} does not support '{options.Format}' format.");
            }
        }

        LogicWorkflowResponse IPersistableModel<LogicWorkflowResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkflowResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicWorkflowResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicWorkflowResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWorkflowResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
