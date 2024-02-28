// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Qumulo.Models
{
    public partial class FileSystemResourceUpdateProperties : IUtf8JsonSerializable, IJsonModel<FileSystemResourceUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FileSystemResourceUpdateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FileSystemResourceUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemResourceUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSystemResourceUpdateProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MarketplaceDetails != null)
            {
                writer.WritePropertyName("marketplaceDetails"u8);
                writer.WriteObjectValue(MarketplaceDetails);
            }
            if (UserDetails != null)
            {
                writer.WritePropertyName("userDetails"u8);
                writer.WriteObjectValue(UserDetails);
            }
            if (DelegatedSubnetId != null)
            {
                writer.WritePropertyName("delegatedSubnetId"u8);
                writer.WriteStringValue(DelegatedSubnetId);
            }
            if (ClusterLoginUri != null)
            {
                writer.WritePropertyName("clusterLoginUrl"u8);
                writer.WriteStringValue(ClusterLoginUri.AbsoluteUri);
            }
            if (!(PrivateIPs is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("privateIPs"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateIPs)
                {
                    writer.WriteStringValue(item);
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

        FileSystemResourceUpdateProperties IJsonModel<FileSystemResourceUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemResourceUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FileSystemResourceUpdateProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFileSystemResourceUpdateProperties(document.RootElement, options);
        }

        internal static FileSystemResourceUpdateProperties DeserializeFileSystemResourceUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MarketplaceDetails marketplaceDetails = default;
            QumuloUserDetails userDetails = default;
            ResourceIdentifier delegatedSubnetId = default;
            Uri clusterLoginUrl = default;
            IList<string> privateIPs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplaceDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceDetails = MarketplaceDetails.DeserializeMarketplaceDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userDetails = QumuloUserDetails.DeserializeQumuloUserDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("delegatedSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delegatedSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clusterLoginUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterLoginUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateIPs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    privateIPs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FileSystemResourceUpdateProperties(
                marketplaceDetails,
                userDetails,
                delegatedSubnetId,
                clusterLoginUrl,
                privateIPs ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FileSystemResourceUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemResourceUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FileSystemResourceUpdateProperties)} does not support '{options.Format}' format.");
            }
        }

        FileSystemResourceUpdateProperties IPersistableModel<FileSystemResourceUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FileSystemResourceUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFileSystemResourceUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FileSystemResourceUpdateProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FileSystemResourceUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
