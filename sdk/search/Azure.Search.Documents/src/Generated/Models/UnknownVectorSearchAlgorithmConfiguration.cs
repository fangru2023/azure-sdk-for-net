// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownVectorSearchAlgorithmConfiguration. </summary>
    internal partial class UnknownVectorSearchAlgorithmConfiguration : VectorSearchAlgorithmConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="UnknownVectorSearchAlgorithmConfiguration"/>. </summary>
        /// <param name="name"> The name to associate with this particular configuration. </param>
        /// <param name="kind"> The name of the kind of algorithm being configured for use with vector search. </param>
        internal UnknownVectorSearchAlgorithmConfiguration(string name, VectorSearchAlgorithmKind kind) : base(name, kind)
        {
            Kind = kind;
        }
    }
}
