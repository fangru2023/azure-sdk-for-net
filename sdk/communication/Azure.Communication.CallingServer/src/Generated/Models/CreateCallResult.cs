// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The response payload of the create call operation. </summary>
    public partial class CreateCallResult
    {
        /// <summary> Initializes a new instance of CreateCallResult. </summary>
        internal CreateCallResult()
        {
        }

        /// <summary> Initializes a new instance of CreateCallResult. </summary>
        /// <param name="callLegId"> The call leg id. </param>
        internal CreateCallResult(string callLegId)
        {
            CallLegId = callLegId;
        }

        /// <summary> The call leg id. </summary>
        public string CallLegId { get; }
    }
}
