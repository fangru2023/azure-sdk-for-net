// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterCreateOrUpdateProperties : IUtf8JsonSerializable, IJsonModel<HDInsightClusterCreateOrUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterCreateOrUpdateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightClusterCreateOrUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterCreateOrUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterCreateOrUpdateProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterVersion))
            {
                writer.WritePropertyName("clusterVersion"u8);
                writer.WriteStringValue(ClusterVersion);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
            }
            if (Optional.IsDefined(ClusterDefinition))
            {
                writer.WritePropertyName("clusterDefinition"u8);
                writer.WriteObjectValue(ClusterDefinition);
            }
            if (Optional.IsDefined(KafkaRestProperties))
            {
                writer.WritePropertyName("kafkaRestProperties"u8);
                writer.WriteObjectValue(KafkaRestProperties);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (Optional.IsDefined(ComputeProfile))
            {
                writer.WritePropertyName("computeProfile"u8);
                writer.WriteObjectValue(ComputeProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(DiskEncryptionProperties))
            {
                writer.WritePropertyName("diskEncryptionProperties"u8);
                writer.WriteObjectValue(DiskEncryptionProperties);
            }
            if (Optional.IsDefined(EncryptionInTransitProperties))
            {
                writer.WritePropertyName("encryptionInTransitProperties"u8);
                writer.WriteObjectValue(EncryptionInTransitProperties);
            }
            if (Optional.IsDefined(MinSupportedTlsVersion))
            {
                writer.WritePropertyName("minSupportedTlsVersion"u8);
                writer.WriteStringValue(MinSupportedTlsVersion);
            }
            if (Optional.IsDefined(NetworkProperties))
            {
                writer.WritePropertyName("networkProperties"u8);
                writer.WriteObjectValue(NetworkProperties);
            }
            if (Optional.IsDefined(ComputeIsolationProperties))
            {
                writer.WritePropertyName("computeIsolationProperties"u8);
                writer.WriteObjectValue(ComputeIsolationProperties);
            }
            if (Optional.IsCollectionDefined(PrivateLinkConfigurations))
            {
                writer.WritePropertyName("privateLinkConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkConfigurations)
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

        HDInsightClusterCreateOrUpdateProperties IJsonModel<HDInsightClusterCreateOrUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterCreateOrUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterCreateOrUpdateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterCreateOrUpdateProperties(document.RootElement, options);
        }

        internal static HDInsightClusterCreateOrUpdateProperties DeserializeHDInsightClusterCreateOrUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clusterVersion = default;
            HDInsightOSType? osType = default;
            HDInsightTier? tier = default;
            HDInsightClusterDefinition clusterDefinition = default;
            KafkaRestProperties kafkaRestProperties = default;
            HDInsightSecurityProfile securityProfile = default;
            ComputeProfile computeProfile = default;
            StorageProfile storageProfile = default;
            HDInsightDiskEncryptionProperties diskEncryptionProperties = default;
            EncryptionInTransitProperties encryptionInTransitProperties = default;
            string minSupportedTlsVersion = default;
            HDInsightClusterNetworkProperties networkProperties = default;
            HDInsightComputeIsolationProperties computeIsolationProperties = default;
            IList<HDInsightPrivateLinkConfiguration> privateLinkConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterVersion"u8))
                {
                    clusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new HDInsightOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new HDInsightTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clusterDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterDefinition = HDInsightClusterDefinition.DeserializeHDInsightClusterDefinition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kafkaRestProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kafkaRestProperties = KafkaRestProperties.DeserializeKafkaRestProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("securityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityProfile = HDInsightSecurityProfile.DeserializeHDInsightSecurityProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("computeProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeProfile = ComputeProfile.DeserializeComputeProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = StorageProfile.DeserializeStorageProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diskEncryptionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionProperties = HDInsightDiskEncryptionProperties.DeserializeHDInsightDiskEncryptionProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("encryptionInTransitProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionInTransitProperties = EncryptionInTransitProperties.DeserializeEncryptionInTransitProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("minSupportedTlsVersion"u8))
                {
                    minSupportedTlsVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProperties = HDInsightClusterNetworkProperties.DeserializeHDInsightClusterNetworkProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("computeIsolationProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeIsolationProperties = HDInsightComputeIsolationProperties.DeserializeHDInsightComputeIsolationProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateLinkConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightPrivateLinkConfiguration> array = new List<HDInsightPrivateLinkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightPrivateLinkConfiguration.DeserializeHDInsightPrivateLinkConfiguration(item, options));
                    }
                    privateLinkConfigurations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightClusterCreateOrUpdateProperties(
                clusterVersion,
                osType,
                tier,
                clusterDefinition,
                kafkaRestProperties,
                securityProfile,
                computeProfile,
                storageProfile,
                diskEncryptionProperties,
                encryptionInTransitProperties,
                minSupportedTlsVersion,
                networkProperties,
                computeIsolationProperties,
                privateLinkConfigurations ?? new ChangeTrackingList<HDInsightPrivateLinkConfiguration>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterCreateOrUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterCreateOrUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterCreateOrUpdateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightClusterCreateOrUpdateProperties IPersistableModel<HDInsightClusterCreateOrUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterCreateOrUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightClusterCreateOrUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterCreateOrUpdateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterCreateOrUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
