// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Avs.Tests.ResourceHelpers;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Azure.ResourceManager.Avs.Tests.TestCase
{
    public class AvsTests : AvsManagementTestBase
    {
        public AvsTests(bool isAsync) :
            base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<AvsPrivateCloudCollection> GetAvsCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetAvsPrivateClouds();
        }
        [TestCase]
        public async Task AvsPrivateCloudTests()
        {
            //1.CreateOrUpdate
            var collection =await GetAvsCollectionAsync();
            var name = Recording.GenerateAssetName("avs-");
            var name2 = Recording.GenerateAssetName("avs-");
            var name3 = Recording.GenerateAssetName("avs-");
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs1 = lro.Value;
            Assert.AreEqual(name, avs1.Data.Name);
            //2.Get
            AvsPrivateCloudResource avs2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertAvsPrivateCloudData(avs1.Data, avs2.Data);
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
            AvsPrivateCloudResource avs3 = await avs1.GetAsync();
            ResourceDataHelpers.AssertAvsPrivateCloudData(avs1.Data, avs3.Data);
            //6.Delete
            await avs1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
