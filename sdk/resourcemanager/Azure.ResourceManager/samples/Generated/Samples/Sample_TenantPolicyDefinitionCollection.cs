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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_TenantPolicyDefinitionCollection
    {
        // Retrieve a built-in policy definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RetrieveABuiltInPolicyDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/getBuiltinPolicyDefinition.json
            // this example is just showing the usage of "PolicyDefinitions_GetBuiltIn" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenant = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantPolicyDefinitionResource
            TenantPolicyDefinitionCollection collection = tenant.GetTenantPolicyDefinitions();

            // invoke the operation
            string policyDefinitionName = "7433c107-6db4-4ad1-b57a-a76dce0154a1";
            TenantPolicyDefinitionResource result = await collection.GetAsync(policyDefinitionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PolicyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Retrieve a built-in policy definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RetrieveABuiltInPolicyDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/getBuiltinPolicyDefinition.json
            // this example is just showing the usage of "PolicyDefinitions_GetBuiltIn" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenant = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantPolicyDefinitionResource
            TenantPolicyDefinitionCollection collection = tenant.GetTenantPolicyDefinitions();

            // invoke the operation
            string policyDefinitionName = "7433c107-6db4-4ad1-b57a-a76dce0154a1";
            bool result = await collection.ExistsAsync(policyDefinitionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Retrieve a built-in policy definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_RetrieveABuiltInPolicyDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/getBuiltinPolicyDefinition.json
            // this example is just showing the usage of "PolicyDefinitions_GetBuiltIn" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenant = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantPolicyDefinitionResource
            TenantPolicyDefinitionCollection collection = tenant.GetTenantPolicyDefinitions();

            // invoke the operation
            string policyDefinitionName = "7433c107-6db4-4ad1-b57a-a76dce0154a1";
            NullableResponse<TenantPolicyDefinitionResource> response = await collection.GetIfExistsAsync(policyDefinitionName);
            TenantPolicyDefinitionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyDefinitionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List built-in policy definitions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListBuiltInPolicyDefinitions()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Authorization/stable/2021-06-01/examples/listBuiltInPolicyDefinitions.json
            // this example is just showing the usage of "PolicyDefinitions_ListBuiltIn" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenant = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantPolicyDefinitionResource
            TenantPolicyDefinitionCollection collection = tenant.GetTenantPolicyDefinitions();

            // invoke the operation and iterate over the result
            await foreach (TenantPolicyDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PolicyDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
