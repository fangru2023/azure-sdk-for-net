// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class EventTriggerConfiguration : IUtf8JsonSerializable, IJsonModel<EventTriggerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventTriggerConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventTriggerConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventTriggerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventTriggerConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ReplicaCompletionCount.HasValue)
            {
                writer.WritePropertyName("replicaCompletionCount"u8);
                writer.WriteNumberValue(ReplicaCompletionCount.Value);
            }
            if (Parallelism.HasValue)
            {
                writer.WritePropertyName("parallelism"u8);
                writer.WriteNumberValue(Parallelism.Value);
            }
            if (Scale != null)
            {
                writer.WritePropertyName("scale"u8);
                writer.WriteObjectValue(Scale);
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

        EventTriggerConfiguration IJsonModel<EventTriggerConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventTriggerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventTriggerConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventTriggerConfiguration(document.RootElement, options);
        }

        internal static EventTriggerConfiguration DeserializeEventTriggerConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? replicaCompletionCount = default;
            int? parallelism = default;
            ContainerAppJobScale scale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicaCompletionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCompletionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("parallelism"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parallelism = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scale = ContainerAppJobScale.DeserializeContainerAppJobScale(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventTriggerConfiguration(replicaCompletionCount, parallelism, scale, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventTriggerConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventTriggerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventTriggerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        EventTriggerConfiguration IPersistableModel<EventTriggerConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventTriggerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventTriggerConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventTriggerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventTriggerConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
