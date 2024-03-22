// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PrepareNetworkPoliciesContent : IUtf8JsonSerializable, IJsonModel<PrepareNetworkPoliciesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrepareNetworkPoliciesContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrepareNetworkPoliciesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrepareNetworkPoliciesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrepareNetworkPoliciesContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceName))
            {
                writer.WritePropertyName("serviceName"u8);
                writer.WriteStringValue(ServiceName);
            }
            if (Optional.IsCollectionDefined(NetworkIntentPolicyConfigurations))
            {
                writer.WritePropertyName("networkIntentPolicyConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkIntentPolicyConfigurations)
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

        PrepareNetworkPoliciesContent IJsonModel<PrepareNetworkPoliciesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrepareNetworkPoliciesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrepareNetworkPoliciesContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrepareNetworkPoliciesContent(document.RootElement, options);
        }

        internal static PrepareNetworkPoliciesContent DeserializePrepareNetworkPoliciesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceName = default;
            IList<NetworkIntentPolicyConfiguration> networkIntentPolicyConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceName"u8))
                {
                    serviceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkIntentPolicyConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkIntentPolicyConfiguration> array = new List<NetworkIntentPolicyConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkIntentPolicyConfiguration.DeserializeNetworkIntentPolicyConfiguration(item, options));
                    }
                    networkIntentPolicyConfigurations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrepareNetworkPoliciesContent(serviceName, networkIntentPolicyConfigurations ?? new ChangeTrackingList<NetworkIntentPolicyConfiguration>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrepareNetworkPoliciesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrepareNetworkPoliciesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrepareNetworkPoliciesContent)} does not support writing '{options.Format}' format.");
            }
        }

        PrepareNetworkPoliciesContent IPersistableModel<PrepareNetworkPoliciesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrepareNetworkPoliciesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrepareNetworkPoliciesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrepareNetworkPoliciesContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrepareNetworkPoliciesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
