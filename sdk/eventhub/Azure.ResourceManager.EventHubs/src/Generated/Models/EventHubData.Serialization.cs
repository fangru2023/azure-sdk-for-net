// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    public partial class EventHubData : IUtf8JsonSerializable, IJsonModel<EventHubData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(PartitionIds))
            {
                writer.WritePropertyName("partitionIds"u8);
                writer.WriteStartArray();
                foreach (var item in PartitionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedAt"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(PartitionCount))
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(CaptureDescription))
            {
                writer.WritePropertyName("captureDescription"u8);
                writer.WriteObjectValue(CaptureDescription);
            }
            if (Optional.IsDefined(RetentionDescription))
            {
                writer.WritePropertyName("retentionDescription"u8);
                writer.WriteObjectValue(RetentionDescription);
            }
            writer.WriteEndObject();
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

        EventHubData IJsonModel<EventHubData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubData(document.RootElement, options);
        }

        internal static EventHubData DeserializeEventHubData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<string>> partitionIds = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<long> partitionCount = default;
            Optional<EventHubEntityStatus> status = default;
            Optional<CaptureDescription> captureDescription = default;
            Optional<RetentionDescription> retentionDescription = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("partitionIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            partitionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("partitionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partitionCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToEventHubEntityStatus();
                            continue;
                        }
                        if (property0.NameEquals("captureDescription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            captureDescription = CaptureDescription.DeserializeCaptureDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("retentionDescription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionDescription = RetentionDescription.DeserializeRetentionDescription(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventHubData(id, name, type, systemData.Value, Optional.ToList(partitionIds), Optional.ToNullable(createdAt), Optional.ToNullable(updatedAt), Optional.ToNullable(partitionCount), Optional.ToNullable(status), captureDescription.Value, retentionDescription.Value, Optional.ToNullable(location), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventHubData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubData)} does not support '{options.Format}' format.");
            }
        }

        EventHubData IPersistableModel<EventHubData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
