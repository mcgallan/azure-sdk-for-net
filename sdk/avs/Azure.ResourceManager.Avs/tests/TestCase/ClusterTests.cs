// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Avs.Tests.ResourceHelpers;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;
using System;

namespace Azure.ResourceManager.Avs.Tests.TestCase
{
    public class ClusterTests : AvsManagementTestBase
    {
        public ClusterTests(bool isAsync) :
            base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<ResourceGroupResource> GetResourceGroupAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup;
        }
        private async Task<AvsPrivateCloudClusterCollection> GetAddonCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("avs-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            return avs.GetAvsPrivateCloudClusters();
        }

        [TestCase]
        public async Task AvsClusterTests()
        {
            //1.CreateOrUpdate
            var collection = await GetAddonCollectionAsync();
            var name = Recording.GenerateAssetName("cluster-");
            var name2 = Recording.GenerateAssetName("cluster-");
            var name3 = Recording.GenerateAssetName("cluster-");
            var input = ResourceDataHelpers.GetAvsCloudClusterData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudClusterResource cluster1 = lro.Value;
            Assert.AreEqual(name, cluster1.Data.Name);
            //2.Get
            AvsPrivateCloudClusterResource cluster2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertAvsCloudClusterData(cluster1.Data, cluster2.Data);
            //3.GetAll
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name2, input);
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name3, input);
            int count = 0;
            await foreach (var account in collection.GetAllAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 3);
            //4.Exists
            Assert.IsTrue(await collection.ExistsAsync(name));
            Assert.IsFalse(await collection.ExistsAsync(name + "1"));

            Assert.ThrowsAsync<ArgumentNullException>(async () => _ = await collection.ExistsAsync(null));
            //ResourceTests
            //5.GetResource
            AvsPrivateCloudClusterResource cluster3 = await cluster1.GetAsync();
            ResourceDataHelpers.AssertAvsCloudClusterData(cluster1.Data, cluster3.Data);
            //6.Delete
            await cluster1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
