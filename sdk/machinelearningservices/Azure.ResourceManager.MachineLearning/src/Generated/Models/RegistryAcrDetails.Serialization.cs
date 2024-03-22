// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RegistryAcrDetails : IUtf8JsonSerializable, IJsonModel<RegistryAcrDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegistryAcrDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RegistryAcrDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegistryAcrDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegistryAcrDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SystemCreatedAcrAccount))
            {
                if (SystemCreatedAcrAccount != null)
                {
                    writer.WritePropertyName("systemCreatedAcrAccount"u8);
                    writer.WriteObjectValue(SystemCreatedAcrAccount);
                }
                else
                {
                    writer.WriteNull("systemCreatedAcrAccount");
                }
            }
            if (Optional.IsDefined(UserCreatedAcrAccount))
            {
                if (UserCreatedAcrAccount != null)
                {
                    writer.WritePropertyName("userCreatedAcrAccount"u8);
                    writer.WriteObjectValue(UserCreatedAcrAccount);
                }
                else
                {
                    writer.WriteNull("userCreatedAcrAccount");
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

        RegistryAcrDetails IJsonModel<RegistryAcrDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegistryAcrDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegistryAcrDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegistryAcrDetails(document.RootElement, options);
        }

        internal static RegistryAcrDetails DeserializeRegistryAcrDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SystemCreatedAcrAccount systemCreatedAcrAccount = default;
            UserCreatedAcrAccount userCreatedAcrAccount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemCreatedAcrAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        systemCreatedAcrAccount = null;
                        continue;
                    }
                    systemCreatedAcrAccount = SystemCreatedAcrAccount.DeserializeSystemCreatedAcrAccount(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userCreatedAcrAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userCreatedAcrAccount = null;
                        continue;
                    }
                    userCreatedAcrAccount = UserCreatedAcrAccount.DeserializeUserCreatedAcrAccount(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegistryAcrDetails(systemCreatedAcrAccount, userCreatedAcrAccount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RegistryAcrDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegistryAcrDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegistryAcrDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RegistryAcrDetails IPersistableModel<RegistryAcrDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegistryAcrDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegistryAcrDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegistryAcrDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegistryAcrDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
