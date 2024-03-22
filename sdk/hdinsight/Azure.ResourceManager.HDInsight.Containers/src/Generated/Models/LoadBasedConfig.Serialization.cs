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
    public partial class LoadBasedConfig : IUtf8JsonSerializable, IJsonModel<LoadBasedConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadBasedConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LoadBasedConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBasedConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBasedConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("minNodes"u8);
            writer.WriteNumberValue(MinNodes);
            writer.WritePropertyName("maxNodes"u8);
            writer.WriteNumberValue(MaxNodes);
            if (Optional.IsDefined(PollIntervalInSeconds))
            {
                writer.WritePropertyName("pollInterval"u8);
                writer.WriteNumberValue(PollIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(CooldownPeriod))
            {
                writer.WritePropertyName("cooldownPeriod"u8);
                writer.WriteNumberValue(CooldownPeriod.Value);
            }
            writer.WritePropertyName("scalingRules"u8);
            writer.WriteStartArray();
            foreach (var item in ScalingRules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        LoadBasedConfig IJsonModel<LoadBasedConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBasedConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBasedConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBasedConfig(document.RootElement, options);
        }

        internal static LoadBasedConfig DeserializeLoadBasedConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minNodes = default;
            int maxNodes = default;
            int? pollInterval = default;
            int? cooldownPeriod = default;
            IList<ScalingRule> scalingRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minNodes"u8))
                {
                    minNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxNodes"u8))
                {
                    maxNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pollInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pollInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cooldownPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cooldownPeriod = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scalingRules"u8))
                {
                    List<ScalingRule> array = new List<ScalingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScalingRule.DeserializeScalingRule(item, options));
                    }
                    scalingRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoadBasedConfig(
                minNodes,
                maxNodes,
                pollInterval,
                cooldownPeriod,
                scalingRules,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadBasedConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBasedConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadBasedConfig)} does not support writing '{options.Format}' format.");
            }
        }

        LoadBasedConfig IPersistableModel<LoadBasedConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBasedConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadBasedConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadBasedConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadBasedConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
