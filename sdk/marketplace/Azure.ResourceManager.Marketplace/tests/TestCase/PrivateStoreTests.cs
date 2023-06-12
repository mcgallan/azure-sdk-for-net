// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Marketplace.Tests.Helpers;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Marketplace.Tests.TestCase
{
    public class PrivateStoreTests : MarketplaceManagementTestBase
    {
        public PrivateStoreTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record) { }

        [TestCase]
        public async Task PrivateStoreApiTests()
        {
            CreateTenantResourceAsync();
            var privateStoreData = ResourceDataHelpers.GetPrivateStoreData();
            var privateStoreCollection = DefaultTenantResource.GetPrivateStores();
            var privateStoreId = new Guid("3bc6b734-0508-42db-849e-7a60818a96fc");
            //2.Get
            var lro = await privateStoreCollection.GetAsync(privateStoreId);
            var privateStore2 = lro.Value;
            Assert.AreEqual(privateStoreId, privateStore2.Data.PrivateStoreId);
            //3.GetAll
            _ = await privateStoreCollection.CreateOrUpdateAsync(WaitUntil.Completed, privateStoreId, privateStoreData);
            //_ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name2, input);
            //_ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name3, input);
            int count = 0;
            await foreach (var num in privateStoreCollection.GetAllAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 1);
            //4.Exists
            Assert.IsTrue(await privateStoreCollection.ExistsAsync(privateStoreId));
            Assert.IsFalse(await privateStoreCollection.ExistsAsync(new Guid("3bc6b734-0508-42db-849e-7a60818a96bd")));

            //Assert.ThrowsAsync<ArgumentNullException>(async () => _ = await privateStoreCollection.ExistsAsync(null));
            //Resource
            //5.Get
            PrivateStoreResource privateStore3 = await privateStore2.GetAsync();
            ResourceDataHelpers.AssertPrivateStore(privateStore2.Data, privateStore3.Data);
            //6.Delete
            await privateStore2.DeleteAsync(WaitUntil.Completed);
        }
    }
}
