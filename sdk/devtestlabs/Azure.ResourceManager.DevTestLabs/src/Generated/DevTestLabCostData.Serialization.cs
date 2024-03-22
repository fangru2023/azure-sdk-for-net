// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabCostData : IUtf8JsonSerializable, IJsonModel<DevTestLabCostData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabCostData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabCostData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCostData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsDefined(TargetCost))
            {
                writer.WritePropertyName("targetCost"u8);
                writer.WriteObjectValue(TargetCost);
            }
            if (options.Format != "W" && Optional.IsDefined(LabCostSummary))
            {
                writer.WritePropertyName("labCostSummary"u8);
                writer.WriteObjectValue(LabCostSummary);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(LabCostDetails))
            {
                writer.WritePropertyName("labCostDetails"u8);
                writer.WriteStartArray();
                foreach (var item in LabCostDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ResourceCosts))
            {
                writer.WritePropertyName("resourceCosts"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceCosts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueIdentifier))
            {
                writer.WritePropertyName("uniqueIdentifier"u8);
                writer.WriteStringValue(UniqueIdentifier.Value);
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

        DevTestLabCostData IJsonModel<DevTestLabCostData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCostData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabCostData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabCostData(document.RootElement, options);
        }

        internal static DevTestLabCostData DeserializeDevTestLabCostData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DevTestLabTargetCost targetCost = default;
            LabCostSummaryProperties labCostSummary = default;
            IReadOnlyList<DevTestLabCostDetails> labCostDetails = default;
            IReadOnlyList<DevTestLabResourceCost> resourceCosts = default;
            string currencyCode = default;
            DateTimeOffset? startDateTime = default;
            DateTimeOffset? endDateTime = default;
            DateTimeOffset? createdDate = default;
            string provisioningState = default;
            Guid? uniqueIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("targetCost"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetCost = DevTestLabTargetCost.DeserializeDevTestLabTargetCost(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("labCostSummary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            labCostSummary = LabCostSummaryProperties.DeserializeLabCostSummaryProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("labCostDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabCostDetails> array = new List<DevTestLabCostDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabCostDetails.DeserializeDevTestLabCostDetails(item, options));
                            }
                            labCostDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceCosts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabResourceCost> array = new List<DevTestLabResourceCost>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabResourceCost.DeserializeDevTestLabResourceCost(item, options));
                            }
                            resourceCosts = array;
                            continue;
                        }
                        if (property0.NameEquals("currencyCode"u8))
                        {
                            currencyCode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
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
            return new DevTestLabCostData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                targetCost,
                labCostSummary,
                labCostDetails ?? new ChangeTrackingList<DevTestLabCostDetails>(),
                resourceCosts ?? new ChangeTrackingList<DevTestLabResourceCost>(),
                currencyCode,
                startDateTime,
                endDateTime,
                createdDate,
                provisioningState,
                uniqueIdentifier,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabCostData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCostData)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabCostData IPersistableModel<DevTestLabCostData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabCostData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabCostData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabCostData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabCostData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
