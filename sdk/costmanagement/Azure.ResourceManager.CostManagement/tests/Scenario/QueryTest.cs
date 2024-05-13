// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Storage;
using NUnit.Framework;

namespace Azure.ResourceManager.CostManagement.Tests.Scenario
{
    public class QueryTest : CostManagementManagementTestBase
    {
        public QueryTest(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
        }

        [RecordedTest]
        public async Task GetCost()
        {
            var queryDataSet = new QueryDataset()
            {
                Granularity = GranularityType.Daily,
            };

            var query = new QueryDefinition(ExportType.ActualCost, TimeframeType.Custom, queryDataSet);
            var today = DateTime.UtcNow;
            var startDate = new DateTime(today.Year, today.Month, 1).AddDays(-5);
            var endDate = new DateTime(today.Year, today.Month, 1).AddDays(-1);
            query.TimePeriod = new QueryTimePeriod(startDate, endDate);

            var result = await Client.UsageQueryAsync(new ResourceIdentifier("/subscriptions/db1ab6f0-4769-4b27-930e-01e2ef9c123c"), query);

            var x = result.Value;
            var y = result.GetRawResponse();
            foreach (var row in result.Value.Rows)
            {
                Console.WriteLine($"Date: {row[0]}, Cost: {row[1]}");
            }
        }
    }
}
