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
    public class DataStoreTests : AvsManagementTestBase
    {
        public DataStoreTests(bool isAsync) :
            base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<AvsPrivateCloudDatastoreCollection> GetDataStoreCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("avs-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            var clusterCollection = avs.GetAvsPrivateCloudClusters();
            var clusterName = Recording.GenerateAssetName("cluster-");
            var clusterInput = ResourceDataHelpers.GetAvsCloudClusterData();
            var clusterLro = await clusterCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, clusterInput);
            AvsPrivateCloudClusterResource cluster = clusterLro.Value;
            return cluster.GetAvsPrivateCloudDatastores();
        }

        [TestCase]
        public async Task AvsDataStoreTests()
        {
            //1.CreateOrUpdate
            var collection = await GetDataStoreCollectionAsync();
            var name = Recording.GenerateAssetName("datastore-");
            var name2 = Recording.GenerateAssetName("datastore-");
            var name3 = Recording.GenerateAssetName("datastore-");
            var input = ResourceDataHelpers.GetDataStoreData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudDatastoreResource store1 = lro.Value;
            Assert.AreEqual(name, store1.Data.Name);
            //2.Get
            AvsPrivateCloudDatastoreResource store2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertDataStoreData(store1.Data, store2.Data);
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
            AvsPrivateCloudDatastoreResource store3 = await store1.GetAsync();
            ResourceDataHelpers.AssertDataStoreData(store1.Data, store3.Data);
            //6.Delete
            await store1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
