// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class PeeringReceivedRoute : IUtf8JsonSerializable, IJsonModel<PeeringReceivedRoute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PeeringReceivedRoute>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PeeringReceivedRoute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringReceivedRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringReceivedRoute)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix"u8);
                writer.WriteStringValue(Prefix);
            }
            if (options.Format != "W" && Optional.IsDefined(NextHop))
            {
                writer.WritePropertyName("nextHop"u8);
                writer.WriteStringValue(NextHop);
            }
            if (options.Format != "W" && Optional.IsDefined(AsPath))
            {
                writer.WritePropertyName("asPath"u8);
                writer.WriteStringValue(AsPath);
            }
            if (options.Format != "W" && Optional.IsDefined(OriginAsValidationState))
            {
                writer.WritePropertyName("originAsValidationState"u8);
                writer.WriteStringValue(OriginAsValidationState);
            }
            if (options.Format != "W" && Optional.IsDefined(RpkiValidationState))
            {
                writer.WritePropertyName("rpkiValidationState"u8);
                writer.WriteStringValue(RpkiValidationState);
            }
            if (options.Format != "W" && Optional.IsDefined(TrustAnchor))
            {
                writer.WritePropertyName("trustAnchor"u8);
                writer.WriteStringValue(TrustAnchor);
            }
            if (options.Format != "W" && Optional.IsDefined(ReceivedTimestamp))
            {
                writer.WritePropertyName("receivedTimestamp"u8);
                writer.WriteStringValue(ReceivedTimestamp);
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

        PeeringReceivedRoute IJsonModel<PeeringReceivedRoute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringReceivedRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PeeringReceivedRoute)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePeeringReceivedRoute(document.RootElement, options);
        }

        internal static PeeringReceivedRoute DeserializePeeringReceivedRoute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string prefix = default;
            string nextHop = default;
            string asPath = default;
            string originAsValidationState = default;
            string rpkiValidationState = default;
            string trustAnchor = default;
            string receivedTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHop"u8))
                {
                    nextHop = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asPath"u8))
                {
                    asPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("originAsValidationState"u8))
                {
                    originAsValidationState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpkiValidationState"u8))
                {
                    rpkiValidationState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trustAnchor"u8))
                {
                    trustAnchor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("receivedTimestamp"u8))
                {
                    receivedTimestamp = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PeeringReceivedRoute(
                prefix,
                nextHop,
                asPath,
                originAsValidationState,
                rpkiValidationState,
                trustAnchor,
                receivedTimestamp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PeeringReceivedRoute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringReceivedRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PeeringReceivedRoute)} does not support writing '{options.Format}' format.");
            }
        }

        PeeringReceivedRoute IPersistableModel<PeeringReceivedRoute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PeeringReceivedRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePeeringReceivedRoute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PeeringReceivedRoute)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PeeringReceivedRoute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
