// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableComputeArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableComputeArmClient"/> class for mocking. </summary>
        protected MockableComputeArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableComputeArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableComputeArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableComputeArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineScaleSetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineScaleSetResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineScaleSetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetResource"/> object. </returns>
        public virtual VirtualMachineScaleSetResource GetVirtualMachineScaleSetResource(ResourceIdentifier id)
        {
            VirtualMachineScaleSetResource.ValidateResourceId(id);
            return new VirtualMachineScaleSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineScaleSetExtensionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineScaleSetExtensionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetExtensionResource"/> object. </returns>
        public virtual VirtualMachineScaleSetExtensionResource GetVirtualMachineScaleSetExtensionResource(ResourceIdentifier id)
        {
            VirtualMachineScaleSetExtensionResource.ValidateResourceId(id);
            return new VirtualMachineScaleSetExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineScaleSetRollingUpgradeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineScaleSetRollingUpgradeResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineScaleSetRollingUpgradeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetRollingUpgradeResource"/> object. </returns>
        public virtual VirtualMachineScaleSetRollingUpgradeResource GetVirtualMachineScaleSetRollingUpgradeResource(ResourceIdentifier id)
        {
            VirtualMachineScaleSetRollingUpgradeResource.ValidateResourceId(id);
            return new VirtualMachineScaleSetRollingUpgradeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineScaleSetVmExtensionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineScaleSetVmExtensionResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineScaleSetVmExtensionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVmExtensionResource"/> object. </returns>
        public virtual VirtualMachineScaleSetVmExtensionResource GetVirtualMachineScaleSetVmExtensionResource(ResourceIdentifier id)
        {
            VirtualMachineScaleSetVmExtensionResource.ValidateResourceId(id);
            return new VirtualMachineScaleSetVmExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineScaleSetVmResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineScaleSetVmResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineScaleSetVmResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVmResource"/> object. </returns>
        public virtual VirtualMachineScaleSetVmResource GetVirtualMachineScaleSetVmResource(ResourceIdentifier id)
        {
            VirtualMachineScaleSetVmResource.ValidateResourceId(id);
            return new VirtualMachineScaleSetVmResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineExtensionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineExtensionResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineExtensionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineExtensionResource"/> object. </returns>
        public virtual VirtualMachineExtensionResource GetVirtualMachineExtensionResource(ResourceIdentifier id)
        {
            VirtualMachineExtensionResource.ValidateResourceId(id);
            return new VirtualMachineExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineResource"/> object. </returns>
        public virtual VirtualMachineResource GetVirtualMachineResource(ResourceIdentifier id)
        {
            VirtualMachineResource.ValidateResourceId(id);
            return new VirtualMachineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineExtensionImageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineExtensionImageResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineExtensionImageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineExtensionImageResource"/> object. </returns>
        public virtual VirtualMachineExtensionImageResource GetVirtualMachineExtensionImageResource(ResourceIdentifier id)
        {
            VirtualMachineExtensionImageResource.ValidateResourceId(id);
            return new VirtualMachineExtensionImageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvailabilitySetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailabilitySetResource.CreateResourceIdentifier" /> to create an <see cref="AvailabilitySetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySetResource"/> object. </returns>
        public virtual AvailabilitySetResource GetAvailabilitySetResource(ResourceIdentifier id)
        {
            AvailabilitySetResource.ValidateResourceId(id);
            return new AvailabilitySetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProximityPlacementGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProximityPlacementGroupResource.CreateResourceIdentifier" /> to create a <see cref="ProximityPlacementGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProximityPlacementGroupResource"/> object. </returns>
        public virtual ProximityPlacementGroupResource GetProximityPlacementGroupResource(ResourceIdentifier id)
        {
            ProximityPlacementGroupResource.ValidateResourceId(id);
            return new ProximityPlacementGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DedicatedHostGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DedicatedHostGroupResource.CreateResourceIdentifier" /> to create a <see cref="DedicatedHostGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHostGroupResource"/> object. </returns>
        public virtual DedicatedHostGroupResource GetDedicatedHostGroupResource(ResourceIdentifier id)
        {
            DedicatedHostGroupResource.ValidateResourceId(id);
            return new DedicatedHostGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DedicatedHostResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DedicatedHostResource.CreateResourceIdentifier" /> to create a <see cref="DedicatedHostResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHostResource"/> object. </returns>
        public virtual DedicatedHostResource GetDedicatedHostResource(ResourceIdentifier id)
        {
            DedicatedHostResource.ValidateResourceId(id);
            return new DedicatedHostResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SshPublicKeyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SshPublicKeyResource.CreateResourceIdentifier" /> to create a <see cref="SshPublicKeyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SshPublicKeyResource"/> object. </returns>
        public virtual SshPublicKeyResource GetSshPublicKeyResource(ResourceIdentifier id)
        {
            SshPublicKeyResource.ValidateResourceId(id);
            return new SshPublicKeyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DiskImageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskImageResource.CreateResourceIdentifier" /> to create a <see cref="DiskImageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskImageResource"/> object. </returns>
        public virtual DiskImageResource GetDiskImageResource(ResourceIdentifier id)
        {
            DiskImageResource.ValidateResourceId(id);
            return new DiskImageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RestorePointGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RestorePointGroupResource.CreateResourceIdentifier" /> to create a <see cref="RestorePointGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorePointGroupResource"/> object. </returns>
        public virtual RestorePointGroupResource GetRestorePointGroupResource(ResourceIdentifier id)
        {
            RestorePointGroupResource.ValidateResourceId(id);
            return new RestorePointGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="RestorePointResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RestorePointResource.CreateResourceIdentifier" /> to create a <see cref="RestorePointResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RestorePointResource"/> object. </returns>
        public virtual RestorePointResource GetRestorePointResource(ResourceIdentifier id)
        {
            RestorePointResource.ValidateResourceId(id);
            return new RestorePointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CapacityReservationGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CapacityReservationGroupResource.CreateResourceIdentifier" /> to create a <see cref="CapacityReservationGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CapacityReservationGroupResource"/> object. </returns>
        public virtual CapacityReservationGroupResource GetCapacityReservationGroupResource(ResourceIdentifier id)
        {
            CapacityReservationGroupResource.ValidateResourceId(id);
            return new CapacityReservationGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CapacityReservationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CapacityReservationResource.CreateResourceIdentifier" /> to create a <see cref="CapacityReservationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CapacityReservationResource"/> object. </returns>
        public virtual CapacityReservationResource GetCapacityReservationResource(ResourceIdentifier id)
        {
            CapacityReservationResource.ValidateResourceId(id);
            return new CapacityReservationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineRunCommandResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineRunCommandResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineRunCommandResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineRunCommandResource"/> object. </returns>
        public virtual VirtualMachineRunCommandResource GetVirtualMachineRunCommandResource(ResourceIdentifier id)
        {
            VirtualMachineRunCommandResource.ValidateResourceId(id);
            return new VirtualMachineRunCommandResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineScaleSetVmRunCommandResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineScaleSetVmRunCommandResource.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineScaleSetVmRunCommandResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVmRunCommandResource"/> object. </returns>
        public virtual VirtualMachineScaleSetVmRunCommandResource GetVirtualMachineScaleSetVmRunCommandResource(ResourceIdentifier id)
        {
            VirtualMachineScaleSetVmRunCommandResource.ValidateResourceId(id);
            return new VirtualMachineScaleSetVmRunCommandResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedDiskResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedDiskResource.CreateResourceIdentifier" /> to create a <see cref="ManagedDiskResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedDiskResource"/> object. </returns>
        public virtual ManagedDiskResource GetManagedDiskResource(ResourceIdentifier id)
        {
            ManagedDiskResource.ValidateResourceId(id);
            return new ManagedDiskResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DiskAccessResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskAccessResource.CreateResourceIdentifier" /> to create a <see cref="DiskAccessResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskAccessResource"/> object. </returns>
        public virtual DiskAccessResource GetDiskAccessResource(ResourceIdentifier id)
        {
            DiskAccessResource.ValidateResourceId(id);
            return new DiskAccessResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ComputePrivateEndpointConnectionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ComputePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="ComputePrivateEndpointConnectionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ComputePrivateEndpointConnectionResource"/> object. </returns>
        public virtual ComputePrivateEndpointConnectionResource GetComputePrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            ComputePrivateEndpointConnectionResource.ValidateResourceId(id);
            return new ComputePrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DiskEncryptionSetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskEncryptionSetResource.CreateResourceIdentifier" /> to create a <see cref="DiskEncryptionSetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskEncryptionSetResource"/> object. </returns>
        public virtual DiskEncryptionSetResource GetDiskEncryptionSetResource(ResourceIdentifier id)
        {
            DiskEncryptionSetResource.ValidateResourceId(id);
            return new DiskEncryptionSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DiskRestorePointResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskRestorePointResource.CreateResourceIdentifier" /> to create a <see cref="DiskRestorePointResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskRestorePointResource"/> object. </returns>
        public virtual DiskRestorePointResource GetDiskRestorePointResource(ResourceIdentifier id)
        {
            DiskRestorePointResource.ValidateResourceId(id);
            return new DiskRestorePointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SnapshotResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SnapshotResource.CreateResourceIdentifier" /> to create a <see cref="SnapshotResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SnapshotResource"/> object. </returns>
        public virtual SnapshotResource GetSnapshotResource(ResourceIdentifier id)
        {
            SnapshotResource.ValidateResourceId(id);
            return new SnapshotResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GalleryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GalleryResource.CreateResourceIdentifier" /> to create a <see cref="GalleryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryResource"/> object. </returns>
        public virtual GalleryResource GetGalleryResource(ResourceIdentifier id)
        {
            GalleryResource.ValidateResourceId(id);
            return new GalleryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GalleryImageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GalleryImageResource.CreateResourceIdentifier" /> to create a <see cref="GalleryImageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryImageResource"/> object. </returns>
        public virtual GalleryImageResource GetGalleryImageResource(ResourceIdentifier id)
        {
            GalleryImageResource.ValidateResourceId(id);
            return new GalleryImageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GalleryImageVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GalleryImageVersionResource.CreateResourceIdentifier" /> to create a <see cref="GalleryImageVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryImageVersionResource"/> object. </returns>
        public virtual GalleryImageVersionResource GetGalleryImageVersionResource(ResourceIdentifier id)
        {
            GalleryImageVersionResource.ValidateResourceId(id);
            return new GalleryImageVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GalleryApplicationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GalleryApplicationResource.CreateResourceIdentifier" /> to create a <see cref="GalleryApplicationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryApplicationResource"/> object. </returns>
        public virtual GalleryApplicationResource GetGalleryApplicationResource(ResourceIdentifier id)
        {
            GalleryApplicationResource.ValidateResourceId(id);
            return new GalleryApplicationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GalleryApplicationVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GalleryApplicationVersionResource.CreateResourceIdentifier" /> to create a <see cref="GalleryApplicationVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GalleryApplicationVersionResource"/> object. </returns>
        public virtual GalleryApplicationVersionResource GetGalleryApplicationVersionResource(ResourceIdentifier id)
        {
            GalleryApplicationVersionResource.ValidateResourceId(id);
            return new GalleryApplicationVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SharedGalleryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SharedGalleryResource.CreateResourceIdentifier" /> to create a <see cref="SharedGalleryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGalleryResource"/> object. </returns>
        public virtual SharedGalleryResource GetSharedGalleryResource(ResourceIdentifier id)
        {
            SharedGalleryResource.ValidateResourceId(id);
            return new SharedGalleryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SharedGalleryImageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SharedGalleryImageResource.CreateResourceIdentifier" /> to create a <see cref="SharedGalleryImageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGalleryImageResource"/> object. </returns>
        public virtual SharedGalleryImageResource GetSharedGalleryImageResource(ResourceIdentifier id)
        {
            SharedGalleryImageResource.ValidateResourceId(id);
            return new SharedGalleryImageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SharedGalleryImageVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SharedGalleryImageVersionResource.CreateResourceIdentifier" /> to create a <see cref="SharedGalleryImageVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SharedGalleryImageVersionResource"/> object. </returns>
        public virtual SharedGalleryImageVersionResource GetSharedGalleryImageVersionResource(ResourceIdentifier id)
        {
            SharedGalleryImageVersionResource.ValidateResourceId(id);
            return new SharedGalleryImageVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommunityGalleryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommunityGalleryResource.CreateResourceIdentifier" /> to create a <see cref="CommunityGalleryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommunityGalleryResource"/> object. </returns>
        public virtual CommunityGalleryResource GetCommunityGalleryResource(ResourceIdentifier id)
        {
            CommunityGalleryResource.ValidateResourceId(id);
            return new CommunityGalleryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommunityGalleryImageResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommunityGalleryImageResource.CreateResourceIdentifier" /> to create a <see cref="CommunityGalleryImageResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommunityGalleryImageResource"/> object. </returns>
        public virtual CommunityGalleryImageResource GetCommunityGalleryImageResource(ResourceIdentifier id)
        {
            CommunityGalleryImageResource.ValidateResourceId(id);
            return new CommunityGalleryImageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CommunityGalleryImageVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CommunityGalleryImageVersionResource.CreateResourceIdentifier" /> to create a <see cref="CommunityGalleryImageVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CommunityGalleryImageVersionResource"/> object. </returns>
        public virtual CommunityGalleryImageVersionResource GetCommunityGalleryImageVersionResource(ResourceIdentifier id)
        {
            CommunityGalleryImageVersionResource.ValidateResourceId(id);
            return new CommunityGalleryImageVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudServiceRoleInstanceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudServiceRoleInstanceResource.CreateResourceIdentifier" /> to create a <see cref="CloudServiceRoleInstanceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudServiceRoleInstanceResource"/> object. </returns>
        public virtual CloudServiceRoleInstanceResource GetCloudServiceRoleInstanceResource(ResourceIdentifier id)
        {
            CloudServiceRoleInstanceResource.ValidateResourceId(id);
            return new CloudServiceRoleInstanceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudServiceRoleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudServiceRoleResource.CreateResourceIdentifier" /> to create a <see cref="CloudServiceRoleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudServiceRoleResource"/> object. </returns>
        public virtual CloudServiceRoleResource GetCloudServiceRoleResource(ResourceIdentifier id)
        {
            CloudServiceRoleResource.ValidateResourceId(id);
            return new CloudServiceRoleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudServiceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudServiceResource.CreateResourceIdentifier" /> to create a <see cref="CloudServiceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudServiceResource"/> object. </returns>
        public virtual CloudServiceResource GetCloudServiceResource(ResourceIdentifier id)
        {
            CloudServiceResource.ValidateResourceId(id);
            return new CloudServiceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudServiceOSVersionResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudServiceOSVersionResource.CreateResourceIdentifier" /> to create a <see cref="CloudServiceOSVersionResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudServiceOSVersionResource"/> object. </returns>
        public virtual CloudServiceOSVersionResource GetCloudServiceOSVersionResource(ResourceIdentifier id)
        {
            CloudServiceOSVersionResource.ValidateResourceId(id);
            return new CloudServiceOSVersionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CloudServiceOSFamilyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CloudServiceOSFamilyResource.CreateResourceIdentifier" /> to create a <see cref="CloudServiceOSFamilyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CloudServiceOSFamilyResource"/> object. </returns>
        public virtual CloudServiceOSFamilyResource GetCloudServiceOSFamilyResource(ResourceIdentifier id)
        {
            CloudServiceOSFamilyResource.ValidateResourceId(id);
            return new CloudServiceOSFamilyResource(Client, id);
        }
    }
}
