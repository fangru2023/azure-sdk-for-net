// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ExportRoutePolicyInformation : IUtf8JsonSerializable, IJsonModel<ExportRoutePolicyInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportRoutePolicyInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExportRoutePolicyInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportRoutePolicyInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportRoutePolicyInformation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExportIPv4RoutePolicyId))
            {
                writer.WritePropertyName("exportIpv4RoutePolicyId"u8);
                writer.WriteStringValue(ExportIPv4RoutePolicyId);
            }
            if (Optional.IsDefined(ExportIPv6RoutePolicyId))
            {
                writer.WritePropertyName("exportIpv6RoutePolicyId"u8);
                writer.WriteStringValue(ExportIPv6RoutePolicyId);
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

        ExportRoutePolicyInformation IJsonModel<ExportRoutePolicyInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportRoutePolicyInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportRoutePolicyInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportRoutePolicyInformation(document.RootElement, options);
        }

        internal static ExportRoutePolicyInformation DeserializeExportRoutePolicyInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier exportIPv4RoutePolicyId = default;
            ResourceIdentifier exportIPv6RoutePolicyId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exportIpv4RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportIPv4RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exportIpv6RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportIPv6RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ExportRoutePolicyInformation(exportIPv4RoutePolicyId, exportIPv6RoutePolicyId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportRoutePolicyInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportRoutePolicyInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportRoutePolicyInformation)} does not support writing '{options.Format}' format.");
            }
        }

        ExportRoutePolicyInformation IPersistableModel<ExportRoutePolicyInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportRoutePolicyInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExportRoutePolicyInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportRoutePolicyInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportRoutePolicyInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
