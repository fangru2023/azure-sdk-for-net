// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorEndpoint : IUtf8JsonSerializable, IJsonModel<ConnectionMonitorEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionMonitorEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectionMonitorEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorEndpoint)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(EndpointType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(EndpointType.Value.ToString());
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteObjectValue(Scope);
            }
            if (Optional.IsDefined(CoverageLevel))
            {
                writer.WritePropertyName("coverageLevel"u8);
                writer.WriteStringValue(CoverageLevel.Value.ToString());
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

        ConnectionMonitorEndpoint IJsonModel<ConnectionMonitorEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorEndpoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorEndpoint(document.RootElement, options);
        }

        internal static ConnectionMonitorEndpoint DeserializeConnectionMonitorEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ConnectionMonitorEndpointType? type = default;
            ResourceIdentifier resourceId = default;
            string address = default;
            ConnectionMonitorEndpointFilter filter = default;
            ConnectionMonitorEndpointScope scope = default;
            CoverageLevel? coverageLevel = default;
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ConnectionMonitorEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = ConnectionMonitorEndpointFilter.DeserializeConnectionMonitorEndpointFilter(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = ConnectionMonitorEndpointScope.DeserializeConnectionMonitorEndpointScope(property.Value, options);
                    continue;
                }
                if (property.NameEquals("coverageLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coverageLevel = new CoverageLevel(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectionMonitorEndpoint(
                name,
                type,
                resourceId,
                address,
                filter,
                scope,
                coverageLevel,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectionMonitorEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectionMonitorEndpoint)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectionMonitorEndpoint IPersistableModel<ConnectionMonitorEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectionMonitorEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectionMonitorEndpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectionMonitorEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
