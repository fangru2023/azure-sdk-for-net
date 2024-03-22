// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class WorkloadGroupData : IUtf8JsonSerializable, IJsonModel<WorkloadGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadGroupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadGroupData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(MinResourcePercent))
            {
                writer.WritePropertyName("minResourcePercent"u8);
                writer.WriteNumberValue(MinResourcePercent.Value);
            }
            if (Optional.IsDefined(MaxResourcePercent))
            {
                writer.WritePropertyName("maxResourcePercent"u8);
                writer.WriteNumberValue(MaxResourcePercent.Value);
            }
            if (Optional.IsDefined(MinResourcePercentPerRequest))
            {
                writer.WritePropertyName("minResourcePercentPerRequest"u8);
                writer.WriteNumberValue(MinResourcePercentPerRequest.Value);
            }
            if (Optional.IsDefined(MaxResourcePercentPerRequest))
            {
                writer.WritePropertyName("maxResourcePercentPerRequest"u8);
                writer.WriteNumberValue(MaxResourcePercentPerRequest.Value);
            }
            if (Optional.IsDefined(Importance))
            {
                writer.WritePropertyName("importance"u8);
                writer.WriteStringValue(Importance);
            }
            if (Optional.IsDefined(QueryExecutionTimeout))
            {
                writer.WritePropertyName("queryExecutionTimeout"u8);
                writer.WriteNumberValue(QueryExecutionTimeout.Value);
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

        WorkloadGroupData IJsonModel<WorkloadGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadGroupData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadGroupData(document.RootElement, options);
        }

        internal static WorkloadGroupData DeserializeWorkloadGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? minResourcePercent = default;
            int? maxResourcePercent = default;
            double? minResourcePercentPerRequest = default;
            double? maxResourcePercentPerRequest = default;
            string importance = default;
            int? queryExecutionTimeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("minResourcePercent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minResourcePercent = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxResourcePercent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxResourcePercent = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minResourcePercentPerRequest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minResourcePercentPerRequest = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("maxResourcePercentPerRequest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxResourcePercentPerRequest = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("importance"u8))
                        {
                            importance = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryExecutionTimeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryExecutionTimeout = property0.Value.GetInt32();
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
            return new WorkloadGroupData(
                id,
                name,
                type,
                systemData,
                minResourcePercent,
                maxResourcePercent,
                minResourcePercentPerRequest,
                maxResourcePercentPerRequest,
                importance,
                queryExecutionTimeout,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkloadGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadGroupData)} does not support writing '{options.Format}' format.");
            }
        }

        WorkloadGroupData IPersistableModel<WorkloadGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadGroupData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
