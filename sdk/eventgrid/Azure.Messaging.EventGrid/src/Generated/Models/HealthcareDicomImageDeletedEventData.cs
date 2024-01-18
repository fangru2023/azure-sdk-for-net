// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.HealthcareApis.DicomImageDeleted event. </summary>
    public partial class HealthcareDicomImageDeletedEventData
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareDicomImageDeletedEventData"/>. </summary>
        internal HealthcareDicomImageDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareDicomImageDeletedEventData"/>. </summary>
        /// <param name="partitionName"> Data partition name. </param>
        /// <param name="imageStudyInstanceUid"> Unique identifier for the Study. </param>
        /// <param name="imageSeriesInstanceUid"> Unique identifier for the Series. </param>
        /// <param name="imageSopInstanceUid"> Unique identifier for the DICOM Image. </param>
        /// <param name="serviceHostName"> Host name of the DICOM account for this image. </param>
        /// <param name="sequenceNumber"> Sequence number of the DICOM Service within Azure Health Data Services. It is unique for every image creation and deletion within the service. </param>
        internal HealthcareDicomImageDeletedEventData(string partitionName, string imageStudyInstanceUid, string imageSeriesInstanceUid, string imageSopInstanceUid, string serviceHostName, long? sequenceNumber)
        {
            PartitionName = partitionName;
            ImageStudyInstanceUid = imageStudyInstanceUid;
            ImageSeriesInstanceUid = imageSeriesInstanceUid;
            ImageSopInstanceUid = imageSopInstanceUid;
            ServiceHostName = serviceHostName;
            SequenceNumber = sequenceNumber;
        }

        /// <summary> Data partition name. </summary>
        public string PartitionName { get; }
        /// <summary> Unique identifier for the Study. </summary>
        public string ImageStudyInstanceUid { get; }
        /// <summary> Unique identifier for the Series. </summary>
        public string ImageSeriesInstanceUid { get; }
        /// <summary> Unique identifier for the DICOM Image. </summary>
        public string ImageSopInstanceUid { get; }
        /// <summary> Host name of the DICOM account for this image. </summary>
        public string ServiceHostName { get; }
        /// <summary> Sequence number of the DICOM Service within Azure Health Data Services. It is unique for every image creation and deletion within the service. </summary>
        public long? SequenceNumber { get; }
    }
}
