// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class HybridContainerServiceAgentPoolProfile : IUtf8JsonSerializable, IJsonModel<HybridContainerServiceAgentPoolProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridContainerServiceAgentPoolProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridContainerServiceAgentPoolProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceAgentPoolProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridContainerServiceAgentPoolProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(OSSku))
            {
                writer.WritePropertyName("osSKU"u8);
                writer.WriteStringValue(OSSku.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels"u8);
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount"u8);
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount"u8);
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(EnableAutoScaling))
            {
                writer.WritePropertyName("enableAutoScaling"u8);
                writer.WriteBooleanValue(EnableAutoScaling.Value);
            }
            if (Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods"u8);
                writer.WriteNumberValue(MaxPods.Value);
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

        HybridContainerServiceAgentPoolProfile IJsonModel<HybridContainerServiceAgentPoolProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceAgentPoolProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridContainerServiceAgentPoolProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridContainerServiceAgentPoolProfile(document.RootElement, options);
        }

        internal static HybridContainerServiceAgentPoolProfile DeserializeHybridContainerServiceAgentPoolProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HybridContainerServiceOSType? osType = default;
            HybridContainerServiceOSSku? ossku = default;
            IDictionary<string, string> nodeLabels = default;
            IList<string> nodeTaints = default;
            int? maxCount = default;
            int? minCount = default;
            bool? enableAutoScaling = default;
            int? maxPods = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new HybridContainerServiceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osSKU"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ossku = new HybridContainerServiceOSSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeLabels"u8))
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
                    nodeLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeTaints"u8))
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
                    nodeTaints = array;
                    continue;
                }
                if (property.NameEquals("maxCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableAutoScaling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutoScaling = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxPods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPods = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridContainerServiceAgentPoolProfile(
                osType,
                ossku,
                nodeLabels ?? new ChangeTrackingDictionary<string, string>(),
                nodeTaints ?? new ChangeTrackingList<string>(),
                maxCount,
                minCount,
                enableAutoScaling,
                maxPods,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridContainerServiceAgentPoolProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceAgentPoolProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridContainerServiceAgentPoolProfile)} does not support writing '{options.Format}' format.");
            }
        }

        HybridContainerServiceAgentPoolProfile IPersistableModel<HybridContainerServiceAgentPoolProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridContainerServiceAgentPoolProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridContainerServiceAgentPoolProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridContainerServiceAgentPoolProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridContainerServiceAgentPoolProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
