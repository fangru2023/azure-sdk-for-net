// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class DatadogHost : IUtf8JsonSerializable, IJsonModel<DatadogHost>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatadogHost>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatadogHost>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogHost>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatadogHost)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (!(Aliases is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("aliases"u8);
                writer.WriteStartArray();
                foreach (var item in Aliases)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Apps is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("apps"u8);
                writer.WriteStartArray();
                foreach (var item in Apps)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Meta != null)
            {
                writer.WritePropertyName("meta"u8);
                writer.WriteObjectValue(Meta);
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

        DatadogHost IJsonModel<DatadogHost>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogHost>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatadogHost)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatadogHost(document.RootElement, options);
        }

        internal static DatadogHost DeserializeDatadogHost(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IReadOnlyList<string> aliases = default;
            IReadOnlyList<string> apps = default;
            DatadogHostMetadata meta = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    aliases = array;
                    continue;
                }
                if (property.NameEquals("apps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apps = array;
                    continue;
                }
                if (property.NameEquals("meta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meta = DatadogHostMetadata.DeserializeDatadogHostMetadata(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatadogHost(name, aliases ?? new ChangeTrackingList<string>(), apps ?? new ChangeTrackingList<string>(), meta, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatadogHost>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogHost>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatadogHost)} does not support '{options.Format}' format.");
            }
        }

        DatadogHost IPersistableModel<DatadogHost>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatadogHost>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatadogHost(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatadogHost)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatadogHost>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
