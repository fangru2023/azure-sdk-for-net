// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class DocumentAdministrativeMetadata : IUtf8JsonSerializable, IJsonModel<DocumentAdministrativeMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentAdministrativeMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentAdministrativeMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentAdministrativeMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentAdministrativeMetadata)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(OrderedProcedures))
            {
                writer.WritePropertyName("orderedProcedures"u8);
                writer.WriteStartArray();
                foreach (var item in OrderedProcedures)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EncounterId))
            {
                writer.WritePropertyName("encounterId"u8);
                writer.WriteStringValue(EncounterId);
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

        DocumentAdministrativeMetadata IJsonModel<DocumentAdministrativeMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentAdministrativeMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentAdministrativeMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentAdministrativeMetadata(document.RootElement, options);
        }

        internal static DocumentAdministrativeMetadata DeserializeDocumentAdministrativeMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<FhirR4Extendible> orderedProcedures = default;
            string encounterId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("orderedProcedures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extendible> array = new List<FhirR4Extendible>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extendible.DeserializeFhirR4Extendible(item, options));
                    }
                    orderedProcedures = array;
                    continue;
                }
                if (property.NameEquals("encounterId"u8))
                {
                    encounterId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DocumentAdministrativeMetadata(orderedProcedures ?? new ChangeTrackingList<FhirR4Extendible>(), encounterId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentAdministrativeMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentAdministrativeMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentAdministrativeMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentAdministrativeMetadata IPersistableModel<DocumentAdministrativeMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentAdministrativeMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentAdministrativeMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentAdministrativeMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentAdministrativeMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentAdministrativeMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentAdministrativeMetadata(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
