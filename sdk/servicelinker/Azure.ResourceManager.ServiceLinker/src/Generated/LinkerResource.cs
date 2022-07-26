// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ServiceLinker.Models;

namespace Azure.ResourceManager.ServiceLinker
{
    /// <summary>
    /// A Class representing a LinkerResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LinkerResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLinkerResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetLinkerResource method.
    /// </summary>
    public partial class LinkerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LinkerResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string linkerName)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _linkerResourceLinkerClientDiagnostics;
        private readonly LinkerRestOperations _linkerResourceLinkerRestClient;
        private readonly LinkerResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="LinkerResource"/> class for mocking. </summary>
        protected LinkerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LinkerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LinkerResource(ArmClient client, LinkerResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LinkerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LinkerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _linkerResourceLinkerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceLinker", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string linkerResourceLinkerApiVersion);
            _linkerResourceLinkerRestClient = new LinkerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, linkerResourceLinkerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceLinker/linkers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LinkerResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns Linker resource for a given name.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}
        /// Operation Id: Linker_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinkerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.Get");
            scope.Start();
            try
            {
                var response = await _linkerResourceLinkerRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LinkerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns Linker resource for a given name.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}
        /// Operation Id: Linker_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinkerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.Get");
            scope.Start();
            try
            {
                var response = _linkerResourceLinkerRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LinkerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a link.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}
        /// Operation Id: Linker_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.Delete");
            scope.Start();
            try
            {
                var response = await _linkerResourceLinkerRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceLinkerArmOperation(_linkerResourceLinkerClientDiagnostics, Pipeline, _linkerResourceLinkerRestClient.CreateDeleteRequest(Id.Parent, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a link.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}
        /// Operation Id: Linker_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.Delete");
            scope.Start();
            try
            {
                var response = _linkerResourceLinkerRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new ServiceLinkerArmOperation(_linkerResourceLinkerClientDiagnostics, Pipeline, _linkerResourceLinkerRestClient.CreateDeleteRequest(Id.Parent, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to update an existing link.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}
        /// Operation Id: Linker_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Linker details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<LinkerResource>> UpdateAsync(WaitUntil waitUntil, LinkerResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.Update");
            scope.Start();
            try
            {
                var response = await _linkerResourceLinkerRestClient.UpdateAsync(Id.Parent, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceLinkerArmOperation<LinkerResource>(new LinkerResourceOperationSource(Client), _linkerResourceLinkerClientDiagnostics, Pipeline, _linkerResourceLinkerRestClient.CreateUpdateRequest(Id.Parent, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Operation to update an existing link.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}
        /// Operation Id: Linker_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Linker details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<LinkerResource> Update(WaitUntil waitUntil, LinkerResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.Update");
            scope.Start();
            try
            {
                var response = _linkerResourceLinkerRestClient.Update(Id.Parent, Id.Name, patch, cancellationToken);
                var operation = new ServiceLinkerArmOperation<LinkerResource>(new LinkerResourceOperationSource(Client), _linkerResourceLinkerClientDiagnostics, Pipeline, _linkerResourceLinkerRestClient.CreateUpdateRequest(Id.Parent, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validate a link.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}/validateLinker
        /// Operation Id: Linker_Validate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<LinkerValidateOperationResult>> ValidateAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.Validate");
            scope.Start();
            try
            {
                var response = await _linkerResourceLinkerRestClient.ValidateAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceLinkerArmOperation<LinkerValidateOperationResult>(new LinkerValidateOperationResultOperationSource(), _linkerResourceLinkerClientDiagnostics, Pipeline, _linkerResourceLinkerRestClient.CreateValidateRequest(Id.Parent, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validate a link.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}/validateLinker
        /// Operation Id: Linker_Validate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<LinkerValidateOperationResult> Validate(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.Validate");
            scope.Start();
            try
            {
                var response = _linkerResourceLinkerRestClient.Validate(Id.Parent, Id.Name, cancellationToken);
                var operation = new ServiceLinkerArmOperation<LinkerValidateOperationResult>(new LinkerValidateOperationResultOperationSource(), _linkerResourceLinkerClientDiagnostics, Pipeline, _linkerResourceLinkerRestClient.CreateValidateRequest(Id.Parent, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// list source configurations for a linker.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}/listConfigurations
        /// Operation Id: Linker_ListConfigurations
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SourceConfigurationResult>> GetConfigurationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.GetConfigurations");
            scope.Start();
            try
            {
                var response = await _linkerResourceLinkerRestClient.ListConfigurationsAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// list source configurations for a linker.
        /// Request Path: /{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}/listConfigurations
        /// Operation Id: Linker_ListConfigurations
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SourceConfigurationResult> GetConfigurations(CancellationToken cancellationToken = default)
        {
            using var scope = _linkerResourceLinkerClientDiagnostics.CreateScope("LinkerResource.GetConfigurations");
            scope.Start();
            try
            {
                var response = _linkerResourceLinkerRestClient.ListConfigurations(Id.Parent, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
