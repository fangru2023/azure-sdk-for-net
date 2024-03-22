// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterWindowsProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterWindowsProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterWindowsProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterWindowsProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterWindowsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterWindowsProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("adminUsername"u8);
            writer.WriteStringValue(AdminUsername);
            if (Optional.IsDefined(AdminPassword))
            {
                writer.WritePropertyName("adminPassword"u8);
                writer.WriteStringValue(AdminPassword);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(IsCsiProxyEnabled))
            {
                writer.WritePropertyName("enableCSIProxy"u8);
                writer.WriteBooleanValue(IsCsiProxyEnabled.Value);
            }
            if (Optional.IsDefined(GmsaProfile))
            {
                writer.WritePropertyName("gmsaProfile"u8);
                writer.WriteObjectValue(GmsaProfile);
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

        ManagedClusterWindowsProfile IJsonModel<ManagedClusterWindowsProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterWindowsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterWindowsProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterWindowsProfile(document.RootElement, options);
        }

        internal static ManagedClusterWindowsProfile DeserializeManagedClusterWindowsProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string adminUsername = default;
            string adminPassword = default;
            WindowsVmLicenseType? licenseType = default;
            bool? enableCsiProxy = default;
            WindowsGmsaProfile gmsaProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminPassword"u8))
                {
                    adminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new WindowsVmLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableCSIProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCsiProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gmsaProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gmsaProfile = WindowsGmsaProfile.DeserializeWindowsGmsaProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterWindowsProfile(
                adminUsername,
                adminPassword,
                licenseType,
                enableCsiProxy,
                gmsaProfile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterWindowsProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterWindowsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterWindowsProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterWindowsProfile IPersistableModel<ManagedClusterWindowsProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterWindowsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterWindowsProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterWindowsProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterWindowsProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
