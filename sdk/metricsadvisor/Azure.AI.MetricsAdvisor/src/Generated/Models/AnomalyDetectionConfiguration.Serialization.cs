// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class AnomalyDetectionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("metricId"u8);
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("wholeMetricConfiguration"u8);
            writer.WriteObjectValue(WholeSeriesDetectionConditions);
            if (!(SeriesGroupDetectionConditions is ChangeTrackingList<MetricSeriesGroupDetectionCondition> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dimensionGroupOverrideConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in SeriesGroupDetectionConditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(SeriesDetectionConditions is ChangeTrackingList<MetricSingleSeriesDetectionCondition> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("seriesOverrideConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in SeriesDetectionConditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AnomalyDetectionConfiguration DeserializeAnomalyDetectionConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string anomalyDetectionConfigurationId = default;
            string name = default;
            string description = default;
            string metricId = default;
            MetricWholeSeriesDetectionCondition wholeMetricConfiguration = default;
            IList<MetricSeriesGroupDetectionCondition> dimensionGroupOverrideConfigurations = default;
            IList<MetricSingleSeriesDetectionCondition> seriesOverrideConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("anomalyDetectionConfigurationId"u8))
                {
                    anomalyDetectionConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricId"u8))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wholeMetricConfiguration"u8))
                {
                    wholeMetricConfiguration = MetricWholeSeriesDetectionCondition.DeserializeMetricWholeSeriesDetectionCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("dimensionGroupOverrideConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricSeriesGroupDetectionCondition> array = new List<MetricSeriesGroupDetectionCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricSeriesGroupDetectionCondition.DeserializeMetricSeriesGroupDetectionCondition(item));
                    }
                    dimensionGroupOverrideConfigurations = array;
                    continue;
                }
                if (property.NameEquals("seriesOverrideConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricSingleSeriesDetectionCondition> array = new List<MetricSingleSeriesDetectionCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricSingleSeriesDetectionCondition.DeserializeMetricSingleSeriesDetectionCondition(item));
                    }
                    seriesOverrideConfigurations = array;
                    continue;
                }
            }
            return new AnomalyDetectionConfiguration(
                anomalyDetectionConfigurationId,
                name,
                description,
                metricId,
                wholeMetricConfiguration,
                dimensionGroupOverrideConfigurations ?? new ChangeTrackingList<MetricSeriesGroupDetectionCondition>(),
                seriesOverrideConfigurations ?? new ChangeTrackingList<MetricSingleSeriesDetectionCondition>());
        }
    }
}
