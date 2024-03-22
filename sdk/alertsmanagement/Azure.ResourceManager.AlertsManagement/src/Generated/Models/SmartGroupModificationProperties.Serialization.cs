// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class SmartGroupModificationProperties : IUtf8JsonSerializable, IJsonModel<SmartGroupModificationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SmartGroupModificationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SmartGroupModificationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmartGroupModificationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SmartGroupModificationProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SmartGroupId))
            {
                writer.WritePropertyName("smartGroupId"u8);
                writer.WriteStringValue(SmartGroupId.Value);
            }
            if (Optional.IsCollectionDefined(Modifications))
            {
                writer.WritePropertyName("modifications"u8);
                writer.WriteStartArray();
                foreach (var item in Modifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        SmartGroupModificationProperties IJsonModel<SmartGroupModificationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmartGroupModificationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SmartGroupModificationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSmartGroupModificationProperties(document.RootElement, options);
        }

        internal static SmartGroupModificationProperties DeserializeSmartGroupModificationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? smartGroupId = default;
            IList<SmartGroupModificationItemInfo> modifications = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("smartGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartGroupId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("modifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SmartGroupModificationItemInfo> array = new List<SmartGroupModificationItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SmartGroupModificationItemInfo.DeserializeSmartGroupModificationItemInfo(item, options));
                    }
                    modifications = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SmartGroupModificationProperties(smartGroupId, modifications ?? new ChangeTrackingList<SmartGroupModificationItemInfo>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SmartGroupModificationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmartGroupModificationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SmartGroupModificationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SmartGroupModificationProperties IPersistableModel<SmartGroupModificationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SmartGroupModificationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSmartGroupModificationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SmartGroupModificationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SmartGroupModificationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
