// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseGetSsisObjectMetadataContent : IUtf8JsonSerializable, IJsonModel<SynapseGetSsisObjectMetadataContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseGetSsisObjectMetadataContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseGetSsisObjectMetadataContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseGetSsisObjectMetadataContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseGetSsisObjectMetadataContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MetadataPath))
            {
                writer.WritePropertyName("metadataPath"u8);
                writer.WriteStringValue(MetadataPath);
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

        SynapseGetSsisObjectMetadataContent IJsonModel<SynapseGetSsisObjectMetadataContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseGetSsisObjectMetadataContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseGetSsisObjectMetadataContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseGetSsisObjectMetadataContent(document.RootElement, options);
        }

        internal static SynapseGetSsisObjectMetadataContent DeserializeSynapseGetSsisObjectMetadataContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metadataPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadataPath"u8))
                {
                    metadataPath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseGetSsisObjectMetadataContent(metadataPath, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseGetSsisObjectMetadataContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseGetSsisObjectMetadataContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseGetSsisObjectMetadataContent)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseGetSsisObjectMetadataContent IPersistableModel<SynapseGetSsisObjectMetadataContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseGetSsisObjectMetadataContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseGetSsisObjectMetadataContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseGetSsisObjectMetadataContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseGetSsisObjectMetadataContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
