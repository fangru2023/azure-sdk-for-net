// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class IotSeverityMetrics : IUtf8JsonSerializable, IJsonModel<IotSeverityMetrics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotSeverityMetrics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotSeverityMetrics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSeverityMetrics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSeverityMetrics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(High))
            {
                writer.WritePropertyName("high"u8);
                writer.WriteNumberValue(High.Value);
            }
            if (Optional.IsDefined(Medium))
            {
                writer.WritePropertyName("medium"u8);
                writer.WriteNumberValue(Medium.Value);
            }
            if (Optional.IsDefined(Low))
            {
                writer.WritePropertyName("low"u8);
                writer.WriteNumberValue(Low.Value);
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

        IotSeverityMetrics IJsonModel<IotSeverityMetrics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSeverityMetrics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotSeverityMetrics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSeverityMetrics(document.RootElement, options);
        }

        internal static IotSeverityMetrics DeserializeIotSeverityMetrics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> high = default;
            Optional<long> medium = default;
            Optional<long> low = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("high"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    high = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("medium"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    medium = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("low"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    low = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotSeverityMetrics(Optional.ToNullable(high), Optional.ToNullable(medium), Optional.ToNullable(low), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotSeverityMetrics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSeverityMetrics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotSeverityMetrics)} does not support '{options.Format}' format.");
            }
        }

        IotSeverityMetrics IPersistableModel<IotSeverityMetrics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotSeverityMetrics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotSeverityMetrics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotSeverityMetrics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotSeverityMetrics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
