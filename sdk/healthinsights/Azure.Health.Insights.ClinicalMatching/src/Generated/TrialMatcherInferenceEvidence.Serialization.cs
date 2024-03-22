// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class TrialMatcherInferenceEvidence : IUtf8JsonSerializable, IJsonModel<TrialMatcherInferenceEvidence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrialMatcherInferenceEvidence>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrialMatcherInferenceEvidence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherInferenceEvidence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrialMatcherInferenceEvidence)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EligibilityCriteriaEvidence))
            {
                writer.WritePropertyName("eligibilityCriteriaEvidence"u8);
                writer.WriteStringValue(EligibilityCriteriaEvidence);
            }
            if (Optional.IsDefined(PatientDataEvidence))
            {
                writer.WritePropertyName("patientDataEvidence"u8);
                writer.WriteObjectValue(PatientDataEvidence);
            }
            if (Optional.IsDefined(PatientInfoEvidence))
            {
                writer.WritePropertyName("patientInfoEvidence"u8);
                writer.WriteObjectValue(PatientInfoEvidence);
            }
            if (Optional.IsDefined(Importance))
            {
                writer.WritePropertyName("importance"u8);
                writer.WriteNumberValue(Importance.Value);
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

        TrialMatcherInferenceEvidence IJsonModel<TrialMatcherInferenceEvidence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherInferenceEvidence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrialMatcherInferenceEvidence)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrialMatcherInferenceEvidence(document.RootElement, options);
        }

        internal static TrialMatcherInferenceEvidence DeserializeTrialMatcherInferenceEvidence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eligibilityCriteriaEvidence = default;
            ClinicalNoteEvidence patientDataEvidence = default;
            ClinicalCodedElement patientInfoEvidence = default;
            float? importance = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eligibilityCriteriaEvidence"u8))
                {
                    eligibilityCriteriaEvidence = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("patientDataEvidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patientDataEvidence = ClinicalNoteEvidence.DeserializeClinicalNoteEvidence(property.Value, options);
                    continue;
                }
                if (property.NameEquals("patientInfoEvidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patientInfoEvidence = ClinicalCodedElement.DeserializeClinicalCodedElement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("importance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    importance = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrialMatcherInferenceEvidence(eligibilityCriteriaEvidence, patientDataEvidence, patientInfoEvidence, importance, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrialMatcherInferenceEvidence>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherInferenceEvidence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrialMatcherInferenceEvidence)} does not support writing '{options.Format}' format.");
            }
        }

        TrialMatcherInferenceEvidence IPersistableModel<TrialMatcherInferenceEvidence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrialMatcherInferenceEvidence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrialMatcherInferenceEvidence(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrialMatcherInferenceEvidence)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrialMatcherInferenceEvidence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TrialMatcherInferenceEvidence FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTrialMatcherInferenceEvidence(document.RootElement);
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
