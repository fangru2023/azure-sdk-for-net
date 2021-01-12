// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Pool in the Azure Batch service to add.
    /// </summary>
    public partial class PoolAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolAddParameter class.
        /// </summary>
        public PoolAddParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolAddParameter class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the Pool within
        /// the Account.</param>
        /// <param name="vmSize">The size of virtual machines in the Pool. All
        /// virtual machines in a Pool are the same size.</param>
        /// <param name="displayName">The display name for the Pool.</param>
        /// <param name="cloudServiceConfiguration">The cloud service
        /// configuration for the Pool.</param>
        /// <param name="virtualMachineConfiguration">The virtual machine
        /// configuration for the Pool.</param>
        /// <param name="resizeTimeout">The timeout for allocation of Compute
        /// Nodes to the Pool.</param>
        /// <param name="targetDedicatedNodes">The desired number of dedicated
        /// Compute Nodes in the Pool.</param>
        /// <param name="targetLowPriorityNodes">The desired number of low
        /// priority Compute Nodes in the Pool.</param>
        /// <param name="enableAutoScale">Whether the Pool size should
        /// automatically adjust over time.</param>
        /// <param name="autoScaleFormula">A formula for the desired number of
        /// Compute Nodes in the Pool.</param>
        /// <param name="autoScaleEvaluationInterval">The time interval at
        /// which to automatically adjust the Pool size according to the
        /// autoscale formula.</param>
        /// <param name="enableInterNodeCommunication">Whether the Pool permits
        /// direct communication between Compute Nodes.</param>
        /// <param name="networkConfiguration">The network configuration for
        /// the Pool.</param>
        /// <param name="startTask">A Task specified to run on each Compute
        /// Node as it joins the Pool.</param>
        /// <param name="certificateReferences">The list of Certificates to be
        /// installed on each Compute Node in the Pool.</param>
        /// <param name="applicationPackageReferences">The list of Packages to
        /// be installed on each Compute Node in the Pool.</param>
        /// <param name="applicationLicenses">The list of application licenses
        /// the Batch service will make available on each Compute Node in the
        /// Pool.</param>
        /// <param name="taskSlotsPerNode">The number of task slots that can be
        /// used to run concurrent tasks on a single compute node in the
        /// pool.</param>
        /// <param name="taskSchedulingPolicy">How Tasks are distributed across
        /// Compute Nodes in a Pool.</param>
        /// <param name="userAccounts">The list of user Accounts to be created
        /// on each Compute Node in the Pool.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the Pool as metadata.</param>
        /// <param name="mountConfiguration">Mount storage using specified file
        /// system for the entire lifetime of the pool.</param>
        public PoolAddParameter(string id, string vmSize, string displayName = default(string), CloudServiceConfiguration cloudServiceConfiguration = default(CloudServiceConfiguration), VirtualMachineConfiguration virtualMachineConfiguration = default(VirtualMachineConfiguration), System.TimeSpan? resizeTimeout = default(System.TimeSpan?), int? targetDedicatedNodes = default(int?), int? targetLowPriorityNodes = default(int?), bool? enableAutoScale = default(bool?), string autoScaleFormula = default(string), System.TimeSpan? autoScaleEvaluationInterval = default(System.TimeSpan?), bool? enableInterNodeCommunication = default(bool?), NetworkConfiguration networkConfiguration = default(NetworkConfiguration), StartTask startTask = default(StartTask), IList<CertificateReference> certificateReferences = default(IList<CertificateReference>), IList<ApplicationPackageReference> applicationPackageReferences = default(IList<ApplicationPackageReference>), IList<string> applicationLicenses = default(IList<string>), int? taskSlotsPerNode = default(int?), TaskSchedulingPolicy taskSchedulingPolicy = default(TaskSchedulingPolicy), IList<UserAccount> userAccounts = default(IList<UserAccount>), IList<MetadataItem> metadata = default(IList<MetadataItem>), IList<MountConfiguration> mountConfiguration = default(IList<MountConfiguration>))
        {
            Id = id;
            DisplayName = displayName;
            VmSize = vmSize;
            CloudServiceConfiguration = cloudServiceConfiguration;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            ResizeTimeout = resizeTimeout;
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            EnableAutoScale = enableAutoScale;
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
            EnableInterNodeCommunication = enableInterNodeCommunication;
            NetworkConfiguration = networkConfiguration;
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            ApplicationLicenses = applicationLicenses;
            TaskSlotsPerNode = taskSlotsPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            UserAccounts = userAccounts;
            Metadata = metadata;
            MountConfiguration = mountConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the Pool within the
        /// Account.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than 64
        /// characters. The ID is case-preserving and case-insensitive (that
        /// is, you may not have two Pool IDs within an Account that differ
        /// only by case).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the Pool.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the size of virtual machines in the Pool. All virtual
        /// machines in a Pool are the same size.
        /// </summary>
        /// <remarks>
        /// For information about available sizes of virtual machines for Cloud
        /// Services Pools (pools created with cloudServiceConfiguration), see
        /// Sizes for Cloud Services
        /// (https://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/).
        /// Batch supports all Cloud Services VM sizes except ExtraSmall, A1V2
        /// and A2V2. For information about available VM sizes for Pools using
        /// Images from the Virtual Machines Marketplace (pools created with
        /// virtualMachineConfiguration) see Sizes for Virtual Machines (Linux)
        /// (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/)
        /// or Sizes for Virtual Machines (Windows)
        /// (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/).
        /// Batch supports all Azure VM sizes except STANDARD_A0 and those with
        /// premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2
        /// series).
        /// </remarks>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the cloud service configuration for the Pool.
        /// </summary>
        /// <remarks>
        /// This property and virtualMachineConfiguration are mutually
        /// exclusive and one of the properties must be specified. This
        /// property cannot be specified if the Batch Account was created with
        /// its poolAllocationMode property set to 'UserSubscription'.
        /// </remarks>
        [JsonProperty(PropertyName = "cloudServiceConfiguration")]
        public CloudServiceConfiguration CloudServiceConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine configuration for the Pool.
        /// </summary>
        /// <remarks>
        /// This property and cloudServiceConfiguration are mutually exclusive
        /// and one of the properties must be specified.
        /// </remarks>
        [JsonProperty(PropertyName = "virtualMachineConfiguration")]
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the timeout for allocation of Compute Nodes to the
        /// Pool.
        /// </summary>
        /// <remarks>
        /// This timeout applies only to manual scaling; it has no effect when
        /// enableAutoScale is set to true. The default value is 15 minutes.
        /// The minimum value is 5 minutes. If you specify a value less than 5
        /// minutes, the Batch service returns an error; if you are calling the
        /// REST API directly, the HTTP status code is 400 (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public System.TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets the desired number of dedicated Compute Nodes in the
        /// Pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// true. If enableAutoScale is set to false, then you must set either
        /// targetDedicatedNodes, targetLowPriorityNodes, or both.
        /// </remarks>
        [JsonProperty(PropertyName = "targetDedicatedNodes")]
        public int? TargetDedicatedNodes { get; set; }

        /// <summary>
        /// Gets or sets the desired number of low priority Compute Nodes in
        /// the Pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// true. If enableAutoScale is set to false, then you must set either
        /// targetDedicatedNodes, targetLowPriorityNodes, or both.
        /// </remarks>
        [JsonProperty(PropertyName = "targetLowPriorityNodes")]
        public int? TargetLowPriorityNodes { get; set; }

        /// <summary>
        /// Gets or sets whether the Pool size should automatically adjust over
        /// time.
        /// </summary>
        /// <remarks>
        /// If false, at least one of targetDedicatedNodes and
        /// targetLowPriorityNodes must be specified. If true, the
        /// autoScaleFormula property is required and the Pool automatically
        /// resizes according to the formula. The default value is false.
        /// </remarks>
        [JsonProperty(PropertyName = "enableAutoScale")]
        public bool? EnableAutoScale { get; set; }

        /// <summary>
        /// Gets or sets a formula for the desired number of Compute Nodes in
        /// the Pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// false. It is required if enableAutoScale is set to true. The
        /// formula is checked for validity before the Pool is created. If the
        /// formula is not valid, the Batch service rejects the request with
        /// detailed error information. For more information about specifying
        /// this formula, see 'Automatically scale Compute Nodes in an Azure
        /// Batch Pool'
        /// (https://azure.microsoft.com/documentation/articles/batch-automatic-scaling/).
        /// </remarks>
        [JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Gets or sets the time interval at which to automatically adjust the
        /// Pool size according to the autoscale formula.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. The minimum and maximum value are
        /// 5 minutes and 168 hours respectively. If you specify a value less
        /// than 5 minutes or greater than 168 hours, the Batch service returns
        /// an error; if you are calling the REST API directly, the HTTP status
        /// code is 400 (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "autoScaleEvaluationInterval")]
        public System.TimeSpan? AutoScaleEvaluationInterval { get; set; }

        /// <summary>
        /// Gets or sets whether the Pool permits direct communication between
        /// Compute Nodes.
        /// </summary>
        /// <remarks>
        /// Enabling inter-node communication limits the maximum size of the
        /// Pool due to deployment restrictions on the Compute Nodes of the
        /// Pool. This may result in the Pool not reaching its desired size.
        /// The default value is false.
        /// </remarks>
        [JsonProperty(PropertyName = "enableInterNodeCommunication")]
        public bool? EnableInterNodeCommunication { get; set; }

        /// <summary>
        /// Gets or sets the network configuration for the Pool.
        /// </summary>
        [JsonProperty(PropertyName = "networkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a Task specified to run on each Compute Node as it
        /// joins the Pool.
        /// </summary>
        /// <remarks>
        /// The Task runs when the Compute Node is added to the Pool or when
        /// the Compute Node is restarted.
        /// </remarks>
        [JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets the list of Certificates to be installed on each
        /// Compute Node in the Pool.
        /// </summary>
        /// <remarks>
        /// For Windows Nodes, the Batch service installs the Certificates to
        /// the specified Certificate store and location. For Linux Compute
        /// Nodes, the Certificates are stored in a directory inside the Task
        /// working directory and an environment variable
        /// AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this
        /// location. For Certificates with visibility of 'remoteUser', a
        /// 'certs' directory is created in the user's home directory (e.g.,
        /// /home/{user-name}/certs) and Certificates are placed in that
        /// directory.
        /// </remarks>
        [JsonProperty(PropertyName = "certificateReferences")]
        public IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of Packages to be installed on each Compute
        /// Node in the Pool.
        /// </summary>
        /// <remarks>
        /// Changes to Package references affect all new Nodes joining the
        /// Pool, but do not affect Compute Nodes that are already in the Pool
        /// until they are rebooted or reimaged. There is a maximum of 10
        /// Package references on any given Pool.
        /// </remarks>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of application licenses the Batch service
        /// will make available on each Compute Node in the Pool.
        /// </summary>
        /// <remarks>
        /// The list of application licenses must be a subset of available
        /// Batch service application licenses. If a license is requested which
        /// is not supported, Pool creation will fail.
        /// </remarks>
        [JsonProperty(PropertyName = "applicationLicenses")]
        public IList<string> ApplicationLicenses { get; set; }

        /// <summary>
        /// Gets or sets the number of task slots that can be used to run
        /// concurrent tasks on a single compute node in the pool.
        /// </summary>
        /// <remarks>
        /// The default value is 1. The maximum value is the smaller of 4 times
        /// the number of cores of the vmSize of the pool or 256.
        /// </remarks>
        [JsonProperty(PropertyName = "taskSlotsPerNode")]
        public int? TaskSlotsPerNode { get; set; }

        /// <summary>
        /// Gets or sets how Tasks are distributed across Compute Nodes in a
        /// Pool.
        /// </summary>
        /// <remarks>
        /// If not specified, the default is spread.
        /// </remarks>
        [JsonProperty(PropertyName = "taskSchedulingPolicy")]
        public TaskSchedulingPolicy TaskSchedulingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the list of user Accounts to be created on each
        /// Compute Node in the Pool.
        /// </summary>
        [JsonProperty(PropertyName = "userAccounts")]
        public IList<UserAccount> UserAccounts { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the Pool as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets mount storage using specified file system for the
        /// entire lifetime of the pool.
        /// </summary>
        /// <remarks>
        /// Mount the storage using Azure fileshare, NFS, CIFS or Blobfuse
        /// based file system.
        /// </remarks>
        [JsonProperty(PropertyName = "mountConfiguration")]
        public IList<MountConfiguration> MountConfiguration { get; set; }

    }
}
