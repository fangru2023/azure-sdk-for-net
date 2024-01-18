// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> Description of the check name availability request properties. </summary>
    public partial class RelayNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of <see cref="RelayNameAvailabilityResult"/>. </summary>
        internal RelayNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RelayNameAvailabilityResult"/>. </summary>
        /// <param name="message"> The detailed info regarding the reason associated with the namespace. </param>
        /// <param name="isNameAvailable"> Value indicating namespace is available. Returns true if the namespace is available; otherwise, false. </param>
        /// <param name="reason"> The reason for unavailability of a namespace. </param>
        internal RelayNameAvailabilityResult(string message, bool? isNameAvailable, RelayNameUnavailableReason? reason)
        {
            Message = message;
            IsNameAvailable = isNameAvailable;
            Reason = reason;
        }

        /// <summary> The detailed info regarding the reason associated with the namespace. </summary>
        public string Message { get; }
        /// <summary> Value indicating namespace is available. Returns true if the namespace is available; otherwise, false. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> The reason for unavailability of a namespace. </summary>
        public RelayNameUnavailableReason? Reason { get; }
    }
}
