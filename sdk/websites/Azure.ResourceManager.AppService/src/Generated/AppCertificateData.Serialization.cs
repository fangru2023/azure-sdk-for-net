// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppCertificateData : IUtf8JsonSerializable, IJsonModel<AppCertificateData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppCertificateData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppCertificateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificateData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppCertificateData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(SubjectName))
            {
                writer.WritePropertyName("subjectName"u8);
                writer.WriteStringValue(SubjectName);
            }
            if (Optional.IsCollectionDefined(HostNames))
            {
                writer.WritePropertyName("hostNames"u8);
                writer.WriteStartArray();
                foreach (var item in HostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PfxBlob))
            {
                writer.WritePropertyName("pfxBlob"u8);
                writer.WriteBase64StringValue(PfxBlob, "D");
            }
            if (options.Format != "W" && Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
            if (options.Format != "W" && Optional.IsDefined(SelfLink))
            {
                writer.WritePropertyName("selfLink"u8);
                writer.WriteStringValue(SelfLink);
            }
            if (options.Format != "W" && Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (options.Format != "W" && Optional.IsDefined(IssueOn))
            {
                writer.WritePropertyName("issueDate"u8);
                writer.WriteStringValue(IssueOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (options.Format != "W" && Optional.IsDefined(IsValid))
            {
                writer.WritePropertyName("valid"u8);
                writer.WriteBooleanValue(IsValid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CerBlob))
            {
                writer.WritePropertyName("cerBlob"u8);
                writer.WriteBase64StringValue(CerBlob, "D");
            }
            if (options.Format != "W" && Optional.IsDefined(PublicKeyHash))
            {
                writer.WritePropertyName("publicKeyHash"u8);
                writer.WriteStringValue(PublicKeyHash);
            }
            if (options.Format != "W" && Optional.IsDefined(HostingEnvironmentProfile))
            {
                writer.WritePropertyName("hostingEnvironmentProfile"u8);
                writer.WriteObjectValue(HostingEnvironmentProfile);
            }
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(KeyVaultSecretName))
            {
                writer.WritePropertyName("keyVaultSecretName"u8);
                writer.WriteStringValue(KeyVaultSecretName);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultSecretStatus))
            {
                writer.WritePropertyName("keyVaultSecretStatus"u8);
                writer.WriteStringValue(KeyVaultSecretStatus.Value.ToSerialString());
            }
            if (Optional.IsDefined(ServerFarmId))
            {
                writer.WritePropertyName("serverFarmId"u8);
                writer.WriteStringValue(ServerFarmId);
            }
            if (Optional.IsDefined(CanonicalName))
            {
                writer.WritePropertyName("canonicalName"u8);
                writer.WriteStringValue(CanonicalName);
            }
            if (Optional.IsDefined(DomainValidationMethod))
            {
                writer.WritePropertyName("domainValidationMethod"u8);
                writer.WriteStringValue(DomainValidationMethod);
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

        AppCertificateData IJsonModel<AppCertificateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificateData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppCertificateData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppCertificateData(document.RootElement, options);
        }

        BinaryData IPersistableModel<AppCertificateData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificateData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppCertificateData)} does not support writing '{options.Format}' format.");
            }
        }

        AppCertificateData IPersistableModel<AppCertificateData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificateData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppCertificateData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppCertificateData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppCertificateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
