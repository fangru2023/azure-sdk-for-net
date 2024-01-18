// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes threat intelligence metric. </summary>
    public partial class ThreatIntelligenceMetric
    {
        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceMetric"/>. </summary>
        internal ThreatIntelligenceMetric()
        {
            ThreatTypeMetrics = new ChangeTrackingList<ThreatIntelligenceMetricEntity>();
            PatternTypeMetrics = new ChangeTrackingList<ThreatIntelligenceMetricEntity>();
            SourceMetrics = new ChangeTrackingList<ThreatIntelligenceMetricEntity>();
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceMetric"/>. </summary>
        /// <param name="lastUpdatedOn"> Last updated indicator metric. </param>
        /// <param name="threatTypeMetrics"> Threat type metrics. </param>
        /// <param name="patternTypeMetrics"> Pattern type metrics. </param>
        /// <param name="sourceMetrics"> Source metrics. </param>
        internal ThreatIntelligenceMetric(string lastUpdatedOn, IReadOnlyList<ThreatIntelligenceMetricEntity> threatTypeMetrics, IReadOnlyList<ThreatIntelligenceMetricEntity> patternTypeMetrics, IReadOnlyList<ThreatIntelligenceMetricEntity> sourceMetrics)
        {
            LastUpdatedOn = lastUpdatedOn;
            ThreatTypeMetrics = threatTypeMetrics;
            PatternTypeMetrics = patternTypeMetrics;
            SourceMetrics = sourceMetrics;
        }

        /// <summary> Last updated indicator metric. </summary>
        public string LastUpdatedOn { get; }
        /// <summary> Threat type metrics. </summary>
        public IReadOnlyList<ThreatIntelligenceMetricEntity> ThreatTypeMetrics { get; }
        /// <summary> Pattern type metrics. </summary>
        public IReadOnlyList<ThreatIntelligenceMetricEntity> PatternTypeMetrics { get; }
        /// <summary> Source metrics. </summary>
        public IReadOnlyList<ThreatIntelligenceMetricEntity> SourceMetrics { get; }
    }
}
