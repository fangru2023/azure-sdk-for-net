// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Request for getting sso details for a user. </summary>
    public partial class DynatraceSsoDetailsContent
    {
        /// <summary> Initializes a new instance of <see cref="DynatraceSsoDetailsContent"/>. </summary>
        public DynatraceSsoDetailsContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceSsoDetailsContent"/>. </summary>
        /// <param name="userPrincipal"> user principal id of the user. </param>
        internal DynatraceSsoDetailsContent(string userPrincipal)
        {
            UserPrincipal = userPrincipal;
        }

        /// <summary> user principal id of the user. </summary>
        public string UserPrincipal { get; set; }
    }
}
