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
    public partial class ResponseValidationProperties : IUtf8JsonSerializable, IJsonModel<ResponseValidationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResponseValidationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResponseValidationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResponseValidationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResponseValidationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Regex))
            {
                writer.WritePropertyName("regex"u8);
                writer.WriteStringValue(Regex);
            }
            if (Optional.IsDefined(IsRequired))
            {
                writer.WritePropertyName("isRequired"u8);
                writer.WriteBooleanValue(IsRequired.Value);
            }
            if (Optional.IsDefined(ValidationErrorMessage))
            {
                writer.WritePropertyName("validationErrorMessage"u8);
                writer.WriteStringValue(ValidationErrorMessage);
            }
            if (Optional.IsDefined(MaxLength))
            {
                writer.WritePropertyName("maxLength"u8);
                writer.WriteNumberValue(MaxLength.Value);
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

        ResponseValidationProperties IJsonModel<ResponseValidationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResponseValidationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResponseValidationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResponseValidationProperties(document.RootElement, options);
        }

        internal static ResponseValidationProperties DeserializeResponseValidationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> regex = default;
            Optional<bool> isRequired = default;
            Optional<string> validationErrorMessage = default;
            Optional<long> maxLength = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("regex"u8))
                {
                    regex = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("validationErrorMessage"u8))
                {
                    validationErrorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLength = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResponseValidationProperties(regex.Value, Optional.ToNullable(isRequired), validationErrorMessage.Value, Optional.ToNullable(maxLength), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResponseValidationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResponseValidationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResponseValidationProperties)} does not support '{options.Format}' format.");
            }
        }

        ResponseValidationProperties IPersistableModel<ResponseValidationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResponseValidationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResponseValidationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResponseValidationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResponseValidationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
