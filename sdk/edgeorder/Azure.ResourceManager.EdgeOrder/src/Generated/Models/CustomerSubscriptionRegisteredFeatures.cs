// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Represents subscription registered features. </summary>
    public partial class CustomerSubscriptionRegisteredFeatures
    {
        /// <summary> Initializes a new instance of <see cref="CustomerSubscriptionRegisteredFeatures"/>. </summary>
        public CustomerSubscriptionRegisteredFeatures()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomerSubscriptionRegisteredFeatures"/>. </summary>
        /// <param name="name"> Name of subscription registered feature. </param>
        /// <param name="state"> State of subscription registered feature. </param>
        internal CustomerSubscriptionRegisteredFeatures(string name, string state)
        {
            Name = name;
            State = state;
        }

        /// <summary> Name of subscription registered feature. </summary>
        public string Name { get; set; }
        /// <summary> State of subscription registered feature. </summary>
        public string State { get; set; }
    }
}
