// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class JitSchedulingPolicy : IUtf8JsonSerializable, IJsonModel<JitSchedulingPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JitSchedulingPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JitSchedulingPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitSchedulingPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitSchedulingPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(SchedulingType.ToString());
            }
            writer.WritePropertyName("duration"u8);
            writer.WriteStringValue(Duration, "P");
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
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

        JitSchedulingPolicy IJsonModel<JitSchedulingPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitSchedulingPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitSchedulingPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJitSchedulingPolicy(document.RootElement, options);
        }

        internal static JitSchedulingPolicy DeserializeJitSchedulingPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            JitSchedulingType type = default;
            TimeSpan duration = default;
            DateTimeOffset startTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new JitSchedulingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JitSchedulingPolicy(type, duration, startTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JitSchedulingPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitSchedulingPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JitSchedulingPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        JitSchedulingPolicy IPersistableModel<JitSchedulingPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitSchedulingPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJitSchedulingPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JitSchedulingPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<JitSchedulingPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
