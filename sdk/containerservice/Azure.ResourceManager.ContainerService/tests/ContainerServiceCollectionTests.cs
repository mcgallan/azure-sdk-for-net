// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerService.Tests
{
    public class ContainerServiceCollectionTests : ContainerServiceManagementTestBase
    {
        public ContainerServiceCollectionTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        [RecordedTest]
        public async Task CreateListGetDelete()
        {
            ResourceGroupResource rg = await CreateResourceGroupAsync(Subscription, "testaksrg", AzureLocation.EastUS2);
            var clusterCollection = rg.GetContainerServiceManagedClusters();
            string clusterName = Recording.GenerateAssetName("akscluster");
            // Create
            ContainerServiceManagedClusterResource cluster = await CreateContainerServiceAsync(rg, clusterName, rg.Data.Location);
            Assert.AreEqual(clusterName, cluster.Data.Name);
            Assert.AreEqual(DnsPrefix, cluster.Data.DnsPrefix);
            // List
            await foreach (var clusterFromList in clusterCollection)
            {
                Assert.AreEqual(clusterFromList.Data.Name, clusterName);
            }
            // Get
            ContainerServiceManagedClusterResource clusterFromGet = await cluster.GetAsync();
            Assert.AreEqual(clusterFromGet.Data.Name, cluster.Data.Name);
            Assert.AreEqual(clusterFromGet.Data.DnsPrefix, cluster.Data.DnsPrefix);
        }

        [RecordedTest]
        public async Task Update()
        {
            ResourceGroupResource rg = await CreateResourceGroupAsync(Subscription, "testaksrg", AzureLocation.EastUS2);
            var clusterCollection = rg.GetContainerServiceManagedClusters();
            string clusterName = Recording.GenerateAssetName("akscluster");
            // Create
            ContainerServiceManagedClusterResource cluster = await CreateContainerServiceAsync(rg, clusterName, rg.Data.Location);
            // Update
            var kubernetId = await CreateIdentityAsync(rg, "test", AzureLocation.EastUS2);
            var clusterData = new ContainerServiceManagedClusterData(AzureLocation.EastUS2)
            {
                AgentPoolProfiles =
                {
                    new ManagedClusterAgentPoolProfile(AgentPoolProfileName)
                    {
                        VmSize = VmSize,
                        Count = 1,
                        Mode = AgentPoolMode.System,
                    }
                },
                DnsPrefix = DnsPrefix,
                Identity = new ManagedServiceIdentity(ManagedServiceIdentityType.SystemAssigned),
                NetworkProfile = new ContainerServiceNetworkProfile
                {
                    ServiceCidr = "10.1.0.0/16",
                    DnsServiceIP = "10.1.0.10",
                    DockerBridgeCidr = "172.17.0.1/16"
                },
                AddonProfiles =
                {
                    { "IngressApplicationGateway", new ManagedClusterAddonProfile(isEnabled: true)
                    {
                        Config =
                        {
                            {"applicationGatewayId", "/subscriptions/4d042dc6-fe17-4698-a23f-ec6a8d1e98f4/resourceGroups/deleteme0225/providers/Microsoft.Network/applicationGateways/AGICTest" },
                            {"userAssignedIdentities", kubernetId.Id }
                        }
                    }
                    }
                },
            };
            var lro = await rg.GetContainerServiceManagedClusters().CreateOrUpdateAsync(WaitUntil.Completed, clusterName, clusterData);
            ContainerServiceManagedClusterResource clusterFromUpdate = lro.Value;
            Assert.AreEqual(clusterFromUpdate.Data.Name, clusterName);
            Assert.AreEqual(clusterFromUpdate.Data.AgentPoolProfiles[0].Count, 1);
        }

        [RecordedTest]
        public async Task GetCredentials()
        {
            ResourceGroupResource rg = await CreateResourceGroupAsync(Subscription, "testaksrg", AzureLocation.EastUS);
            var clusterCollection = rg.GetContainerServiceManagedClusters();
            string clusterName = Recording.GenerateAssetName("akscluster");
            // Create
            ContainerServiceManagedClusterResource cluster = await CreateContainerServiceAsync(rg, clusterName, rg.Data.Location);
            ManagedClusterCredentials adminCredentials = await cluster.GetClusterAdminCredentialsAsync();
            Assert.True(adminCredentials.Kubeconfigs.Count > 0);
            Assert.True(!string.IsNullOrWhiteSpace(adminCredentials.Kubeconfigs[0].Name));
            ManagedClusterCredentials userCredentials = await cluster.GetClusterUserCredentialsAsync();
            Assert.True(userCredentials.Kubeconfigs.Count > 0);
            // Delete
            await cluster.DeleteAsync(WaitUntil.Completed);
        }
    }
}
