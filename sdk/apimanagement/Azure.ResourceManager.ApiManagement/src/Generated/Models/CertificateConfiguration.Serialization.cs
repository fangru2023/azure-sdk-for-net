// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class CertificateConfiguration : IUtf8JsonSerializable, IJsonModel<CertificateConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CertificateConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CertificateConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertificateConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EncodedCertificate))
            {
                writer.WritePropertyName("encodedCertificate"u8);
                writer.WriteStringValue(EncodedCertificate);
            }
            if (Optional.IsDefined(CertificatePassword))
            {
                writer.WritePropertyName("certificatePassword"u8);
                writer.WriteStringValue(CertificatePassword);
            }
            writer.WritePropertyName("storeName"u8);
            writer.WriteStringValue(StoreName.ToString());
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteObjectValue(Certificate);
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

        CertificateConfiguration IJsonModel<CertificateConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertificateConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCertificateConfiguration(document.RootElement, options);
        }

        internal static CertificateConfiguration DeserializeCertificateConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string encodedCertificate = default;
            string certificatePassword = default;
            CertificateConfigurationStoreName storeName = default;
            CertificateInformation certificate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedCertificate"u8))
                {
                    encodedCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificatePassword"u8))
                {
                    certificatePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storeName"u8))
                {
                    storeName = new CertificateConfigurationStoreName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificate = CertificateInformation.DeserializeCertificateInformation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CertificateConfiguration(encodedCertificate, certificatePassword, storeName, certificate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CertificateConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CertificateConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        CertificateConfiguration IPersistableModel<CertificateConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertificateConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCertificateConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CertificateConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CertificateConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
