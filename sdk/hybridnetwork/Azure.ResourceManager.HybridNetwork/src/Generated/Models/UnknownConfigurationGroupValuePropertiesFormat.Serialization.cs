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
    internal partial class UnknownConfigurationGroupValuePropertiesFormat : IUtf8JsonSerializable, IJsonModel<ConfigurationGroupValuePropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationGroupValuePropertiesFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfigurationGroupValuePropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherScope))
            {
                writer.WritePropertyName("publisherScope"u8);
                writer.WriteStringValue(PublisherScope.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationGroupSchemaName))
            {
                writer.WritePropertyName("configurationGroupSchemaName"u8);
                writer.WriteStringValue(ConfigurationGroupSchemaName);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationGroupSchemaOfferingLocation))
            {
                writer.WritePropertyName("configurationGroupSchemaOfferingLocation"u8);
                writer.WriteStringValue(ConfigurationGroupSchemaOfferingLocation);
            }
            if (Optional.IsDefined(ConfigurationGroupSchemaResourceReference))
            {
                writer.WritePropertyName("configurationGroupSchemaResourceReference"u8);
                writer.WriteObjectValue(ConfigurationGroupSchemaResourceReference);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        ConfigurationGroupValuePropertiesFormat IJsonModel<ConfigurationGroupValuePropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationGroupValuePropertiesFormat(document.RootElement, options);
        }

        internal static UnknownConfigurationGroupValuePropertiesFormat DeserializeUnknownConfigurationGroupValuePropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningState? provisioningState = default;
            string publisherName = default;
            PublisherScope? publisherScope = default;
            string configurationGroupSchemaName = default;
            string configurationGroupSchemaOfferingLocation = default;
            DeploymentResourceIdReference configurationGroupSchemaResourceReference = default;
            ConfigurationGroupValueConfigurationType configurationType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherScope = new PublisherScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaName"u8))
                {
                    configurationGroupSchemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaOfferingLocation"u8))
                {
                    configurationGroupSchemaOfferingLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaResourceReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurationGroupSchemaResourceReference = DeploymentResourceIdReference.DeserializeDeploymentResourceIdReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("configurationType"u8))
                {
                    configurationType = new ConfigurationGroupValueConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownConfigurationGroupValuePropertiesFormat(
                provisioningState,
                publisherName,
                publisherScope,
                configurationGroupSchemaName,
                configurationGroupSchemaOfferingLocation,
                configurationGroupSchemaResourceReference,
                configurationType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationGroupValuePropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support writing '{options.Format}' format.");
            }
        }

        ConfigurationGroupValuePropertiesFormat IPersistableModel<ConfigurationGroupValuePropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationGroupValuePropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationGroupValuePropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
