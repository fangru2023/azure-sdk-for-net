// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class VirtualIPMapping : IUtf8JsonSerializable, IJsonModel<VirtualIPMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualIPMapping>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualIPMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualIPMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualIPMapping)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualIP))
            {
                writer.WritePropertyName("virtualIP"u8);
                writer.WriteStringValue(VirtualIP);
            }
            if (Optional.IsDefined(InternalHttpPort))
            {
                writer.WritePropertyName("internalHttpPort"u8);
                writer.WriteNumberValue(InternalHttpPort.Value);
            }
            if (Optional.IsDefined(InternalHttpsPort))
            {
                writer.WritePropertyName("internalHttpsPort"u8);
                writer.WriteNumberValue(InternalHttpsPort.Value);
            }
            if (Optional.IsDefined(IsInUse))
            {
                writer.WritePropertyName("inUse"u8);
                writer.WriteBooleanValue(IsInUse.Value);
            }
            if (Optional.IsDefined(ServiceName))
            {
                writer.WritePropertyName("serviceName"u8);
                writer.WriteStringValue(ServiceName);
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

        VirtualIPMapping IJsonModel<VirtualIPMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualIPMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualIPMapping)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualIPMapping(document.RootElement, options);
        }

        internal static VirtualIPMapping DeserializeVirtualIPMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string virtualIP = default;
            int? internalHttpPort = default;
            int? internalHttpsPort = default;
            bool? inUse = default;
            string serviceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualIP"u8))
                {
                    virtualIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalHttpPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalHttpPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("internalHttpsPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalHttpsPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inUse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inUse = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualIPMapping(
                virtualIP,
                internalHttpPort,
                internalHttpsPort,
                inUse,
                serviceName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualIPMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualIPMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualIPMapping)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualIPMapping IPersistableModel<VirtualIPMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualIPMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualIPMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualIPMapping)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualIPMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
