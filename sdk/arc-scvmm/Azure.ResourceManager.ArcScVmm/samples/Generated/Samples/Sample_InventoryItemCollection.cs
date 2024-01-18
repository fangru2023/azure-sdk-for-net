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
using Azure.ResourceManager.ArcScVmm;
using Azure.ResourceManager.ArcScVmm.Models;

namespace Azure.ResourceManager.ArcScVmm.Samples
{
    public partial class Sample_InventoryItemCollection
    {
        // CreateInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateInventoryItem()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/CreateInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmServerResource created on azure
            // for more information of creating ScVmmServerResource, please refer to the document of ScVmmServerResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vmmServerName = "ContosoVMMServer";
            ResourceIdentifier scVmmServerResourceId = ScVmmServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmmServerName);
            ScVmmServerResource scVmmServer = client.GetScVmmServerResource(scVmmServerResourceId);

            // get the collection of this InventoryItemResource
            InventoryItemCollection collection = scVmmServer.GetInventoryItems();

            // invoke the operation
            string inventoryItemName = "12345678-1234-1234-1234-123456789abc";
            InventoryItemData data = new InventoryItemData(new CloudInventoryItem());
            ArmOperation<InventoryItemResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, inventoryItemName, data);
            InventoryItemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InventoryItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInventoryItem()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/GetInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmServerResource created on azure
            // for more information of creating ScVmmServerResource, please refer to the document of ScVmmServerResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vmmServerName = "ContosoVMMServer";
            ResourceIdentifier scVmmServerResourceId = ScVmmServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmmServerName);
            ScVmmServerResource scVmmServer = client.GetScVmmServerResource(scVmmServerResourceId);

            // get the collection of this InventoryItemResource
            InventoryItemCollection collection = scVmmServer.GetInventoryItems();

            // invoke the operation
            string inventoryItemName = "12345678-1234-1234-1234-123456789abc";
            InventoryItemResource result = await collection.GetAsync(inventoryItemName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InventoryItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetInventoryItem()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/GetInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmServerResource created on azure
            // for more information of creating ScVmmServerResource, please refer to the document of ScVmmServerResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vmmServerName = "ContosoVMMServer";
            ResourceIdentifier scVmmServerResourceId = ScVmmServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmmServerName);
            ScVmmServerResource scVmmServer = client.GetScVmmServerResource(scVmmServerResourceId);

            // get the collection of this InventoryItemResource
            InventoryItemCollection collection = scVmmServer.GetInventoryItems();

            // invoke the operation
            string inventoryItemName = "12345678-1234-1234-1234-123456789abc";
            bool result = await collection.ExistsAsync(inventoryItemName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetInventoryItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetInventoryItem()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/GetInventoryItem.json
            // this example is just showing the usage of "InventoryItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmServerResource created on azure
            // for more information of creating ScVmmServerResource, please refer to the document of ScVmmServerResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vmmServerName = "ContosoVMMServer";
            ResourceIdentifier scVmmServerResourceId = ScVmmServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmmServerName);
            ScVmmServerResource scVmmServer = client.GetScVmmServerResource(scVmmServerResourceId);

            // get the collection of this InventoryItemResource
            InventoryItemCollection collection = scVmmServer.GetInventoryItems();

            // invoke the operation
            string inventoryItemName = "12345678-1234-1234-1234-123456789abc";
            NullableResponse<InventoryItemResource> response = await collection.GetIfExistsAsync(inventoryItemName);
            InventoryItemResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InventoryItemData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // InventoryItemsListByVMMServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_InventoryItemsListByVMMServer()
        {
            // Generated from example definition: specification/scvmm/resource-manager/Microsoft.ScVmm/preview/2020-06-05-preview/examples/ListInventoryItemsByVMMServer.json
            // this example is just showing the usage of "InventoryItems_ListByVMMServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScVmmServerResource created on azure
            // for more information of creating ScVmmServerResource, please refer to the document of ScVmmServerResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string vmmServerName = "ContosoVMMServer";
            ResourceIdentifier scVmmServerResourceId = ScVmmServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmmServerName);
            ScVmmServerResource scVmmServer = client.GetScVmmServerResource(scVmmServerResourceId);

            // get the collection of this InventoryItemResource
            InventoryItemCollection collection = scVmmServer.GetInventoryItems();

            // invoke the operation and iterate over the result
            await foreach (InventoryItemResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InventoryItemData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
