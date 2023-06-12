// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.Marketplace.Tests
{
    public class MarketplaceManagementTestBase : ManagementRecordedTestBase<MarketplaceManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }
        protected AzureLocation DefaultLocation => TestEnvironment.Location;
        protected string groupName;
        protected SubscriptionResource DefaultSubscription { get; private set; }
        protected TenantCollection DefaultTenantCollection { get; private set; }
        protected TenantResource DefaultTenantResource { get; private set; }
        protected MarketplaceManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected MarketplaceManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
            DefaultTenantCollection = Client.GetTenants();
            DefaultSubscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
        }

        protected async Task<ResourceGroupResource> CreateResourceGroupAsync()
        {
            var resourceGroupName = Recording.GenerateAssetName("testRG-");
            var rgOp = await DefaultSubscription.GetResourceGroups().CreateOrUpdateAsync(
                WaitUntil.Completed,
                resourceGroupName,
                new ResourceGroupData(DefaultLocation)
                {
                    Tags =
                    {
                        { "test", "env" }
                    }
                });
            return rgOp.Value;
        }

        protected async void CreateTenantResourceAsync()
        {
            var tenantResourceName = Recording.GenerateAssetName("testTR-");
            AsyncPageable<TenantResource> tenantResources = DefaultTenantCollection.GetAllAsync();
            await foreach (var tenantResource in tenantResources)
            {
                DefaultTenantResource = tenantResource;
            }
        }
    }
}
