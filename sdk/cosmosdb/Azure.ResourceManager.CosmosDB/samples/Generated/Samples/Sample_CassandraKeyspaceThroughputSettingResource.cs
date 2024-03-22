// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CassandraKeyspaceThroughputSettingResource
    {
        // CosmosDBCassandraKeyspaceThroughputGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBCassandraKeyspaceThroughputGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBCassandraKeyspaceThroughputGet.json
            // this example is just showing the usage of "CassandraResources_GetCassandraKeyspaceThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraKeyspaceThroughputSettingResource created on azure
            // for more information of creating CassandraKeyspaceThroughputSettingResource, please refer to the document of CassandraKeyspaceThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspaceName";
            ResourceIdentifier cassandraKeyspaceThroughputSettingResourceId = CassandraKeyspaceThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName);
            CassandraKeyspaceThroughputSettingResource cassandraKeyspaceThroughputSetting = client.GetCassandraKeyspaceThroughputSettingResource(cassandraKeyspaceThroughputSettingResourceId);

            // invoke the operation
            CassandraKeyspaceThroughputSettingResource result = await cassandraKeyspaceThroughputSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraKeyspaceThroughputUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CosmosDBCassandraKeyspaceThroughputUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBCassandraKeyspaceThroughputUpdate.json
            // this example is just showing the usage of "CassandraResources_UpdateCassandraKeyspaceThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraKeyspaceThroughputSettingResource created on azure
            // for more information of creating CassandraKeyspaceThroughputSettingResource, please refer to the document of CassandraKeyspaceThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspaceName";
            ResourceIdentifier cassandraKeyspaceThroughputSettingResourceId = CassandraKeyspaceThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName);
            CassandraKeyspaceThroughputSettingResource cassandraKeyspaceThroughputSetting = client.GetCassandraKeyspaceThroughputSettingResource(cassandraKeyspaceThroughputSettingResourceId);

            // invoke the operation
            ThroughputSettingsUpdateData data = new ThroughputSettingsUpdateData(new AzureLocation("West US"), new ThroughputSettingsResourceInfo()
            {
                Throughput = 400,
            })
            {
                Tags =
{
},
            };
            ArmOperation<CassandraKeyspaceThroughputSettingResource> lro = await cassandraKeyspaceThroughputSetting.CreateOrUpdateAsync(WaitUntil.Completed, data);
            CassandraKeyspaceThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraKeyspaceMigrateToAutoscale
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateCassandraKeyspaceToAutoscale_CosmosDBCassandraKeyspaceMigrateToAutoscale()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBCassandraKeyspaceMigrateToAutoscale.json
            // this example is just showing the usage of "CassandraResources_MigrateCassandraKeyspaceToAutoscale" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraKeyspaceThroughputSettingResource created on azure
            // for more information of creating CassandraKeyspaceThroughputSettingResource, please refer to the document of CassandraKeyspaceThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspaceName";
            ResourceIdentifier cassandraKeyspaceThroughputSettingResourceId = CassandraKeyspaceThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName);
            CassandraKeyspaceThroughputSettingResource cassandraKeyspaceThroughputSetting = client.GetCassandraKeyspaceThroughputSettingResource(cassandraKeyspaceThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CassandraKeyspaceThroughputSettingResource> lro = await cassandraKeyspaceThroughputSetting.MigrateCassandraKeyspaceToAutoscaleAsync(WaitUntil.Completed);
            CassandraKeyspaceThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBCassandraKeyspaceMigrateToManualThroughput
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateCassandraKeyspaceToManualThroughput_CosmosDBCassandraKeyspaceMigrateToManualThroughput()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-02-15-preview/examples/CosmosDBCassandraKeyspaceMigrateToManualThroughput.json
            // this example is just showing the usage of "CassandraResources_MigrateCassandraKeyspaceToManualThroughput" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CassandraKeyspaceThroughputSettingResource created on azure
            // for more information of creating CassandraKeyspaceThroughputSettingResource, please refer to the document of CassandraKeyspaceThroughputSettingResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string keyspaceName = "keyspaceName";
            ResourceIdentifier cassandraKeyspaceThroughputSettingResourceId = CassandraKeyspaceThroughputSettingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, keyspaceName);
            CassandraKeyspaceThroughputSettingResource cassandraKeyspaceThroughputSetting = client.GetCassandraKeyspaceThroughputSettingResource(cassandraKeyspaceThroughputSettingResourceId);

            // invoke the operation
            ArmOperation<CassandraKeyspaceThroughputSettingResource> lro = await cassandraKeyspaceThroughputSetting.MigrateCassandraKeyspaceToManualThroughputAsync(WaitUntil.Completed);
            CassandraKeyspaceThroughputSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ThroughputSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
