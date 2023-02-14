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
    public class ScriptAllTests : AvsManagementTestBase
    {
        public ScriptAllTests(bool isAsync) :
            base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<ScriptExecutionCollection> GetScriptExecutionCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("avs-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            return avs.GetScriptExecutions();
        }

        [TestCase]
        public async Task ScriptExecutionTests()
        {
            //1.CreateOrUpdate
            var collection = await GetScriptExecutionCollectionAsync();
            var name = Recording.GenerateAssetName("scriptexecution-");
            var name2 = Recording.GenerateAssetName("scriptexecution-");
            var name3 = Recording.GenerateAssetName("scriptexecution-");
            var input = ResourceDataHelpers.GetScriptExecutionData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            ScriptExecutionResource execution1 = lro.Value;
            Assert.AreEqual(name, execution1.Data.Name);
            //2.Get
            ScriptExecutionResource execution2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertScriptExecutionData(execution1.Data, execution2.Data);
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
            ScriptExecutionResource execution3 = await execution1.GetAsync();
            ResourceDataHelpers.AssertScriptExecutionData(execution1.Data, execution3.Data);
            //6.Delete
            await execution1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
