// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformBuildResourceRequirements : IUtf8JsonSerializable, IJsonModel<AppPlatformBuildResourceRequirements>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformBuildResourceRequirements>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformBuildResourceRequirements>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformBuildResourceRequirements)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Cpu))
            {
                writer.WritePropertyName("cpu"u8);
                writer.WriteStringValue(Cpu);
            }
            if (Optional.IsDefined(Memory))
            {
                writer.WritePropertyName("memory"u8);
                writer.WriteStringValue(Memory);
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

        AppPlatformBuildResourceRequirements IJsonModel<AppPlatformBuildResourceRequirements>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformBuildResourceRequirements)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformBuildResourceRequirements(document.RootElement, options);
        }

        internal static AppPlatformBuildResourceRequirements DeserializeAppPlatformBuildResourceRequirements(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string cpu = default;
            string memory = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"u8))
                {
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"u8))
                {
                    memory = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformBuildResourceRequirements(cpu, memory, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformBuildResourceRequirements>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformBuildResourceRequirements)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformBuildResourceRequirements IPersistableModel<AppPlatformBuildResourceRequirements>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildResourceRequirements>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformBuildResourceRequirements(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformBuildResourceRequirements)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformBuildResourceRequirements>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
