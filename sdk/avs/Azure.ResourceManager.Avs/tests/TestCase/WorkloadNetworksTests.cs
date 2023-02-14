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
    public class WorkloadNetworksTests: AvsManagementTestBase
    {
        public WorkloadNetworksTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }
        private async Task<WorkloadNetworkDhcpCollection> GetDhcpCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("avs-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            return avs.GetWorkloadNetworkDhcps();
        }

        private async Task<WorkloadNetworkDnsZoneCollection> GetDnsCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("avs-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            return avs.GetWorkloadNetworkDnsZones();
        }

        private async Task<WorkloadNetworkPortMirroringProfileCollection> GetMirrorCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("avs-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            return avs.GetWorkloadNetworkPortMirroringProfiles();
        }

        private async Task<WorkloadNetworkSegmentCollection> GetSegmentCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            var name = Recording.GenerateAssetName("avs-");
            var AvsCollection = resourceGroup.GetAvsPrivateClouds();
            var input = ResourceDataHelpers.GetAvsPrivateCloudData();
            var lro = await AvsCollection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            AvsPrivateCloudResource avs = lro.Value;
            return avs.GetWorkloadNetworkSegments();
        }

        [TestCase]
        public async Task workloadNerworkDhcps()
        {
            //1.CreateOrUpdate
            var collection = await GetDhcpCollectionAsync();
            var name = Recording.GenerateAssetName("dhcp-");
            var name2 = Recording.GenerateAssetName("dhcp-");
            var name3 = Recording.GenerateAssetName("dhcp-");
            var input = ResourceDataHelpers.GetDhcpData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            WorkloadNetworkDhcpResource dhcp1 = lro.Value;
            Assert.AreEqual(name, dhcp1.Data.Name);
            //2.Get
            WorkloadNetworkDhcpResource dhcp2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertDhcpData(dhcp1.Data, dhcp2.Data);
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
            WorkloadNetworkDhcpResource dhcp3 = await dhcp1.GetAsync();
            ResourceDataHelpers.AssertDhcpData(dhcp1.Data, dhcp3.Data);
            //6.Delete
            await dhcp1.DeleteAsync(WaitUntil.Completed);
        }

        [TestCase]
        public async Task workloadNerworkDns()
        {
            //1.CreateOrUpdate
            var collection = await GetDnsCollectionAsync();
            var name = Recording.GenerateAssetName("dns-");
            var name2 = Recording.GenerateAssetName("dns-");
            var name3 = Recording.GenerateAssetName("dns-");
            var input = ResourceDataHelpers.GetDnsData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            WorkloadNetworkDnsZoneResource dns1 = lro.Value;
            Assert.AreEqual(name, dns1.Data.Name);
            //2.Get
            WorkloadNetworkDnsZoneResource dns2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertDnsData(dns1.Data, dns2.Data);
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
            WorkloadNetworkDnsZoneResource dns3 = await dns1.GetAsync();
            ResourceDataHelpers.AssertDnsData(dns1.Data, dns3.Data);
            //6.Delete
            await dns1.DeleteAsync(WaitUntil.Completed);
        }

        [TestCase]
        public async Task workloadNerworkMirroring()
        {
            //1.CreateOrUpdate
            var collection = await GetMirrorCollectionAsync();
            var name = Recording.GenerateAssetName("mirroring-");
            var name2 = Recording.GenerateAssetName("mirroring-");
            var name3 = Recording.GenerateAssetName("mirroring-");
            var input = ResourceDataHelpers.GetPortMirroringData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            WorkloadNetworkPortMirroringProfileResource mirroring1 = lro.Value;
            Assert.AreEqual(name, mirroring1.Data.Name);
            //2.Get
            WorkloadNetworkPortMirroringProfileResource mirroring2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertPortMirroringData(mirroring1.Data, mirroring2.Data);
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
            WorkloadNetworkPortMirroringProfileResource mirroring = await mirroring1.GetAsync();
            ResourceDataHelpers.AssertPortMirroringData(mirroring1.Data, mirroring.Data);
            //6.Delete
            await mirroring1.DeleteAsync(WaitUntil.Completed);
        }

        [TestCase]
        public async Task workloadNerworkSegment()
        {
            //1.CreateOrUpdate
            var collection = await GetSegmentCollectionAsync();
            var name = Recording.GenerateAssetName("segment-");
            var name2 = Recording.GenerateAssetName("segment-");
            var name3 = Recording.GenerateAssetName("segment-");
            var input = ResourceDataHelpers.GetSegmentData();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            WorkloadNetworkSegmentResource segment1 = lro.Value;
            Assert.AreEqual(name, segment1.Data.Name);
            //2.Get
            WorkloadNetworkSegmentResource segment2 = await collection.GetAsync(name);
            ResourceDataHelpers.AssertSegmentData(segment1.Data, segment2.Data);
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
            WorkloadNetworkSegmentResource segmrnt3 = await segment1.GetAsync();
            ResourceDataHelpers.AssertSegmentData(segment1.Data, segmrnt3.Data);
            //6.Delete
            await segment1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
