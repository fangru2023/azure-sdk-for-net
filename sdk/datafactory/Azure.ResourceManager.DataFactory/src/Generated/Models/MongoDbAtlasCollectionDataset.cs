// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The MongoDB Atlas database dataset. </summary>
    public partial class MongoDbAtlasCollectionDataset : Dataset
    {
        /// <summary> Initializes a new instance of MongoDbAtlasCollectionDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="collection"> The collection name of the MongoDB Atlas database. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="collection"/> is null. </exception>
        public MongoDbAtlasCollectionDataset(LinkedServiceReference linkedServiceName, BinaryData collection) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Collection = collection;
            DatasetType = "MongoDbAtlasCollection";
        }

        /// <summary> Initializes a new instance of MongoDbAtlasCollectionDataset. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="collection"> The collection name of the MongoDB Atlas database. Type: string (or Expression with resultType string). </param>
        internal MongoDbAtlasCollectionDataset(string datasetType, string description, BinaryData structure, BinaryData schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, BinaryData collection) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Collection = collection;
            DatasetType = datasetType ?? "MongoDbAtlasCollection";
        }

        /// <summary> The collection name of the MongoDB Atlas database. Type: string (or Expression with resultType string). </summary>
        public BinaryData Collection { get; set; }
    }
}
