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
    public partial class AppServiceTableStorageApplicationLogsConfig : IUtf8JsonSerializable, IJsonModel<AppServiceTableStorageApplicationLogsConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceTableStorageApplicationLogsConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceTableStorageApplicationLogsConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceTableStorageApplicationLogsConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceTableStorageApplicationLogsConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToSerialString());
            }
            writer.WritePropertyName("sasUrl"u8);
            writer.WriteStringValue(SasUriString);
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

        AppServiceTableStorageApplicationLogsConfig IJsonModel<AppServiceTableStorageApplicationLogsConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceTableStorageApplicationLogsConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceTableStorageApplicationLogsConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceTableStorageApplicationLogsConfig(document.RootElement, options);
        }

        internal static AppServiceTableStorageApplicationLogsConfig DeserializeAppServiceTableStorageApplicationLogsConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebAppLogLevel? level = default;
            string sasUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = property.Value.GetString().ToWebAppLogLevel();
                    continue;
                }
                if (property.NameEquals("sasUrl"u8))
                {
                    sasUrl = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceTableStorageApplicationLogsConfig(level, sasUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceTableStorageApplicationLogsConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceTableStorageApplicationLogsConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceTableStorageApplicationLogsConfig)} does not support writing '{options.Format}' format.");
            }
        }

        AppServiceTableStorageApplicationLogsConfig IPersistableModel<AppServiceTableStorageApplicationLogsConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceTableStorageApplicationLogsConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceTableStorageApplicationLogsConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceTableStorageApplicationLogsConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceTableStorageApplicationLogsConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
