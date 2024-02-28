// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeStorageAccountData : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeStorageAccountData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeStorageAccountData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeStorageAccountData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeStorageAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeStorageAccountData)} does not support '{format}' format.");
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (StorageAccountStatus.HasValue)
            {
                writer.WritePropertyName("storageAccountStatus"u8);
                writer.WriteStringValue(StorageAccountStatus.Value.ToString());
            }
            writer.WritePropertyName("dataPolicy"u8);
            writer.WriteStringValue(DataPolicy.ToString());
            if (StorageAccountCredentialId != null)
            {
                writer.WritePropertyName("storageAccountCredentialId"u8);
                writer.WriteStringValue(StorageAccountCredentialId);
            }
            if (options.Format != "W" && BlobEndpoint != null)
            {
                writer.WritePropertyName("blobEndpoint"u8);
                writer.WriteStringValue(BlobEndpoint);
            }
            if (options.Format != "W" && ContainerCount.HasValue)
            {
                writer.WritePropertyName("containerCount"u8);
                writer.WriteNumberValue(ContainerCount.Value);
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

        DataBoxEdgeStorageAccountData IJsonModel<DataBoxEdgeStorageAccountData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeStorageAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeStorageAccountData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeStorageAccountData(document.RootElement, options);
        }

        internal static DataBoxEdgeStorageAccountData DeserializeDataBoxEdgeStorageAccountData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string description = default;
            DataBoxEdgeStorageAccountStatus? storageAccountStatus = default;
            DataBoxEdgeDataPolicy dataPolicy = default;
            ResourceIdentifier storageAccountCredentialId = default;
            string blobEndpoint = default;
            int? containerCount = default;
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountStatus = new DataBoxEdgeStorageAccountStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataPolicy"u8))
                        {
                            dataPolicy = new DataBoxEdgeDataPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAccountCredentialId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountCredentialId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobEndpoint"u8))
                        {
                            blobEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerCount = property0.Value.GetInt32();
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
            return new DataBoxEdgeStorageAccountData(
                id,
                name,
                type,
                systemData,
                description,
                storageAccountStatus,
                dataPolicy,
                storageAccountCredentialId,
                blobEndpoint,
                containerCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeStorageAccountData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeStorageAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeStorageAccountData)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeStorageAccountData IPersistableModel<DataBoxEdgeStorageAccountData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeStorageAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeStorageAccountData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeStorageAccountData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeStorageAccountData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
