// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class LoadBalancerResourceSettings : IUtf8JsonSerializable, IJsonModel<LoadBalancerResourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadBalancerResourceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LoadBalancerResourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerResourceSettings)} does not support writing '{format}' format.");
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
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsCollectionDefined(FrontendIPConfigurations))
            {
                writer.WritePropertyName("frontendIPConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BackendAddressPools))
            {
                writer.WritePropertyName("backendAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in BackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStringValue(Zones);
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            if (Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Optional.IsDefined(TargetResourceGroupName))
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
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

        LoadBalancerResourceSettings IJsonModel<LoadBalancerResourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerResourceSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerResourceSettings(document.RootElement, options);
        }

        internal static LoadBalancerResourceSettings DeserializeLoadBalancerResourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            string sku = default;
            IList<LoadBalancerFrontendIPConfigurationResourceSettings> frontendIPConfigurations = default;
            IList<LoadBalancerBackendAddressPoolResourceSettings> backendAddressPools = default;
            string zones = default;
            string resourceType = default;
            string targetResourceName = default;
            string targetResourceGroupName = default;
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
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frontendIPConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancerFrontendIPConfigurationResourceSettings> array = new List<LoadBalancerFrontendIPConfigurationResourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancerFrontendIPConfigurationResourceSettings.DeserializeLoadBalancerFrontendIPConfigurationResourceSettings(item, options));
                    }
                    frontendIPConfigurations = array;
                    continue;
                }
                if (property.NameEquals("backendAddressPools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancerBackendAddressPoolResourceSettings> array = new List<LoadBalancerBackendAddressPoolResourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancerBackendAddressPoolResourceSettings.DeserializeLoadBalancerBackendAddressPoolResourceSettings(item, options));
                    }
                    backendAddressPools = array;
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    zones = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoadBalancerResourceSettings(
                resourceType,
                targetResourceName,
                targetResourceGroupName,
                serializedAdditionalRawData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                sku,
                frontendIPConfigurations ?? new ChangeTrackingList<LoadBalancerFrontendIPConfigurationResourceSettings>(),
                backendAddressPools ?? new ChangeTrackingList<LoadBalancerBackendAddressPoolResourceSettings>(),
                zones);
        }

        BinaryData IPersistableModel<LoadBalancerResourceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerResourceSettings)} does not support writing '{options.Format}' format.");
            }
        }

        LoadBalancerResourceSettings IPersistableModel<LoadBalancerResourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadBalancerResourceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerResourceSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadBalancerResourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
