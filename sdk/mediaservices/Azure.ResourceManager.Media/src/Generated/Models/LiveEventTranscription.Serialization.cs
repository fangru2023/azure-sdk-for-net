// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class LiveEventTranscription : IUtf8JsonSerializable, IJsonModel<LiveEventTranscription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LiveEventTranscription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LiveEventTranscription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LiveEventTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LiveEventTranscription)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsCollectionDefined(InputTrackSelection))
            {
                writer.WritePropertyName("inputTrackSelection"u8);
                writer.WriteStartArray();
                foreach (var item in InputTrackSelection)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OutputTranscriptionTrack))
            {
                writer.WritePropertyName("outputTranscriptionTrack"u8);
                writer.WriteObjectValue(OutputTranscriptionTrack);
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

        LiveEventTranscription IJsonModel<LiveEventTranscription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LiveEventTranscription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LiveEventTranscription)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLiveEventTranscription(document.RootElement, options);
        }

        internal static LiveEventTranscription DeserializeLiveEventTranscription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string language = default;
            IList<LiveEventInputTrackSelection> inputTrackSelection = default;
            LiveEventOutputTranscriptionTrack outputTranscriptionTrack = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputTrackSelection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LiveEventInputTrackSelection> array = new List<LiveEventInputTrackSelection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LiveEventInputTrackSelection.DeserializeLiveEventInputTrackSelection(item, options));
                    }
                    inputTrackSelection = array;
                    continue;
                }
                if (property.NameEquals("outputTranscriptionTrack"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputTranscriptionTrack = LiveEventOutputTranscriptionTrack.DeserializeLiveEventOutputTranscriptionTrack(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LiveEventTranscription(language, inputTrackSelection ?? new ChangeTrackingList<LiveEventInputTrackSelection>(), outputTranscriptionTrack, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LiveEventTranscription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LiveEventTranscription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LiveEventTranscription)} does not support writing '{options.Format}' format.");
            }
        }

        LiveEventTranscription IPersistableModel<LiveEventTranscription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LiveEventTranscription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLiveEventTranscription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LiveEventTranscription)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LiveEventTranscription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
