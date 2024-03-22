// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class NamedPartitionSchemeDescription : IUtf8JsonSerializable, IJsonModel<NamedPartitionSchemeDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NamedPartitionSchemeDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NamedPartitionSchemeDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamedPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NamedPartitionSchemeDescription)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("names"u8);
            writer.WriteStartArray();
            foreach (var item in Names)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        NamedPartitionSchemeDescription IJsonModel<NamedPartitionSchemeDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamedPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NamedPartitionSchemeDescription)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNamedPartitionSchemeDescription(document.RootElement, options);
        }

        internal static NamedPartitionSchemeDescription DeserializeNamedPartitionSchemeDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int count = default;
            IList<string> names = default;
            ApplicationPartitionScheme partitionScheme = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("names"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    names = array;
                    continue;
                }
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new ApplicationPartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NamedPartitionSchemeDescription(partitionScheme, serializedAdditionalRawData, count, names);
        }

        BinaryData IPersistableModel<NamedPartitionSchemeDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamedPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NamedPartitionSchemeDescription)} does not support writing '{options.Format}' format.");
            }
        }

        NamedPartitionSchemeDescription IPersistableModel<NamedPartitionSchemeDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamedPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNamedPartitionSchemeDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NamedPartitionSchemeDescription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NamedPartitionSchemeDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
