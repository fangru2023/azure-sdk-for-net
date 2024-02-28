// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    public partial class SupportContactProfile : IUtf8JsonSerializable, IJsonModel<SupportContactProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SupportContactProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SupportContactProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportContactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportContactProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("firstName"u8);
            writer.WriteStringValue(FirstName);
            writer.WritePropertyName("lastName"u8);
            writer.WriteStringValue(LastName);
            writer.WritePropertyName("preferredContactMethod"u8);
            writer.WriteStringValue(PreferredContactMethod.ToString());
            writer.WritePropertyName("primaryEmailAddress"u8);
            writer.WriteStringValue(PrimaryEmailAddress);
            if (!(AdditionalEmailAddresses is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("additionalEmailAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalEmailAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (PhoneNumber != null)
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteStringValue(PhoneNumber);
            }
            writer.WritePropertyName("preferredTimeZone"u8);
            writer.WriteStringValue(PreferredTimeZone);
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            writer.WritePropertyName("preferredSupportLanguage"u8);
            writer.WriteStringValue(PreferredSupportLanguage);
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

        SupportContactProfile IJsonModel<SupportContactProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportContactProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SupportContactProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportContactProfile(document.RootElement, options);
        }

        internal static SupportContactProfile DeserializeSupportContactProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string firstName = default;
            string lastName = default;
            PreferredContactMethod preferredContactMethod = default;
            string primaryEmailAddress = default;
            IList<string> additionalEmailAddresses = default;
            string phoneNumber = default;
            string preferredTimeZone = default;
            string country = default;
            string preferredSupportLanguage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstName"u8))
                {
                    firstName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastName"u8))
                {
                    lastName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredContactMethod"u8))
                {
                    preferredContactMethod = new PreferredContactMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryEmailAddress"u8))
                {
                    primaryEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalEmailAddresses"u8))
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
                    additionalEmailAddresses = array;
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredTimeZone"u8))
                {
                    preferredTimeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferredSupportLanguage"u8))
                {
                    preferredSupportLanguage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SupportContactProfile(
                firstName,
                lastName,
                preferredContactMethod,
                primaryEmailAddress,
                additionalEmailAddresses ?? new ChangeTrackingList<string>(),
                phoneNumber,
                preferredTimeZone,
                country,
                preferredSupportLanguage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SupportContactProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportContactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SupportContactProfile)} does not support '{options.Format}' format.");
            }
        }

        SupportContactProfile IPersistableModel<SupportContactProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SupportContactProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSupportContactProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SupportContactProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SupportContactProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
