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
    public partial class RedshiftUnloadSettings : IUtf8JsonSerializable, IJsonModel<RedshiftUnloadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedshiftUnloadSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedshiftUnloadSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedshiftUnloadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedshiftUnloadSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("s3LinkedServiceName"u8);
            JsonSerializer.Serialize(writer, S3LinkedServiceName);
            writer.WritePropertyName("bucketName"u8);
            JsonSerializer.Serialize(writer, BucketName);
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

        RedshiftUnloadSettings IJsonModel<RedshiftUnloadSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedshiftUnloadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedshiftUnloadSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedshiftUnloadSettings(document.RootElement, options);
        }

        internal static RedshiftUnloadSettings DeserializeRedshiftUnloadSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryLinkedServiceReference s3LinkedServiceName = default;
            DataFactoryElement<string> bucketName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("s3LinkedServiceName"u8))
                {
                    s3LinkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("bucketName"u8))
                {
                    bucketName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedshiftUnloadSettings(s3LinkedServiceName, bucketName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedshiftUnloadSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedshiftUnloadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedshiftUnloadSettings)} does not support writing '{options.Format}' format.");
            }
        }

        RedshiftUnloadSettings IPersistableModel<RedshiftUnloadSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedshiftUnloadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedshiftUnloadSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedshiftUnloadSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedshiftUnloadSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
