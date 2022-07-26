// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Connection string for the Cosmos DB account. </summary>
    public partial class CosmosDBAccountConnectionString
    {
        /// <summary> Initializes a new instance of CosmosDBAccountConnectionString. </summary>
        internal CosmosDBAccountConnectionString()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBAccountConnectionString. </summary>
        /// <param name="connectionString"> Value of the connection string. </param>
        /// <param name="description"> Description of the connection string. </param>
        internal CosmosDBAccountConnectionString(string connectionString, string description)
        {
            ConnectionString = connectionString;
            Description = description;
        }

        /// <summary> Value of the connection string. </summary>
        public string ConnectionString { get; }
        /// <summary> Description of the connection string. </summary>
        public string Description { get; }
    }
}
