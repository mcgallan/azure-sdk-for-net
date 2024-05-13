// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Network.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Tests.Tests
{
    public class NatGaterwayTest : NetworkServiceClientTestBase
    {
        private SubscriptionResource _subscription;
        public NatGaterwayTest(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
        }

        [SetUp]
        public async Task ClearChallengeCacheforRecord()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                Initialize();
            }
            _subscription = await ArmClient.GetDefaultSubscriptionAsync();
        }

        [Test]
        public async Task CreateTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            var resourceGroup = await CreateResourceGroup(resourceGroupName);
            //var natGateway = resourceGroup.GetNatGateway("natgateway");
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnet1Name = Recording.GenerateAssetName("azsmnet");
            string subnet2Name = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = Core.AzureLocation.EastUS,
                AddressSpace = new AddressSpace()
                {
                    AddressPrefixes = { "10.0.0.0/16", }
                },
                DhcpOptions = new DhcpOptions()
                {
                    DnsServers = { "10.1.1.1", "10.1.2.4" }
                },
                Subnets = { new SubnetData() { Name = subnet1Name, AddressPrefix = "10.0.1.0/24", }, new SubnetData() { Name = subnet2Name, AddressPrefix = "10.0.2.0/24", NatGatewayId = new Core.ResourceIdentifier("/subscriptions/db1ab6f0-4769-4b27-930e-01e2ef9c123c/resourceGroups/deleteme0508/providers/Microsoft.Network/natGateways/natgateway") } }
            };

            // Put Vnet
            var virtualNetworkCollection = resourceGroup.GetVirtualNetworks();
            var putVnetResponseOperation = await virtualNetworkCollection.CreateOrUpdateAsync(WaitUntil.Completed, vnetName, vnet);
            var putVnetResponse = putVnetResponseOperation.Value;
        }

        [Test]
        public async Task RemoveNatTest()
        {
            var resourceGroup = ArmClient.GetResourceGroupResource(new Core.ResourceIdentifier("/subscriptions/db1ab6f0-4769-4b27-930e-01e2ef9c123c/resourceGroups/deleteme0508"));
            var network =(await resourceGroup.GetVirtualNetworkAsync("gatewaytest")).Value;
            var subnetResource =(await network.GetSubnetAsync("subnet1")).Value;
            subnetResource.Data.NatGatewayId = null;

            await subnetResource.UpdateAsync(waitUntil: WaitUntil.Completed, data: subnetResource.Data);
        }
    }
}
