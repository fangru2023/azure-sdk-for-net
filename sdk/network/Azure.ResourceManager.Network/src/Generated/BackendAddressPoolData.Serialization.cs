// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class BackendAddressPoolData : IUtf8JsonSerializable, IJsonModel<BackendAddressPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackendAddressPoolData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackendAddressPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAddressPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendAddressPoolData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (!(TunnelInterfaces is ChangeTrackingList<GatewayLoadBalancerTunnelInterface> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tunnelInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in TunnelInterfaces)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(LoadBalancerBackendAddresses is ChangeTrackingList<LoadBalancerBackendAddress> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("loadBalancerBackendAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(BackendIPConfigurations is ChangeTrackingList<NetworkInterfaceIPConfigurationData> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("backendIPConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in BackendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(LoadBalancingRules is ChangeTrackingList<WritableSubResource> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("loadBalancingRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && OutboundRule != null)
            {
                writer.WritePropertyName("outboundRule"u8);
                JsonSerializer.Serialize(writer, OutboundRule);
            }
            if (options.Format != "W" && !(OutboundRules is ChangeTrackingList<WritableSubResource> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("outboundRules"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(InboundNatRules is ChangeTrackingList<WritableSubResource> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("inboundNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in InboundNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (DrainPeriodInSeconds.HasValue)
            {
                writer.WritePropertyName("drainPeriodInSeconds"u8);
                writer.WriteNumberValue(DrainPeriodInSeconds.Value);
            }
            if (VirtualNetwork != null)
            {
                writer.WritePropertyName("virtualNetwork"u8);
                JsonSerializer.Serialize(writer, VirtualNetwork);
            }
            if (SyncMode.HasValue)
            {
                writer.WritePropertyName("syncMode"u8);
                writer.WriteStringValue(SyncMode.Value.ToString());
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

        BackendAddressPoolData IJsonModel<BackendAddressPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAddressPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendAddressPoolData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendAddressPoolData(document.RootElement, options);
        }

        internal static BackendAddressPoolData DeserializeBackendAddressPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IList<GatewayLoadBalancerTunnelInterface> tunnelInterfaces = default;
            IList<LoadBalancerBackendAddress> loadBalancerBackendAddresses = default;
            IReadOnlyList<NetworkInterfaceIPConfigurationData> backendIPConfigurations = default;
            IReadOnlyList<WritableSubResource> loadBalancingRules = default;
            WritableSubResource outboundRule = default;
            IReadOnlyList<WritableSubResource> outboundRules = default;
            IReadOnlyList<WritableSubResource> inboundNatRules = default;
            NetworkProvisioningState? provisioningState = default;
            int? drainPeriodInSeconds = default;
            WritableSubResource virtualNetwork = default;
            BackendAddressSyncMode? syncMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("location"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            location = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tunnelInterfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GatewayLoadBalancerTunnelInterface> array = new List<GatewayLoadBalancerTunnelInterface>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GatewayLoadBalancerTunnelInterface.DeserializeGatewayLoadBalancerTunnelInterface(item, options));
                            }
                            tunnelInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerBackendAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LoadBalancerBackendAddress> array = new List<LoadBalancerBackendAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LoadBalancerBackendAddress.DeserializeLoadBalancerBackendAddress(item, options));
                            }
                            loadBalancerBackendAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("backendIPConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceIPConfigurationData> array = new List<NetworkInterfaceIPConfigurationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceIPConfigurationData.DeserializeNetworkInterfaceIPConfigurationData(item, options));
                            }
                            backendIPConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("outboundRule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outboundRule = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("outboundRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            outboundRules = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            inboundNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("drainPeriodInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            drainPeriodInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetwork = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("syncMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncMode = new BackendAddressSyncMode(property0.Value.GetString());
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
            return new BackendAddressPoolData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                location,
                tunnelInterfaces ?? new ChangeTrackingList<GatewayLoadBalancerTunnelInterface>(),
                loadBalancerBackendAddresses ?? new ChangeTrackingList<LoadBalancerBackendAddress>(),
                backendIPConfigurations ?? new ChangeTrackingList<NetworkInterfaceIPConfigurationData>(),
                loadBalancingRules ?? new ChangeTrackingList<WritableSubResource>(),
                outboundRule,
                outboundRules ?? new ChangeTrackingList<WritableSubResource>(),
                inboundNatRules ?? new ChangeTrackingList<WritableSubResource>(),
                provisioningState,
                drainPeriodInSeconds,
                virtualNetwork,
                syncMode);
        }

        BinaryData IPersistableModel<BackendAddressPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAddressPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackendAddressPoolData)} does not support '{options.Format}' format.");
            }
        }

        BackendAddressPoolData IPersistableModel<BackendAddressPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendAddressPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackendAddressPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackendAddressPoolData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackendAddressPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
