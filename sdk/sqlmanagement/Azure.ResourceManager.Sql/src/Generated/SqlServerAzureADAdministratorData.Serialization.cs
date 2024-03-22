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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerAzureADAdministratorData : IUtf8JsonSerializable, IJsonModel<SqlServerAzureADAdministratorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServerAzureADAdministratorData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServerAzureADAdministratorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerAzureADAdministratorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerAzureADAdministratorData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(AdministratorType))
            {
                writer.WritePropertyName("administratorType"u8);
                writer.WriteStringValue(AdministratorType.Value.ToString());
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
            if (options.Format != "W" && Optional.IsDefined(IsAzureADOnlyAuthenticationEnabled))
            {
                writer.WritePropertyName("azureADOnlyAuthentication"u8);
                writer.WriteBooleanValue(IsAzureADOnlyAuthenticationEnabled.Value);
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

        SqlServerAzureADAdministratorData IJsonModel<SqlServerAzureADAdministratorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerAzureADAdministratorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlServerAzureADAdministratorData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerAzureADAdministratorData(document.RootElement, options);
        }

        internal static SqlServerAzureADAdministratorData DeserializeSqlServerAzureADAdministratorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            SqlAdministratorType? administratorType = default;
            string login = default;
            Guid? sid = default;
            Guid? tenantId = default;
            bool? azureADOnlyAuthentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("administratorType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administratorType = new SqlAdministratorType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("login"u8))
                        {
                            login = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("azureADOnlyAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureADOnlyAuthentication = property0.Value.GetBoolean();
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
            return new SqlServerAzureADAdministratorData(
                id,
                name,
                type,
                systemData,
                administratorType,
                login,
                sid,
                tenantId,
                azureADOnlyAuthentication,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServerAzureADAdministratorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerAzureADAdministratorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlServerAzureADAdministratorData)} does not support writing '{options.Format}' format.");
            }
        }

        SqlServerAzureADAdministratorData IPersistableModel<SqlServerAzureADAdministratorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlServerAzureADAdministratorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlServerAzureADAdministratorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlServerAzureADAdministratorData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlServerAzureADAdministratorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
