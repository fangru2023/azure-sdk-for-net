// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    [PersistableModelProxy(typeof(UnknownEventSubscriptionDestination))]
    public partial class EventSubscriptionDestination : IUtf8JsonSerializable, IJsonModel<EventSubscriptionDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventSubscriptionDestination>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventSubscriptionDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventSubscriptionDestination)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
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

        EventSubscriptionDestination IJsonModel<EventSubscriptionDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventSubscriptionDestination)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventSubscriptionDestination(document.RootElement, options);
        }

        internal static EventSubscriptionDestination DeserializeEventSubscriptionDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFunction": return AzureFunctionEventSubscriptionDestination.DeserializeAzureFunctionEventSubscriptionDestination(element);
                    case "EventHub": return EventHubEventSubscriptionDestination.DeserializeEventHubEventSubscriptionDestination(element);
                    case "HybridConnection": return HybridConnectionEventSubscriptionDestination.DeserializeHybridConnectionEventSubscriptionDestination(element);
                    case "MonitorAlert": return MonitorAlertEventSubscriptionDestination.DeserializeMonitorAlertEventSubscriptionDestination(element);
                    case "NamespaceTopic": return NamespaceTopicEventSubscriptionDestination.DeserializeNamespaceTopicEventSubscriptionDestination(element);
                    case "PartnerDestination": return PartnerEventSubscriptionDestination.DeserializePartnerEventSubscriptionDestination(element);
                    case "ServiceBusQueue": return ServiceBusQueueEventSubscriptionDestination.DeserializeServiceBusQueueEventSubscriptionDestination(element);
                    case "ServiceBusTopic": return ServiceBusTopicEventSubscriptionDestination.DeserializeServiceBusTopicEventSubscriptionDestination(element);
                    case "StorageQueue": return StorageQueueEventSubscriptionDestination.DeserializeStorageQueueEventSubscriptionDestination(element);
                    case "WebHook": return WebHookEventSubscriptionDestination.DeserializeWebHookEventSubscriptionDestination(element);
                }
            }
            return UnknownEventSubscriptionDestination.DeserializeUnknownEventSubscriptionDestination(element);
        }

        BinaryData IPersistableModel<EventSubscriptionDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventSubscriptionDestination)} does not support '{options.Format}' format.");
            }
        }

        EventSubscriptionDestination IPersistableModel<EventSubscriptionDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventSubscriptionDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventSubscriptionDestination(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventSubscriptionDestination)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventSubscriptionDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
