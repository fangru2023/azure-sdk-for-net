// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Represents a video track in the asset. </summary>
    public partial class VideoTrack : MediaAssetTrackBase
    {
        /// <summary> Initializes a new instance of <see cref="VideoTrack"/>. </summary>
        public VideoTrack()
        {
            OdataType = "#Microsoft.Media.VideoTrack";
        }

        /// <summary> Initializes a new instance of <see cref="VideoTrack"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VideoTrack(string odataType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, serializedAdditionalRawData)
        {
            OdataType = odataType ?? "#Microsoft.Media.VideoTrack";
        }
    }
}
