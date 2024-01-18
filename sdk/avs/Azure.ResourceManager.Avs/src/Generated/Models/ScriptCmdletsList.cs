// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Pageable list of scripts/cmdlets. </summary>
    internal partial class ScriptCmdletsList
    {
        /// <summary> Initializes a new instance of <see cref="ScriptCmdletsList"/>. </summary>
        internal ScriptCmdletsList()
        {
            Value = new ChangeTrackingList<ScriptCmdletData>();
        }

        /// <summary> Initializes a new instance of <see cref="ScriptCmdletsList"/>. </summary>
        /// <param name="value"> List of scripts. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal ScriptCmdletsList(IReadOnlyList<ScriptCmdletData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of scripts. </summary>
        public IReadOnlyList<ScriptCmdletData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
