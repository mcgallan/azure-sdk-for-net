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
    public class AvsCloudLinkTests : AvsManagementTestBase
    {
        public AvsCloudLinkTests(bool isAsync) :
            base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<AvsCloudLinkCollection> GetLinkCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("avs-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            return avs.GetAvsCloudLinks();
        }

        [TestCase]
        public async Task AvsPrivateCloudTests()
        {
            //1.CreateOrUpdate
            var collection = await GetLinkCollectionAsync();
            var name = Recording.GenerateAssetName("link-");
            var name2 = Recording.GenerateAssetName("link-");
            var name3 = Recording.GenerateAssetName("link-");
            var input = ResourceDataHelpers.GetAvsCloudLinkData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsCloudLinkResource link1 = lro.Value;
            Assert.AreEqual(name, link1.Data.Name);
            //2.Get
            AvsCloudLinkResource link2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertAvsCloudLinkData(link1.Data, link2.Data);
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
            AvsCloudLinkResource link3 = await link1.GetAsync();
            ResourceDataHelpers.AssertAvsCloudLinkData(link1.Data, link3.Data);
            //6.Delete
            await link1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
