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
using Azure.ResourceManager.Synapse;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseAttachedDatabaseConfigurationCollection
    {
        // KustoPoolAttachedDatabaseConfigurationsListByKustoPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_KustoPoolAttachedDatabaseConfigurationsListByKustoPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolAttachedDatabaseConfigurationsListByKustoPool.json
            // this example is just showing the usage of "KustoPoolAttachedDatabaseConfigurations_ListByKustoPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // get the collection of this SynapseAttachedDatabaseConfigurationResource
            SynapseAttachedDatabaseConfigurationCollection collection = synapseKustoPool.GetSynapseAttachedDatabaseConfigurations();

            // invoke the operation and iterate over the result
            await foreach (SynapseAttachedDatabaseConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseAttachedDatabaseConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // KustoPoolAttachedDatabaseConfigurationsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KustoPoolAttachedDatabaseConfigurationsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolAttachedDatabaseConfigurationsGet.json
            // this example is just showing the usage of "KustoPoolAttachedDatabaseConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // get the collection of this SynapseAttachedDatabaseConfigurationResource
            SynapseAttachedDatabaseConfigurationCollection collection = synapseKustoPool.GetSynapseAttachedDatabaseConfigurations();

            // invoke the operation
            string attachedDatabaseConfigurationName = "attachedDatabaseConfigurations1";
            SynapseAttachedDatabaseConfigurationResource result = await collection.GetAsync(attachedDatabaseConfigurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseAttachedDatabaseConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoPoolAttachedDatabaseConfigurationsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_KustoPoolAttachedDatabaseConfigurationsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolAttachedDatabaseConfigurationsGet.json
            // this example is just showing the usage of "KustoPoolAttachedDatabaseConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // get the collection of this SynapseAttachedDatabaseConfigurationResource
            SynapseAttachedDatabaseConfigurationCollection collection = synapseKustoPool.GetSynapseAttachedDatabaseConfigurations();

            // invoke the operation
            string attachedDatabaseConfigurationName = "attachedDatabaseConfigurations1";
            bool result = await collection.ExistsAsync(attachedDatabaseConfigurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // KustoPoolAttachedDatabaseConfigurationsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_KustoPoolAttachedDatabaseConfigurationsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolAttachedDatabaseConfigurationsGet.json
            // this example is just showing the usage of "KustoPoolAttachedDatabaseConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // get the collection of this SynapseAttachedDatabaseConfigurationResource
            SynapseAttachedDatabaseConfigurationCollection collection = synapseKustoPool.GetSynapseAttachedDatabaseConfigurations();

            // invoke the operation
            string attachedDatabaseConfigurationName = "attachedDatabaseConfigurations1";
            NullableResponse<SynapseAttachedDatabaseConfigurationResource> response = await collection.GetIfExistsAsync(attachedDatabaseConfigurationName);
            SynapseAttachedDatabaseConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseAttachedDatabaseConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // KustoPoolAttachedDatabaseConfigurationsCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_KustoPoolAttachedDatabaseConfigurationsCreateOrUpdate()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolAttachedDatabaseConfigurationsCreateOrUpdate.json
            // this example is just showing the usage of "KustoPoolAttachedDatabaseConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseKustoPoolResource created on azure
            // for more information of creating SynapseKustoPoolResource, please refer to the document of SynapseKustoPoolResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "kustorptest";
            string kustoPoolName = "kustoclusterrptest4";
            ResourceIdentifier synapseKustoPoolResourceId = SynapseKustoPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName);
            SynapseKustoPoolResource synapseKustoPool = client.GetSynapseKustoPoolResource(synapseKustoPoolResourceId);

            // get the collection of this SynapseAttachedDatabaseConfigurationResource
            SynapseAttachedDatabaseConfigurationCollection collection = synapseKustoPool.GetSynapseAttachedDatabaseConfigurations();

            // invoke the operation
            string attachedDatabaseConfigurationName = "attachedDatabaseConfigurations1";
            SynapseAttachedDatabaseConfigurationData data = new SynapseAttachedDatabaseConfigurationData()
            {
                Location = new AzureLocation("westus"),
                DatabaseName = "kustodatabase",
                KustoPoolResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.Synapse/Workspaces/kustorptest/KustoPools/kustoclusterrptest4"),
                DefaultPrincipalsModificationKind = SynapseDefaultPrincipalsModificationKind.Union,
                TableLevelSharingProperties = new SynapseTableLevelSharingProperties()
                {
                    TablesToInclude =
{
"Table1"
},
                    TablesToExclude =
{
"Table2"
},
                    ExternalTablesToInclude =
{
"ExternalTable1"
},
                    ExternalTablesToExclude =
{
"ExternalTable2"
},
                    MaterializedViewsToInclude =
{
"MaterializedViewTable1"
},
                    MaterializedViewsToExclude =
{
"MaterializedViewTable2"
},
                },
            };
            ArmOperation<SynapseAttachedDatabaseConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, attachedDatabaseConfigurationName, data);
            SynapseAttachedDatabaseConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseAttachedDatabaseConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
