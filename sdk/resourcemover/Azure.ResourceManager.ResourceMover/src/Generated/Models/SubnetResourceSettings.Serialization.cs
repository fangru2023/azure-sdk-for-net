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
    public partial class SubnetResourceSettings : IUtf8JsonSerializable, IJsonModel<SubnetResourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SubnetResourceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SubnetResourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubnetResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubnetResourceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(NetworkSecurityGroup))
            {
                if (NetworkSecurityGroup != null)
                {
                    writer.WritePropertyName("networkSecurityGroup"u8);
                    writer.WriteObjectValue(NetworkSecurityGroup);
                }
                else
                {
                    writer.WriteNull("networkSecurityGroup");
                }
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

        SubnetResourceSettings IJsonModel<SubnetResourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubnetResourceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SubnetResourceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSubnetResourceSettings(document.RootElement, options);
        }

        internal static SubnetResourceSettings DeserializeSubnetResourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> addressPrefix = default;
            Optional<NetworkSecurityGroupResourceReferenceInfo> networkSecurityGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressPrefix"u8))
                {
                    addressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkSecurityGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        networkSecurityGroup = null;
                        continue;
                    }
                    networkSecurityGroup = NetworkSecurityGroupResourceReferenceInfo.DeserializeNetworkSecurityGroupResourceReferenceInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SubnetResourceSettings(name.Value, addressPrefix.Value, networkSecurityGroup.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SubnetResourceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubnetResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SubnetResourceSettings)} does not support '{options.Format}' format.");
            }
        }

        SubnetResourceSettings IPersistableModel<SubnetResourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SubnetResourceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSubnetResourceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SubnetResourceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SubnetResourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
