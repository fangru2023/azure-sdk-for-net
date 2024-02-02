// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class ImportRdbContent : IUtf8JsonSerializable, IJsonModel<ImportRdbContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImportRdbContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImportRdbContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRdbContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportRdbContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format);
            }
            writer.WritePropertyName("files"u8);
            writer.WriteStartArray();
            foreach (var item in Files)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(PreferredDataArchiveAuthMethod))
            {
                writer.WritePropertyName("preferred-data-archive-auth-method"u8);
                writer.WriteStringValue(PreferredDataArchiveAuthMethod);
            }
            if (Optional.IsDefined(StorageSubscriptionId))
            {
                writer.WritePropertyName("storage-subscription-id"u8);
                writer.WriteStringValue(StorageSubscriptionId);
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

        ImportRdbContent IJsonModel<ImportRdbContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRdbContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImportRdbContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImportRdbContent(document.RootElement, options);
        }

        internal static ImportRdbContent DeserializeImportRdbContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> format = default;
            IList<string> files = default;
            Optional<string> preferredDataArchiveAuthMethod = default;
            Optional<string> storageSubscriptionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("format"u8))
                {
                    format = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("files"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    files = array;
                    continue;
                }
                if (property.NameEquals("preferred-data-archive-auth-method"u8))
                {
                    preferredDataArchiveAuthMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storage-subscription-id"u8))
                {
                    storageSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImportRdbContent(format.Value, files, preferredDataArchiveAuthMethod.Value, storageSubscriptionId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImportRdbContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRdbContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImportRdbContent)} does not support '{options.Format}' format.");
            }
        }

        ImportRdbContent IPersistableModel<ImportRdbContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImportRdbContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImportRdbContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImportRdbContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImportRdbContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
