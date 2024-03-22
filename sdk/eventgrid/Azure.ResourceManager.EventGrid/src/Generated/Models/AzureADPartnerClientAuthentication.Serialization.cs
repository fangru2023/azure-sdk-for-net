// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class AzureADPartnerClientAuthentication : IUtf8JsonSerializable, IJsonModel<AzureADPartnerClientAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureADPartnerClientAuthentication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureADPartnerClientAuthentication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureADPartnerClientAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureADPartnerClientAuthentication)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("clientAuthenticationType"u8);
            writer.WriteStringValue(ClientAuthenticationType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureActiveDirectoryTenantId))
            {
                writer.WritePropertyName("azureActiveDirectoryTenantId"u8);
                writer.WriteStringValue(AzureActiveDirectoryTenantId);
            }
            if (Optional.IsDefined(AzureActiveDirectoryApplicationIdOrUri))
            {
                writer.WritePropertyName("azureActiveDirectoryApplicationIdOrUri"u8);
                writer.WriteStringValue(AzureActiveDirectoryApplicationIdOrUri.AbsoluteUri);
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

        AzureADPartnerClientAuthentication IJsonModel<AzureADPartnerClientAuthentication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureADPartnerClientAuthentication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureADPartnerClientAuthentication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureADPartnerClientAuthentication(document.RootElement, options);
        }

        internal static AzureADPartnerClientAuthentication DeserializeAzureADPartnerClientAuthentication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PartnerClientAuthenticationType clientAuthenticationType = default;
            string azureActiveDirectoryTenantId = default;
            Uri azureActiveDirectoryApplicationIdOrUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientAuthenticationType"u8))
                {
                    clientAuthenticationType = new PartnerClientAuthenticationType(property.Value.GetString());
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
                        if (property0.NameEquals("azureActiveDirectoryTenantId"u8))
                        {
                            azureActiveDirectoryTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureActiveDirectoryApplicationIdOrUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureActiveDirectoryApplicationIdOrUri = new Uri(property0.Value.GetString());
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
            return new AzureADPartnerClientAuthentication(clientAuthenticationType, serializedAdditionalRawData, azureActiveDirectoryTenantId, azureActiveDirectoryApplicationIdOrUri);
        }

        BinaryData IPersistableModel<AzureADPartnerClientAuthentication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureADPartnerClientAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureADPartnerClientAuthentication)} does not support writing '{options.Format}' format.");
            }
        }

        AzureADPartnerClientAuthentication IPersistableModel<AzureADPartnerClientAuthentication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureADPartnerClientAuthentication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureADPartnerClientAuthentication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureADPartnerClientAuthentication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureADPartnerClientAuthentication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
