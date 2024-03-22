// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class BotChannelSite : IUtf8JsonSerializable, IJsonModel<BotChannelSite>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BotChannelSite>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BotChannelSite>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelSite>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelSite)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SiteId))
            {
                writer.WritePropertyName("siteId"u8);
                writer.WriteStringValue(SiteId);
            }
            writer.WritePropertyName("siteName"u8);
            writer.WriteStringValue(SiteName);
            if (options.Format != "W" && Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
            }
            if (options.Format != "W" && Optional.IsDefined(Key2))
            {
                writer.WritePropertyName("key2"u8);
                writer.WriteStringValue(Key2);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (options.Format != "W" && Optional.IsDefined(IsTokenEnabled))
            {
                writer.WritePropertyName("isTokenEnabled"u8);
                writer.WriteBooleanValue(IsTokenEnabled.Value);
            }
            if (Optional.IsDefined(IsEndpointParametersEnabled))
            {
                writer.WritePropertyName("isEndpointParametersEnabled"u8);
                writer.WriteBooleanValue(IsEndpointParametersEnabled.Value);
            }
            if (Optional.IsDefined(IsDetailedLoggingEnabled))
            {
                writer.WritePropertyName("isDetailedLoggingEnabled"u8);
                writer.WriteBooleanValue(IsDetailedLoggingEnabled.Value);
            }
            if (Optional.IsDefined(IsBlockUserUploadEnabled))
            {
                if (IsBlockUserUploadEnabled != null)
                {
                    writer.WritePropertyName("isBlockUserUploadEnabled"u8);
                    writer.WriteBooleanValue(IsBlockUserUploadEnabled.Value);
                }
                else
                {
                    writer.WriteNull("isBlockUserUploadEnabled");
                }
            }
            if (Optional.IsDefined(IsNoStorageEnabled))
            {
                writer.WritePropertyName("isNoStorageEnabled"u8);
                writer.WriteBooleanValue(IsNoStorageEnabled.Value);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (Optional.IsDefined(IsV1Enabled))
            {
                writer.WritePropertyName("isV1Enabled"u8);
                writer.WriteBooleanValue(IsV1Enabled.Value);
            }
            if (Optional.IsDefined(IsV3Enabled))
            {
                writer.WritePropertyName("isV3Enabled"u8);
                writer.WriteBooleanValue(IsV3Enabled.Value);
            }
            if (Optional.IsDefined(IsSecureSiteEnabled))
            {
                writer.WritePropertyName("isSecureSiteEnabled"u8);
                writer.WriteBooleanValue(IsSecureSiteEnabled.Value);
            }
            if (Optional.IsCollectionDefined(TrustedOrigins))
            {
                writer.WritePropertyName("trustedOrigins"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedOrigins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsWebChatSpeechEnabled))
            {
                writer.WritePropertyName("isWebChatSpeechEnabled"u8);
                writer.WriteBooleanValue(IsWebChatSpeechEnabled.Value);
            }
            if (Optional.IsDefined(IsWebchatPreviewEnabled))
            {
                writer.WritePropertyName("isWebchatPreviewEnabled"u8);
                writer.WriteBooleanValue(IsWebchatPreviewEnabled.Value);
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

        BotChannelSite IJsonModel<BotChannelSite>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelSite>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelSite)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBotChannelSite(document.RootElement, options);
        }

        internal static BotChannelSite DeserializeBotChannelSite(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? tenantId = default;
            string siteId = default;
            string siteName = default;
            string key = default;
            string key2 = default;
            bool isEnabled = default;
            bool? isTokenEnabled = default;
            bool? isEndpointParametersEnabled = default;
            bool? isDetailedLoggingEnabled = default;
            bool? isBlockUserUploadEnabled = default;
            bool? isNoStorageEnabled = default;
            ETag? eTag = default;
            string appId = default;
            bool? isV1Enabled = default;
            bool? isV3Enabled = default;
            bool? isSecureSiteEnabled = default;
            IList<string> trustedOrigins = default;
            bool? isWebChatSpeechEnabled = default;
            bool? isWebchatPreviewEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("siteId"u8))
                {
                    siteId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("siteName"u8))
                {
                    siteName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isTokenEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isTokenEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEndpointParametersEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEndpointParametersEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDetailedLoggingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDetailedLoggingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isBlockUserUploadEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isBlockUserUploadEnabled = null;
                        continue;
                    }
                    isBlockUserUploadEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNoStorageEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNoStorageEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isV1Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isV1Enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isV3Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isV3Enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSecureSiteEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSecureSiteEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trustedOrigins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    trustedOrigins = array;
                    continue;
                }
                if (property.NameEquals("isWebChatSpeechEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebChatSpeechEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isWebchatPreviewEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebchatPreviewEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BotChannelSite(
                tenantId,
                siteId,
                siteName,
                key,
                key2,
                isEnabled,
                isTokenEnabled,
                isEndpointParametersEnabled,
                isDetailedLoggingEnabled,
                isBlockUserUploadEnabled,
                isNoStorageEnabled,
                eTag,
                appId,
                isV1Enabled,
                isV3Enabled,
                isSecureSiteEnabled,
                trustedOrigins ?? new ChangeTrackingList<string>(),
                isWebChatSpeechEnabled,
                isWebchatPreviewEnabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BotChannelSite>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelSite>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BotChannelSite)} does not support writing '{options.Format}' format.");
            }
        }

        BotChannelSite IPersistableModel<BotChannelSite>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelSite>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBotChannelSite(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BotChannelSite)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BotChannelSite>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
