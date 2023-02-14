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
    public class GlobalReachConnectionTests : AvsManagementTestBase
    {
        public GlobalReachConnectionTests(bool isAsync) :
            base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<ResourceGroupResource> GetResourceGroupAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup;
        }
        private async Task<GlobalReachConnectionCollection> GetConnectionCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("Connection-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            return avs.GetGlobalReachConnections();
        }

        [TestCase]
        public async Task AvsPrivateCloudTests()
        {
            //1.CreateOrUpdate
            var collection = await GetConnectionCollectionAsync();
            var name = Recording.GenerateAssetName("connection-");
            var name2 = Recording.GenerateAssetName("connection-");
            var name3 = Recording.GenerateAssetName("connection-");
            var input = ResourceDataHelpers.GetGlobalReachConnectionData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            GlobalReachConnectionResource connection1 = lro.Value;
            Assert.AreEqual(name, connection1.Data.Name);
            //2.Get
            GlobalReachConnectionResource connection2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertGlobalReachConnectionDataData(connection1.Data, connection2.Data);
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
            GlobalReachConnectionResource connection3 = await connection1.GetAsync();
            ResourceDataHelpers.AssertGlobalReachConnectionDataData(connection1.Data, connection3.Data);
            //6.Delete
            await connection1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
