// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownWebLinkedServiceTypeProperties))]
    public partial class WebLinkedServiceTypeProperties : IUtf8JsonSerializable, IJsonModel<WebLinkedServiceTypeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebLinkedServiceTypeProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebLinkedServiceTypeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebLinkedServiceTypeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebLinkedServiceTypeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            JsonSerializer.Serialize(writer, Uri);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
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

        WebLinkedServiceTypeProperties IJsonModel<WebLinkedServiceTypeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebLinkedServiceTypeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebLinkedServiceTypeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebLinkedServiceTypeProperties(document.RootElement, options);
        }

        internal static WebLinkedServiceTypeProperties DeserializeWebLinkedServiceTypeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authenticationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Anonymous": return WebAnonymousAuthentication.DeserializeWebAnonymousAuthentication(element, options);
                    case "Basic": return WebBasicAuthentication.DeserializeWebBasicAuthentication(element, options);
                    case "ClientCertificate": return WebClientCertificateAuthentication.DeserializeWebClientCertificateAuthentication(element, options);
                }
            }
            return UnknownWebLinkedServiceTypeProperties.DeserializeUnknownWebLinkedServiceTypeProperties(element, options);
        }

        BinaryData IPersistableModel<WebLinkedServiceTypeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebLinkedServiceTypeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebLinkedServiceTypeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        WebLinkedServiceTypeProperties IPersistableModel<WebLinkedServiceTypeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebLinkedServiceTypeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebLinkedServiceTypeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebLinkedServiceTypeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebLinkedServiceTypeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
