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
    public partial class A2AProtectionIntentDiskDetails : IUtf8JsonSerializable, IJsonModel<A2AProtectionIntentDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AProtectionIntentDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AProtectionIntentDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AProtectionIntentDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AProtectionIntentDiskDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("diskUri"u8);
            writer.WriteStringValue(DiskUri.AbsoluteUri);
            if (Optional.IsDefined(RecoveryAzureStorageAccountCustomContent))
            {
                writer.WritePropertyName("recoveryAzureStorageAccountCustomInput"u8);
                writer.WriteObjectValue(RecoveryAzureStorageAccountCustomContent);
            }
            if (Optional.IsDefined(PrimaryStagingStorageAccountCustomContent))
            {
                writer.WritePropertyName("primaryStagingStorageAccountCustomInput"u8);
                writer.WriteObjectValue(PrimaryStagingStorageAccountCustomContent);
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

        A2AProtectionIntentDiskDetails IJsonModel<A2AProtectionIntentDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AProtectionIntentDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AProtectionIntentDiskDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AProtectionIntentDiskDetails(document.RootElement, options);
        }

        internal static A2AProtectionIntentDiskDetails DeserializeA2AProtectionIntentDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri diskUri = default;
            StorageAccountCustomDetails recoveryAzureStorageAccountCustomContent = default;
            StorageAccountCustomDetails primaryStagingStorageAccountCustomContent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskUri"u8))
                {
                    diskUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryAzureStorageAccountCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAzureStorageAccountCustomContent = StorageAccountCustomDetails.DeserializeStorageAccountCustomDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("primaryStagingStorageAccountCustomInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryStagingStorageAccountCustomContent = StorageAccountCustomDetails.DeserializeStorageAccountCustomDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AProtectionIntentDiskDetails(diskUri, recoveryAzureStorageAccountCustomContent, primaryStagingStorageAccountCustomContent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<A2AProtectionIntentDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AProtectionIntentDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AProtectionIntentDiskDetails)} does not support writing '{options.Format}' format.");
            }
        }

        A2AProtectionIntentDiskDetails IPersistableModel<A2AProtectionIntentDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AProtectionIntentDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AProtectionIntentDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AProtectionIntentDiskDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AProtectionIntentDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
