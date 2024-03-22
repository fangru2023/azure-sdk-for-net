// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricControllerData : IUtf8JsonSerializable, IJsonModel<NetworkFabricControllerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFabricControllerData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkFabricControllerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricControllerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricControllerData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsCollectionDefined(InfrastructureExpressRouteConnections))
            {
                writer.WritePropertyName("infrastructureExpressRouteConnections"u8);
                writer.WriteStartArray();
                foreach (var item in InfrastructureExpressRouteConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WorkloadExpressRouteConnections))
            {
                writer.WritePropertyName("workloadExpressRouteConnections"u8);
                writer.WriteStartArray();
                foreach (var item in WorkloadExpressRouteConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(InfrastructureServices))
            {
                writer.WritePropertyName("infrastructureServices"u8);
                writer.WriteObjectValue(InfrastructureServices);
            }
            if (options.Format != "W" && Optional.IsDefined(WorkloadServices))
            {
                writer.WritePropertyName("workloadServices"u8);
                writer.WriteObjectValue(WorkloadServices);
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkFabricIds))
            {
                writer.WritePropertyName("networkFabricIds"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkFabricIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsWorkloadManagementNetwork))
            {
                writer.WritePropertyName("workloadManagementNetwork"u8);
                writer.WriteBooleanValue(IsWorkloadManagementNetwork.Value);
            }
            if (Optional.IsDefined(IsWorkloadManagementNetworkEnabled))
            {
                writer.WritePropertyName("isWorkloadManagementNetworkEnabled"u8);
                writer.WriteStringValue(IsWorkloadManagementNetworkEnabled.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(TenantInternetGatewayIds))
            {
                writer.WritePropertyName("tenantInternetGatewayIds"u8);
                writer.WriteStartArray();
                foreach (var item in TenantInternetGatewayIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IPv4AddressSpace))
            {
                writer.WritePropertyName("ipv4AddressSpace"u8);
                writer.WriteStringValue(IPv4AddressSpace);
            }
            if (Optional.IsDefined(IPv6AddressSpace))
            {
                writer.WritePropertyName("ipv6AddressSpace"u8);
                writer.WriteStringValue(IPv6AddressSpace);
            }
            if (Optional.IsDefined(NfcSku))
            {
                writer.WritePropertyName("nfcSku"u8);
                writer.WriteStringValue(NfcSku.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        NetworkFabricControllerData IJsonModel<NetworkFabricControllerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricControllerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricControllerData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricControllerData(document.RootElement, options);
        }

        internal static NetworkFabricControllerData DeserializeNetworkFabricControllerData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string annotation = default;
            IList<ExpressRouteConnectionInformation> infrastructureExpressRouteConnections = default;
            IList<ExpressRouteConnectionInformation> workloadExpressRouteConnections = default;
            NetworkFabricControllerServices infrastructureServices = default;
            NetworkFabricControllerServices workloadServices = default;
            ManagedResourceGroupConfiguration managedResourceGroupConfiguration = default;
            IReadOnlyList<ResourceIdentifier> networkFabricIds = default;
            bool? workloadManagementNetwork = default;
            IsWorkloadManagementNetworkEnabled? isWorkloadManagementNetworkEnabled = default;
            IReadOnlyList<ResourceIdentifier> tenantInternetGatewayIds = default;
            string ipv4AddressSpace = default;
            string ipv6AddressSpace = default;
            NetworkFabricControllerSKU? nfcSku = default;
            NetworkFabricProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("infrastructureExpressRouteConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteConnectionInformation> array = new List<ExpressRouteConnectionInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteConnectionInformation.DeserializeExpressRouteConnectionInformation(item, options));
                            }
                            infrastructureExpressRouteConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("workloadExpressRouteConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteConnectionInformation> array = new List<ExpressRouteConnectionInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExpressRouteConnectionInformation.DeserializeExpressRouteConnectionInformation(item, options));
                            }
                            workloadExpressRouteConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("infrastructureServices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            infrastructureServices = NetworkFabricControllerServices.DeserializeNetworkFabricControllerServices(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("workloadServices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workloadServices = NetworkFabricControllerServices.DeserializeNetworkFabricControllerServices(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedResourceGroupConfiguration.DeserializeManagedResourceGroupConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkFabricIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            networkFabricIds = array;
                            continue;
                        }
                        if (property0.NameEquals("workloadManagementNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workloadManagementNetwork = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isWorkloadManagementNetworkEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isWorkloadManagementNetworkEnabled = new IsWorkloadManagementNetworkEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tenantInternetGatewayIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            tenantInternetGatewayIds = array;
                            continue;
                        }
                        if (property0.NameEquals("ipv4AddressSpace"u8))
                        {
                            ipv4AddressSpace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6AddressSpace"u8))
                        {
                            ipv6AddressSpace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nfcSku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nfcSku = new NetworkFabricControllerSKU(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
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
            return new NetworkFabricControllerData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                annotation,
                infrastructureExpressRouteConnections ?? new ChangeTrackingList<ExpressRouteConnectionInformation>(),
                workloadExpressRouteConnections ?? new ChangeTrackingList<ExpressRouteConnectionInformation>(),
                infrastructureServices,
                workloadServices,
                managedResourceGroupConfiguration,
                networkFabricIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                workloadManagementNetwork,
                isWorkloadManagementNetworkEnabled,
                tenantInternetGatewayIds ?? new ChangeTrackingList<ResourceIdentifier>(),
                ipv4AddressSpace,
                ipv6AddressSpace,
                nfcSku,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkFabricControllerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricControllerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricControllerData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkFabricControllerData IPersistableModel<NetworkFabricControllerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricControllerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkFabricControllerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricControllerData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFabricControllerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
