// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    [PersistableModelProxy(typeof(UnknownRequiredToolCall))]
    public partial class RequiredToolCall : IUtf8JsonSerializable, IJsonModel<RequiredToolCall>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequiredToolCall>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RequiredToolCall>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredToolCall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequiredToolCall)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
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

        RequiredToolCall IJsonModel<RequiredToolCall>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredToolCall>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequiredToolCall)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequiredToolCall(document.RootElement, options);
        }

        internal static RequiredToolCall DeserializeRequiredToolCall(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "function": return RequiredFunctionToolCall.DeserializeRequiredFunctionToolCall(element, options);
                }
            }
            return UnknownRequiredToolCall.DeserializeUnknownRequiredToolCall(element, options);
        }

        BinaryData IPersistableModel<RequiredToolCall>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredToolCall>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RequiredToolCall)} does not support writing '{options.Format}' format.");
            }
        }

        RequiredToolCall IPersistableModel<RequiredToolCall>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequiredToolCall>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRequiredToolCall(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RequiredToolCall)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequiredToolCall>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RequiredToolCall FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRequiredToolCall(document.RootElement);
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
