// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesRegistrationProperties : IUtf8JsonSerializable, IJsonModel<ManagedServicesRegistrationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicesRegistrationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedServicesRegistrationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicesRegistrationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("authorizations"u8);
            writer.WriteStartArray();
            foreach (var item in Authorizations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(EligibleAuthorizations is ChangeTrackingList<ManagedServicesEligibleAuthorization> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("eligibleAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in EligibleAuthorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RegistrationDefinitionName != null)
            {
                writer.WritePropertyName("registrationDefinitionName"u8);
                writer.WriteStringValue(RegistrationDefinitionName);
            }
            writer.WritePropertyName("managedByTenantId"u8);
            writer.WriteStringValue(ManagedByTenantId);
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && ManageeTenantId.HasValue)
            {
                writer.WritePropertyName("manageeTenantId"u8);
                writer.WriteStringValue(ManageeTenantId.Value);
            }
            if (options.Format != "W" && ManageeTenantName != null)
            {
                writer.WritePropertyName("manageeTenantName"u8);
                writer.WriteStringValue(ManageeTenantName);
            }
            if (options.Format != "W" && ManagedByTenantName != null)
            {
                writer.WritePropertyName("managedByTenantName"u8);
                writer.WriteStringValue(ManagedByTenantName);
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

        ManagedServicesRegistrationProperties IJsonModel<ManagedServicesRegistrationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicesRegistrationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesRegistrationProperties(document.RootElement, options);
        }

        internal static ManagedServicesRegistrationProperties DeserializeManagedServicesRegistrationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            IList<ManagedServicesAuthorization> authorizations = default;
            IList<ManagedServicesEligibleAuthorization> eligibleAuthorizations = default;
            string registrationDefinitionName = default;
            Guid managedByTenantId = default;
            ManagedServicesProvisioningState? provisioningState = default;
            Guid? manageeTenantId = default;
            string manageeTenantName = default;
            string managedByTenantName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizations"u8))
                {
                    List<ManagedServicesAuthorization> array = new List<ManagedServicesAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesAuthorization.DeserializeManagedServicesAuthorization(item, options));
                    }
                    authorizations = array;
                    continue;
                }
                if (property.NameEquals("eligibleAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicesEligibleAuthorization> array = new List<ManagedServicesEligibleAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesEligibleAuthorization.DeserializeManagedServicesEligibleAuthorization(item, options));
                    }
                    eligibleAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("registrationDefinitionName"u8))
                {
                    registrationDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByTenantId"u8))
                {
                    managedByTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ManagedServicesProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("manageeTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manageeTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("manageeTenantName"u8))
                {
                    manageeTenantName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByTenantName"u8))
                {
                    managedByTenantName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedServicesRegistrationProperties(
                description,
                authorizations,
                eligibleAuthorizations ?? new ChangeTrackingList<ManagedServicesEligibleAuthorization>(),
                registrationDefinitionName,
                managedByTenantId,
                provisioningState,
                manageeTenantId,
                manageeTenantName,
                managedByTenantName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedServicesRegistrationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServicesRegistrationProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedServicesRegistrationProperties IPersistableModel<ManagedServicesRegistrationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedServicesRegistrationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServicesRegistrationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServicesRegistrationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
