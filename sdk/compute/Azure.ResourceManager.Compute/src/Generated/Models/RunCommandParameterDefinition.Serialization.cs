// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RunCommandParameterDefinition : IUtf8JsonSerializable, IJsonModel<RunCommandParameterDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunCommandParameterDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RunCommandParameterDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunCommandParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunCommandParameterDefinition)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RunCommandParameterDefinitionType);
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue"u8);
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsDefined(Required))
            {
                writer.WritePropertyName("required"u8);
                writer.WriteBooleanValue(Required.Value);
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

        RunCommandParameterDefinition IJsonModel<RunCommandParameterDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunCommandParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunCommandParameterDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunCommandParameterDefinition(document.RootElement, options);
        }

        internal static RunCommandParameterDefinition DeserializeRunCommandParameterDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string type = default;
            string defaultValue = default;
            bool? required = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultValue"u8))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RunCommandParameterDefinition(name, type, defaultValue, required, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunCommandParameterDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunCommandParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunCommandParameterDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        RunCommandParameterDefinition IPersistableModel<RunCommandParameterDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunCommandParameterDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunCommandParameterDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunCommandParameterDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunCommandParameterDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
