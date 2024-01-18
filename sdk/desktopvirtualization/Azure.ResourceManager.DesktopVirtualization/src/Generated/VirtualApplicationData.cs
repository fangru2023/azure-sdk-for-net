// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing the VirtualApplication data model.
    /// Schema for Application properties.
    /// </summary>
    public partial class VirtualApplicationData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualApplicationData"/>. </summary>
        /// <param name="commandLineSetting"> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </param>
        public VirtualApplicationData(VirtualApplicationCommandLineSetting commandLineSetting)
        {
            CommandLineSetting = commandLineSetting;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualApplicationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="objectId"> ObjectId of Application. (internal use). </param>
        /// <param name="description"> Description of Application. </param>
        /// <param name="friendlyName"> Friendly name of Application. </param>
        /// <param name="filePath"> Specifies a path for the executable file for the application. </param>
        /// <param name="msixPackageFamilyName"> Specifies the package family name for MSIX applications. </param>
        /// <param name="msixPackageApplicationId"> Specifies the package application Id for MSIX applications. </param>
        /// <param name="applicationType"> Resource Type of Application. </param>
        /// <param name="commandLineSetting"> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </param>
        /// <param name="commandLineArguments"> Command Line Arguments for Application. </param>
        /// <param name="showInPortal"> Specifies whether to show the RemoteApp program in the RD Web Access server. </param>
        /// <param name="iconPath"> Path to icon. </param>
        /// <param name="iconIndex"> Index of the icon. </param>
        /// <param name="iconHash"> Hash of the icon. </param>
        /// <param name="iconContent"> the icon a 64 bit string as a byte array. </param>
        internal VirtualApplicationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string objectId, string description, string friendlyName, string filePath, string msixPackageFamilyName, string msixPackageApplicationId, RemoteApplicationType? applicationType, VirtualApplicationCommandLineSetting commandLineSetting, string commandLineArguments, bool? showInPortal, string iconPath, int? iconIndex, string iconHash, BinaryData iconContent) : base(id, name, resourceType, systemData)
        {
            ObjectId = objectId;
            Description = description;
            FriendlyName = friendlyName;
            FilePath = filePath;
            MsixPackageFamilyName = msixPackageFamilyName;
            MsixPackageApplicationId = msixPackageApplicationId;
            ApplicationType = applicationType;
            CommandLineSetting = commandLineSetting;
            CommandLineArguments = commandLineArguments;
            ShowInPortal = showInPortal;
            IconPath = iconPath;
            IconIndex = iconIndex;
            IconHash = iconHash;
            IconContent = iconContent;
        }

        /// <summary> ObjectId of Application. (internal use). </summary>
        public string ObjectId { get; }
        /// <summary> Description of Application. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of Application. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Specifies a path for the executable file for the application. </summary>
        public string FilePath { get; set; }
        /// <summary> Specifies the package family name for MSIX applications. </summary>
        public string MsixPackageFamilyName { get; set; }
        /// <summary> Specifies the package application Id for MSIX applications. </summary>
        public string MsixPackageApplicationId { get; set; }
        /// <summary> Resource Type of Application. </summary>
        public RemoteApplicationType? ApplicationType { get; set; }
        /// <summary> Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all. </summary>
        public VirtualApplicationCommandLineSetting CommandLineSetting { get; set; }
        /// <summary> Command Line Arguments for Application. </summary>
        public string CommandLineArguments { get; set; }
        /// <summary> Specifies whether to show the RemoteApp program in the RD Web Access server. </summary>
        public bool? ShowInPortal { get; set; }
        /// <summary> Path to icon. </summary>
        public string IconPath { get; set; }
        /// <summary> Index of the icon. </summary>
        public int? IconIndex { get; set; }
        /// <summary> Hash of the icon. </summary>
        public string IconHash { get; }
        /// <summary>
        /// the icon a 64 bit string as a byte array.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData IconContent { get; }
    }
}
