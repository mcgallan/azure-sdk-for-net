// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Grafana.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Grafana.Tests.TestsCase
{
    public class GrafanaPrivateEndPointConnectionCollectionTests : GrafanaTestBase
    {
        public GrafanaPrivateEndPointConnectionCollectionTests(bool isAsync)
           : base(isAsync, RecordedTestMode.Record)
        {
        }
        private async Task<GrafanaPrivateEndpointConnectionCollection> GetCollectionAsync()
        {
            var container = (await CreateResourceGroupAsync()).GetManagedGrafanas();
            var input = ResourceDataHelper.GetGrafanaResourceData(DefaultLocation);
            var Grafana = await container.CreateOrUpdateAsync(WaitUntil.Completed, "testEndpoint", input);
            return Grafana.Value.GetGrafanaPrivateEndpointConnections();
        }

        [TestCase]
        [RecordedTest]
        public async Task Collection()
        {
            //1.CreateOrUpdate
            var container = await GetCollectionAsync();
            var pointName = Recording.GenerateAssetName("sdkTestPoint-");
            var input = ResourceDataHelper.GetPrivateEndpointConnectionData();
            var lro = await container.CreateOrUpdateAsync(WaitUntil.Completed, pointName, input);
            GrafanaPrivateEndpointConnectionResource resource1 = lro.Value;
            Assert.AreEqual(pointName, resource1.Data.Name);
            //2.Get
            GrafanaPrivateEndpointConnectionResource resource2 = await container.GetAsync(pointName);
            ResourceDataHelper.AssertPrivateEndPointConnection(resource1.Data, resource2.Data);
            //3.GetAll
            var pointName1 = Recording.GenerateAssetName("sdkTestPoint1-");
            var pointName2 = Recording.GenerateAssetName("sdkTestPoint2-");
            var input1 = ResourceDataHelper.GetPrivateEndpointConnectionData();
            var input2 = ResourceDataHelper.GetPrivateEndpointConnectionData();
            _ = await container.CreateOrUpdateAsync(WaitUntil.Completed, pointName1, input1);
            _ = await container.CreateOrUpdateAsync(WaitUntil.Completed, pointName2, input2);
            int count = 0;
            await foreach (var appServicePlan in container.GetAllAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 2);
        }
    }
}
