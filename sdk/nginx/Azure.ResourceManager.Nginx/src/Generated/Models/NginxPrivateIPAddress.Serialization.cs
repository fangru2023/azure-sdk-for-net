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

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxPrivateIPAddress : IUtf8JsonSerializable, IJsonModel<NginxPrivateIPAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxPrivateIPAddress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NginxPrivateIPAddress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxPrivateIPAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxPrivateIPAddress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress"u8);
                writer.WriteStringValue(PrivateIPAddress.ToString());
            }
            if (Optional.IsDefined(PrivateIPAllocationMethod))
            {
                writer.WritePropertyName("privateIPAllocationMethod"u8);
                writer.WriteStringValue(PrivateIPAllocationMethod.Value.ToString());
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
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

        NginxPrivateIPAddress IJsonModel<NginxPrivateIPAddress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxPrivateIPAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxPrivateIPAddress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxPrivateIPAddress(document.RootElement, options);
        }

        internal static NginxPrivateIPAddress DeserializeNginxPrivateIPAddress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddress> privateIPAddress = default;
            Optional<NginxPrivateIPAllocationMethod> privateIPAllocationMethod = default;
            Optional<ResourceIdentifier> subnetId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateIPAllocationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAllocationMethod = new NginxPrivateIPAllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NginxPrivateIPAddress(privateIPAddress.Value, Optional.ToNullable(privateIPAllocationMethod), subnetId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxPrivateIPAddress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxPrivateIPAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NginxPrivateIPAddress)} does not support '{options.Format}' format.");
            }
        }

        NginxPrivateIPAddress IPersistableModel<NginxPrivateIPAddress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxPrivateIPAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNginxPrivateIPAddress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxPrivateIPAddress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxPrivateIPAddress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
