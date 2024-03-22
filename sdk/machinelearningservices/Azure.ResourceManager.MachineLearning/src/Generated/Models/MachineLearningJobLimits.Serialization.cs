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
    [PersistableModelProxy(typeof(UnknownJobLimits))]
    public partial class MachineLearningJobLimits : IUtf8JsonSerializable, IJsonModel<MachineLearningJobLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningJobLimits>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningJobLimits>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobLimits)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("jobLimitsType"u8);
            writer.WriteStringValue(JobLimitsType.ToString());
            if (Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout"u8);
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
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

        MachineLearningJobLimits IJsonModel<MachineLearningJobLimits>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningJobLimits)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningJobLimits(document.RootElement, options);
        }

        internal static MachineLearningJobLimits DeserializeMachineLearningJobLimits(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobLimitsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Command": return MachineLearningCommandJobLimits.DeserializeMachineLearningCommandJobLimits(element, options);
                    case "Sweep": return MachineLearningSweepJobLimits.DeserializeMachineLearningSweepJobLimits(element, options);
                }
            }
            return UnknownJobLimits.DeserializeUnknownJobLimits(element, options);
        }

        BinaryData IPersistableModel<MachineLearningJobLimits>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobLimits)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningJobLimits IPersistableModel<MachineLearningJobLimits>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningJobLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningJobLimits(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningJobLimits)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningJobLimits>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
