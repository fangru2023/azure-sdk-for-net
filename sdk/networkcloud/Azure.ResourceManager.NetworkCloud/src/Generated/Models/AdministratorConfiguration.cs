// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> AdministratorConfiguration represents the administrative credentials that will be applied to the control plane and agent pool nodes in Kubernetes clusters. </summary>
    public partial class AdministratorConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="AdministratorConfiguration"/>. </summary>
        public AdministratorConfiguration()
        {
            SshPublicKeys = new ChangeTrackingList<NetworkCloudSshPublicKey>();
        }

        /// <summary> Initializes a new instance of <see cref="AdministratorConfiguration"/>. </summary>
        /// <param name="adminUsername"> The user name for the administrator that will be applied to the operating systems that run Kubernetes nodes. If not supplied, a user name will be chosen by the service. </param>
        /// <param name="sshPublicKeys"> The SSH configuration for the operating systems that run the nodes in the Kubernetes cluster. In some cases, specification of public keys may be required to produce a working environment. </param>
        internal AdministratorConfiguration(string adminUsername, IList<NetworkCloudSshPublicKey> sshPublicKeys)
        {
            AdminUsername = adminUsername;
            SshPublicKeys = sshPublicKeys;
        }

        /// <summary> The user name for the administrator that will be applied to the operating systems that run Kubernetes nodes. If not supplied, a user name will be chosen by the service. </summary>
        public string AdminUsername { get; set; }
        /// <summary> The SSH configuration for the operating systems that run the nodes in the Kubernetes cluster. In some cases, specification of public keys may be required to produce a working environment. </summary>
        public IList<NetworkCloudSshPublicKey> SshPublicKeys { get; }
    }
}
