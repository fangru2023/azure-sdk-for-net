// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Customer Managed Identity. </summary>
    public partial class MyWorkbookManagedIdentity
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

        /// <summary> Initializes a new instance of <see cref="MyWorkbookManagedIdentity"/>. </summary>
        public MyWorkbookManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MyWorkbookManagedIdentity"/>. </summary>
        /// <param name="userAssignedIdentities"> Customer Managed Identity. </param>
        /// <param name="identityType"> The identity type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MyWorkbookManagedIdentity(MyWorkbookUserAssignedIdentities userAssignedIdentities, MyWorkbookManagedIdentityType? identityType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserAssignedIdentities = userAssignedIdentities;
            IdentityType = identityType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Customer Managed Identity. </summary>
        public MyWorkbookUserAssignedIdentities UserAssignedIdentities { get; set; }
        /// <summary> The identity type. </summary>
        public MyWorkbookManagedIdentityType? IdentityType { get; set; }
    }
}
