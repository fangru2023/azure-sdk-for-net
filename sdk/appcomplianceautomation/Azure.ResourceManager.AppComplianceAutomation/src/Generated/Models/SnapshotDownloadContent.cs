// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Snapshot's download request. </summary>
    public partial class SnapshotDownloadContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotDownloadContent"/>. </summary>
        /// <param name="downloadType"> Indicates the download type. </param>
        public SnapshotDownloadContent(DownloadType downloadType)
        {
            DownloadType = downloadType;
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotDownloadContent"/>. </summary>
        /// <param name="reportCreatorTenantId"> Tenant id. </param>
        /// <param name="downloadType"> Indicates the download type. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotDownloadContent(string reportCreatorTenantId, DownloadType downloadType, string offerGuid, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReportCreatorTenantId = reportCreatorTenantId;
            DownloadType = downloadType;
            OfferGuid = offerGuid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotDownloadContent"/> for deserialization. </summary>
        internal SnapshotDownloadContent()
        {
        }

        /// <summary> Tenant id. </summary>
        public string ReportCreatorTenantId { get; set; }
        /// <summary> Indicates the download type. </summary>
        public DownloadType DownloadType { get; }
        /// <summary> The offerGuid which mapping to the reports. </summary>
        public string OfferGuid { get; set; }
    }
}
