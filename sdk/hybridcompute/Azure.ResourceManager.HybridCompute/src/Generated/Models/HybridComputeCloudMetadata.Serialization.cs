// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    internal partial class HybridComputeCloudMetadata : IUtf8JsonSerializable, IJsonModel<HybridComputeCloudMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeCloudMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputeCloudMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeCloudMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeCloudMetadata)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
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

        HybridComputeCloudMetadata IJsonModel<HybridComputeCloudMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeCloudMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeCloudMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeCloudMetadata(document.RootElement, options);
        }

        internal static HybridComputeCloudMetadata DeserializeHybridComputeCloudMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provider = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"u8))
                {
                    provider = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridComputeCloudMetadata(provider, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridComputeCloudMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeCloudMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeCloudMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        HybridComputeCloudMetadata IPersistableModel<HybridComputeCloudMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeCloudMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputeCloudMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputeCloudMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeCloudMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
