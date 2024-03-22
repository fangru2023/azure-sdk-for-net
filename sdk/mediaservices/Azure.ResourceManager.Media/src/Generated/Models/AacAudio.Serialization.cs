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
    public partial class AacAudio : IUtf8JsonSerializable, IJsonModel<AacAudio>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AacAudio>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AacAudio>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AacAudio>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AacAudio)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteStringValue(Profile.Value.ToString());
            }
            if (Optional.IsDefined(Channels))
            {
                writer.WritePropertyName("channels"u8);
                writer.WriteNumberValue(Channels.Value);
            }
            if (Optional.IsDefined(SamplingRate))
            {
                writer.WritePropertyName("samplingRate"u8);
                writer.WriteNumberValue(SamplingRate.Value);
            }
            if (Optional.IsDefined(Bitrate))
            {
                writer.WritePropertyName("bitrate"u8);
                writer.WriteNumberValue(Bitrate.Value);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
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

        AacAudio IJsonModel<AacAudio>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AacAudio>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AacAudio)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAacAudio(document.RootElement, options);
        }

        internal static AacAudio DeserializeAacAudio(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AacAudioProfile? profile = default;
            int? channels = default;
            int? samplingRate = default;
            int? bitrate = default;
            string odataType = default;
            string label = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profile = new AacAudioProfile(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("channels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    channels = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("samplingRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingRate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AacAudio(
                odataType,
                label,
                serializedAdditionalRawData,
                channels,
                samplingRate,
                bitrate,
                profile);
        }

        BinaryData IPersistableModel<AacAudio>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AacAudio>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AacAudio)} does not support writing '{options.Format}' format.");
            }
        }

        AacAudio IPersistableModel<AacAudio>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AacAudio>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAacAudio(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AacAudio)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AacAudio>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
