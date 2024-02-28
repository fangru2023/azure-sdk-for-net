// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class GeoReplicationStatistics : IUtf8JsonSerializable, IJsonModel<GeoReplicationStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GeoReplicationStatistics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GeoReplicationStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeoReplicationStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GeoReplicationStatistics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && LastSyncOn.HasValue)
            {
                writer.WritePropertyName("lastSyncTime"u8);
                writer.WriteStringValue(LastSyncOn.Value, "O");
            }
            if (options.Format != "W" && CanFailover.HasValue)
            {
                writer.WritePropertyName("canFailover"u8);
                writer.WriteBooleanValue(CanFailover.Value);
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

        GeoReplicationStatistics IJsonModel<GeoReplicationStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeoReplicationStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GeoReplicationStatistics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGeoReplicationStatistics(document.RootElement, options);
        }

        internal static GeoReplicationStatistics DeserializeGeoReplicationStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GeoReplicationStatus? status = default;
            DateTimeOffset? lastSyncTime = default;
            bool? canFailover = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new GeoReplicationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastSyncTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("canFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canFailover = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GeoReplicationStatistics(status, lastSyncTime, canFailover, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GeoReplicationStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeoReplicationStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GeoReplicationStatistics)} does not support '{options.Format}' format.");
            }
        }

        GeoReplicationStatistics IPersistableModel<GeoReplicationStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GeoReplicationStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGeoReplicationStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GeoReplicationStatistics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GeoReplicationStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
