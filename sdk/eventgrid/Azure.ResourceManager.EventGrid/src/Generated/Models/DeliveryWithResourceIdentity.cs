// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the delivery for an event subscription with resource identity. </summary>
    public partial class DeliveryWithResourceIdentity
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

        /// <summary> Initializes a new instance of <see cref="DeliveryWithResourceIdentity"/>. </summary>
        public DeliveryWithResourceIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryWithResourceIdentity"/>. </summary>
        /// <param name="identity"> The identity to use when delivering events. </param>
        /// <param name="destination">
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
        /// Please note <see cref="EventSubscriptionDestination"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureFunctionEventSubscriptionDestination"/>, <see cref="EventHubEventSubscriptionDestination"/>, <see cref="HybridConnectionEventSubscriptionDestination"/>, <see cref="MonitorAlertEventSubscriptionDestination"/>, <see cref="NamespaceTopicEventSubscriptionDestination"/>, <see cref="PartnerEventSubscriptionDestination"/>, <see cref="ServiceBusQueueEventSubscriptionDestination"/>, <see cref="ServiceBusTopicEventSubscriptionDestination"/>, <see cref="StorageQueueEventSubscriptionDestination"/> and <see cref="WebHookEventSubscriptionDestination"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeliveryWithResourceIdentity(EventSubscriptionIdentity identity, EventSubscriptionDestination destination, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Destination = destination;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identity to use when delivering events. </summary>
        public EventSubscriptionIdentity Identity { get; set; }
        /// <summary>
        /// Information about the destination where events have to be delivered for the event subscription.
        /// Uses Azure Event Grid's identity to acquire the authentication tokens being used during delivery / dead-lettering.
        /// Please note <see cref="EventSubscriptionDestination"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureFunctionEventSubscriptionDestination"/>, <see cref="EventHubEventSubscriptionDestination"/>, <see cref="HybridConnectionEventSubscriptionDestination"/>, <see cref="MonitorAlertEventSubscriptionDestination"/>, <see cref="NamespaceTopicEventSubscriptionDestination"/>, <see cref="PartnerEventSubscriptionDestination"/>, <see cref="ServiceBusQueueEventSubscriptionDestination"/>, <see cref="ServiceBusTopicEventSubscriptionDestination"/>, <see cref="StorageQueueEventSubscriptionDestination"/> and <see cref="WebHookEventSubscriptionDestination"/>.
        /// </summary>
        public EventSubscriptionDestination Destination { get; set; }
    }
}
