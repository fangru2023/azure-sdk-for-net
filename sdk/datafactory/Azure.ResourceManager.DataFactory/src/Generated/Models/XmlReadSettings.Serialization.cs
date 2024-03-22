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
    public partial class XmlReadSettings : IUtf8JsonSerializable, IJsonModel<XmlReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<XmlReadSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<XmlReadSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<XmlReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(XmlReadSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CompressionProperties))
            {
                writer.WritePropertyName("compressionProperties"u8);
                writer.WriteObjectValue(CompressionProperties);
            }
            if (Optional.IsDefined(ValidationMode))
            {
                writer.WritePropertyName("validationMode"u8);
                JsonSerializer.Serialize(writer, ValidationMode);
            }
            if (Optional.IsDefined(DetectDataType))
            {
                writer.WritePropertyName("detectDataType"u8);
                JsonSerializer.Serialize(writer, DetectDataType);
            }
            if (Optional.IsDefined(Namespaces))
            {
                writer.WritePropertyName("namespaces"u8);
                JsonSerializer.Serialize(writer, Namespaces);
            }
            if (Optional.IsDefined(NamespacePrefixes))
            {
                writer.WritePropertyName("namespacePrefixes"u8);
                JsonSerializer.Serialize(writer, NamespacePrefixes);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FormatReadSettingsType);
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

        XmlReadSettings IJsonModel<XmlReadSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<XmlReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(XmlReadSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeXmlReadSettings(document.RootElement, options);
        }

        internal static XmlReadSettings DeserializeXmlReadSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CompressionReadSettings compressionProperties = default;
            DataFactoryElement<string> validationMode = default;
            DataFactoryElement<bool> detectDataType = default;
            DataFactoryElement<bool> namespaces = default;
            DataFactoryElement<IDictionary<string, string>> namespacePrefixes = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compressionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressionProperties = CompressionReadSettings.DeserializeCompressionReadSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationMode = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("detectDataType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectDataType = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("namespaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespaces = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("namespacePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespacePrefixes = JsonSerializer.Deserialize<DataFactoryElement<IDictionary<string, string>>>(property.Value.GetRawText());
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
            return new XmlReadSettings(
                type,
                additionalProperties,
                compressionProperties,
                validationMode,
                detectDataType,
                namespaces,
                namespacePrefixes);
        }

        BinaryData IPersistableModel<XmlReadSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<XmlReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(XmlReadSettings)} does not support writing '{options.Format}' format.");
            }
        }

        XmlReadSettings IPersistableModel<XmlReadSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<XmlReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeXmlReadSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(XmlReadSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<XmlReadSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
