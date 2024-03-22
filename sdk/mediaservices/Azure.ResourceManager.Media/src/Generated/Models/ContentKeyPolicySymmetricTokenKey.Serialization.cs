// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicySymmetricTokenKey : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicySymmetricTokenKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicySymmetricTokenKey>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContentKeyPolicySymmetricTokenKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicySymmetricTokenKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicySymmetricTokenKey)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (KeyValue != null)
            {
                writer.WritePropertyName("keyValue"u8);
                writer.WriteBase64StringValue(KeyValue, "D");
            }
            else
            {
                writer.WriteNull("keyValue");
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicySymmetricTokenKey IJsonModel<ContentKeyPolicySymmetricTokenKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicySymmetricTokenKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicySymmetricTokenKey)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicySymmetricTokenKey(document.RootElement, options);
        }

        internal static ContentKeyPolicySymmetricTokenKey DeserializeContentKeyPolicySymmetricTokenKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            byte[] keyValue = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyValue = null;
                        continue;
                    }
                    keyValue = property.Value.GetBytesFromBase64("D");
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContentKeyPolicySymmetricTokenKey(odataType, serializedAdditionalRawData, keyValue);
        }

        BinaryData IPersistableModel<ContentKeyPolicySymmetricTokenKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicySymmetricTokenKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicySymmetricTokenKey)} does not support writing '{options.Format}' format.");
            }
        }

        ContentKeyPolicySymmetricTokenKey IPersistableModel<ContentKeyPolicySymmetricTokenKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicySymmetricTokenKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicySymmetricTokenKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicySymmetricTokenKey)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicySymmetricTokenKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
