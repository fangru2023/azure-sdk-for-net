// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class FileSystemSource : IUtf8JsonSerializable, IJsonModel<FileSystemSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FileSystemSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FileSystemSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSystemSource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                if (Path != null)
                {
                    writer.WritePropertyName("path"u8);
                    writer.WriteStringValue(Path);
                }
                else
                {
                    writer.WriteNull("path");
                }
            }
            if (Optional.IsDefined(Connection))
            {
                if (Connection != null)
                {
                    writer.WritePropertyName("connection"u8);
                    writer.WriteStringValue(Connection);
                }
                else
                {
                    writer.WriteNull("connection");
                }
            }
            writer.WritePropertyName("sourceType"u8);
            writer.WriteStringValue(SourceType.ToString());
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

        FileSystemSource IJsonModel<FileSystemSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSystemSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileSystemSource(document.RootElement, options);
        }

        internal static FileSystemSource DeserializeFileSystemSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string path = default;
            string connection = default;
            DataImportSourceType sourceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        path = null;
                        continue;
                    }
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connection = null;
                        continue;
                    }
                    connection = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceType"u8))
                {
                    sourceType = new DataImportSourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FileSystemSource(connection, sourceType, serializedAdditionalRawData, path);
        }

        BinaryData IPersistableModel<FileSystemSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileSystemSource)} does not support writing '{options.Format}' format.");
            }
        }

        FileSystemSource IPersistableModel<FileSystemSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFileSystemSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileSystemSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileSystemSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
