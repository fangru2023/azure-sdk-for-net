// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Parquet sink. </summary>
    public partial class ParquetSink : CopySink
    {
        /// <summary> Initializes a new instance of <see cref="ParquetSink"/>. </summary>
        public ParquetSink()
        {
            Type = "ParquetSink";
        }

        /// <summary> Initializes a new instance of <see cref="ParquetSink"/>. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="storeSettings">
        /// Parquet store settings.
        /// Please note <see cref="StoreWriteSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobFSWriteSettings"/>, <see cref="AzureBlobStorageWriteSettings"/>, <see cref="AzureDataLakeStoreWriteSettings"/>, <see cref="AzureFileStorageWriteSettings"/>, <see cref="FileServerWriteSettings"/> and <see cref="SftpWriteSettings"/>.
        /// </param>
        /// <param name="formatSettings"> Parquet format settings. </param>
        internal ParquetSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, StoreWriteSettings storeSettings, ParquetWriteSettings formatSettings) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            StoreSettings = storeSettings;
            FormatSettings = formatSettings;
            Type = type ?? "ParquetSink";
        }

        /// <summary>
        /// Parquet store settings.
        /// Please note <see cref="StoreWriteSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobFSWriteSettings"/>, <see cref="AzureBlobStorageWriteSettings"/>, <see cref="AzureDataLakeStoreWriteSettings"/>, <see cref="AzureFileStorageWriteSettings"/>, <see cref="FileServerWriteSettings"/> and <see cref="SftpWriteSettings"/>.
        /// </summary>
        public StoreWriteSettings StoreSettings { get; set; }
        /// <summary> Parquet format settings. </summary>
        public ParquetWriteSettings FormatSettings { get; set; }
    }
}
