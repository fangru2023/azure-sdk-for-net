// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    internal partial class SparkUserPluginListResult : IUtf8JsonSerializable, IJsonModel<SparkUserPluginListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkUserPluginListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SparkUserPluginListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkUserPluginListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkUserPluginListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Plugins))
            {
                writer.WritePropertyName("plugins"u8);
                writer.WriteStartArray();
                foreach (var item in Plugins)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SparkUserPluginListResult IJsonModel<SparkUserPluginListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkUserPluginListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkUserPluginListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkUserPluginListResult(document.RootElement, options);
        }

        internal static SparkUserPluginListResult DeserializeSparkUserPluginListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SparkUserPlugin> plugins = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("plugins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkUserPlugin> array = new List<SparkUserPlugin>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkUserPlugin.DeserializeSparkUserPlugin(item, options));
                    }
                    plugins = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SparkUserPluginListResult(plugins ?? new ChangeTrackingList<SparkUserPlugin>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SparkUserPluginListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkUserPluginListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SparkUserPluginListResult)} does not support writing '{options.Format}' format.");
            }
        }

        SparkUserPluginListResult IPersistableModel<SparkUserPluginListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkUserPluginListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSparkUserPluginListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SparkUserPluginListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SparkUserPluginListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
