// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary>
    /// Model that represents a selector in the Experiment resource.
    /// Please note <see cref="ChaosTargetSelector"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ChaosTargetListSelector"/> and <see cref="ChaosTargetQuerySelector"/>.
    /// </summary>
    public abstract partial class ChaosTargetSelector
    {
        /// <summary> Initializes a new instance of <see cref="ChaosTargetSelector"/>. </summary>
        /// <param name="id"> String of the selector ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        protected ChaosTargetSelector(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ChaosTargetSelector"/>. </summary>
        /// <param name="selectorType"> Enum of the selector type. </param>
        /// <param name="id"> String of the selector ID. </param>
        /// <param name="filter">
        /// Model that represents available filter types that can be applied to a targets list.
        /// Please note <see cref="ChaosTargetFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChaosTargetSimpleFilter"/>.
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ChaosTargetSelector(SelectorType selectorType, string id, ChaosTargetFilter filter, IDictionary<string, BinaryData> additionalProperties)
        {
            SelectorType = selectorType;
            Id = id;
            Filter = filter;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosTargetSelector"/> for deserialization. </summary>
        internal ChaosTargetSelector()
        {
        }

        /// <summary> Enum of the selector type. </summary>
        internal SelectorType SelectorType { get; set; }
        /// <summary> String of the selector ID. </summary>
        public string Id { get; set; }
        /// <summary>
        /// Model that represents available filter types that can be applied to a targets list.
        /// Please note <see cref="ChaosTargetFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChaosTargetSimpleFilter"/>.
        /// </summary>
        public ChaosTargetFilter Filter { get; set; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
