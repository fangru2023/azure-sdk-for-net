// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsEncryptionKeyVaultProperties : IUtf8JsonSerializable, IJsonModel<AvsEncryptionKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsEncryptionKeyVaultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvsEncryptionKeyVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsEncryptionKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsEncryptionKeyVaultProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyName"u8);
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyVersion"u8);
                writer.WriteStringValue(KeyVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(AutoDetectedKeyVersion))
            {
                writer.WritePropertyName("autoDetectedKeyVersion"u8);
                writer.WriteStringValue(AutoDetectedKeyVersion);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUrl"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyState))
            {
                writer.WritePropertyName("keyState"u8);
                writer.WriteStringValue(KeyState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(VersionType))
            {
                writer.WritePropertyName("versionType"u8);
                writer.WriteStringValue(VersionType.Value.ToString());
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

        AvsEncryptionKeyVaultProperties IJsonModel<AvsEncryptionKeyVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsEncryptionKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsEncryptionKeyVaultProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsEncryptionKeyVaultProperties(document.RootElement, options);
        }

        internal static AvsEncryptionKeyVaultProperties DeserializeAvsEncryptionKeyVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyName = default;
            string keyVersion = default;
            string autoDetectedKeyVersion = default;
            Uri keyVaultUrl = default;
            AvsEncryptionKeyStatus? keyState = default;
            AvsEncryptionVersionType? versionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"u8))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDetectedKeyVersion"u8))
                {
                    autoDetectedKeyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyState = new AvsEncryptionKeyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionType = new AvsEncryptionVersionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvsEncryptionKeyVaultProperties(
                keyName,
                keyVersion,
                autoDetectedKeyVersion,
                keyVaultUrl,
                keyState,
                versionType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsEncryptionKeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsEncryptionKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvsEncryptionKeyVaultProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AvsEncryptionKeyVaultProperties IPersistableModel<AvsEncryptionKeyVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsEncryptionKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvsEncryptionKeyVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsEncryptionKeyVaultProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsEncryptionKeyVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
