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
    public partial class MachineLearningSynapseSparkProperties : IUtf8JsonSerializable, IJsonModel<MachineLearningSynapseSparkProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningSynapseSparkProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningSynapseSparkProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSynapseSparkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSynapseSparkProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AutoScaleProperties))
            {
                writer.WritePropertyName("autoScaleProperties"u8);
                writer.WriteObjectValue(AutoScaleProperties);
            }
            if (Optional.IsDefined(AutoPauseProperties))
            {
                writer.WritePropertyName("autoPauseProperties"u8);
                writer.WriteObjectValue(AutoPauseProperties);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion"u8);
                writer.WriteStringValue(SparkVersion);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize);
            }
            if (Optional.IsDefined(NodeSizeFamily))
            {
                writer.WritePropertyName("nodeSizeFamily"u8);
                writer.WriteStringValue(NodeSizeFamily);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (Optional.IsDefined(WorkspaceName))
            {
                writer.WritePropertyName("workspaceName"u8);
                writer.WriteStringValue(WorkspaceName);
            }
            if (Optional.IsDefined(PoolName))
            {
                writer.WritePropertyName("poolName"u8);
                writer.WriteStringValue(PoolName);
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

        MachineLearningSynapseSparkProperties IJsonModel<MachineLearningSynapseSparkProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSynapseSparkProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningSynapseSparkProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSynapseSparkProperties(document.RootElement, options);
        }

        internal static MachineLearningSynapseSparkProperties DeserializeMachineLearningSynapseSparkProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningAutoScaleProperties autoScaleProperties = default;
            MachineLearningAutoPauseProperties autoPauseProperties = default;
            string sparkVersion = default;
            int? nodeCount = default;
            string nodeSize = default;
            string nodeSizeFamily = default;
            string subscriptionId = default;
            string resourceGroup = default;
            string workspaceName = default;
            string poolName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoScaleProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoScaleProperties = MachineLearningAutoScaleProperties.DeserializeMachineLearningAutoScaleProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("autoPauseProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoPauseProperties = MachineLearningAutoPauseProperties.DeserializeMachineLearningAutoPauseProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sparkVersion"u8))
                {
                    sparkVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeSize"u8))
                {
                    nodeSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeSizeFamily"u8))
                {
                    nodeSizeFamily = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceName"u8))
                {
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poolName"u8))
                {
                    poolName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningSynapseSparkProperties(
                autoScaleProperties,
                autoPauseProperties,
                sparkVersion,
                nodeCount,
                nodeSize,
                nodeSizeFamily,
                subscriptionId,
                resourceGroup,
                workspaceName,
                poolName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningSynapseSparkProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSynapseSparkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSynapseSparkProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningSynapseSparkProperties IPersistableModel<MachineLearningSynapseSparkProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningSynapseSparkProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningSynapseSparkProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningSynapseSparkProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningSynapseSparkProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
