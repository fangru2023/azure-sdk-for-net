// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceOperationSteps : IUtf8JsonSerializable, IJsonModel<ManagedInstanceOperationSteps>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceOperationSteps>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstanceOperationSteps>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TotalSteps))
            {
                writer.WritePropertyName("totalSteps"u8);
                writer.WriteStringValue(TotalSteps);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentStep))
            {
                writer.WritePropertyName("currentStep"u8);
                writer.WriteNumberValue(CurrentStep.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(StepsList))
            {
                writer.WritePropertyName("stepsList"u8);
                writer.WriteStartArray();
                foreach (var item in StepsList)
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

        ManagedInstanceOperationSteps IJsonModel<ManagedInstanceOperationSteps>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceOperationSteps(document.RootElement, options);
        }

        internal static ManagedInstanceOperationSteps DeserializeManagedInstanceOperationSteps(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string totalSteps = default;
            int? currentStep = default;
            IReadOnlyList<UpsertManagedServerOperationStep> stepsList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalSteps"u8))
                {
                    totalSteps = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentStep = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stepsList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UpsertManagedServerOperationStep> array = new List<UpsertManagedServerOperationStep>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UpsertManagedServerOperationStep.DeserializeUpsertManagedServerOperationStep(item, options));
                    }
                    stepsList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstanceOperationSteps(totalSteps, currentStep, stepsList ?? new ChangeTrackingList<UpsertManagedServerOperationStep>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedInstanceOperationSteps>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedInstanceOperationSteps IPersistableModel<ManagedInstanceOperationSteps>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceOperationSteps>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedInstanceOperationSteps(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceOperationSteps)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceOperationSteps>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
