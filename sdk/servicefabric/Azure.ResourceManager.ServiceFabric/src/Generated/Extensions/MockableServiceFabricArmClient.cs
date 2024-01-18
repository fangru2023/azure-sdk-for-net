// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableServiceFabricArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricArmClient"/> class for mocking. </summary>
        protected MockableServiceFabricArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableServiceFabricArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableServiceFabricArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableServiceFabricArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricClusterResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricClusterResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricClusterResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricClusterResource"/> object. </returns>
        public virtual ServiceFabricClusterResource GetServiceFabricClusterResource(ResourceIdentifier id)
        {
            ServiceFabricClusterResource.ValidateResourceId(id);
            return new ServiceFabricClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationTypeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationTypeResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationTypeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationTypeResource"/> object. </returns>
        public virtual ServiceFabricApplicationTypeResource GetServiceFabricApplicationTypeResource(ResourceIdentifier id)
        {
            ServiceFabricApplicationTypeResource.ValidateResourceId(id);
            return new ServiceFabricApplicationTypeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationTypeVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationTypeVersionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationTypeVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationTypeVersionResource"/> object. </returns>
        public virtual ServiceFabricApplicationTypeVersionResource GetServiceFabricApplicationTypeVersionResource(ResourceIdentifier id)
        {
            ServiceFabricApplicationTypeVersionResource.ValidateResourceId(id);
            return new ServiceFabricApplicationTypeVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricApplicationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricApplicationResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricApplicationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricApplicationResource"/> object. </returns>
        public virtual ServiceFabricApplicationResource GetServiceFabricApplicationResource(ResourceIdentifier id)
        {
            ServiceFabricApplicationResource.ValidateResourceId(id);
            return new ServiceFabricApplicationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceFabricServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceFabricServiceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceFabricServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceFabricServiceResource"/> object. </returns>
        public virtual ServiceFabricServiceResource GetServiceFabricServiceResource(ResourceIdentifier id)
        {
            ServiceFabricServiceResource.ValidateResourceId(id);
            return new ServiceFabricServiceResource(Client, id);
        }
    }
}
