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
    internal partial class OfficeDataConnectorDataTypesTeams : IUtf8JsonSerializable, IJsonModel<OfficeDataConnectorDataTypesTeams>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OfficeDataConnectorDataTypesTeams>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OfficeDataConnectorDataTypesTeams>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OfficeDataConnectorDataTypesTeams>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OfficeDataConnectorDataTypesTeams)} does not support writing '{format}' format.");
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

        OfficeDataConnectorDataTypesTeams IJsonModel<OfficeDataConnectorDataTypesTeams>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OfficeDataConnectorDataTypesTeams>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OfficeDataConnectorDataTypesTeams)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOfficeDataConnectorDataTypesTeams(document.RootElement, options);
        }

        internal static OfficeDataConnectorDataTypesTeams DeserializeOfficeDataConnectorDataTypesTeams(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsDataTypeConnectionState? state = default;
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
            return new OfficeDataConnectorDataTypesTeams(state, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OfficeDataConnectorDataTypesTeams>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OfficeDataConnectorDataTypesTeams>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OfficeDataConnectorDataTypesTeams)} does not support writing '{options.Format}' format.");
            }
        }

        OfficeDataConnectorDataTypesTeams IPersistableModel<OfficeDataConnectorDataTypesTeams>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OfficeDataConnectorDataTypesTeams>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOfficeDataConnectorDataTypesTeams(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OfficeDataConnectorDataTypesTeams)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OfficeDataConnectorDataTypesTeams>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
