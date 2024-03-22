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
    public partial class BatchNfsMountConfiguration : IUtf8JsonSerializable, IJsonModel<BatchNfsMountConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchNfsMountConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchNfsMountConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNfsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNfsMountConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source);
            writer.WritePropertyName("relativeMountPath"u8);
            writer.WriteStringValue(RelativeMountPath);
            if (Optional.IsDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStringValue(MountOptions);
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

        BatchNfsMountConfiguration IJsonModel<BatchNfsMountConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNfsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchNfsMountConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchNfsMountConfiguration(document.RootElement, options);
        }

        internal static BatchNfsMountConfiguration DeserializeBatchNfsMountConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string source = default;
            string relativeMountPath = default;
            string mountOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeMountPath"u8))
                {
                    relativeMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    mountOptions = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchNfsMountConfiguration(source, relativeMountPath, mountOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchNfsMountConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNfsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchNfsMountConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        BatchNfsMountConfiguration IPersistableModel<BatchNfsMountConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchNfsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchNfsMountConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchNfsMountConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchNfsMountConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
