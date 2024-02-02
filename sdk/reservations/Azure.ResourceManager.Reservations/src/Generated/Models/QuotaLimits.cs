// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Quota limits. </summary>
    internal partial class QuotaLimits
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

        /// <summary> Initializes a new instance of <see cref="QuotaLimits"/>. </summary>
        internal QuotaLimits()
        {
            Value = new ChangeTrackingList<ReservationQuotaData>();
        }

        /// <summary> Initializes a new instance of <see cref="QuotaLimits"/>. </summary>
        /// <param name="value"> List of quotas (service limits). </param>
        /// <param name="nextLink"> The URI for fetching the next page of quotas (service limits). When no more pages exist, the value is null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaLimits(IReadOnlyList<ReservationQuotaData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of quotas (service limits). </summary>
        public IReadOnlyList<ReservationQuotaData> Value { get; }
        /// <summary> The URI for fetching the next page of quotas (service limits). When no more pages exist, the value is null. </summary>
        public string NextLink { get; }
    }
}
