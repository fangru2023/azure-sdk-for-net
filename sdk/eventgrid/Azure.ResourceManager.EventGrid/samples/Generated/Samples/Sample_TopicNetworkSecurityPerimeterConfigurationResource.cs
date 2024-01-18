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
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_TopicNetworkSecurityPerimeterConfigurationResource
    {
        // NetworkSecurityPerimeterConfigurations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkSecurityPerimeterConfigurationsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/NetworkSecurityPerimeterConfigurations_Get.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicNetworkSecurityPerimeterConfigurationResource created on azure
            // for more information of creating TopicNetworkSecurityPerimeterConfigurationResource, please refer to the document of TopicNetworkSecurityPerimeterConfigurationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string resourceName = "exampleResourceName";
            string perimeterGuid = "8f6b6269-84f2-4d09-9e31-1127efcd1e40perimeter";
            string associationName = "someAssociation";
            ResourceIdentifier topicNetworkSecurityPerimeterConfigurationResourceId = TopicNetworkSecurityPerimeterConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, perimeterGuid, associationName);
            TopicNetworkSecurityPerimeterConfigurationResource topicNetworkSecurityPerimeterConfiguration = client.GetTopicNetworkSecurityPerimeterConfigurationResource(topicNetworkSecurityPerimeterConfigurationResourceId);

            // invoke the operation
            TopicNetworkSecurityPerimeterConfigurationResource result = await topicNetworkSecurityPerimeterConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkSecurityPerimeterConfigurations_Reconcile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Reconcile_NetworkSecurityPerimeterConfigurationsReconcile()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/NetworkSecurityPerimeterConfigurations_Reconcile.json
            // this example is just showing the usage of "NetworkSecurityPerimeterConfigurations_Reconcile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TopicNetworkSecurityPerimeterConfigurationResource created on azure
            // for more information of creating TopicNetworkSecurityPerimeterConfigurationResource, please refer to the document of TopicNetworkSecurityPerimeterConfigurationResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string resourceName = "exampleResourceName";
            string perimeterGuid = "8f6b6269-84f2-4d09-9e31-1127efcd1e40perimeter";
            string associationName = "someAssociation";
            ResourceIdentifier topicNetworkSecurityPerimeterConfigurationResourceId = TopicNetworkSecurityPerimeterConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, perimeterGuid, associationName);
            TopicNetworkSecurityPerimeterConfigurationResource topicNetworkSecurityPerimeterConfiguration = client.GetTopicNetworkSecurityPerimeterConfigurationResource(topicNetworkSecurityPerimeterConfigurationResourceId);

            // invoke the operation
            ArmOperation<TopicNetworkSecurityPerimeterConfigurationResource> lro = await topicNetworkSecurityPerimeterConfiguration.ReconcileAsync(WaitUntil.Completed);
            TopicNetworkSecurityPerimeterConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkSecurityPerimeterConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
