// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceProvisioningServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// IotDpsResourceOperations operations.
    /// </summary>
    public partial interface IIotDpsResourceOperations
    {
        /// <summary>
        /// Get the non-security related metadata of the provisioning service.
        /// </summary>
        /// <remarks>
        /// Get the metadata of the provisioning service without SAS keys.
        /// </remarks>
        /// <param name='provisioningServiceName'>
        /// Name of the provisioning service to retrieve.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource group name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProvisioningServiceDescription>> GetWithHttpMessagesAsync(string provisioningServiceName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update the metadata of the provisioning service.
        /// </summary>
        /// <remarks>
        /// Create or update the metadata of the provisioning service. The
        /// usual pattern to modify a property is to retrieve the provisioning
        /// service metadata and security metadata, and then combine them with
        /// the modified values in a new body to update the provisioning
        /// service.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service to create or update.
        /// </param>
        /// <param name='iotDpsDescription'>
        /// Description of the provisioning service to create or update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProvisioningServiceDescription>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string provisioningServiceName, ProvisioningServiceDescription iotDpsDescription, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an existing provisioning service's tags.
        /// </summary>
        /// <remarks>
        /// Update an existing provisioning service's tags. to update other
        /// fields use the CreateOrUpdate method
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service to create or update.
        /// </param>
        /// <param name='tags'>
        /// Resource tags
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProvisioningServiceDescription>> UpdateWithHttpMessagesAsync(string resourceGroupName, string provisioningServiceName, IDictionary<string, string> tags = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the Provisioning Service
        /// </summary>
        /// <remarks>
        /// Deletes the Provisioning Service.
        /// </remarks>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service to delete.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string provisioningServiceName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the provisioning services in a subscription.
        /// </summary>
        /// <remarks>
        /// List all the provisioning services for a given subscription id.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProvisioningServiceDescription>>> ListBySubscriptionWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a list of all provisioning services in the given resource
        /// group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProvisioningServiceDescription>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the status of a long running operation, such as create, update
        /// or delete a provisioning service.
        /// </summary>
        /// <param name='operationId'>
        /// Operation id corresponding to long running operation. Use this to
        /// poll for the status.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service that the operation is running on.
        /// </param>
        /// <param name='asyncinfo'>
        /// Async header used to poll on the status of the operation, obtained
        /// while creating the long running operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AsyncOperationResult>> GetOperationResultWithHttpMessagesAsync(string operationId, string resourceGroupName, string provisioningServiceName, string asyncinfo, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the list of valid SKUs for a provisioning service.
        /// </summary>
        /// <remarks>
        /// Gets the list of valid SKUs and tiers for a provisioning service.
        /// </remarks>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<IotDpsSkuDefinition>>> ListValidSkusWithHttpMessagesAsync(string provisioningServiceName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Check if a provisioning service name is available.
        /// </summary>
        /// <remarks>
        /// Check if a provisioning service name is available. This will
        /// validate if the name is syntactically valid and if the name is
        /// usable
        /// </remarks>
        /// <param name='name'>
        /// The name of the Provisioning Service to check.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<NameAvailabilityInfo>> CheckProvisioningServiceNameAvailabilityWithHttpMessagesAsync(string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the security metadata for a provisioning service.
        /// </summary>
        /// <remarks>
        /// List the primary and secondary keys for a provisioning service.
        /// </remarks>
        /// <param name='provisioningServiceName'>
        /// The provisioning service name to get the shared access keys for.
        /// </param>
        /// <param name='resourceGroupName'>
        /// resource group name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SharedAccessSignatureAuthorizationRuleAccessRightsDescription>>> ListKeysWithHttpMessagesAsync(string provisioningServiceName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a shared access policy by name from a provisioning service.
        /// </summary>
        /// <remarks>
        /// List primary and secondary keys for a specific key name
        /// </remarks>
        /// <param name='provisioningServiceName'>
        /// Name of the provisioning service.
        /// </param>
        /// <param name='keyName'>
        /// Logical key name to get key-values for.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SharedAccessSignatureAuthorizationRuleAccessRightsDescription>> ListKeysForKeyNameWithHttpMessagesAsync(string provisioningServiceName, string keyName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List private link resources
        /// </summary>
        /// <remarks>
        /// List private link resources for the given provisioning service
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateLinkResources>> ListPrivateLinkResourcesWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the specified private link resource
        /// </summary>
        /// <remarks>
        /// Get the specified private link resource for the given provisioning
        /// service
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='groupId'>
        /// The name of the private link resource
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<GroupIdInformation>> GetPrivateLinkResourcesWithHttpMessagesAsync(string resourceGroupName, string resourceName, string groupId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List private endpoint connections
        /// </summary>
        /// <remarks>
        /// List private endpoint connection properties
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IList<PrivateEndpointConnection>>> ListPrivateEndpointConnectionsWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get private endpoint connection
        /// </summary>
        /// <remarks>
        /// Get private endpoint connection properties
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> GetPrivateEndpointConnectionWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update private endpoint connection
        /// </summary>
        /// <remarks>
        /// Create or update the status of a private endpoint connection with
        /// the specified name
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='properties'>
        /// The properties of a private endpoint connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> CreateOrUpdatePrivateEndpointConnectionWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnectionProperties properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete private endpoint connection
        /// </summary>
        /// <remarks>
        /// Delete private endpoint connection with the specified name
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection,IotDpsResourceDeletePrivateEndpointConnectionHeaders>> DeletePrivateEndpointConnectionWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update the metadata of the provisioning service.
        /// </summary>
        /// <remarks>
        /// Create or update the metadata of the provisioning service. The
        /// usual pattern to modify a property is to retrieve the provisioning
        /// service metadata and security metadata, and then combine them with
        /// the modified values in a new body to update the provisioning
        /// service.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service to create or update.
        /// </param>
        /// <param name='iotDpsDescription'>
        /// Description of the provisioning service to create or update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProvisioningServiceDescription>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string provisioningServiceName, ProvisioningServiceDescription iotDpsDescription, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an existing provisioning service's tags.
        /// </summary>
        /// <remarks>
        /// Update an existing provisioning service's tags. to update other
        /// fields use the CreateOrUpdate method
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service to create or update.
        /// </param>
        /// <param name='tags'>
        /// Resource tags
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProvisioningServiceDescription>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string provisioningServiceName, IDictionary<string, string> tags = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the Provisioning Service
        /// </summary>
        /// <remarks>
        /// Deletes the Provisioning Service.
        /// </remarks>
        /// <param name='provisioningServiceName'>
        /// Name of provisioning service to delete.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Resource group identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string provisioningServiceName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update private endpoint connection
        /// </summary>
        /// <remarks>
        /// Create or update the status of a private endpoint connection with
        /// the specified name
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='properties'>
        /// The properties of a private endpoint connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection>> BeginCreateOrUpdatePrivateEndpointConnectionWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, PrivateEndpointConnectionProperties properties, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete private endpoint connection
        /// </summary>
        /// <remarks>
        /// Delete private endpoint connection with the specified name
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the provisioning
        /// service.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the provisioning service.
        /// </param>
        /// <param name='privateEndpointConnectionName'>
        /// The name of the private endpoint connection
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PrivateEndpointConnection,IotDpsResourceDeletePrivateEndpointConnectionHeaders>> BeginDeletePrivateEndpointConnectionWithHttpMessagesAsync(string resourceGroupName, string resourceName, string privateEndpointConnectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the provisioning services in a subscription.
        /// </summary>
        /// <remarks>
        /// List all the provisioning services for a given subscription id.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProvisioningServiceDescription>>> ListBySubscriptionNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a list of all provisioning services in the given resource
        /// group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProvisioningServiceDescription>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the list of valid SKUs for a provisioning service.
        /// </summary>
        /// <remarks>
        /// Gets the list of valid SKUs and tiers for a provisioning service.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<IotDpsSkuDefinition>>> ListValidSkusNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the security metadata for a provisioning service.
        /// </summary>
        /// <remarks>
        /// List the primary and secondary keys for a provisioning service.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorDetailsException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SharedAccessSignatureAuthorizationRuleAccessRightsDescription>>> ListKeysNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
