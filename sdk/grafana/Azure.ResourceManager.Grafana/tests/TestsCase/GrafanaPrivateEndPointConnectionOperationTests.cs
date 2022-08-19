// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Grafana.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Grafana.Tests.TestsCase
{
    public class GrafanaPrivateEndPointConnectionOperationTests : GrafanaTestBase
    {
        public GrafanaPrivateEndPointConnectionOperationTests(bool isAsync)
          : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<GrafanaPrivateEndpointConnectionResource> CreateGrafanaResourceAsync()
        {
            var container = (await CreateResourceGroupAsync()).GetManagedGrafanas();
            var input = ResourceDataHelper.GetGrafanaResourceData(DefaultLocation);
            var Grafana = await container.CreateOrUpdateAsync(WaitUntil.Completed, "sdkTestGrafana", input);
            var grafanaPrivateEndpointConnection =  Grafana.Value.GetGrafanaPrivateEndpointConnections();
            var pointInput = ResourceDataHelper.GetPrivateEndpointConnectionData();
            var lro = await grafanaPrivateEndpointConnection.CreateOrUpdateAsync(WaitUntil.Completed, "sdkTestPoint", pointInput);
            return lro.Value;
        }

        [Test]
        [TestCase]
        public async Task Operations()
        {
            //1.Get
            var resource1 = await CreateGrafanaResourceAsync();
            GrafanaPrivateEndpointConnectionResource resource2 = await resource1.GetAsync();
            ResourceDataHelper.AssertPrivateEndPointConnection(resource1.Data, resource2.Data);
            //2.Delete
            await resource1.DeleteAsync(WaitUntil.Completed);
        }
    }
}
