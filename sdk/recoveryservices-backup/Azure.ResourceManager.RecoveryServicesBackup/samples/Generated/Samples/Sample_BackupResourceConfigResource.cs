// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesBackup;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Samples
{
    public partial class Sample_BackupResourceConfigResource
    {
        // Get Vault Storage Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVaultStorageConfiguration()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/Common/BackupStorageConfig_Get.json
            // this example is just showing the usage of "BackupResourceStorageConfigsNonCRR_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupResourceConfigResource created on azure
            // for more information of creating BackupResourceConfigResource, please refer to the document of BackupResourceConfigResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "PythonSDKBackupTestRg";
            string vaultName = "PySDKBackupTestRsVault";
            ResourceIdentifier backupResourceConfigResourceId = BackupResourceConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            BackupResourceConfigResource backupResourceConfig = client.GetBackupResourceConfigResource(backupResourceConfigResourceId);

            // invoke the operation
            BackupResourceConfigResource result = await backupResourceConfig.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupResourceConfigData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Vault Storage Configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVaultStorageConfiguration()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/Common/BackupStorageConfig_Patch.json
            // this example is just showing the usage of "BackupResourceStorageConfigsNonCRR_patch" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupResourceConfigResource created on azure
            // for more information of creating BackupResourceConfigResource, please refer to the document of BackupResourceConfigResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "PythonSDKBackupTestRg";
            string vaultName = "PySDKBackupTestRsVault";
            ResourceIdentifier backupResourceConfigResourceId = BackupResourceConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            BackupResourceConfigResource backupResourceConfig = client.GetBackupResourceConfigResource(backupResourceConfigResourceId);

            // invoke the operation
            BackupResourceConfigData data = new BackupResourceConfigData(new AzureLocation("placeholder"))
            {
                Properties = new BackupResourceConfigProperties()
                {
                    StorageType = BackupStorageType.LocallyRedundant,
                    StorageTypeState = BackupStorageTypeState.Unlocked,
                },
            };
            BackupResourceConfigResource result = await backupResourceConfig.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupResourceConfigData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Prepare Data Move
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PrepareDataMove_PrepareDataMove()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/BackupDataMove/PrepareDataMove_Post.json
            // this example is just showing the usage of "BMSPrepareDataMove" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupResourceConfigResource created on azure
            // for more information of creating BackupResourceConfigResource, please refer to the document of BackupResourceConfigResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sourceRG";
            string vaultName = "source-rsv";
            ResourceIdentifier backupResourceConfigResourceId = BackupResourceConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            BackupResourceConfigResource backupResourceConfig = client.GetBackupResourceConfigResource(backupResourceConfigResourceId);

            // invoke the operation
            PrepareDataMoveContent content = new PrepareDataMoveContent(new ResourceIdentifier("/subscriptions/04cf684a-d41f-4550-9f70-7708a3a2283b/resourceGroups/targetRG/providers/Microsoft.RecoveryServices/vaults/target-rsv"), new AzureLocation("USGov Virginia"), DataMoveLevel.Vault);
            await backupResourceConfig.PrepareDataMoveAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }

        // Trigger Data Move
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task TriggerDataMove_TriggerDataMove()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/BackupDataMove/TriggerDataMove_Post.json
            // this example is just showing the usage of "BMSTriggerDataMove" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupResourceConfigResource created on azure
            // for more information of creating BackupResourceConfigResource, please refer to the document of BackupResourceConfigResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "targetRG";
            string vaultName = "target-rsv";
            ResourceIdentifier backupResourceConfigResourceId = BackupResourceConfigResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            BackupResourceConfigResource backupResourceConfig = client.GetBackupResourceConfigResource(backupResourceConfigResourceId);

            // invoke the operation
            TriggerDataMoveContent content = new TriggerDataMoveContent(new ResourceIdentifier("/subscriptions/04cf684a-d41f-4550-9f70-7708a3a2283b/resourceGroups/sourceRG/providers/Microsoft.RecoveryServices/vaults/source-rsv"), new AzureLocation("USGov Iowa"), DataMoveLevel.Vault, "MTg2OTcyMzM4NzYyMjc1NDY3Nzs1YmUzYmVmNi04YjJiLTRhOTItOTllYi01NTM0MDllYjk2NjE=");
            await backupResourceConfig.TriggerDataMoveAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }
    }
}
