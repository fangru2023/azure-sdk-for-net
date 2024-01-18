// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Parameters supplied to the Scale Streaming Job operation. </summary>
    public partial class ScaleStreamingJobContent
    {
        /// <summary> Initializes a new instance of <see cref="ScaleStreamingJobContent"/>. </summary>
        public ScaleStreamingJobContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScaleStreamingJobContent"/>. </summary>
        /// <param name="streamingUnits"> Specifies the number of streaming units that the streaming job will scale to. </param>
        internal ScaleStreamingJobContent(int? streamingUnits)
        {
            StreamingUnits = streamingUnits;
        }

        /// <summary> Specifies the number of streaming units that the streaming job will scale to. </summary>
        public int? StreamingUnits { get; set; }
    }
}
