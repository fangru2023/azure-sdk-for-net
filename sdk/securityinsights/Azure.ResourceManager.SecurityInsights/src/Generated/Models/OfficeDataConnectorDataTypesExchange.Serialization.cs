// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class OfficeDataConnectorDataTypesExchange : IUtf8JsonSerializable, IJsonModel<OfficeDataConnectorDataTypesExchange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OfficeDataConnectorDataTypesExchange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OfficeDataConnectorDataTypesExchange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OfficeDataConnectorDataTypesExchange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OfficeDataConnectorDataTypesExchange)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        OfficeDataConnectorDataTypesExchange IJsonModel<OfficeDataConnectorDataTypesExchange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OfficeDataConnectorDataTypesExchange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OfficeDataConnectorDataTypesExchange)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOfficeDataConnectorDataTypesExchange(document.RootElement, options);
        }

        internal static OfficeDataConnectorDataTypesExchange DeserializeOfficeDataConnectorDataTypesExchange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityInsightsDataTypeConnectionState> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SecurityInsightsDataTypeConnectionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OfficeDataConnectorDataTypesExchange(Optional.ToNullable(state), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OfficeDataConnectorDataTypesExchange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OfficeDataConnectorDataTypesExchange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OfficeDataConnectorDataTypesExchange)} does not support '{options.Format}' format.");
            }
        }

        OfficeDataConnectorDataTypesExchange IPersistableModel<OfficeDataConnectorDataTypesExchange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OfficeDataConnectorDataTypesExchange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOfficeDataConnectorDataTypesExchange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OfficeDataConnectorDataTypesExchange)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OfficeDataConnectorDataTypesExchange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
