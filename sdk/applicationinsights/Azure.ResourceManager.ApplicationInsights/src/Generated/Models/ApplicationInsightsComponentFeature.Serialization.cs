// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentFeature : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentFeature>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentFeature>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationInsightsComponentFeature>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeature)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(FeatureName))
            {
                writer.WritePropertyName("FeatureName"u8);
                writer.WriteStringValue(FeatureName);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterId))
            {
                writer.WritePropertyName("MeterId"u8);
                writer.WriteStringValue(MeterId);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterRateFrequency))
            {
                writer.WritePropertyName("MeterRateFrequency"u8);
                writer.WriteStringValue(MeterRateFrequency);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("ResouceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("IsHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("Capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Title))
            {
                writer.WritePropertyName("Title"u8);
                writer.WriteStringValue(Title);
            }
            if (options.Format != "W" && Optional.IsDefined(IsMainFeature))
            {
                writer.WritePropertyName("IsMainFeature"u8);
                writer.WriteBooleanValue(IsMainFeature.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SupportedAddonFeatures))
            {
                writer.WritePropertyName("SupportedAddonFeatures"u8);
                writer.WriteStringValue(SupportedAddonFeatures);
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

        ApplicationInsightsComponentFeature IJsonModel<ApplicationInsightsComponentFeature>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeature>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeature)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentFeature(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentFeature DeserializeApplicationInsightsComponentFeature(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string featureName = default;
            string meterId = default;
            string meterRateFrequency = default;
            string resouceId = default;
            bool? isHidden = default;
            IReadOnlyList<ApplicationInsightsComponentFeatureCapability> capabilities = default;
            string title = default;
            bool? isMainFeature = default;
            string supportedAddonFeatures = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("FeatureName"u8))
                {
                    featureName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("MeterId"u8))
                {
                    meterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("MeterRateFrequency"u8))
                {
                    meterRateFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ResouceId"u8))
                {
                    resouceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IsHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("Capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationInsightsComponentFeatureCapability> array = new List<ApplicationInsightsComponentFeatureCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationInsightsComponentFeatureCapability.DeserializeApplicationInsightsComponentFeatureCapability(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("Title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("IsMainFeature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMainFeature = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("SupportedAddonFeatures"u8))
                {
                    supportedAddonFeatures = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentFeature(
                featureName,
                meterId,
                meterRateFrequency,
                resouceId,
                isHidden,
                capabilities ?? new ChangeTrackingList<ApplicationInsightsComponentFeatureCapability>(),
                title,
                isMainFeature,
                supportedAddonFeatures,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentFeature>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeature)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentFeature IPersistableModel<ApplicationInsightsComponentFeature>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentFeature>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationInsightsComponentFeature(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentFeature)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentFeature>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
