// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AddressResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceIPAddress))
            {
                writer.WritePropertyName("serviceIpAddress");
                writer.WriteStringValue(ServiceIPAddress);
            }
            if (Optional.IsDefined(InternalIPAddress))
            {
                writer.WritePropertyName("internalIpAddress");
                writer.WriteStringValue(InternalIPAddress);
            }
            if (Optional.IsCollectionDefined(OutboundIPAddresses))
            {
                writer.WritePropertyName("outboundIpAddresses");
                writer.WriteStartArray();
                foreach (var item in OutboundIPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VipMappings))
            {
                writer.WritePropertyName("vipMappings");
                writer.WriteStartArray();
                foreach (var item in VipMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AddressResponse DeserializeAddressResponse(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> serviceIPAddress = default;
            Optional<string> internalIPAddress = default;
            Optional<IList<string>> outboundIPAddresses = default;
            Optional<IList<VirtualIPMapping>> vipMappings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceIpAddress"))
                        {
                            serviceIPAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("internalIpAddress"))
                        {
                            internalIPAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("outboundIpAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            outboundIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("vipMappings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualIPMapping> array = new List<VirtualIPMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualIPMapping.DeserializeVirtualIPMapping(item));
                            }
                            vipMappings = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AddressResponse(id, name, type, systemData.Value, serviceIPAddress.Value, internalIPAddress.Value, Optional.ToList(outboundIPAddresses), Optional.ToList(vipMappings), kind.Value);
        }
    }
}
