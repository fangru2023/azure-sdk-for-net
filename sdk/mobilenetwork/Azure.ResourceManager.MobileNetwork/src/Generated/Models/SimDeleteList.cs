// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The SIMs to delete. </summary>
    public partial class SimDeleteList
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

        /// <summary> Initializes a new instance of <see cref="SimDeleteList"/>. </summary>
        /// <param name="sims"> A list of SIM resource names to delete. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sims"/> is null. </exception>
        public SimDeleteList(IEnumerable<string> sims)
        {
            Argument.AssertNotNull(sims, nameof(sims));

            Sims = sims.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SimDeleteList"/>. </summary>
        /// <param name="sims"> A list of SIM resource names to delete. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SimDeleteList(IList<string> sims, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sims = sims;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SimDeleteList"/> for deserialization. </summary>
        internal SimDeleteList()
        {
        }

        /// <summary> A list of SIM resource names to delete. </summary>
        public IList<string> Sims { get; }
    }
}
