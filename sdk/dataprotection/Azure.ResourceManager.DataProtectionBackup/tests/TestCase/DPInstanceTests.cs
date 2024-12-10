// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.DataProtectionBackup.Tests;
using Azure.ResourceManager.DataProtectionBackup.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.DataProtectionBackup.Tests.TestCase
{
    public class DPInstanceTests : DataProtectionBackupManagementTestBase
    {
        public DPInstanceTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        private async Task<(DataProtectionBackupInstanceCollection InstanceCollection, DataProtectionBackupPolicyCollection PolicyCollection, ManagedDiskCollection DiskCollection)> GetInstanceCollection()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var vaultCollection = resourceGroup.GetDataProtectionBackupVaults();
            var name = Recording.GenerateAssetName("vault");
            var input = ResourceDataHelpers.GetVaultData();
            var lro = await vaultCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            DataProtectionBackupVaultResource resource = lro.Value;

            return (resource.GetDataProtectionBackupInstances(), resource.GetDataProtectionBackupPolicies() , resourceGroup.GetManagedDisks());
        }

        private static ManagedDiskData GetEmptyDiskData(AzureLocation location, IDictionary<string, string> tags = null)
        {
            return new ManagedDiskData(location)
            {
                Sku = new DiskSku()
                {
                    Name = DiskStorageAccountType.StandardLrs
                },
                CreationData = new DiskCreationData(DiskCreateOption.Empty),
                DiskSizeGB = 1,
            };
        }

        [RecordedTest]
        [Ignore("Microsoft Azure Backup encountered an internal error.")]
        public async Task InstanceApiTests()
        {
            //0.prepare
            (DataProtectionBackupInstanceCollection collection, DataProtectionBackupPolicyCollection policyCollection, ManagedDiskCollection diskCollection) = await GetInstanceCollection();
            var policyData = ResourceDataHelpers.GetDiskPolicyData();
            var policy = (await policyCollection.CreateOrUpdateAsync(WaitUntil.Completed, "diskpolicy2", policyData)).Value;
            var diskName = Recording.GenerateAssetName("testDisk-");
            var diskinput = GetEmptyDiskData(DefaultLocation);
            var disklro = await diskCollection.CreateOrUpdateAsync(WaitUntil.Completed, diskName, diskinput);
            var disk = disklro.Value;
            //1.CreateOrUpdate
            var name = Recording.GenerateAssetName("instance");
            var name2 = Recording.GenerateAssetName("instance");
            var name3 = Recording.GenerateAssetName("instance");
            var input = ResourceDataHelpers.GetInstanceData(policy.Id, disk.Id, name);
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            DataProtectionBackupInstanceResource resource = lro.Value;
            Assert.AreEqual(name, resource.Data.Name);
            //2.Get
            DataProtectionBackupInstanceResource resource2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertInstanceData(resource.Data, resource2.Data);
            //3.GetAll
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name2, input);
            _ = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name3, input);
            int count = 0;
            await foreach (var num in collection.GetAllAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 3);
            //4Exists
            Assert.IsTrue(await collection.ExistsAsync(name));
            Assert.IsFalse(await collection.ExistsAsync(name + "1"));

            Assert.ThrowsAsync<ArgumentNullException>(async () => _ = await collection.ExistsAsync(null));
            //resourceTests
            //5.Get
            DataProtectionBackupInstanceResource resource3 = await resource.GetAsync();
            ResourceDataHelpers.AssertInstanceData(resource.Data, resource3.Data);
            //6.Delete
            await resource.DeleteAsync(WaitUntil.Completed);
        }
    }
}
