// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppWorkloadProfile : IUtf8JsonSerializable, IJsonModel<ContainerAppWorkloadProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppWorkloadProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppWorkloadProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppWorkloadProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("workloadProfileType"u8);
            writer.WriteStringValue(WorkloadProfileType);
            if (Optional.IsDefined(MinimumNodeCount))
            {
                writer.WritePropertyName("minimumCount"u8);
                writer.WriteNumberValue(MinimumNodeCount.Value);
            }
            if (Optional.IsDefined(MaximumNodeCount))
            {
                writer.WritePropertyName("maximumCount"u8);
                writer.WriteNumberValue(MaximumNodeCount.Value);
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

        ContainerAppWorkloadProfile IJsonModel<ContainerAppWorkloadProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppWorkloadProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppWorkloadProfile(document.RootElement, options);
        }

        internal static ContainerAppWorkloadProfile DeserializeContainerAppWorkloadProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string workloadProfileType = default;
            int? minimumCount = default;
            int? maximumCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadProfileType"u8))
                {
                    workloadProfileType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppWorkloadProfile(name, workloadProfileType, minimumCount, maximumCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppWorkloadProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppWorkloadProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppWorkloadProfile IPersistableModel<ContainerAppWorkloadProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppWorkloadProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppWorkloadProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppWorkloadProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
