// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalContactAntennaConfiguration : IUtf8JsonSerializable, IJsonModel<OrbitalContactAntennaConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrbitalContactAntennaConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OrbitalContactAntennaConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactAntennaConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalContactAntennaConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DestinationIP))
            {
                writer.WritePropertyName("destinationIp"u8);
                writer.WriteStringValue(DestinationIP.ToString());
            }
            if (Optional.IsCollectionDefined(SourceIPs))
            {
                writer.WritePropertyName("sourceIps"u8);
                writer.WriteStartArray();
                foreach (var item in SourceIPs)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
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

        OrbitalContactAntennaConfiguration IJsonModel<OrbitalContactAntennaConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactAntennaConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrbitalContactAntennaConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrbitalContactAntennaConfiguration(document.RootElement, options);
        }

        internal static OrbitalContactAntennaConfiguration DeserializeOrbitalContactAntennaConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddress> destinationIP = default;
            Optional<IReadOnlyList<IPAddress>> sourceIPs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destinationIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceIps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    sourceIPs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OrbitalContactAntennaConfiguration(destinationIP.Value, Optional.ToList(sourceIPs), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OrbitalContactAntennaConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactAntennaConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OrbitalContactAntennaConfiguration)} does not support '{options.Format}' format.");
            }
        }

        OrbitalContactAntennaConfiguration IPersistableModel<OrbitalContactAntennaConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrbitalContactAntennaConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOrbitalContactAntennaConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OrbitalContactAntennaConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OrbitalContactAntennaConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
