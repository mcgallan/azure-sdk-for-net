// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;
using Azure.Core;
using System;
using System.Text;
using Azure.ResourceManager.Resources;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using System.IO;
using System.Xml;

namespace Azure.ResourceManager.Marketplace.Tests.Helpers
{
    public static class ResourceDataHelpers
    {
        public static IDictionary<string, string> ReplaceWith(this IDictionary<string, string> dest, IDictionary<string, string> src)
        {
            dest.Clear();
            foreach (var kv in src)
            {
                dest.Add(kv);
            }

            return dest;
        }

        public static void AssertResource(ResourceData r1, ResourceData r2)
        {
            Assert.AreEqual(r1.Name, r2.Name);
            Assert.AreEqual(r1.Id, r2.Id);
            Assert.AreEqual(r1.ResourceType, r2.ResourceType);
        }

        #region AdminApprovalRequest
        public static MarketplaceAdminApprovalRequestData GetRequestData()
        {
            var data = new MarketplaceAdminApprovalRequestData()
            {
                PublisherId = "data3-limited-1019419",
            };
            return data;
        }
         public static void AssertAdimnRequest(MarketplaceAdminApprovalRequestData data1, MarketplaceAdminApprovalRequestData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.PublisherId, data2.PublisherId);
            Assert.AreEqual(data1.Comment , data2.Comment);
            Assert.AreEqual(data1.Comment, data2.Comment);
        }
        #endregion

        #region PrivateStore
        public static PrivateStoreData GetPrivateStoreData()
        {
            var data = new PrivateStoreData()
            {
                Availability = PrivateStoreAvailability.Enabled,
            };
            return data;
        }

        public static void AssertPrivateStore(PrivateStoreData data1, PrivateStoreData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.Availability, data2.Availability);
            Assert.AreEqual(data1.IsGov, data2.IsGov);
            Assert.AreEqual(data1.CollectionIds, data2.CollectionIds);
        }
        #endregion

        #region MarketplaceApprovalRequestData
        public static MarketplaceApprovalRequestData GetMarketplaceApprovalRequestData()
        {
            var data = new MarketplaceApprovalRequestData()
            {
                PublisherId = "data3-limited-1019419",
                PlansDetails =
                {
                    new PrivateStorePlanDetails()
                    {
                        PlanId = "d3-azure-health-check",
                        Justification = "because ...",
                        SubscriptionId = "db1ab6f0-4769-4b27-930e-01e2ef9c123c",
                        SubscriptionName = ".NET Mgmt SDK Test with TTL = 1 Day"
                    }
                }
            };
            return data;
        }
        #endregion
    }
}
