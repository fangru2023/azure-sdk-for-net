// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DatasetOrcFormat : IUtf8JsonSerializable, IJsonModel<DatasetOrcFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatasetOrcFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatasetOrcFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetOrcFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetOrcFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetStorageFormatType);
            if (Serializer != null)
            {
                writer.WritePropertyName("serializer"u8);
                JsonSerializer.Serialize(writer, Serializer);
            }
            if (Deserializer != null)
            {
                writer.WritePropertyName("deserializer"u8);
                JsonSerializer.Serialize(writer, Deserializer);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DatasetOrcFormat IJsonModel<DatasetOrcFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetOrcFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetOrcFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatasetOrcFormat(document.RootElement, options);
        }

        internal static DatasetOrcFormat DeserializeDatasetOrcFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            DataFactoryElement<string> serializer = default;
            DataFactoryElement<string> deserializer = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serializer = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("deserializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deserializer = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DatasetOrcFormat(type, serializer, deserializer, additionalProperties);
        }

        BinaryData IPersistableModel<DatasetOrcFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetOrcFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatasetOrcFormat)} does not support '{options.Format}' format.");
            }
        }

        DatasetOrcFormat IPersistableModel<DatasetOrcFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetOrcFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatasetOrcFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatasetOrcFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatasetOrcFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
