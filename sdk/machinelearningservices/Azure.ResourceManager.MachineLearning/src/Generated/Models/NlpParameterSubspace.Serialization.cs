// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class NlpParameterSubspace : IUtf8JsonSerializable, IJsonModel<NlpParameterSubspace>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NlpParameterSubspace>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NlpParameterSubspace>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpParameterSubspace>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NlpParameterSubspace)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(GradientAccumulationSteps))
            {
                if (GradientAccumulationSteps != null)
                {
                    writer.WritePropertyName("gradientAccumulationSteps"u8);
                    writer.WriteStringValue(GradientAccumulationSteps);
                }
                else
                {
                    writer.WriteNull("gradientAccumulationSteps");
                }
            }
            if (Optional.IsDefined(LearningRate))
            {
                if (LearningRate != null)
                {
                    writer.WritePropertyName("learningRate"u8);
                    writer.WriteStringValue(LearningRate);
                }
                else
                {
                    writer.WriteNull("learningRate");
                }
            }
            if (Optional.IsDefined(LearningRateScheduler))
            {
                if (LearningRateScheduler != null)
                {
                    writer.WritePropertyName("learningRateScheduler"u8);
                    writer.WriteStringValue(LearningRateScheduler);
                }
                else
                {
                    writer.WriteNull("learningRateScheduler");
                }
            }
            if (Optional.IsDefined(ModelName))
            {
                if (ModelName != null)
                {
                    writer.WritePropertyName("modelName"u8);
                    writer.WriteStringValue(ModelName);
                }
                else
                {
                    writer.WriteNull("modelName");
                }
            }
            if (Optional.IsDefined(NumberOfEpochs))
            {
                if (NumberOfEpochs != null)
                {
                    writer.WritePropertyName("numberOfEpochs"u8);
                    writer.WriteStringValue(NumberOfEpochs);
                }
                else
                {
                    writer.WriteNull("numberOfEpochs");
                }
            }
            if (Optional.IsDefined(TrainingBatchSize))
            {
                if (TrainingBatchSize != null)
                {
                    writer.WritePropertyName("trainingBatchSize"u8);
                    writer.WriteStringValue(TrainingBatchSize);
                }
                else
                {
                    writer.WriteNull("trainingBatchSize");
                }
            }
            if (Optional.IsDefined(ValidationBatchSize))
            {
                if (ValidationBatchSize != null)
                {
                    writer.WritePropertyName("validationBatchSize"u8);
                    writer.WriteStringValue(ValidationBatchSize);
                }
                else
                {
                    writer.WriteNull("validationBatchSize");
                }
            }
            if (Optional.IsDefined(WarmupRatio))
            {
                if (WarmupRatio != null)
                {
                    writer.WritePropertyName("warmupRatio"u8);
                    writer.WriteStringValue(WarmupRatio);
                }
                else
                {
                    writer.WriteNull("warmupRatio");
                }
            }
            if (Optional.IsDefined(WeightDecay))
            {
                if (WeightDecay != null)
                {
                    writer.WritePropertyName("weightDecay"u8);
                    writer.WriteStringValue(WeightDecay);
                }
                else
                {
                    writer.WriteNull("weightDecay");
                }
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

        NlpParameterSubspace IJsonModel<NlpParameterSubspace>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpParameterSubspace>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NlpParameterSubspace)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNlpParameterSubspace(document.RootElement, options);
        }

        internal static NlpParameterSubspace DeserializeNlpParameterSubspace(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string gradientAccumulationSteps = default;
            string learningRate = default;
            string learningRateScheduler = default;
            string modelName = default;
            string numberOfEpochs = default;
            string trainingBatchSize = default;
            string validationBatchSize = default;
            string warmupRatio = default;
            string weightDecay = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gradientAccumulationSteps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gradientAccumulationSteps = null;
                        continue;
                    }
                    gradientAccumulationSteps = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRate = null;
                        continue;
                    }
                    learningRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRateScheduler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRateScheduler = null;
                        continue;
                    }
                    learningRateScheduler = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelName = null;
                        continue;
                    }
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfEpochs = null;
                        continue;
                    }
                    numberOfEpochs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trainingBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingBatchSize = null;
                        continue;
                    }
                    trainingBatchSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationBatchSize = null;
                        continue;
                    }
                    validationBatchSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warmupRatio"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupRatio = null;
                        continue;
                    }
                    warmupRatio = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weightDecay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightDecay = null;
                        continue;
                    }
                    weightDecay = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NlpParameterSubspace(
                gradientAccumulationSteps,
                learningRate,
                learningRateScheduler,
                modelName,
                numberOfEpochs,
                trainingBatchSize,
                validationBatchSize,
                warmupRatio,
                weightDecay,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NlpParameterSubspace>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpParameterSubspace>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NlpParameterSubspace)} does not support writing '{options.Format}' format.");
            }
        }

        NlpParameterSubspace IPersistableModel<NlpParameterSubspace>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpParameterSubspace>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNlpParameterSubspace(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NlpParameterSubspace)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NlpParameterSubspace>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
