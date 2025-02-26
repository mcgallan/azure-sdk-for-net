// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ManagedServiceIdentities;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerService.Tests
{
    public class ContainerServiceManagementTestBase : ManagementRecordedTestBase<ContainerServiceManagementTestEnvironment>
    {
        internal const string DnsPrefix = "aksdotnetsdk";
        internal const string AgentPoolProfileName = "aksagent";
        internal const string VmSize = "Standard_D2s_v3";
        protected ArmClient Client { get; private set; }

        protected SubscriptionResource Subscription { get; private set; }

        protected ContainerServiceManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected ContainerServiceManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
            Subscription = await Client.GetDefaultSubscriptionAsync();
        }

        public async Task<UserAssignedIdentityResource> CreateIdentityAsync(ResourceGroupResource resourceGroup, string input, AzureLocation location)
        {
            string miName = Recording.GenerateAssetName("AGICtest");
            var collection = resourceGroup.GetUserAssignedIdentities();
            var data = new UserAssignedIdentityData(location);
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, miName, data);
            return lro.Value;
        }

        protected async Task<ResourceGroupResource> CreateResourceGroupAsync(SubscriptionResource subscription, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new ResourceGroupData(location);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }

        protected async Task<ContainerServiceManagedClusterResource> CreateContainerServiceAsync(ResourceGroupResource resourceGroup, string clusterName, AzureLocation? location = null)
        {
            var kubernetId = await CreateIdentityAsync(resourceGroup, "test", location.Value);
            var clusterData = new ContainerServiceManagedClusterData(location == null ? resourceGroup.Data.Location : location.Value)
            {
                AgentPoolProfiles =
                {
                    new ManagedClusterAgentPoolProfile(AgentPoolProfileName)
                    {
                        VmSize = VmSize,
                        Count = 1,
                        Mode = AgentPoolMode.System,
                        VnetSubnetId = new ResourceIdentifier("/subscriptions/4d042dc6-fe17-4698-a23f-ec6a8d1e98f4/resourceGroups/deleteme0225/providers/Microsoft.Network/virtualNetworks/testnet/subnets/aks-net")
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
            var lro = await resourceGroup.GetContainerServiceManagedClusters().CreateOrUpdateAsync(WaitUntil.Completed, clusterName, clusterData);
            return lro.Value;
        }
    }
}
