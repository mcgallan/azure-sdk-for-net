// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Consumption.Models;
using Azure.ResourceManager.Consumption.Tests;
using NUnit.Framework;

namespace Azure.ResourceManager.Consumption.Tests
{
    public class MarketplaceTests : ConsumptionManagementTestBase
    {
        public MarketplaceTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        [TestCase]
        public async Task testCase()
        {
            ResourceIdentifier scope = new ResourceIdentifier("/subscriptions/db1ab6f0-4769-4b27-930e-01e2ef9c123c");
            AsyncPageable<ConsumptionMarketplace> marketplaces = ConsumptionExtensions.GetConsumptionMarketPlacesAsync(Client, scope);
            await foreach (var marketplace in marketplaces)
            {
                Assert.IsNotNull(marketplace);
            }
        }
    }
}
