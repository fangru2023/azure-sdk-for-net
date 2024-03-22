// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DWCopyCommandSettings : IUtf8JsonSerializable, IJsonModel<DWCopyCommandSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DWCopyCommandSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DWCopyCommandSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DWCopyCommandSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DWCopyCommandSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DefaultValues))
            {
                writer.WritePropertyName("defaultValues"u8);
                writer.WriteStartArray();
                foreach (var item in DefaultValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdditionalOptions))
            {
                writer.WritePropertyName("additionalOptions"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalOptions)
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

        DWCopyCommandSettings IJsonModel<DWCopyCommandSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DWCopyCommandSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DWCopyCommandSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDWCopyCommandSettings(document.RootElement, options);
        }

        internal static DWCopyCommandSettings DeserializeDWCopyCommandSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DWCopyCommandDefaultValue> defaultValues = default;
            IDictionary<string, string> additionalOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DWCopyCommandDefaultValue> array = new List<DWCopyCommandDefaultValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DWCopyCommandDefaultValue.DeserializeDWCopyCommandDefaultValue(item, options));
                    }
                    defaultValues = array;
                    continue;
                }
                if (property.NameEquals("additionalOptions"u8))
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
                    additionalOptions = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DWCopyCommandSettings(defaultValues ?? new ChangeTrackingList<DWCopyCommandDefaultValue>(), additionalOptions ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DWCopyCommandSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DWCopyCommandSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DWCopyCommandSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DWCopyCommandSettings IPersistableModel<DWCopyCommandSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DWCopyCommandSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDWCopyCommandSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DWCopyCommandSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DWCopyCommandSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
