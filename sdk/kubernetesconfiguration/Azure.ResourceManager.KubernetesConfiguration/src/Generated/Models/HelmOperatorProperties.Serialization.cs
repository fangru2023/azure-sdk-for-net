// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class HelmOperatorProperties : IUtf8JsonSerializable, IJsonModel<HelmOperatorProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmOperatorProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HelmOperatorProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmOperatorProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmOperatorProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ChartVersion))
            {
                writer.WritePropertyName("chartVersion"u8);
                writer.WriteStringValue(ChartVersion);
            }
            if (Optional.IsDefined(ChartValues))
            {
                writer.WritePropertyName("chartValues"u8);
                writer.WriteStringValue(ChartValues);
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

        HelmOperatorProperties IJsonModel<HelmOperatorProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmOperatorProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmOperatorProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmOperatorProperties(document.RootElement, options);
        }

        internal static HelmOperatorProperties DeserializeHelmOperatorProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string chartVersion = default;
            string chartValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("chartVersion"u8))
                {
                    chartVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chartValues"u8))
                {
                    chartValues = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HelmOperatorProperties(chartVersion, chartValues, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HelmOperatorProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmOperatorProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HelmOperatorProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HelmOperatorProperties IPersistableModel<HelmOperatorProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmOperatorProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHelmOperatorProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HelmOperatorProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HelmOperatorProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
