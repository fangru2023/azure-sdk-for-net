// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CloudServiceExtension : IUtf8JsonSerializable, IJsonModel<CloudServiceExtension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudServiceExtension>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudServiceExtension>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceExtension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudServiceExtension)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(CloudServiceExtensionPropertiesType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(CloudServiceExtensionPropertiesType);
            }
            if (Optional.IsDefined(TypeHandlerVersion))
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (Optional.IsDefined(AutoUpgradeMinorVersion))
            {
                writer.WritePropertyName("autoUpgradeMinorVersion"u8);
                writer.WriteBooleanValue(AutoUpgradeMinorVersion.Value);
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                using (JsonDocument document = JsonDocument.Parse(Settings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ProtectedSettings))
            {
                writer.WritePropertyName("protectedSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectedSettings);
#else
                using (JsonDocument document = JsonDocument.Parse(ProtectedSettings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(ProtectedSettingsFromKeyVault))
            {
                writer.WritePropertyName("protectedSettingsFromKeyVault"u8);
                writer.WriteObjectValue(ProtectedSettingsFromKeyVault);
            }
            if (Optional.IsDefined(ForceUpdateTag))
            {
                writer.WritePropertyName("forceUpdateTag"u8);
                writer.WriteStringValue(ForceUpdateTag);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsCollectionDefined(RolesAppliedTo))
            {
                writer.WritePropertyName("rolesAppliedTo"u8);
                writer.WriteStartArray();
                foreach (var item in RolesAppliedTo)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        CloudServiceExtension IJsonModel<CloudServiceExtension>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceExtension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudServiceExtension)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudServiceExtension(document.RootElement, options);
        }

        internal static CloudServiceExtension DeserializeCloudServiceExtension(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string publisher = default;
            string type = default;
            string typeHandlerVersion = default;
            bool? autoUpgradeMinorVersion = default;
            BinaryData settings = default;
            BinaryData protectedSettings = default;
            CloudServiceVaultAndSecretReference protectedSettingsFromKeyVault = default;
            string forceUpdateTag = default;
            string provisioningState = default;
            IList<string> rolesAppliedTo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            type = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typeHandlerVersion"u8))
                        {
                            typeHandlerVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpgradeMinorVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpgradeMinorVersion = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("settings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            settings = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("protectedSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protectedSettings = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("protectedSettingsFromKeyVault"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protectedSettingsFromKeyVault = CloudServiceVaultAndSecretReference.DeserializeCloudServiceVaultAndSecretReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("forceUpdateTag"u8))
                        {
                            forceUpdateTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rolesAppliedTo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            rolesAppliedTo = array;
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
            return new CloudServiceExtension(
                name,
                publisher,
                type,
                typeHandlerVersion,
                autoUpgradeMinorVersion,
                settings,
                protectedSettings,
                protectedSettingsFromKeyVault,
                forceUpdateTag,
                provisioningState,
                rolesAppliedTo ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudServiceExtension>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceExtension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudServiceExtension)} does not support writing '{options.Format}' format.");
            }
        }

        CloudServiceExtension IPersistableModel<CloudServiceExtension>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudServiceExtension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudServiceExtension(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudServiceExtension)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudServiceExtension>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
