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
    public partial class ZipDeflateReadSettings : IUtf8JsonSerializable, IJsonModel<ZipDeflateReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ZipDeflateReadSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ZipDeflateReadSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ZipDeflateReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ZipDeflateReadSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PreserveZipFileNameAsFolder != null)
            {
                writer.WritePropertyName("preserveZipFileNameAsFolder"u8);
                JsonSerializer.Serialize(writer, PreserveZipFileNameAsFolder);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CompressionReadSettingsType);
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

        ZipDeflateReadSettings IJsonModel<ZipDeflateReadSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ZipDeflateReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ZipDeflateReadSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeZipDeflateReadSettings(document.RootElement, options);
        }

        internal static ZipDeflateReadSettings DeserializeZipDeflateReadSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<bool> preserveZipFileNameAsFolder = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveZipFileNameAsFolder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveZipFileNameAsFolder = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ZipDeflateReadSettings(type, additionalProperties, preserveZipFileNameAsFolder);
        }

        BinaryData IPersistableModel<ZipDeflateReadSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ZipDeflateReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ZipDeflateReadSettings)} does not support '{options.Format}' format.");
            }
        }

        ZipDeflateReadSettings IPersistableModel<ZipDeflateReadSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ZipDeflateReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeZipDeflateReadSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ZipDeflateReadSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ZipDeflateReadSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
