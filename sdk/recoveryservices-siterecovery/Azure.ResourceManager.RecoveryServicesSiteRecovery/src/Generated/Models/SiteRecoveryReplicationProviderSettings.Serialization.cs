// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownConfigurationSettings))]
    public partial class SiteRecoveryReplicationProviderSettings : IUtf8JsonSerializable, IJsonModel<SiteRecoveryReplicationProviderSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryReplicationProviderSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryReplicationProviderSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryReplicationProviderSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryReplicationProviderSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        SiteRecoveryReplicationProviderSettings IJsonModel<SiteRecoveryReplicationProviderSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryReplicationProviderSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryReplicationProviderSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryReplicationProviderSettings(document.RootElement, options);
        }

        internal static SiteRecoveryReplicationProviderSettings DeserializeSiteRecoveryReplicationProviderSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "HyperVVirtualMachine": return HyperVVmDetails.DeserializeHyperVVmDetails(element, options);
                    case "ReplicationGroupDetails": return ReplicationGroupDetails.DeserializeReplicationGroupDetails(element, options);
                    case "VmmVirtualMachine": return VmmVmDetails.DeserializeVmmVmDetails(element, options);
                    case "VMwareVirtualMachine": return VMwareVmDetails.DeserializeVMwareVmDetails(element, options);
                }
            }
            return UnknownConfigurationSettings.DeserializeUnknownConfigurationSettings(element, options);
        }

        BinaryData IPersistableModel<SiteRecoveryReplicationProviderSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryReplicationProviderSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryReplicationProviderSettings)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryReplicationProviderSettings IPersistableModel<SiteRecoveryReplicationProviderSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryReplicationProviderSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryReplicationProviderSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryReplicationProviderSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryReplicationProviderSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
