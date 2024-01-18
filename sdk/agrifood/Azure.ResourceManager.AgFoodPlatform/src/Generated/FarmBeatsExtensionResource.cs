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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AgFoodPlatform
{
    /// <summary>
    /// A Class representing a FarmBeatsExtension along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="FarmBeatsExtensionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetFarmBeatsExtensionResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetFarmBeatsExtension method.
    /// </summary>
    public partial class FarmBeatsExtensionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FarmBeatsExtensionResource"/> instance. </summary>
        /// <param name="farmBeatsExtensionId"> The farmBeatsExtensionId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string farmBeatsExtensionId)
        {
            var resourceId = $"/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/{farmBeatsExtensionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _farmBeatsExtensionClientDiagnostics;
        private readonly FarmBeatsExtensionsRestOperations _farmBeatsExtensionRestClient;
        private readonly FarmBeatsExtensionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions";

        /// <summary> Initializes a new instance of the <see cref="FarmBeatsExtensionResource"/> class for mocking. </summary>
        protected FarmBeatsExtensionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FarmBeatsExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FarmBeatsExtensionResource(ArmClient client, FarmBeatsExtensionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FarmBeatsExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FarmBeatsExtensionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _farmBeatsExtensionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AgFoodPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string farmBeatsExtensionApiVersion);
            _farmBeatsExtensionRestClient = new FarmBeatsExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, farmBeatsExtensionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FarmBeatsExtensionData Data
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
        /// Get farmBeats extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/{farmBeatsExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsExtensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FarmBeatsExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FarmBeatsExtensionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _farmBeatsExtensionClientDiagnostics.CreateScope("FarmBeatsExtensionResource.Get");
            scope.Start();
            try
            {
                var response = await _farmBeatsExtensionRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FarmBeatsExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get farmBeats extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/{farmBeatsExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsExtensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FarmBeatsExtensionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FarmBeatsExtensionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _farmBeatsExtensionClientDiagnostics.CreateScope("FarmBeatsExtensionResource.Get");
            scope.Start();
            try
            {
                var response = _farmBeatsExtensionRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FarmBeatsExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
