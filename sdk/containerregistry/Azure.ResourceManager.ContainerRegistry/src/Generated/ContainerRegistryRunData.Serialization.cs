// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    public partial class ContainerRegistryRunData : IUtf8JsonSerializable, IJsonModel<ContainerRegistryRunData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryRunData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryRunData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RunId))
            {
                writer.WritePropertyName("runId"u8);
                writer.WriteStringValue(RunId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(RunType))
            {
                writer.WritePropertyName("runType"u8);
                writer.WriteStringValue(RunType.Value.ToString());
            }
            if (Optional.IsDefined(AgentPoolName))
            {
                writer.WritePropertyName("agentPoolName"u8);
                writer.WriteStringValue(AgentPoolName);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(FinishOn))
            {
                writer.WritePropertyName("finishTime"u8);
                writer.WriteStringValue(FinishOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(OutputImages))
            {
                writer.WritePropertyName("outputImages"u8);
                writer.WriteStartArray();
                foreach (var item in OutputImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Task))
            {
                writer.WritePropertyName("task"u8);
                writer.WriteStringValue(Task);
            }
            if (Optional.IsDefined(ImageUpdateTrigger))
            {
                writer.WritePropertyName("imageUpdateTrigger"u8);
                writer.WriteObjectValue(ImageUpdateTrigger);
            }
            if (Optional.IsDefined(SourceTrigger))
            {
                writer.WritePropertyName("sourceTrigger"u8);
                writer.WriteObjectValue(SourceTrigger);
            }
            if (Optional.IsDefined(TimerTrigger))
            {
                writer.WritePropertyName("timerTrigger"u8);
                writer.WriteObjectValue(TimerTrigger);
            }
            if (Optional.IsDefined(Platform))
            {
                writer.WritePropertyName("platform"u8);
                writer.WriteObjectValue(Platform);
            }
            if (Optional.IsDefined(AgentConfiguration))
            {
                writer.WritePropertyName("agentConfiguration"u8);
                writer.WriteObjectValue(AgentConfiguration);
            }
            if (Optional.IsDefined(SourceRegistryAuth))
            {
                writer.WritePropertyName("sourceRegistryAuth"u8);
                writer.WriteStringValue(SourceRegistryAuth);
            }
            if (Optional.IsCollectionDefined(CustomRegistries))
            {
                writer.WritePropertyName("customRegistries"u8);
                writer.WriteStartArray();
                foreach (var item in CustomRegistries)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(RunErrorMessage))
            {
                writer.WritePropertyName("runErrorMessage"u8);
                writer.WriteStringValue(RunErrorMessage);
            }
            if (Optional.IsDefined(UpdateTriggerToken))
            {
                writer.WritePropertyName("updateTriggerToken"u8);
                writer.WriteStringValue(UpdateTriggerToken);
            }
            if (options.Format != "W" && Optional.IsDefined(LogArtifact))
            {
                writer.WritePropertyName("logArtifact"u8);
                writer.WriteObjectValue(LogArtifact);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(IsArchiveEnabled))
            {
                writer.WritePropertyName("isArchiveEnabled"u8);
                writer.WriteBooleanValue(IsArchiveEnabled.Value);
            }
            writer.WriteEndObject();
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

        ContainerRegistryRunData IJsonModel<ContainerRegistryRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryRunData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryRunData(document.RootElement, options);
        }

        internal static ContainerRegistryRunData DeserializeContainerRegistryRunData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string runId = default;
            ContainerRegistryRunStatus? status = default;
            DateTimeOffset? lastUpdatedTime = default;
            ContainerRegistryRunType? runType = default;
            string agentPoolName = default;
            DateTimeOffset? createTime = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? finishTime = default;
            IList<ContainerRegistryImageDescriptor> outputImages = default;
            string task = default;
            ContainerRegistryImageUpdateTrigger imageUpdateTrigger = default;
            ContainerRegistrySourceTriggerDescriptor sourceTrigger = default;
            ContainerRegistryTimerTriggerDescriptor timerTrigger = default;
            ContainerRegistryPlatformProperties platform = default;
            ContainerRegistryAgentProperties agentConfiguration = default;
            string sourceRegistryAuth = default;
            IList<string> customRegistries = default;
            string runErrorMessage = default;
            string updateTriggerToken = default;
            ContainerRegistryImageDescriptor logArtifact = default;
            ContainerRegistryProvisioningState? provisioningState = default;
            bool? isArchiveEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("runId"u8))
                        {
                            runId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new ContainerRegistryRunStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("runType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            runType = new ContainerRegistryRunType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("agentPoolName"u8))
                        {
                            agentPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("finishTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            finishTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("outputImages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerRegistryImageDescriptor> array = new List<ContainerRegistryImageDescriptor>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerRegistryImageDescriptor.DeserializeContainerRegistryImageDescriptor(item, options));
                            }
                            outputImages = array;
                            continue;
                        }
                        if (property0.NameEquals("task"u8))
                        {
                            task = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageUpdateTrigger"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            imageUpdateTrigger = ContainerRegistryImageUpdateTrigger.DeserializeContainerRegistryImageUpdateTrigger(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sourceTrigger"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceTrigger = ContainerRegistrySourceTriggerDescriptor.DeserializeContainerRegistrySourceTriggerDescriptor(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("timerTrigger"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timerTrigger = ContainerRegistryTimerTriggerDescriptor.DeserializeContainerRegistryTimerTriggerDescriptor(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("platform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            platform = ContainerRegistryPlatformProperties.DeserializeContainerRegistryPlatformProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("agentConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            agentConfiguration = ContainerRegistryAgentProperties.DeserializeContainerRegistryAgentProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sourceRegistryAuth"u8))
                        {
                            sourceRegistryAuth = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customRegistries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            customRegistries = array;
                            continue;
                        }
                        if (property0.NameEquals("runErrorMessage"u8))
                        {
                            runErrorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updateTriggerToken"u8))
                        {
                            updateTriggerToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("logArtifact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logArtifact = ContainerRegistryImageDescriptor.DeserializeContainerRegistryImageDescriptor(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ContainerRegistryProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isArchiveEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isArchiveEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryRunData(
                id,
                name,
                type,
                systemData,
                runId,
                status,
                lastUpdatedTime,
                runType,
                agentPoolName,
                createTime,
                startTime,
                finishTime,
                outputImages ?? new ChangeTrackingList<ContainerRegistryImageDescriptor>(),
                task,
                imageUpdateTrigger,
                sourceTrigger,
                timerTrigger,
                platform,
                agentConfiguration,
                sourceRegistryAuth,
                customRegistries ?? new ChangeTrackingList<string>(),
                runErrorMessage,
                updateTriggerToken,
                logArtifact,
                provisioningState,
                isArchiveEnabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryRunData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryRunData)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryRunData IPersistableModel<ContainerRegistryRunData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryRunData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryRunData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
