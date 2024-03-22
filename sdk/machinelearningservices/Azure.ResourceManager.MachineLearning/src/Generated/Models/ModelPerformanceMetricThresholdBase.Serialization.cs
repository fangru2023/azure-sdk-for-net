// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownModelPerformanceMetricThresholdBase))]
    public partial class ModelPerformanceMetricThresholdBase : IUtf8JsonSerializable, IJsonModel<ModelPerformanceMetricThresholdBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelPerformanceMetricThresholdBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ModelPerformanceMetricThresholdBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPerformanceMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelPerformanceMetricThresholdBase)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("modelType"u8);
            writer.WriteStringValue(ModelType.ToString());
            if (Optional.IsDefined(Threshold))
            {
                if (Threshold != null)
                {
                    writer.WritePropertyName("threshold"u8);
                    writer.WriteObjectValue(Threshold);
                }
                else
                {
                    writer.WriteNull("threshold");
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

        ModelPerformanceMetricThresholdBase IJsonModel<ModelPerformanceMetricThresholdBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPerformanceMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelPerformanceMetricThresholdBase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelPerformanceMetricThresholdBase(document.RootElement, options);
        }

        internal static ModelPerformanceMetricThresholdBase DeserializeModelPerformanceMetricThresholdBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("modelType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Classification": return ClassificationModelPerformanceMetricThreshold.DeserializeClassificationModelPerformanceMetricThreshold(element, options);
                    case "Regression": return RegressionModelPerformanceMetricThreshold.DeserializeRegressionModelPerformanceMetricThreshold(element, options);
                }
            }
            return UnknownModelPerformanceMetricThresholdBase.DeserializeUnknownModelPerformanceMetricThresholdBase(element, options);
        }

        BinaryData IPersistableModel<ModelPerformanceMetricThresholdBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPerformanceMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelPerformanceMetricThresholdBase)} does not support writing '{options.Format}' format.");
            }
        }

        ModelPerformanceMetricThresholdBase IPersistableModel<ModelPerformanceMetricThresholdBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPerformanceMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModelPerformanceMetricThresholdBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelPerformanceMetricThresholdBase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelPerformanceMetricThresholdBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
