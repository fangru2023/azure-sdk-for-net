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
    public partial class SiteRecoveryEventProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryEventProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryEventProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryEventProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryEventProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EventCode))
            {
                writer.WritePropertyName("eventCode"u8);
                writer.WriteStringValue(EventCode);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType);
            }
            if (Optional.IsDefined(AffectedObjectFriendlyName))
            {
                writer.WritePropertyName("affectedObjectFriendlyName"u8);
                writer.WriteStringValue(AffectedObjectFriendlyName);
            }
            if (Optional.IsDefined(AffectedObjectCorrelationId))
            {
                writer.WritePropertyName("affectedObjectCorrelationId"u8);
                writer.WriteStringValue(AffectedObjectCorrelationId);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity);
            }
            if (Optional.IsDefined(OccurredOn))
            {
                writer.WritePropertyName("timeOfOccurrence"u8);
                writer.WriteStringValue(OccurredOn.Value, "O");
            }
            if (Optional.IsDefined(FabricId))
            {
                writer.WritePropertyName("fabricId"u8);
                writer.WriteStringValue(FabricId);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails);
            }
            if (Optional.IsDefined(EventSpecificDetails))
            {
                writer.WritePropertyName("eventSpecificDetails"u8);
                writer.WriteObjectValue(EventSpecificDetails);
            }
            if (Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SiteRecoveryEventProperties IJsonModel<SiteRecoveryEventProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryEventProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryEventProperties(document.RootElement, options);
        }

        internal static SiteRecoveryEventProperties DeserializeSiteRecoveryEventProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventCode = default;
            string description = default;
            string eventType = default;
            string affectedObjectFriendlyName = default;
            string affectedObjectCorrelationId = default;
            string severity = default;
            DateTimeOffset? timeOfOccurrence = default;
            ResourceIdentifier fabricId = default;
            SiteRecoveryEventProviderSpecificDetails providerSpecificDetails = default;
            SiteRecoveryEventSpecificDetails eventSpecificDetails = default;
            IReadOnlyList<SiteRecoveryHealthError> healthErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventCode"u8))
                {
                    eventCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectFriendlyName"u8))
                {
                    affectedObjectFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectCorrelationId"u8))
                {
                    affectedObjectCorrelationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeOfOccurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeOfOccurrence = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("fabricId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = SiteRecoveryEventProviderSpecificDetails.DeserializeSiteRecoveryEventProviderSpecificDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("eventSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventSpecificDetails = SiteRecoveryEventSpecificDetails.DeserializeSiteRecoveryEventSpecificDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryEventProperties(
                eventCode,
                description,
                eventType,
                affectedObjectFriendlyName,
                affectedObjectCorrelationId,
                severity,
                timeOfOccurrence,
                fabricId,
                providerSpecificDetails,
                eventSpecificDetails,
                healthErrors ?? new ChangeTrackingList<SiteRecoveryHealthError>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryEventProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryEventProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryEventProperties IPersistableModel<SiteRecoveryEventProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryEventProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryEventProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryEventProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
