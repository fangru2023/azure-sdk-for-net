// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MonitoringDataSegment. </summary>
    public partial class MonitoringDataSegment
    {
        /// <summary> Initializes a new instance of MonitoringDataSegment. </summary>
        public MonitoringDataSegment()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of MonitoringDataSegment. </summary>
        /// <param name="feature"> The feature to segment the data on. </param>
        /// <param name="values"> Filters for only the specified values of the given segmented feature. </param>
        internal MonitoringDataSegment(string feature, IList<string> values)
        {
            Feature = feature;
            Values = values;
        }

        /// <summary> The feature to segment the data on. </summary>
        public string Feature { get; set; }
        /// <summary> Filters for only the specified values of the given segmented feature. </summary>
        public IList<string> Values { get; set; }
    }
}
