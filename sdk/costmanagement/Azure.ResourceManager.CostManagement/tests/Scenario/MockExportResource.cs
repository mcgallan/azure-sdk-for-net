// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.CostManagement.Mocking;
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Resources;
using Moq;
using NUnit.Framework;

namespace Azure.ResourceManager.CostManagement.Tests
{
    public class MockExportResource
    {
        [Test]
        public async Task Mocking_GetCollectionAndCreate()
        {
            #region mocking data
            var subscriptionId = Guid.NewGuid().ToString();
            var resourceGroupName = "myRg";
            var exportName = "myExport";
            var exportScope = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}";
            var exportId = CostManagementExportResource.CreateResourceIdentifier(exportScope, "exportName");
            var exportData = ArmCostManagementModelFactory.CostManagementExportData(exportId, exportName);
            #endregion

            #region mocking setup
            var clientMock = new Mock<ArmClient>();
            var clientExtensionMock = new Mock<MockableCostManagementArmClient>();
            var rgMock = new Mock<ResourceGroupResource>();
            //for CostManagementExport
            var exportCollectionMock = new Mock<CostManagementExportCollection>();
            var exportMock = new Mock<CostManagementExportResource>();
            var exportLroMock = new Mock<ArmOperation<CostManagementExportResource>>();
            //set some data in the result
            exportMock.Setup(exportMock => exportMock.Id).Returns(exportId);
            exportMock.Setup(exportMock => exportMock.Data).Returns(exportData);
            // first mock: mock the same method in mocking extension class
            clientExtensionMock.Setup(e => e.GetCostManagementExports(new ResourceIdentifier(exportScope))).Returns(exportCollectionMock.Object);
            // second mock: mock the GetCachedClient method on the "extendee"
            clientMock.Setup(rg => rg.GetCachedClient(It.IsAny<Func<ArmClient, MockableCostManagementArmClient>>())).Returns(clientExtensionMock.Object);
            // setup the mock on the collection for CreateOrUpdate method
            exportCollectionMock.Setup(c => c.CreateOrUpdateAsync(WaitUntil.Completed, exportName, exportData, default)).ReturnsAsync(exportLroMock.Object);
            exportLroMock.Setup(lro => lro.Value).Returns(exportMock.Object);
            #endregion

            //the mocking test
            var client = clientMock.Object;
            var exportCollection = client.GetCostManagementExports(new ResourceIdentifier(exportScope));
            var exportlro = await exportCollection.CreateOrUpdateAsync(WaitUntil.Completed, exportName, exportData, default);
            var export = exportlro.Value;

            Assert.AreEqual(exportId, export.Id);
            Assert.AreEqual(exportName, export.Data.Name);
            Assert.AreEqual(exportData, export.Data);
        }
    }
}
