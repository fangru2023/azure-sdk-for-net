// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountQuotaLimit : IUtf8JsonSerializable, IJsonModel<ServiceAccountQuotaLimit>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAccountQuotaLimit>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceAccountQuotaLimit>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountQuotaLimit>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAccountQuotaLimit)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(RenewalPeriod))
            {
                writer.WritePropertyName("renewalPeriod"u8);
                writer.WriteNumberValue(RenewalPeriod.Value);
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
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

        ServiceAccountQuotaLimit IJsonModel<ServiceAccountQuotaLimit>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountQuotaLimit>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAccountQuotaLimit)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAccountQuotaLimit(document.RootElement, options);
        }

        internal static ServiceAccountQuotaLimit DeserializeServiceAccountQuotaLimit(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? count = default;
            float? renewalPeriod = default;
            IReadOnlyList<ServiceAccountThrottlingRule> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("renewalPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewalPeriod = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAccountThrottlingRule> array = new List<ServiceAccountThrottlingRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountThrottlingRule.DeserializeServiceAccountThrottlingRule(item, options));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceAccountQuotaLimit(count, renewalPeriod, rules ?? new ChangeTrackingList<ServiceAccountThrottlingRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceAccountQuotaLimit>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountQuotaLimit>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAccountQuotaLimit)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceAccountQuotaLimit IPersistableModel<ServiceAccountQuotaLimit>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAccountQuotaLimit>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAccountQuotaLimit(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAccountQuotaLimit)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAccountQuotaLimit>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
