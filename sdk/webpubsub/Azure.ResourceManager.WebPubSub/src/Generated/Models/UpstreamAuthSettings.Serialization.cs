// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class UpstreamAuthSettings : IUtf8JsonSerializable, IJsonModel<UpstreamAuthSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpstreamAuthSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpstreamAuthSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpstreamAuthSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpstreamAuthSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AuthType.Value.ToString());
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                writer.WritePropertyName("managedIdentity"u8);
                writer.WriteObjectValue(ManagedIdentity);
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

        UpstreamAuthSettings IJsonModel<UpstreamAuthSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpstreamAuthSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpstreamAuthSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpstreamAuthSettings(document.RootElement, options);
        }

        internal static UpstreamAuthSettings DeserializeUpstreamAuthSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpstreamAuthType? type = default;
            ManagedIdentitySettings managedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new UpstreamAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedIdentity = ManagedIdentitySettings.DeserializeManagedIdentitySettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpstreamAuthSettings(type, managedIdentity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpstreamAuthSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpstreamAuthSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpstreamAuthSettings)} does not support writing '{options.Format}' format.");
            }
        }

        UpstreamAuthSettings IPersistableModel<UpstreamAuthSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpstreamAuthSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpstreamAuthSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpstreamAuthSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpstreamAuthSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
