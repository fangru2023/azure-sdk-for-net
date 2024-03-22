// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServerExternalAdministrator : IUtf8JsonSerializable, IJsonModel<ServerExternalAdministrator>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerExternalAdministrator>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServerExternalAdministrator>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerExternalAdministrator>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerExternalAdministrator)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorType))
            {
                writer.WritePropertyName("administratorType"u8);
                writer.WriteStringValue(AdministratorType.Value.ToString());
            }
            if (Optional.IsDefined(PrincipalType))
            {
                writer.WritePropertyName("principalType"u8);
                writer.WriteStringValue(PrincipalType.Value.ToString());
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login"u8);
                writer.WriteStringValue(Login);
            }
            if (Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid"u8);
                writer.WriteStringValue(Sid.Value);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(IsAzureADOnlyAuthenticationEnabled))
            {
                writer.WritePropertyName("azureADOnlyAuthentication"u8);
                writer.WriteBooleanValue(IsAzureADOnlyAuthenticationEnabled.Value);
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

        ServerExternalAdministrator IJsonModel<ServerExternalAdministrator>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerExternalAdministrator>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerExternalAdministrator)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerExternalAdministrator(document.RootElement, options);
        }

        internal static ServerExternalAdministrator DeserializeServerExternalAdministrator(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlAdministratorType? administratorType = default;
            SqlServerPrincipalType? principalType = default;
            string login = default;
            Guid? sid = default;
            Guid? tenantId = default;
            bool? azureADOnlyAuthentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("administratorType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administratorType = new SqlAdministratorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("principalType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalType = new SqlServerPrincipalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("login"u8))
                {
                    login = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("azureADOnlyAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureADOnlyAuthentication = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServerExternalAdministrator(
                administratorType,
                principalType,
                login,
                sid,
                tenantId,
                azureADOnlyAuthentication,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerExternalAdministrator>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerExternalAdministrator>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerExternalAdministrator)} does not support writing '{options.Format}' format.");
            }
        }

        ServerExternalAdministrator IPersistableModel<ServerExternalAdministrator>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerExternalAdministrator>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerExternalAdministrator(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerExternalAdministrator)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerExternalAdministrator>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
