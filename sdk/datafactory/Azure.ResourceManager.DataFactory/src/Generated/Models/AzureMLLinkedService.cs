// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure ML Studio Web Service linked service. </summary>
    public partial class AzureMLLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AzureMLLinkedService. </summary>
        /// <param name="mlEndpoint"> The Batch Execution REST URL for an Azure ML Studio Web Service endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="apiKey">
        /// The API key for accessing the Azure ML model endpoint.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mlEndpoint"/> or <paramref name="apiKey"/> is null. </exception>
        public AzureMLLinkedService(BinaryData mlEndpoint, SecretBase apiKey)
        {
            if (mlEndpoint == null)
            {
                throw new ArgumentNullException(nameof(mlEndpoint));
            }
            if (apiKey == null)
            {
                throw new ArgumentNullException(nameof(apiKey));
            }

            MlEndpoint = mlEndpoint;
            ApiKey = apiKey;
            LinkedServiceType = "AzureML";
        }

        /// <summary> Initializes a new instance of AzureMLLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="mlEndpoint"> The Batch Execution REST URL for an Azure ML Studio Web Service endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="apiKey">
        /// The API key for accessing the Azure ML model endpoint.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="updateResourceEndpoint"> The Update Resource REST URL for an Azure ML Studio Web Service endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against the ARM-based updateResourceEndpoint of an Azure ML Studio web service. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey">
        /// The key of the service principal used to authenticate against the ARM-based updateResourceEndpoint of an Azure ML Studio web service.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Type of authentication (Required to specify MSI) used to connect to AzureML. Type: string (or Expression with resultType string). </param>
        internal AzureMLLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData mlEndpoint, SecretBase apiKey, BinaryData updateResourceEndpoint, BinaryData servicePrincipalId, SecretBase servicePrincipalKey, BinaryData tenant, BinaryData encryptedCredential, BinaryData authentication) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            MlEndpoint = mlEndpoint;
            ApiKey = apiKey;
            UpdateResourceEndpoint = updateResourceEndpoint;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            EncryptedCredential = encryptedCredential;
            Authentication = authentication;
            LinkedServiceType = linkedServiceType ?? "AzureML";
        }

        /// <summary> The Batch Execution REST URL for an Azure ML Studio Web Service endpoint. Type: string (or Expression with resultType string). </summary>
        public BinaryData MlEndpoint { get; set; }
        /// <summary>
        /// The API key for accessing the Azure ML model endpoint.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase ApiKey { get; set; }
        /// <summary> The Update Resource REST URL for an Azure ML Studio Web Service endpoint. Type: string (or Expression with resultType string). </summary>
        public BinaryData UpdateResourceEndpoint { get; set; }
        /// <summary> The ID of the service principal used to authenticate against the ARM-based updateResourceEndpoint of an Azure ML Studio web service. Type: string (or Expression with resultType string). </summary>
        public BinaryData ServicePrincipalId { get; set; }
        /// <summary>
        /// The key of the service principal used to authenticate against the ARM-based updateResourceEndpoint of an Azure ML Studio web service.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public BinaryData Tenant { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
        /// <summary> Type of authentication (Required to specify MSI) used to connect to AzureML. Type: string (or Expression with resultType string). </summary>
        public BinaryData Authentication { get; set; }
    }
}
