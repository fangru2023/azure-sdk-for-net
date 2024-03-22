// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchVmContainerConfiguration : IUtf8JsonSerializable, IJsonModel<BatchVmContainerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchVmContainerConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchVmContainerConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmContainerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchVmContainerConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ContainerType.ToString());
            if (Optional.IsCollectionDefined(ContainerImageNames))
            {
                writer.WritePropertyName("containerImageNames"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerImageNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContainerRegistries))
            {
                writer.WritePropertyName("containerRegistries"u8);
                writer.WriteStartArray();
                foreach (var item in ContainerRegistries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        BatchVmContainerConfiguration IJsonModel<BatchVmContainerConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmContainerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchVmContainerConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchVmContainerConfiguration(document.RootElement, options);
        }

        internal static BatchVmContainerConfiguration DeserializeBatchVmContainerConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BatchVmContainerType type = default;
            IList<string> containerImageNames = default;
            IList<BatchVmContainerRegistry> containerRegistries = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new BatchVmContainerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerImageNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    containerImageNames = array;
                    continue;
                }
                if (property.NameEquals("containerRegistries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchVmContainerRegistry> array = new List<BatchVmContainerRegistry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchVmContainerRegistry.DeserializeBatchVmContainerRegistry(item, options));
                    }
                    containerRegistries = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchVmContainerConfiguration(type, containerImageNames ?? new ChangeTrackingList<string>(), containerRegistries ?? new ChangeTrackingList<BatchVmContainerRegistry>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchVmContainerConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmContainerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchVmContainerConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        BatchVmContainerConfiguration IPersistableModel<BatchVmContainerConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchVmContainerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchVmContainerConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchVmContainerConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchVmContainerConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
