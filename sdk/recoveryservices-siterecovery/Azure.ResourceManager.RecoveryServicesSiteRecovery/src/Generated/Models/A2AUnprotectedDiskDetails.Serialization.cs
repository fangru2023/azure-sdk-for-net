// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AUnprotectedDiskDetails : IUtf8JsonSerializable, IJsonModel<A2AUnprotectedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AUnprotectedDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AUnprotectedDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUnprotectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AUnprotectedDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DiskLunId.HasValue)
            {
                writer.WritePropertyName("diskLunId"u8);
                writer.WriteNumberValue(DiskLunId.Value);
            }
            if (DiskAutoProtectionStatus.HasValue)
            {
                writer.WritePropertyName("diskAutoProtectionStatus"u8);
                writer.WriteStringValue(DiskAutoProtectionStatus.Value.ToString());
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

        A2AUnprotectedDiskDetails IJsonModel<A2AUnprotectedDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUnprotectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AUnprotectedDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AUnprotectedDiskDetails(document.RootElement, options);
        }

        internal static A2AUnprotectedDiskDetails DeserializeA2AUnprotectedDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? diskLunId = default;
            AutoProtectionOfDataDisk? diskAutoProtectionStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskLunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskLunId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskAutoProtectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskAutoProtectionStatus = new AutoProtectionOfDataDisk(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AUnprotectedDiskDetails(diskLunId, diskAutoProtectionStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<A2AUnprotectedDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUnprotectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AUnprotectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        A2AUnprotectedDiskDetails IPersistableModel<A2AUnprotectedDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AUnprotectedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AUnprotectedDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AUnprotectedDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AUnprotectedDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
