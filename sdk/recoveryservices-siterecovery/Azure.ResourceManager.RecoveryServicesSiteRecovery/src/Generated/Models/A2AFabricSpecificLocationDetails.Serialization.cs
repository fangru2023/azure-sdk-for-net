// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AFabricSpecificLocationDetails : IUtf8JsonSerializable, IJsonModel<A2AFabricSpecificLocationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AFabricSpecificLocationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AFabricSpecificLocationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AFabricSpecificLocationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AFabricSpecificLocationDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InitialPrimaryZone))
            {
                writer.WritePropertyName("initialPrimaryZone"u8);
                writer.WriteStringValue(InitialPrimaryZone);
            }
            if (Optional.IsDefined(InitialRecoveryZone))
            {
                writer.WritePropertyName("initialRecoveryZone"u8);
                writer.WriteStringValue(InitialRecoveryZone);
            }
            if (Optional.IsDefined(InitialPrimaryExtendedLocation))
            {
                writer.WritePropertyName("initialPrimaryExtendedLocation"u8);
                writer.WriteObjectValue(InitialPrimaryExtendedLocation);
            }
            if (Optional.IsDefined(InitialRecoveryExtendedLocation))
            {
                writer.WritePropertyName("initialRecoveryExtendedLocation"u8);
                writer.WriteObjectValue(InitialRecoveryExtendedLocation);
            }
            if (Optional.IsDefined(InitialPrimaryFabricLocation))
            {
                writer.WritePropertyName("initialPrimaryFabricLocation"u8);
                writer.WriteStringValue(InitialPrimaryFabricLocation.Value);
            }
            if (Optional.IsDefined(InitialRecoveryFabricLocation))
            {
                writer.WritePropertyName("initialRecoveryFabricLocation"u8);
                writer.WriteStringValue(InitialRecoveryFabricLocation.Value);
            }
            if (Optional.IsDefined(PrimaryZone))
            {
                writer.WritePropertyName("primaryZone"u8);
                writer.WriteStringValue(PrimaryZone);
            }
            if (Optional.IsDefined(RecoveryZone))
            {
                writer.WritePropertyName("recoveryZone"u8);
                writer.WriteStringValue(RecoveryZone);
            }
            if (Optional.IsDefined(PrimaryExtendedLocation))
            {
                writer.WritePropertyName("primaryExtendedLocation"u8);
                writer.WriteObjectValue(PrimaryExtendedLocation);
            }
            if (Optional.IsDefined(RecoveryExtendedLocation))
            {
                writer.WritePropertyName("recoveryExtendedLocation"u8);
                writer.WriteObjectValue(RecoveryExtendedLocation);
            }
            if (Optional.IsDefined(PrimaryFabricLocation))
            {
                writer.WritePropertyName("primaryFabricLocation"u8);
                writer.WriteStringValue(PrimaryFabricLocation.Value);
            }
            if (Optional.IsDefined(RecoveryFabricLocation))
            {
                writer.WritePropertyName("recoveryFabricLocation"u8);
                writer.WriteStringValue(RecoveryFabricLocation.Value);
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

        A2AFabricSpecificLocationDetails IJsonModel<A2AFabricSpecificLocationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AFabricSpecificLocationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AFabricSpecificLocationDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AFabricSpecificLocationDetails(document.RootElement, options);
        }

        internal static A2AFabricSpecificLocationDetails DeserializeA2AFabricSpecificLocationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string initialPrimaryZone = default;
            string initialRecoveryZone = default;
            SiteRecoveryExtendedLocation initialPrimaryExtendedLocation = default;
            SiteRecoveryExtendedLocation initialRecoveryExtendedLocation = default;
            AzureLocation? initialPrimaryFabricLocation = default;
            AzureLocation? initialRecoveryFabricLocation = default;
            string primaryZone = default;
            string recoveryZone = default;
            SiteRecoveryExtendedLocation primaryExtendedLocation = default;
            SiteRecoveryExtendedLocation recoveryExtendedLocation = default;
            AzureLocation? primaryFabricLocation = default;
            AzureLocation? recoveryFabricLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("initialPrimaryZone"u8))
                {
                    initialPrimaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialRecoveryZone"u8))
                {
                    initialRecoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialPrimaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialPrimaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("initialRecoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRecoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("initialPrimaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialPrimaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialRecoveryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRecoveryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryZone"u8))
                {
                    primaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryZone"u8))
                {
                    recoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("primaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2AFabricSpecificLocationDetails(
                initialPrimaryZone,
                initialRecoveryZone,
                initialPrimaryExtendedLocation,
                initialRecoveryExtendedLocation,
                initialPrimaryFabricLocation,
                initialRecoveryFabricLocation,
                primaryZone,
                recoveryZone,
                primaryExtendedLocation,
                recoveryExtendedLocation,
                primaryFabricLocation,
                recoveryFabricLocation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<A2AFabricSpecificLocationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AFabricSpecificLocationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AFabricSpecificLocationDetails)} does not support writing '{options.Format}' format.");
            }
        }

        A2AFabricSpecificLocationDetails IPersistableModel<A2AFabricSpecificLocationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AFabricSpecificLocationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AFabricSpecificLocationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AFabricSpecificLocationDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AFabricSpecificLocationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
