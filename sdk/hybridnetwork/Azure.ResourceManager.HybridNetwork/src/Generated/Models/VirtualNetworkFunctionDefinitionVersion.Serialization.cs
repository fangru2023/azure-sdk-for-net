// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class VirtualNetworkFunctionDefinitionVersion : IUtf8JsonSerializable, IJsonModel<VirtualNetworkFunctionDefinitionVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualNetworkFunctionDefinitionVersion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualNetworkFunctionDefinitionVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkFunctionDefinitionVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkFunctionDefinitionVersion)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkFunctionTemplate))
            {
                writer.WritePropertyName("networkFunctionTemplate"u8);
                writer.WriteObjectValue(NetworkFunctionTemplate);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(VersionState))
            {
                writer.WritePropertyName("versionState"u8);
                writer.WriteStringValue(VersionState.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DeployParameters))
            {
                writer.WritePropertyName("deployParameters"u8);
                writer.WriteStringValue(DeployParameters);
            }
            writer.WritePropertyName("networkFunctionType"u8);
            writer.WriteStringValue(NetworkFunctionType.ToString());
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

        VirtualNetworkFunctionDefinitionVersion IJsonModel<VirtualNetworkFunctionDefinitionVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkFunctionDefinitionVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkFunctionDefinitionVersion)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkFunctionDefinitionVersion(document.RootElement, options);
        }

        internal static VirtualNetworkFunctionDefinitionVersion DeserializeVirtualNetworkFunctionDefinitionVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VirtualNetworkFunctionTemplate networkFunctionTemplate = default;
            ProvisioningState? provisioningState = default;
            VersionState? versionState = default;
            string description = default;
            string deployParameters = default;
            NetworkFunctionType networkFunctionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkFunctionTemplate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkFunctionTemplate = VirtualNetworkFunctionTemplate.DeserializeVirtualNetworkFunctionTemplate(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new VersionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deployParameters"u8))
                {
                    deployParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionType"u8))
                {
                    networkFunctionType = new NetworkFunctionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualNetworkFunctionDefinitionVersion(
                provisioningState,
                versionState,
                description,
                deployParameters,
                networkFunctionType,
                serializedAdditionalRawData,
                networkFunctionTemplate);
        }

        BinaryData IPersistableModel<VirtualNetworkFunctionDefinitionVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkFunctionDefinitionVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkFunctionDefinitionVersion)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualNetworkFunctionDefinitionVersion IPersistableModel<VirtualNetworkFunctionDefinitionVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkFunctionDefinitionVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualNetworkFunctionDefinitionVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkFunctionDefinitionVersion)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualNetworkFunctionDefinitionVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
