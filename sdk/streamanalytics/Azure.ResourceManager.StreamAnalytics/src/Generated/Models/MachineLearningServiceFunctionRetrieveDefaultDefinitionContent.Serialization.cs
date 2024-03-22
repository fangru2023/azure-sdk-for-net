// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class MachineLearningServiceFunctionRetrieveDefaultDefinitionContent : IUtf8JsonSerializable, IJsonModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServiceFunctionRetrieveDefaultDefinitionContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("bindingType"u8);
            writer.WriteStringValue(BindingType);
            writer.WritePropertyName("bindingRetrievalProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExecuteEndpoint))
            {
                writer.WritePropertyName("executeEndpoint"u8);
                writer.WriteStringValue(ExecuteEndpoint);
            }
            if (Optional.IsDefined(UdfType))
            {
                writer.WritePropertyName("udfType"u8);
                writer.WriteStringValue(UdfType.Value.ToString());
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

        MachineLearningServiceFunctionRetrieveDefaultDefinitionContent IJsonModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServiceFunctionRetrieveDefaultDefinitionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServiceFunctionRetrieveDefaultDefinitionContent(document.RootElement, options);
        }

        internal static MachineLearningServiceFunctionRetrieveDefaultDefinitionContent DeserializeMachineLearningServiceFunctionRetrieveDefaultDefinitionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string bindingType = default;
            string executeEndpoint = default;
            StreamingJobFunctionUdfType? udfType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bindingType"u8))
                {
                    bindingType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bindingRetrievalProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("executeEndpoint"u8))
                        {
                            executeEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("udfType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            udfType = new StreamingJobFunctionUdfType(property0.Value.GetString());
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
            return new MachineLearningServiceFunctionRetrieveDefaultDefinitionContent(bindingType, serializedAdditionalRawData, executeEndpoint, udfType);
        }

        BinaryData IPersistableModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServiceFunctionRetrieveDefaultDefinitionContent)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningServiceFunctionRetrieveDefaultDefinitionContent IPersistableModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningServiceFunctionRetrieveDefaultDefinitionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServiceFunctionRetrieveDefaultDefinitionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningServiceFunctionRetrieveDefaultDefinitionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
