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
    public partial class StopSellNotifications : IUtf8JsonSerializable, IJsonModel<StopSellNotifications>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StopSellNotifications>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StopSellNotifications>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopSellNotifications>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StopSellNotifications)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(IsEntire))
            {
                writer.WritePropertyName("isEntire"u8);
                writer.WriteBooleanValue(IsEntire.Value);
            }
            if (Optional.IsDefined(MessageCode))
            {
                writer.WritePropertyName("messageCode"u8);
                writer.WriteNumberValue(MessageCode.Value);
            }
            if (Optional.IsDefined(IconUri))
            {
                writer.WritePropertyName("icon"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Plans))
            {
                writer.WritePropertyName("plans"u8);
                writer.WriteStartArray();
                foreach (var item in Plans)
                {
                    writer.WriteObjectValue(item);
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

        StopSellNotifications IJsonModel<StopSellNotifications>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopSellNotifications>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StopSellNotifications)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStopSellNotifications(document.RootElement, options);
        }

        internal static StopSellNotifications DeserializeStopSellNotifications(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string offerId = default;
            string displayName = default;
            bool? isEntire = default;
            long? messageCode = default;
            Uri icon = default;
            IReadOnlyList<PlanNotificationDetails> plans = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEntire"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEntire = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("messageCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageCode = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("icon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    icon = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("plans"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PlanNotificationDetails> array = new List<PlanNotificationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PlanNotificationDetails.DeserializePlanNotificationDetails(item, options));
                    }
                    plans = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StopSellNotifications(
                offerId,
                displayName,
                isEntire,
                messageCode,
                icon,
                plans ?? new ChangeTrackingList<PlanNotificationDetails>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StopSellNotifications>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopSellNotifications>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StopSellNotifications)} does not support writing '{options.Format}' format.");
            }
        }

        StopSellNotifications IPersistableModel<StopSellNotifications>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopSellNotifications>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStopSellNotifications(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StopSellNotifications)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StopSellNotifications>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
