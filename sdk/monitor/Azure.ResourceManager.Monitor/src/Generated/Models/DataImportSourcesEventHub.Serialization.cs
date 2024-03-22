// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataImportSourcesEventHub : IUtf8JsonSerializable, IJsonModel<DataImportSourcesEventHub>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataImportSourcesEventHub>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataImportSourcesEventHub>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataImportSourcesEventHub>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataImportSourcesEventHub)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ConsumerGroup))
            {
                writer.WritePropertyName("consumerGroup"u8);
                writer.WriteStringValue(ConsumerGroup);
            }
            if (Optional.IsDefined(Stream))
            {
                writer.WritePropertyName("stream"u8);
                writer.WriteStringValue(Stream);
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

        DataImportSourcesEventHub IJsonModel<DataImportSourcesEventHub>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataImportSourcesEventHub>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataImportSourcesEventHub)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataImportSourcesEventHub(document.RootElement, options);
        }

        internal static DataImportSourcesEventHub DeserializeDataImportSourcesEventHub(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string consumerGroup = default;
            string stream = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consumerGroup"u8))
                {
                    consumerGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stream"u8))
                {
                    stream = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataImportSourcesEventHub(name, consumerGroup, stream, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataImportSourcesEventHub>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataImportSourcesEventHub>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataImportSourcesEventHub)} does not support writing '{options.Format}' format.");
            }
        }

        DataImportSourcesEventHub IPersistableModel<DataImportSourcesEventHub>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataImportSourcesEventHub>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataImportSourcesEventHub(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataImportSourcesEventHub)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataImportSourcesEventHub>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
