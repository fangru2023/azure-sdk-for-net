// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class PlanNotificationDetails : IUtf8JsonSerializable, IJsonModel<PlanNotificationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PlanNotificationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PlanNotificationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlanNotificationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlanNotificationDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PlanId))
            {
                writer.WritePropertyName("planId"u8);
                writer.WriteStringValue(PlanId);
            }
            if (Optional.IsDefined(PlanDisplayName))
            {
                writer.WritePropertyName("planDisplayName"u8);
                writer.WriteStringValue(PlanDisplayName);
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

        PlanNotificationDetails IJsonModel<PlanNotificationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlanNotificationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PlanNotificationDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePlanNotificationDetails(document.RootElement, options);
        }

        internal static PlanNotificationDetails DeserializePlanNotificationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> planId = default;
            Optional<string> planDisplayName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDisplayName"u8))
                {
                    planDisplayName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PlanNotificationDetails(planId.Value, planDisplayName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PlanNotificationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlanNotificationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PlanNotificationDetails)} does not support '{options.Format}' format.");
            }
        }

        PlanNotificationDetails IPersistableModel<PlanNotificationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PlanNotificationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePlanNotificationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PlanNotificationDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PlanNotificationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
