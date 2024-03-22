// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PublicIPAddressDnsSettings : IUtf8JsonSerializable, IJsonModel<PublicIPAddressDnsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublicIPAddressDnsSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PublicIPAddressDnsSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicIPAddressDnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicIPAddressDnsSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DomainNameLabel))
            {
                writer.WritePropertyName("domainNameLabel"u8);
                writer.WriteStringValue(DomainNameLabel);
            }
            if (Optional.IsDefined(DomainNameLabelScope))
            {
                writer.WritePropertyName("domainNameLabelScope"u8);
                writer.WriteStringValue(DomainNameLabelScope.Value.ToSerialString());
            }
            if (Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(ReverseFqdn))
            {
                writer.WritePropertyName("reverseFqdn"u8);
                writer.WriteStringValue(ReverseFqdn);
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

        PublicIPAddressDnsSettings IJsonModel<PublicIPAddressDnsSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicIPAddressDnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicIPAddressDnsSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublicIPAddressDnsSettings(document.RootElement, options);
        }

        internal static PublicIPAddressDnsSettings DeserializePublicIPAddressDnsSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainNameLabel = default;
            PublicIPAddressDnsSettingsDomainNameLabelScope? domainNameLabelScope = default;
            string fqdn = default;
            string reverseFqdn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainNameLabel"u8))
                {
                    domainNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainNameLabelScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainNameLabelScope = property.Value.GetString().ToPublicIPAddressDnsSettingsDomainNameLabelScope();
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reverseFqdn"u8))
                {
                    reverseFqdn = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PublicIPAddressDnsSettings(domainNameLabel, domainNameLabelScope, fqdn, reverseFqdn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PublicIPAddressDnsSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicIPAddressDnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PublicIPAddressDnsSettings)} does not support writing '{options.Format}' format.");
            }
        }

        PublicIPAddressDnsSettings IPersistableModel<PublicIPAddressDnsSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicIPAddressDnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePublicIPAddressDnsSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PublicIPAddressDnsSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PublicIPAddressDnsSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
