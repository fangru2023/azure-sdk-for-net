// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class Ambr : IUtf8JsonSerializable, IJsonModel<Ambr>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Ambr>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Ambr>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Ambr>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Ambr)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("uplink"u8);
            writer.WriteStringValue(Uplink);
            writer.WritePropertyName("downlink"u8);
            writer.WriteStringValue(Downlink);
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

        Ambr IJsonModel<Ambr>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Ambr>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Ambr)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmbr(document.RootElement, options);
        }

        internal static Ambr DeserializeAmbr(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string uplink = default;
            string downlink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uplink"u8))
                {
                    uplink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("downlink"u8))
                {
                    downlink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Ambr(uplink, downlink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Ambr>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Ambr>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Ambr)} does not support writing '{options.Format}' format.");
            }
        }

        Ambr IPersistableModel<Ambr>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Ambr>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmbr(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Ambr)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Ambr>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
