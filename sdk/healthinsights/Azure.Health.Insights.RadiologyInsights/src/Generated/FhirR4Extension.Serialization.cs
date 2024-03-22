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
    public partial class FhirR4Extension : IUtf8JsonSerializable, IJsonModel<FhirR4Extension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirR4Extension>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FhirR4Extension>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Extension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Extension)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Url);
            if (Optional.IsDefined(ValueQuantity))
            {
                writer.WritePropertyName("valueQuantity"u8);
                writer.WriteObjectValue(ValueQuantity);
            }
            if (Optional.IsDefined(ValueCodeableConcept))
            {
                writer.WritePropertyName("valueCodeableConcept"u8);
                writer.WriteObjectValue(ValueCodeableConcept);
            }
            if (Optional.IsDefined(ValueString))
            {
                writer.WritePropertyName("valueString"u8);
                writer.WriteStringValue(ValueString);
            }
            if (Optional.IsDefined(ValueBoolean))
            {
                writer.WritePropertyName("valueBoolean"u8);
                writer.WriteBooleanValue(ValueBoolean.Value);
            }
            if (Optional.IsDefined(ValueInteger))
            {
                writer.WritePropertyName("valueInteger"u8);
                writer.WriteNumberValue(ValueInteger.Value);
            }
            if (Optional.IsDefined(ValueRange))
            {
                writer.WritePropertyName("valueRange"u8);
                writer.WriteObjectValue(ValueRange);
            }
            if (Optional.IsDefined(ValueRatio))
            {
                writer.WritePropertyName("valueRatio"u8);
                writer.WriteObjectValue(ValueRatio);
            }
            if (Optional.IsDefined(ValueSampledData))
            {
                writer.WritePropertyName("valueSampledData"u8);
                writer.WriteObjectValue(ValueSampledData);
            }
            if (Optional.IsDefined(ValueTime))
            {
                writer.WritePropertyName("valueTime"u8);
                writer.WriteStringValue(ValueTime.Value, "T");
            }
            if (Optional.IsDefined(ValueDateTime))
            {
                writer.WritePropertyName("valueDateTime"u8);
                writer.WriteStringValue(ValueDateTime);
            }
            if (Optional.IsDefined(ValuePeriod))
            {
                writer.WritePropertyName("valuePeriod"u8);
                writer.WriteObjectValue(ValuePeriod);
            }
            if (Optional.IsDefined(ValueReference))
            {
                writer.WritePropertyName("valueReference"u8);
                writer.WriteObjectValue(ValueReference);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStartArray();
                foreach (var item in Extension)
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

        FhirR4Extension IJsonModel<FhirR4Extension>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Extension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Extension)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirR4Extension(document.RootElement, options);
        }

        internal static FhirR4Extension DeserializeFhirR4Extension(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string url = default;
            FhirR4Quantity valueQuantity = default;
            FhirR4CodeableConcept valueCodeableConcept = default;
            string valueString = default;
            bool? valueBoolean = default;
            int? valueInteger = default;
            FhirR4Range valueRange = default;
            FhirR4Ratio valueRatio = default;
            FhirR4SampledData valueSampledData = default;
            TimeSpan? valueTime = default;
            string valueDateTime = default;
            FhirR4Period valuePeriod = default;
            FhirR4Reference valueReference = default;
            string id = default;
            IReadOnlyList<FhirR4Extension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueQuantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueQuantity = FhirR4Quantity.DeserializeFhirR4Quantity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueCodeableConcept"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueCodeableConcept = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueString"u8))
                {
                    valueString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueBoolean"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueBoolean = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("valueInteger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueInteger = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("valueRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueRange = FhirR4Range.DeserializeFhirR4Range(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueRatio"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueRatio = FhirR4Ratio.DeserializeFhirR4Ratio(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueSampledData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueSampledData = FhirR4SampledData.DeserializeFhirR4SampledData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("valueDateTime"u8))
                {
                    valueDateTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valuePeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valuePeriod = FhirR4Period.DeserializeFhirR4Period(property.Value, options);
                    continue;
                }
                if (property.NameEquals("valueReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueReference = FhirR4Reference.DeserializeFhirR4Reference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extension> array = new List<FhirR4Extension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeFhirR4Extension(item, options));
                    }
                    extension = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FhirR4Extension(
                id,
                extension ?? new ChangeTrackingList<FhirR4Extension>(),
                serializedAdditionalRawData,
                url,
                valueQuantity,
                valueCodeableConcept,
                valueString,
                valueBoolean,
                valueInteger,
                valueRange,
                valueRatio,
                valueSampledData,
                valueTime,
                valueDateTime,
                valuePeriod,
                valueReference);
        }

        BinaryData IPersistableModel<FhirR4Extension>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Extension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirR4Extension)} does not support writing '{options.Format}' format.");
            }
        }

        FhirR4Extension IPersistableModel<FhirR4Extension>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Extension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirR4Extension(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirR4Extension)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirR4Extension>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new FhirR4Extension FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFhirR4Extension(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
