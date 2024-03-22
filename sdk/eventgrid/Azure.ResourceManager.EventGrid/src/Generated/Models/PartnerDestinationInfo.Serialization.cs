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
    [PersistableModelProxy(typeof(UnknownPartnerDestinationInfo))]
    public partial class PartnerDestinationInfo : IUtf8JsonSerializable, IJsonModel<PartnerDestinationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerDestinationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerDestinationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerDestinationInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureSubscriptionId))
            {
                writer.WritePropertyName("azureSubscriptionId"u8);
                writer.WriteStringValue(AzureSubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(EndpointServiceContext))
            {
                writer.WritePropertyName("endpointServiceContext"u8);
                writer.WriteStringValue(EndpointServiceContext);
            }
            if (Optional.IsCollectionDefined(ResourceMoveChangeHistory))
            {
                writer.WritePropertyName("resourceMoveChangeHistory"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceMoveChangeHistory)
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

        PartnerDestinationInfo IJsonModel<PartnerDestinationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerDestinationInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerDestinationInfo(document.RootElement, options);
        }

        internal static PartnerDestinationInfo DeserializePartnerDestinationInfo(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "WebHook": return WebhookPartnerDestinationInfo.DeserializeWebhookPartnerDestinationInfo(element, options);
                }
            }
            return UnknownPartnerDestinationInfo.DeserializeUnknownPartnerDestinationInfo(element, options);
        }

        BinaryData IPersistableModel<PartnerDestinationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartnerDestinationInfo)} does not support writing '{options.Format}' format.");
            }
        }

        PartnerDestinationInfo IPersistableModel<PartnerDestinationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerDestinationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartnerDestinationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerDestinationInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerDestinationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
