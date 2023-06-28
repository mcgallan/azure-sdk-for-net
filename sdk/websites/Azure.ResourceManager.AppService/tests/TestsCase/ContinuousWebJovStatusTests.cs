// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class ContinuousWebJovStatusTests : AppServiceTestBase
    {
        public ContinuousWebJovStatusTests(bool isAsync)
           : base(isAsync, RecordedTestMode.Record)
        {
        }

        [RecordedTest]
        public async Task StatusTests()
        {
            ResourceGroupResource resourceGroup = await DefaultSubscription.GetResourceGroupAsync("deleteme0628");
            WebSiteResource website = await resourceGroup.GetWebSiteAsync("statustest0628");
            WebSiteContinuousWebJobResource webjob = await website.GetWebSiteContinuousWebJobAsync("status");
            Assert.IsNotNull(webjob.Data.Status);
            Console.WriteLine(webjob.Data.Status);
        }
    }
}
