// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Qumulo.Models
{
    /// <summary> User Details of Qumulo FileSystem resource. </summary>
    public partial class QumuloUserDetails
    {
        /// <summary> Initializes a new instance of <see cref="QumuloUserDetails"/>. </summary>
        public QumuloUserDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QumuloUserDetails"/>. </summary>
        /// <param name="email"> User Email. </param>
        internal QumuloUserDetails(string email)
        {
            Email = email;
        }

        /// <summary> User Email. </summary>
        public string Email { get; set; }
    }
}
