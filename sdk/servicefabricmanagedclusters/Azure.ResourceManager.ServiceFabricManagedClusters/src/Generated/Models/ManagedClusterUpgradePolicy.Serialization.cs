// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterUpgradePolicy : IUtf8JsonSerializable, IJsonModel<ManagedClusterUpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterUpgradePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterUpgradePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterUpgradePolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ForceRestart))
            {
                writer.WritePropertyName("forceRestart"u8);
                writer.WriteBooleanValue(ForceRestart.Value);
            }
            if (Optional.IsDefined(HealthPolicy))
            {
                writer.WritePropertyName("healthPolicy"u8);
                writer.WriteObjectValue(HealthPolicy);
            }
            if (Optional.IsDefined(DeltaHealthPolicy))
            {
                writer.WritePropertyName("deltaHealthPolicy"u8);
                writer.WriteObjectValue(DeltaHealthPolicy);
            }
            if (Optional.IsDefined(MonitoringPolicy))
            {
                writer.WritePropertyName("monitoringPolicy"u8);
                writer.WriteObjectValue(MonitoringPolicy);
            }
            if (Optional.IsDefined(UpgradeReplicaSetCheckTimeout))
            {
                writer.WritePropertyName("upgradeReplicaSetCheckTimeout"u8);
                writer.WriteStringValue(UpgradeReplicaSetCheckTimeout);
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

        ManagedClusterUpgradePolicy IJsonModel<ManagedClusterUpgradePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterUpgradePolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterUpgradePolicy(document.RootElement, options);
        }

        internal static ManagedClusterUpgradePolicy DeserializeManagedClusterUpgradePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? forceRestart = default;
            ManagedClusterHealthPolicy healthPolicy = default;
            ManagedClusterUpgradeDeltaHealthPolicy deltaHealthPolicy = default;
            ManagedClusterMonitoringPolicy monitoringPolicy = default;
            string upgradeReplicaSetCheckTimeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forceRestart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceRestart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("healthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthPolicy = ManagedClusterHealthPolicy.DeserializeManagedClusterHealthPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deltaHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deltaHealthPolicy = ManagedClusterUpgradeDeltaHealthPolicy.DeserializeManagedClusterUpgradeDeltaHealthPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("monitoringPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringPolicy = ManagedClusterMonitoringPolicy.DeserializeManagedClusterMonitoringPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("upgradeReplicaSetCheckTimeout"u8))
                {
                    upgradeReplicaSetCheckTimeout = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterUpgradePolicy(
                forceRestart,
                healthPolicy,
                deltaHealthPolicy,
                monitoringPolicy,
                upgradeReplicaSetCheckTimeout,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterUpgradePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterUpgradePolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterUpgradePolicy IPersistableModel<ManagedClusterUpgradePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterUpgradePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterUpgradePolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterUpgradePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
