// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    public partial class DomainsRecordVerificationContent : IUtf8JsonSerializable, IJsonModel<DomainsRecordVerificationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DomainsRecordVerificationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DomainsRecordVerificationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainsRecordVerificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainsRecordVerificationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("verificationType"u8);
            writer.WriteStringValue(VerificationType.ToString());
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

        DomainsRecordVerificationContent IJsonModel<DomainsRecordVerificationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainsRecordVerificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainsRecordVerificationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainsRecordVerificationContent(document.RootElement, options);
        }

        internal static DomainsRecordVerificationContent DeserializeDomainsRecordVerificationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DomainRecordVerificationType verificationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verificationType"u8))
                {
                    verificationType = new DomainRecordVerificationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DomainsRecordVerificationContent(verificationType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DomainsRecordVerificationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainsRecordVerificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DomainsRecordVerificationContent)} does not support '{options.Format}' format.");
            }
        }

        DomainsRecordVerificationContent IPersistableModel<DomainsRecordVerificationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainsRecordVerificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDomainsRecordVerificationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DomainsRecordVerificationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DomainsRecordVerificationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
