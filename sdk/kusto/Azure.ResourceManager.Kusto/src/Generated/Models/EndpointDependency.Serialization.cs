// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class EndpointDependency : IUtf8JsonSerializable, IJsonModel<EndpointDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EndpointDependency>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EndpointDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointDependency)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsCollectionDefined(EndpointDetails))
            {
                writer.WritePropertyName("endpointDetails"u8);
                writer.WriteStartArray();
                foreach (var item in EndpointDetails)
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

        EndpointDependency IJsonModel<EndpointDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointDependency)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEndpointDependency(document.RootElement, options);
        }

        internal static EndpointDependency DeserializeEndpointDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string domainName = default;
            IList<EndpointDetail> endpointDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EndpointDetail> array = new List<EndpointDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EndpointDetail.DeserializeEndpointDetail(item, options));
                    }
                    endpointDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EndpointDependency(domainName, endpointDetails ?? new ChangeTrackingList<EndpointDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EndpointDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EndpointDependency)} does not support writing '{options.Format}' format.");
            }
        }

        EndpointDependency IPersistableModel<EndpointDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEndpointDependency(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EndpointDependency)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EndpointDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
