// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkAnalytics.Models;

namespace Azure.ResourceManager.NetworkAnalytics
{
    public partial class DataProductData : IUtf8JsonSerializable, IJsonModel<DataProductData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProductData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProductData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProductData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (options.Format != "W" && Optional.IsDefined(ResourceGuid))
            {
                writer.WritePropertyName("resourceGuid"u8);
                writer.WriteStringValue(ResourceGuid);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(MajorVersion))
            {
                writer.WritePropertyName("majorVersion"u8);
                writer.WriteStringValue(MajorVersion);
            }
            if (Optional.IsCollectionDefined(Owners))
            {
                writer.WritePropertyName("owners"u8);
                writer.WriteStartArray();
                foreach (var item in Owners)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Redundancy))
            {
                writer.WritePropertyName("redundancy"u8);
                writer.WriteStringValue(Redundancy.Value.ToString());
            }
            if (Optional.IsDefined(PurviewAccount))
            {
                writer.WritePropertyName("purviewAccount"u8);
                writer.WriteStringValue(PurviewAccount);
            }
            if (Optional.IsDefined(PurviewCollection))
            {
                writer.WritePropertyName("purviewCollection"u8);
                writer.WriteStringValue(PurviewCollection);
            }
            if (Optional.IsDefined(PrivateLinksEnabled))
            {
                writer.WritePropertyName("privateLinksEnabled"u8);
                writer.WriteStringValue(PrivateLinksEnabled.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(CustomerManagedKeyEncryptionEnabled))
            {
                writer.WritePropertyName("customerManagedKeyEncryptionEnabled"u8);
                writer.WriteStringValue(CustomerManagedKeyEncryptionEnabled.Value.ToString());
            }
            if (Optional.IsDefined(CustomerEncryptionKey))
            {
                writer.WritePropertyName("customerEncryptionKey"u8);
                writer.WriteObjectValue(CustomerEncryptionKey);
            }
            if (Optional.IsDefined(Networkacls))
            {
                writer.WritePropertyName("networkacls"u8);
                writer.WriteObjectValue(Networkacls);
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AvailableMinorVersions))
            {
                writer.WritePropertyName("availableMinorVersions"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableMinorVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CurrentMinorVersion))
            {
                writer.WritePropertyName("currentMinorVersion"u8);
                writer.WriteStringValue(CurrentMinorVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(Documentation))
            {
                writer.WritePropertyName("documentation"u8);
                writer.WriteStringValue(Documentation);
            }
            if (options.Format != "W" && Optional.IsDefined(ConsumptionEndpoints))
            {
                writer.WritePropertyName("consumptionEndpoints"u8);
                writer.WriteObjectValue(ConsumptionEndpoints);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUrl"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
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

        DataProductData IJsonModel<DataProductData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProductData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProductData(document.RootElement, options);
        }

        internal static DataProductData DeserializeDataProductData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string resourceGuid = default;
            NetworkAnalyticsProvisioningState? provisioningState = default;
            string publisher = default;
            string product = default;
            string majorVersion = default;
            IList<string> owners = default;
            DataProductControlState? redundancy = default;
            string purviewAccount = default;
            string purviewCollection = default;
            DataProductControlState? privateLinksEnabled = default;
            DataProductControlState? publicNetworkAccess = default;
            DataProductControlState? customerManagedKeyEncryptionEnabled = default;
            EncryptionKeyDetails customerEncryptionKey = default;
            DataProductNetworkAcls networkacls = default;
            NetworkAnalyticsManagedResourceGroupConfiguration managedResourceGroupConfiguration = default;
            IReadOnlyList<string> availableMinorVersions = default;
            string currentMinorVersion = default;
            string documentation = default;
            ConsumptionEndpointsProperties consumptionEndpoints = default;
            Uri keyVaultUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            resourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkAnalyticsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("majorVersion"u8))
                        {
                            majorVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("owners"u8))
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
                            owners = array;
                            continue;
                        }
                        if (property0.NameEquals("redundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redundancy = new DataProductControlState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("purviewAccount"u8))
                        {
                            purviewAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("purviewCollection"u8))
                        {
                            purviewCollection = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinksEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinksEnabled = new DataProductControlState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new DataProductControlState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerManagedKeyEncryptionEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerManagedKeyEncryptionEnabled = new DataProductControlState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerEncryptionKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customerEncryptionKey = EncryptionKeyDetails.DeserializeEncryptionKeyDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkacls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkacls = DataProductNetworkAcls.DeserializeDataProductNetworkAcls(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = NetworkAnalyticsManagedResourceGroupConfiguration.DeserializeNetworkAnalyticsManagedResourceGroupConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("availableMinorVersions"u8))
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
                            availableMinorVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("currentMinorVersion"u8))
                        {
                            currentMinorVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentation"u8))
                        {
                            documentation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consumptionEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            consumptionEndpoints = ConsumptionEndpointsProperties.DeserializeConsumptionEndpointsProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("keyVaultUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultUrl = new Uri(property0.Value.GetString());
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
            return new DataProductData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                identity,
                resourceGuid,
                provisioningState,
                publisher,
                product,
                majorVersion,
                owners ?? new ChangeTrackingList<string>(),
                redundancy,
                purviewAccount,
                purviewCollection,
                privateLinksEnabled,
                publicNetworkAccess,
                customerManagedKeyEncryptionEnabled,
                customerEncryptionKey,
                networkacls,
                managedResourceGroupConfiguration,
                availableMinorVersions ?? new ChangeTrackingList<string>(),
                currentMinorVersion,
                documentation,
                consumptionEndpoints,
                keyVaultUrl,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProductData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProductData)} does not support writing '{options.Format}' format.");
            }
        }

        DataProductData IPersistableModel<DataProductData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProductData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProductData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProductData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProductData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
