// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Synapse link workspace resource. </summary>
    public partial class SqlSynapseLinkWorkspace : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SqlSynapseLinkWorkspace"/>. </summary>
        public SqlSynapseLinkWorkspace()
        {
            Workspaces = new ChangeTrackingList<SqlSynapseLinkWorkspaceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlSynapseLinkWorkspace"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="workspaces"> List of all synapselink workspaces. </param>
        internal SqlSynapseLinkWorkspace(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<SqlSynapseLinkWorkspaceInfo> workspaces) : base(id, name, resourceType, systemData)
        {
            Workspaces = workspaces;
        }

        /// <summary> List of all synapselink workspaces. </summary>
        public IList<SqlSynapseLinkWorkspaceInfo> Workspaces { get; }
    }
}
