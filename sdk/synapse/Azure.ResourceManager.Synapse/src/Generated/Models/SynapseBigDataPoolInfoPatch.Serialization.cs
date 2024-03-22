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
    public partial class SynapseBigDataPoolInfoPatch : IUtf8JsonSerializable, IJsonModel<SynapseBigDataPoolInfoPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseBigDataPoolInfoPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseBigDataPoolInfoPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseBigDataPoolInfoPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseBigDataPoolInfoPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        SynapseBigDataPoolInfoPatch IJsonModel<SynapseBigDataPoolInfoPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseBigDataPoolInfoPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseBigDataPoolInfoPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseBigDataPoolInfoPatch(document.RootElement, options);
        }

        internal static SynapseBigDataPoolInfoPatch DeserializeSynapseBigDataPoolInfoPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseBigDataPoolInfoPatch(tags ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseBigDataPoolInfoPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseBigDataPoolInfoPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseBigDataPoolInfoPatch)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseBigDataPoolInfoPatch IPersistableModel<SynapseBigDataPoolInfoPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseBigDataPoolInfoPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseBigDataPoolInfoPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseBigDataPoolInfoPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseBigDataPoolInfoPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
