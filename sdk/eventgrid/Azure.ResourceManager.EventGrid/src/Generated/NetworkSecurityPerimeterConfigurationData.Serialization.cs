// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class NetworkSecurityPerimeterConfigurationData : IUtf8JsonSerializable, IJsonModel<NetworkSecurityPerimeterConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityPerimeterConfigurationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkSecurityPerimeterConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationData)} does not support '{format}' format.");
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
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (!(ProvisioningIssues is ChangeTrackingList<NetworkSecurityPerimeterConfigurationIssues> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("provisioningIssues"u8);
                writer.WriteStartArray();
                foreach (var item in ProvisioningIssues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (NetworkSecurityPerimeter != null)
            {
                writer.WritePropertyName("networkSecurityPerimeter"u8);
                writer.WriteObjectValue(NetworkSecurityPerimeter);
            }
            if (ResourceAssociation != null)
            {
                writer.WritePropertyName("resourceAssociation"u8);
                writer.WriteObjectValue(ResourceAssociation);
            }
            if (Profile != null)
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteObjectValue(Profile);
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

        NetworkSecurityPerimeterConfigurationData IJsonModel<NetworkSecurityPerimeterConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement, options);
        }

        internal static NetworkSecurityPerimeterConfigurationData DeserializeNetworkSecurityPerimeterConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
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
            NetworkSecurityPerimeterConfigProvisioningState? provisioningState = default;
            IList<NetworkSecurityPerimeterConfigurationIssues> provisioningIssues = default;
            NetworkSecurityPerimeterInfo networkSecurityPerimeter = default;
            ResourceAssociation resourceAssociation = default;
            NetworkSecurityPerimeterConfigurationProfile profile = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkSecurityPerimeterConfigProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningIssues"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkSecurityPerimeterConfigurationIssues> array = new List<NetworkSecurityPerimeterConfigurationIssues>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkSecurityPerimeterConfigurationIssues.DeserializeNetworkSecurityPerimeterConfigurationIssues(item, options));
                            }
                            provisioningIssues = array;
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityPerimeter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityPerimeter = NetworkSecurityPerimeterInfo.DeserializeNetworkSecurityPerimeterInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("resourceAssociation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceAssociation = ResourceAssociation.DeserializeResourceAssociation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("profile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            profile = NetworkSecurityPerimeterConfigurationProfile.DeserializeNetworkSecurityPerimeterConfigurationProfile(property0.Value, options);
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
            return new NetworkSecurityPerimeterConfigurationData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                provisioningIssues ?? new ChangeTrackingList<NetworkSecurityPerimeterConfigurationIssues>(),
                networkSecurityPerimeter,
                resourceAssociation,
                profile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkSecurityPerimeterConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        NetworkSecurityPerimeterConfigurationData IPersistableModel<NetworkSecurityPerimeterConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkSecurityPerimeterConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterConfigurationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityPerimeterConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
