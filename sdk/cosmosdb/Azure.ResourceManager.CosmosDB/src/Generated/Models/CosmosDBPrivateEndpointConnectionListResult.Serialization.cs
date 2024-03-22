// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class CosmosDBPrivateEndpointConnectionListResult : IUtf8JsonSerializable, IJsonModel<CosmosDBPrivateEndpointConnectionListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBPrivateEndpointConnectionListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBPrivateEndpointConnectionListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBPrivateEndpointConnectionListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBPrivateEndpointConnectionListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        CosmosDBPrivateEndpointConnectionListResult IJsonModel<CosmosDBPrivateEndpointConnectionListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBPrivateEndpointConnectionListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBPrivateEndpointConnectionListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBPrivateEndpointConnectionListResult(document.RootElement, options);
        }

        internal static CosmosDBPrivateEndpointConnectionListResult DeserializeCosmosDBPrivateEndpointConnectionListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<CosmosDBPrivateEndpointConnectionData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBPrivateEndpointConnectionData> array = new List<CosmosDBPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBPrivateEndpointConnectionData.DeserializeCosmosDBPrivateEndpointConnectionData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBPrivateEndpointConnectionListResult(value ?? new ChangeTrackingList<CosmosDBPrivateEndpointConnectionData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBPrivateEndpointConnectionListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBPrivateEndpointConnectionListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBPrivateEndpointConnectionListResult)} does not support writing '{options.Format}' format.");
            }
        }

        CosmosDBPrivateEndpointConnectionListResult IPersistableModel<CosmosDBPrivateEndpointConnectionListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBPrivateEndpointConnectionListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBPrivateEndpointConnectionListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBPrivateEndpointConnectionListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBPrivateEndpointConnectionListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
