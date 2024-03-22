// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    [PersistableModelProxy(typeof(UnknownChaosTargetFilter))]
    public partial class ChaosTargetFilter : IUtf8JsonSerializable, IJsonModel<ChaosTargetFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosTargetFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ChaosTargetFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosTargetFilter)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FilterType.ToString());
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

        ChaosTargetFilter IJsonModel<ChaosTargetFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosTargetFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosTargetFilter(document.RootElement, options);
        }

        internal static ChaosTargetFilter DeserializeChaosTargetFilter(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "Simple": return ChaosTargetSimpleFilter.DeserializeChaosTargetSimpleFilter(element, options);
                }
            }
            return UnknownChaosTargetFilter.DeserializeUnknownChaosTargetFilter(element, options);
        }

        BinaryData IPersistableModel<ChaosTargetFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChaosTargetFilter)} does not support writing '{options.Format}' format.");
            }
        }

        ChaosTargetFilter IPersistableModel<ChaosTargetFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChaosTargetFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosTargetFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosTargetFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
