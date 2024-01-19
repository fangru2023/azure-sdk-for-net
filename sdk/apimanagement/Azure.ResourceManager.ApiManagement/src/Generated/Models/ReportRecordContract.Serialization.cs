// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ReportRecordContract : IUtf8JsonSerializable, IJsonModel<ReportRecordContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportRecordContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReportRecordContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportRecordContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportRecordContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteStringValue(Interval);
            }
            if (Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
            }
            if (Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Optional.IsDefined(Zip))
            {
                writer.WritePropertyName("zip"u8);
                writer.WriteStringValue(Zip);
            }
            if (options.Format != "W" && Optional.IsDefined(UserId))
            {
                writer.WritePropertyName("userId"u8);
                writer.WriteStringValue(UserId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProductId))
            {
                writer.WritePropertyName("productId"u8);
                writer.WriteStringValue(ProductId);
            }
            if (Optional.IsDefined(ApiId))
            {
                writer.WritePropertyName("apiId"u8);
                writer.WriteStringValue(ApiId);
            }
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(ApiRegion))
            {
                writer.WritePropertyName("apiRegion"u8);
                writer.WriteStringValue(ApiRegion);
            }
            if (Optional.IsDefined(SubscriptionResourceId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionResourceId);
            }
            if (Optional.IsDefined(CallCountSuccess))
            {
                writer.WritePropertyName("callCountSuccess"u8);
                writer.WriteNumberValue(CallCountSuccess.Value);
            }
            if (Optional.IsDefined(CallCountBlocked))
            {
                writer.WritePropertyName("callCountBlocked"u8);
                writer.WriteNumberValue(CallCountBlocked.Value);
            }
            if (Optional.IsDefined(CallCountFailed))
            {
                writer.WritePropertyName("callCountFailed"u8);
                writer.WriteNumberValue(CallCountFailed.Value);
            }
            if (Optional.IsDefined(CallCountOther))
            {
                writer.WritePropertyName("callCountOther"u8);
                writer.WriteNumberValue(CallCountOther.Value);
            }
            if (Optional.IsDefined(CallCountTotal))
            {
                writer.WritePropertyName("callCountTotal"u8);
                writer.WriteNumberValue(CallCountTotal.Value);
            }
            if (Optional.IsDefined(Bandwidth))
            {
                writer.WritePropertyName("bandwidth"u8);
                writer.WriteNumberValue(Bandwidth.Value);
            }
            if (Optional.IsDefined(CacheHitCount))
            {
                writer.WritePropertyName("cacheHitCount"u8);
                writer.WriteNumberValue(CacheHitCount.Value);
            }
            if (Optional.IsDefined(CacheMissCount))
            {
                writer.WritePropertyName("cacheMissCount"u8);
                writer.WriteNumberValue(CacheMissCount.Value);
            }
            if (Optional.IsDefined(ApiTimeAvg))
            {
                writer.WritePropertyName("apiTimeAvg"u8);
                writer.WriteNumberValue(ApiTimeAvg.Value);
            }
            if (Optional.IsDefined(ApiTimeMin))
            {
                writer.WritePropertyName("apiTimeMin"u8);
                writer.WriteNumberValue(ApiTimeMin.Value);
            }
            if (Optional.IsDefined(ApiTimeMax))
            {
                writer.WritePropertyName("apiTimeMax"u8);
                writer.WriteNumberValue(ApiTimeMax.Value);
            }
            if (Optional.IsDefined(ServiceTimeAvg))
            {
                writer.WritePropertyName("serviceTimeAvg"u8);
                writer.WriteNumberValue(ServiceTimeAvg.Value);
            }
            if (Optional.IsDefined(ServiceTimeMin))
            {
                writer.WritePropertyName("serviceTimeMin"u8);
                writer.WriteNumberValue(ServiceTimeMin.Value);
            }
            if (Optional.IsDefined(ServiceTimeMax))
            {
                writer.WritePropertyName("serviceTimeMax"u8);
                writer.WriteNumberValue(ServiceTimeMax.Value);
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

        ReportRecordContract IJsonModel<ReportRecordContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportRecordContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportRecordContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportRecordContract(document.RootElement, options);
        }

        internal static ReportRecordContract DeserializeReportRecordContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> interval = default;
            Optional<string> country = default;
            Optional<string> region = default;
            Optional<string> zip = default;
            Optional<string> userId = default;
            Optional<string> productId = default;
            Optional<string> apiId = default;
            Optional<string> operationId = default;
            Optional<string> apiRegion = default;
            Optional<ResourceIdentifier> subscriptionId = default;
            Optional<int> callCountSuccess = default;
            Optional<int> callCountBlocked = default;
            Optional<int> callCountFailed = default;
            Optional<int> callCountOther = default;
            Optional<int> callCountTotal = default;
            Optional<long> bandwidth = default;
            Optional<int> cacheHitCount = default;
            Optional<int> cacheMissCount = default;
            Optional<double> apiTimeAvg = default;
            Optional<double> apiTimeMin = default;
            Optional<double> apiTimeMax = default;
            Optional<double> serviceTimeAvg = default;
            Optional<double> serviceTimeMin = default;
            Optional<double> serviceTimeMax = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    interval = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zip"u8))
                {
                    zip = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productId"u8))
                {
                    productId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiId"u8))
                {
                    apiId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiRegion"u8))
                {
                    apiRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("callCountSuccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callCountSuccess = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("callCountBlocked"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callCountBlocked = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("callCountFailed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callCountFailed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("callCountOther"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callCountOther = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("callCountTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callCountTotal = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bandwidth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bandwidth = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cacheHitCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheHitCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cacheMissCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cacheMissCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("apiTimeAvg"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiTimeAvg = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("apiTimeMin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiTimeMin = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("apiTimeMax"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiTimeMax = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("serviceTimeAvg"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceTimeAvg = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("serviceTimeMin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceTimeMin = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("serviceTimeMax"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceTimeMax = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReportRecordContract(name.Value, Optional.ToNullable(timestamp), interval.Value, country.Value, region.Value, zip.Value, userId.Value, productId.Value, apiId.Value, operationId.Value, apiRegion.Value, subscriptionId.Value, Optional.ToNullable(callCountSuccess), Optional.ToNullable(callCountBlocked), Optional.ToNullable(callCountFailed), Optional.ToNullable(callCountOther), Optional.ToNullable(callCountTotal), Optional.ToNullable(bandwidth), Optional.ToNullable(cacheHitCount), Optional.ToNullable(cacheMissCount), Optional.ToNullable(apiTimeAvg), Optional.ToNullable(apiTimeMin), Optional.ToNullable(apiTimeMax), Optional.ToNullable(serviceTimeAvg), Optional.ToNullable(serviceTimeMin), Optional.ToNullable(serviceTimeMax), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportRecordContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportRecordContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportRecordContract)} does not support '{options.Format}' format.");
            }
        }

        ReportRecordContract IPersistableModel<ReportRecordContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportRecordContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReportRecordContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportRecordContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportRecordContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
