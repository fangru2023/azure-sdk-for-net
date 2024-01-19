// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Deployment resource properties payload. </summary>
    public partial class AppPlatformDeploymentProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformDeploymentProperties"/>. </summary>
        public AppPlatformDeploymentProperties()
        {
            Instances = new ChangeTrackingList<AppPlatformDeploymentInstance>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformDeploymentProperties"/>. </summary>
        /// <param name="source">
        /// Uploaded source information of the deployment.
        /// Please note <see cref="AppPlatformUserSourceInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppPlatformBuildResultUserSourceInfo"/>, <see cref="AppPlatformCustomContainerUserSourceInfo"/>, <see cref="JarUploadedUserSourceInfo"/>, <see cref="NetCoreZipUploadedUserSourceInfo"/>, <see cref="SourceUploadedUserSourceInfo"/> and <see cref="AppPlatformUploadedUserSourceInfo"/>.
        /// </param>
        /// <param name="deploymentSettings"> Deployment settings of the Deployment. </param>
        /// <param name="provisioningState"> Provisioning state of the Deployment. </param>
        /// <param name="status"> Status of the Deployment. </param>
        /// <param name="isActive"> Indicates whether the Deployment is active. </param>
        /// <param name="instances"> Collection of instances belong to the Deployment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformDeploymentProperties(AppPlatformUserSourceInfo source, AppPlatformDeploymentSettings deploymentSettings, AppPlatformDeploymentProvisioningState? provisioningState, AppPlatformDeploymentStatus? status, bool? isActive, IReadOnlyList<AppPlatformDeploymentInstance> instances, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Source = source;
            DeploymentSettings = deploymentSettings;
            ProvisioningState = provisioningState;
            Status = status;
            IsActive = isActive;
            Instances = instances;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Uploaded source information of the deployment.
        /// Please note <see cref="AppPlatformUserSourceInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppPlatformBuildResultUserSourceInfo"/>, <see cref="AppPlatformCustomContainerUserSourceInfo"/>, <see cref="JarUploadedUserSourceInfo"/>, <see cref="NetCoreZipUploadedUserSourceInfo"/>, <see cref="SourceUploadedUserSourceInfo"/> and <see cref="AppPlatformUploadedUserSourceInfo"/>.
        /// </summary>
        public AppPlatformUserSourceInfo Source { get; set; }
        /// <summary> Deployment settings of the Deployment. </summary>
        public AppPlatformDeploymentSettings DeploymentSettings { get; set; }
        /// <summary> Provisioning state of the Deployment. </summary>
        public AppPlatformDeploymentProvisioningState? ProvisioningState { get; }
        /// <summary> Status of the Deployment. </summary>
        public AppPlatformDeploymentStatus? Status { get; }
        /// <summary> Indicates whether the Deployment is active. </summary>
        public bool? IsActive { get; set; }
        /// <summary> Collection of instances belong to the Deployment. </summary>
        public IReadOnlyList<AppPlatformDeploymentInstance> Instances { get; }
    }
}
