// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.ArcScVmm.Tests
{
    public class ArScVmmManagmentTestBase : ManagementRecordedTestBase<ArcScVmmManagementTestEnvironment>
    {
        protected AzureLocation DefaultLocation => AzureLocation.EastUS;
        protected ArmClient Client { get; private set; }
        protected SubscriptionResource DefaultSubscription { get; private set; }
        public ArScVmmManagmentTestBase(bool isAsync) : base(isAsync)
        {
        }

        public ArScVmmManagmentTestBase(bool isAsync, RecordedTestMode mode) : base(isAsync, mode)
        {
        }

        protected ArScVmmManagmentTestBase(bool isAsync, ResourceType resourceType, string apiVersion, RecordedTestMode? mode = null)
            : base(isAsync, resourceType, apiVersion, mode)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
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
    }
}
