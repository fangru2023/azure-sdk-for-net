// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class WindowsUpdateConfigurationProperties : IUtf8JsonSerializable, IJsonModel<WindowsUpdateConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WindowsUpdateConfigurationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WindowsUpdateConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsUpdateConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsUpdateConfigurationProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IncludedUpdateClassifications))
            {
                writer.WritePropertyName("includedUpdateClassifications"u8);
                writer.WriteStringValue(IncludedUpdateClassifications.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExcludedKBNumbers))
            {
                writer.WritePropertyName("excludedKbNumbers"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedKBNumbers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IncludedKBNumbers))
            {
                writer.WritePropertyName("includedKbNumbers"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedKBNumbers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RebootSetting))
            {
                writer.WritePropertyName("rebootSetting"u8);
                writer.WriteStringValue(RebootSetting);
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

        WindowsUpdateConfigurationProperties IJsonModel<WindowsUpdateConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsUpdateConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WindowsUpdateConfigurationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsUpdateConfigurationProperties(document.RootElement, options);
        }

        internal static WindowsUpdateConfigurationProperties DeserializeWindowsUpdateConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WindowsUpdateClassification? includedUpdateClassifications = default;
            IList<string> excludedKbNumbers = default;
            IList<string> includedKbNumbers = default;
            string rebootSetting = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("includedUpdateClassifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedUpdateClassifications = new WindowsUpdateClassification(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("excludedKbNumbers"u8))
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
                    excludedKbNumbers = array;
                    continue;
                }
                if (property.NameEquals("includedKbNumbers"u8))
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
                    includedKbNumbers = array;
                    continue;
                }
                if (property.NameEquals("rebootSetting"u8))
                {
                    rebootSetting = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WindowsUpdateConfigurationProperties(includedUpdateClassifications, excludedKbNumbers ?? new ChangeTrackingList<string>(), includedKbNumbers ?? new ChangeTrackingList<string>(), rebootSetting, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WindowsUpdateConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsUpdateConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WindowsUpdateConfigurationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        WindowsUpdateConfigurationProperties IPersistableModel<WindowsUpdateConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WindowsUpdateConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWindowsUpdateConfigurationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WindowsUpdateConfigurationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WindowsUpdateConfigurationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
