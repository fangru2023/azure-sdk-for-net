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

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseSqlPoolConnectionPolicyData : IUtf8JsonSerializable, IJsonModel<SynapseSqlPoolConnectionPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseSqlPoolConnectionPolicyData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseSqlPoolConnectionPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSqlPoolConnectionPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSqlPoolConnectionPolicyData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            if (Optional.IsDefined(SecurityEnabledAccess))
            {
                writer.WritePropertyName("securityEnabledAccess"u8);
                writer.WriteStringValue(SecurityEnabledAccess);
            }
            if (Optional.IsDefined(ProxyDnsName))
            {
                writer.WritePropertyName("proxyDnsName"u8);
                writer.WriteStringValue(ProxyDnsName);
            }
            if (Optional.IsDefined(ProxyPort))
            {
                writer.WritePropertyName("proxyPort"u8);
                writer.WriteStringValue(ProxyPort);
            }
            if (Optional.IsDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStringValue(Visibility);
            }
            if (Optional.IsDefined(UseServerDefault))
            {
                writer.WritePropertyName("useServerDefault"u8);
                writer.WriteStringValue(UseServerDefault);
            }
            if (Optional.IsDefined(RedirectionState))
            {
                writer.WritePropertyName("redirectionState"u8);
                writer.WriteStringValue(RedirectionState);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
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

        SynapseSqlPoolConnectionPolicyData IJsonModel<SynapseSqlPoolConnectionPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSqlPoolConnectionPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseSqlPoolConnectionPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseSqlPoolConnectionPolicyData(document.RootElement, options);
        }

        internal static SynapseSqlPoolConnectionPolicyData DeserializeSynapseSqlPoolConnectionPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string securityEnabledAccess = default;
            string proxyDnsName = default;
            string proxyPort = default;
            string visibility = default;
            string useServerDefault = default;
            string redirectionState = default;
            string state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                        if (property0.NameEquals("securityEnabledAccess"u8))
                        {
                            securityEnabledAccess = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("proxyDnsName"u8))
                        {
                            proxyDnsName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("proxyPort"u8))
                        {
                            proxyPort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("visibility"u8))
                        {
                            visibility = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("useServerDefault"u8))
                        {
                            useServerDefault = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("redirectionState"u8))
                        {
                            redirectionState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
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
            return new SynapseSqlPoolConnectionPolicyData(
                id,
                name,
                type,
                systemData,
                kind,
                location,
                securityEnabledAccess,
                proxyDnsName,
                proxyPort,
                visibility,
                useServerDefault,
                redirectionState,
                state,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseSqlPoolConnectionPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSqlPoolConnectionPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseSqlPoolConnectionPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseSqlPoolConnectionPolicyData IPersistableModel<SynapseSqlPoolConnectionPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseSqlPoolConnectionPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseSqlPoolConnectionPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseSqlPoolConnectionPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseSqlPoolConnectionPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
