// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class FirmwareCryptoCertificate : IUtf8JsonSerializable, IJsonModel<FirmwareCryptoCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirmwareCryptoCertificate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirmwareCryptoCertificate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareCryptoCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirmwareCryptoCertificate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CryptoCertId != null)
            {
                if (CryptoCertId != null)
                {
                    writer.WritePropertyName("cryptoCertId"u8);
                    writer.WriteStringValue(CryptoCertId);
                }
                else
                {
                    writer.WriteNull("cryptoCertId");
                }
            }
            if (Name != null)
            {
                if (Name != null)
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            if (Subject != null)
            {
                if (Subject != null)
                {
                    writer.WritePropertyName("subject"u8);
                    writer.WriteObjectValue(Subject);
                }
                else
                {
                    writer.WriteNull("subject");
                }
            }
            if (Issuer != null)
            {
                if (Issuer != null)
                {
                    writer.WritePropertyName("issuer"u8);
                    writer.WriteObjectValue(Issuer);
                }
                else
                {
                    writer.WriteNull("issuer");
                }
            }
            if (IssuedOn.HasValue)
            {
                if (IssuedOn != null)
                {
                    writer.WritePropertyName("issuedDate"u8);
                    writer.WriteStringValue(IssuedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("issuedDate");
                }
            }
            if (ExpireOn.HasValue)
            {
                if (ExpireOn != null)
                {
                    writer.WritePropertyName("expirationDate"u8);
                    writer.WriteStringValue(ExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("expirationDate");
                }
            }
            if (Role != null)
            {
                if (Role != null)
                {
                    writer.WritePropertyName("role"u8);
                    writer.WriteStringValue(Role);
                }
                else
                {
                    writer.WriteNull("role");
                }
            }
            if (SignatureAlgorithm != null)
            {
                if (SignatureAlgorithm != null)
                {
                    writer.WritePropertyName("signatureAlgorithm"u8);
                    writer.WriteStringValue(SignatureAlgorithm);
                }
                else
                {
                    writer.WriteNull("signatureAlgorithm");
                }
            }
            if (KeySize.HasValue)
            {
                if (KeySize != null)
                {
                    writer.WritePropertyName("keySize"u8);
                    writer.WriteNumberValue(KeySize.Value);
                }
                else
                {
                    writer.WriteNull("keySize");
                }
            }
            if (KeyAlgorithm != null)
            {
                if (KeyAlgorithm != null)
                {
                    writer.WritePropertyName("keyAlgorithm"u8);
                    writer.WriteStringValue(KeyAlgorithm);
                }
                else
                {
                    writer.WriteNull("keyAlgorithm");
                }
            }
            if (Encoding != null)
            {
                if (Encoding != null)
                {
                    writer.WritePropertyName("encoding"u8);
                    writer.WriteStringValue(Encoding);
                }
                else
                {
                    writer.WriteNull("encoding");
                }
            }
            if (SerialNumber != null)
            {
                if (SerialNumber != null)
                {
                    writer.WritePropertyName("serialNumber"u8);
                    writer.WriteStringValue(SerialNumber);
                }
                else
                {
                    writer.WriteNull("serialNumber");
                }
            }
            if (Fingerprint != null)
            {
                if (Fingerprint != null)
                {
                    writer.WritePropertyName("fingerprint"u8);
                    writer.WriteStringValue(Fingerprint);
                }
                else
                {
                    writer.WriteNull("fingerprint");
                }
            }
            if (!(Usage is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                if (Usage != null)
                {
                    writer.WritePropertyName("usage"u8);
                    writer.WriteStartArray();
                    foreach (var item in Usage)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("usage");
                }
            }
            if (options.Format != "W" && !(FilePaths is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                if (FilePaths != null)
                {
                    writer.WritePropertyName("filePaths"u8);
                    writer.WriteStartArray();
                    foreach (var item in FilePaths)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("filePaths");
                }
            }
            if (PairedKey != null)
            {
                if (PairedKey != null)
                {
                    writer.WritePropertyName("pairedKey"u8);
                    writer.WriteObjectValue(PairedKey);
                }
                else
                {
                    writer.WriteNull("pairedKey");
                }
            }
            if (IsExpired.HasValue)
            {
                if (IsExpired != null)
                {
                    writer.WritePropertyName("isExpired"u8);
                    writer.WriteStringValue(IsExpired.Value.ToString());
                }
                else
                {
                    writer.WriteNull("isExpired");
                }
            }
            if (IsSelfSigned.HasValue)
            {
                if (IsSelfSigned != null)
                {
                    writer.WritePropertyName("isSelfSigned"u8);
                    writer.WriteStringValue(IsSelfSigned.Value.ToString());
                }
                else
                {
                    writer.WriteNull("isSelfSigned");
                }
            }
            if (IsWeakSignature.HasValue)
            {
                if (IsWeakSignature != null)
                {
                    writer.WritePropertyName("isWeakSignature"u8);
                    writer.WriteStringValue(IsWeakSignature.Value.ToString());
                }
                else
                {
                    writer.WriteNull("isWeakSignature");
                }
            }
            if (IsShortKeySize.HasValue)
            {
                if (IsShortKeySize != null)
                {
                    writer.WritePropertyName("isShortKeySize"u8);
                    writer.WriteStringValue(IsShortKeySize.Value.ToString());
                }
                else
                {
                    writer.WriteNull("isShortKeySize");
                }
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

        FirmwareCryptoCertificate IJsonModel<FirmwareCryptoCertificate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareCryptoCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirmwareCryptoCertificate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirmwareCryptoCertificate(document.RootElement, options);
        }

        internal static FirmwareCryptoCertificate DeserializeFirmwareCryptoCertificate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string cryptoCertId = default;
            string name = default;
            FirmwareCryptoCertificateEntity subject = default;
            FirmwareCryptoCertificateEntity issuer = default;
            DateTimeOffset? issuedDate = default;
            DateTimeOffset? expirationDate = default;
            string role = default;
            string signatureAlgorithm = default;
            long? keySize = default;
            string keyAlgorithm = default;
            string encoding = default;
            string serialNumber = default;
            string fingerprint = default;
            IReadOnlyList<string> usage = default;
            IReadOnlyList<string> filePaths = default;
            PairedKey pairedKey = default;
            IsExpired? isExpired = default;
            IsSelfSigned? isSelfSigned = default;
            IsWeakSignature? isWeakSignature = default;
            IsShortKeySize? isShortKeySize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cryptoCertId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cryptoCertId = null;
                        continue;
                    }
                    cryptoCertId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subject = null;
                        continue;
                    }
                    subject = FirmwareCryptoCertificateEntity.DeserializeFirmwareCryptoCertificateEntity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        issuer = null;
                        continue;
                    }
                    issuer = FirmwareCryptoCertificateEntity.DeserializeFirmwareCryptoCertificateEntity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("issuedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        issuedDate = null;
                        continue;
                    }
                    issuedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expirationDate = null;
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        role = null;
                        continue;
                    }
                    role = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("signatureAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        signatureAlgorithm = null;
                        continue;
                    }
                    signatureAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keySize = null;
                        continue;
                    }
                    keySize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("keyAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyAlgorithm = null;
                        continue;
                    }
                    keyAlgorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encoding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encoding = null;
                        continue;
                    }
                    encoding = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        serialNumber = null;
                        continue;
                    }
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fingerprint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fingerprint = null;
                        continue;
                    }
                    fingerprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usage"u8))
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
                    usage = array;
                    continue;
                }
                if (property.NameEquals("filePaths"u8))
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
                    filePaths = array;
                    continue;
                }
                if (property.NameEquals("pairedKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pairedKey = null;
                        continue;
                    }
                    pairedKey = PairedKey.DeserializePairedKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isExpired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isExpired = null;
                        continue;
                    }
                    isExpired = new IsExpired(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isSelfSigned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isSelfSigned = null;
                        continue;
                    }
                    isSelfSigned = new IsSelfSigned(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isWeakSignature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isWeakSignature = null;
                        continue;
                    }
                    isWeakSignature = new IsWeakSignature(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isShortKeySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isShortKeySize = null;
                        continue;
                    }
                    isShortKeySize = new IsShortKeySize(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirmwareCryptoCertificate(
                cryptoCertId,
                name,
                subject,
                issuer,
                issuedDate,
                expirationDate,
                role,
                signatureAlgorithm,
                keySize,
                keyAlgorithm,
                encoding,
                serialNumber,
                fingerprint,
                usage ?? new ChangeTrackingList<string>(),
                filePaths ?? new ChangeTrackingList<string>(),
                pairedKey,
                isExpired,
                isSelfSigned,
                isWeakSignature,
                isShortKeySize,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirmwareCryptoCertificate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareCryptoCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirmwareCryptoCertificate)} does not support '{options.Format}' format.");
            }
        }

        FirmwareCryptoCertificate IPersistableModel<FirmwareCryptoCertificate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirmwareCryptoCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirmwareCryptoCertificate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirmwareCryptoCertificate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirmwareCryptoCertificate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
