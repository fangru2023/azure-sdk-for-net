// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class ResourceGuardProxyProperties : IUtf8JsonSerializable, IJsonModel<ResourceGuardProxyProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceGuardProxyProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceGuardProxyProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProxyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardProxyProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("resourceGuardResourceId"u8);
            writer.WriteStringValue(ResourceGuardResourceId);
            if (Optional.IsCollectionDefined(ResourceGuardOperationDetails))
            {
                writer.WritePropertyName("resourceGuardOperationDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        ResourceGuardProxyProperties IJsonModel<ResourceGuardProxyProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProxyProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceGuardProxyProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceGuardProxyProperties(document.RootElement, options);
        }

        internal static ResourceGuardProxyProperties DeserializeResourceGuardProxyProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceGuardResourceId = default;
            IList<ResourceGuardOperationDetail> resourceGuardOperationDetails = default;
            DateTimeOffset? lastUpdatedTime = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceGuardResourceId"u8))
                {
                    resourceGuardResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceGuardOperationDetail> array = new List<ResourceGuardOperationDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceGuardOperationDetail.DeserializeResourceGuardOperationDetail(item, options));
                    }
                    resourceGuardOperationDetails = array;
                    continue;
                }
                if (property.NameEquals("lastUpdatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceGuardProxyProperties(resourceGuardResourceId, resourceGuardOperationDetails ?? new ChangeTrackingList<ResourceGuardOperationDetail>(), lastUpdatedTime, description, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceGuardProxyProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProxyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardProxyProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceGuardProxyProperties IPersistableModel<ResourceGuardProxyProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceGuardProxyProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceGuardProxyProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceGuardProxyProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceGuardProxyProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
