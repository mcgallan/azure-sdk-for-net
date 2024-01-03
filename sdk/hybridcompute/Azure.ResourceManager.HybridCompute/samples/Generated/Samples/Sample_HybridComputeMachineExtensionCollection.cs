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
using Azure.ResourceManager.HybridCompute;
using Azure.ResourceManager.HybridCompute.Models;

namespace Azure.ResourceManager.HybridCompute.Samples
{
    public partial class Sample_HybridComputeMachineExtensionCollection
    {
        // Create or Update a Machine Extension
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAMachineExtension()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/extension/Extension_CreateOrUpdate.json
            // this example is just showing the usage of "MachineExtensions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // get the collection of this HybridComputeMachineExtensionResource
            HybridComputeMachineExtensionCollection collection = hybridComputeMachine.GetHybridComputeMachineExtensions();

            // invoke the operation
            string extensionName = "CustomScriptExtension";
            HybridComputeMachineExtensionData data = new HybridComputeMachineExtensionData(new AzureLocation("eastus2euap"))
            {
                Properties = new MachineExtensionProperties()
                {
                    Publisher = "Microsoft.Compute",
                    MachineExtensionPropertiesType = "CustomScriptExtension",
                    TypeHandlerVersion = "1.10",
                    Settings =
{
["commandToExecute"] = BinaryData.FromString("\"powershell.exe -c \"Get-Process | Where-Object { $_.CPU -gt 10000 }\"\""),
},
                },
            };
            ArmOperation<HybridComputeMachineExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, extensionName, data);
            HybridComputeMachineExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputeMachineExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GET Machine Extension
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GETMachineExtension()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/extension/Extension_Get.json
            // this example is just showing the usage of "MachineExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // get the collection of this HybridComputeMachineExtensionResource
            HybridComputeMachineExtensionCollection collection = hybridComputeMachine.GetHybridComputeMachineExtensions();

            // invoke the operation
            string extensionName = "CustomScriptExtension";
            HybridComputeMachineExtensionResource result = await collection.GetAsync(extensionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridComputeMachineExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GET Machine Extension
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GETMachineExtension()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/extension/Extension_Get.json
            // this example is just showing the usage of "MachineExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // get the collection of this HybridComputeMachineExtensionResource
            HybridComputeMachineExtensionCollection collection = hybridComputeMachine.GetHybridComputeMachineExtensions();

            // invoke the operation
            string extensionName = "CustomScriptExtension";
            bool result = await collection.ExistsAsync(extensionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GET Machine Extension
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GETMachineExtension()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/extension/Extension_Get.json
            // this example is just showing the usage of "MachineExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // get the collection of this HybridComputeMachineExtensionResource
            HybridComputeMachineExtensionCollection collection = hybridComputeMachine.GetHybridComputeMachineExtensions();

            // invoke the operation
            string extensionName = "CustomScriptExtension";
            NullableResponse<HybridComputeMachineExtensionResource> response = await collection.GetIfExistsAsync(extensionName);
            HybridComputeMachineExtensionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridComputeMachineExtensionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // GET all Machine Extensions - List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GETAllMachineExtensionsList()
        {
            // Generated from example definition: specification/hybridcompute/resource-manager/Microsoft.HybridCompute/preview/2023-10-03-preview/examples/extension/Extension_List.json
            // this example is just showing the usage of "MachineExtensions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridComputeMachineResource created on azure
            // for more information of creating HybridComputeMachineResource, please refer to the document of HybridComputeMachineResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string machineName = "myMachine";
            ResourceIdentifier hybridComputeMachineResourceId = HybridComputeMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, machineName);
            HybridComputeMachineResource hybridComputeMachine = client.GetHybridComputeMachineResource(hybridComputeMachineResourceId);

            // get the collection of this HybridComputeMachineExtensionResource
            HybridComputeMachineExtensionCollection collection = hybridComputeMachine.GetHybridComputeMachineExtensions();

            // invoke the operation and iterate over the result
            await foreach (HybridComputeMachineExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridComputeMachineExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
