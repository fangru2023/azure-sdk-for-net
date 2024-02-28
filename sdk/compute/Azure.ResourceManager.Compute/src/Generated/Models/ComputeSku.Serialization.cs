// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ComputeSku : IUtf8JsonSerializable, IJsonModel<ComputeSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeSku>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputeSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeSku)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Tier != null)
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (Capacity.HasValue)
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
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

        ComputeSku IJsonModel<ComputeSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeSku)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeSku(document.RootElement, options);
        }

        internal static ComputeSku DeserializeComputeSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string tier = default;
            long? capacity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputeSku(name, tier, capacity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeSku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeSku)} does not support '{options.Format}' format.");
            }
        }

        ComputeSku IPersistableModel<ComputeSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeSku(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeSku)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeSku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
