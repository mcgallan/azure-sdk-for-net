// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Models;
using NuGet.Frameworks;
using NUnit.Framework;

namespace Azure.ResourceManager.ArcScVmm.Tests.Helpers
{
    public static class ResourceDataHelper
    {
        // Temporary solution since the one in Azure.ResourceManager.Compute is internal
        public static IDictionary<string, string> ReplaceWith(this IDictionary<string, string> dest, IDictionary<string, string> src)
        {
            dest.Clear();
            foreach (var kv in src)
            {
                dest.Add(kv);
            }

            return dest;
        }

        public static void AssertTrackedResource(TrackedResourceData r1, TrackedResourceData r2)
        {
            Assert.AreEqual(r1.Name, r2.Name);
            Assert.AreEqual(r1.Id, r2.Id);
            Assert.AreEqual(r1.ResourceType, r2.ResourceType);
            Assert.AreEqual(r1.Location, r2.Location);
            Assert.AreEqual(r1.Tags, r2.Tags);
        }
        public static void AssertResource(ResourceData r1, ResourceData r2)
        {
            Assert.AreEqual(r1.Name, r2.Name);
            Assert.AreEqual(r1.Id, r2.Id);
            Assert.AreEqual(r1.ResourceType, r2.ResourceType);
        }

        #region InnventoryItemData
        public static InventoryItemData GetInventoryItemData()
        {
            return new InventoryItemData(InventoryType.Cloud);
        }
        public static void AssetInnventoryItemData(InventoryItemData data1, InventoryItemData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.InventoryType, data2.InventoryType);
            Assert.AreEqual(data1.ProvisioningState, data2.ProvisioningState);
        }
        #endregion
    }
}
