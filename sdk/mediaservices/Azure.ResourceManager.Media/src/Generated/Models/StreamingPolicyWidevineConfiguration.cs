// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify configurations of Widevine in Streaming Policy. </summary>
    internal partial class StreamingPolicyWidevineConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="StreamingPolicyWidevineConfiguration"/>. </summary>
        public StreamingPolicyWidevineConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingPolicyWidevineConfiguration"/>. </summary>
        /// <param name="customLicenseAcquisitionUriTemplate"> Template for the URL of the custom service delivering licenses to end user players.  Not required when using Azure Media Services for issuing licenses.  The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token values are {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is replaced with the value of identifier of the key being requested. </param>
        internal StreamingPolicyWidevineConfiguration(string customLicenseAcquisitionUriTemplate)
        {
            CustomLicenseAcquisitionUriTemplate = customLicenseAcquisitionUriTemplate;
        }

        /// <summary> Template for the URL of the custom service delivering licenses to end user players.  Not required when using Azure Media Services for issuing licenses.  The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token values are {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is replaced with the value of identifier of the key being requested. </summary>
        public string CustomLicenseAcquisitionUriTemplate { get; set; }
    }
}
