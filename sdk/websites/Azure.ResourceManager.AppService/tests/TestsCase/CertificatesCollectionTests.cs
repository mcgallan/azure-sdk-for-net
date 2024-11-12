// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.AppService.Tests.Helpers;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Authorization;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Tests.TestsCase
{
    public class CertificatesCollectionTests : AppServiceTestBase
    {
        public CertificatesCollectionTests(bool isAsync)
           : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<AppCertificateCollection> GetCertificatesCollectionAsync()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            return resourceGroup.GetAppCertificates();
        }

        [TestCase]
        [RecordedTest]
        [Ignore("Service request failed.Status: 500 (Internal Server Error)")]
        public async Task CreateOrUpdate()
        {
            var container = await GetCertificatesCollectionAsync();
            var name = Recording.GenerateAssetName("testCertificate");
            var input = ResourceDataHelper.GetBasicCertificateData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(WaitUntil.Completed, name, input);
            var certificate = lro.Value;
            Assert.AreEqual(name, certificate.Data.Name);
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdateWithNullKeyVaultId()
        {
            // Call CreateOrUpdate on an existing certificate which returns empty string for keyVaultId
            var name = "aeronline.net#myfirstapp0102-null";
            var data = new AppCertificateData(AzureLocation.EastUS2)
            {
                ServerFarmId = new Core.ResourceIdentifier("/subscriptions/4d042dc6-fe17-4698-a23f-ec6a8d1e98f4/resourceGroups/v-xinnitong-sdktest3668/providers/Microsoft.Web/serverfarms/appServicePlan-xinni"),
                CanonicalName = "webapp-xinni-3668.azurewebsites.net",
            };
            var collection = Client.GetResourceGroupResource(ResourceGroupResource.CreateResourceIdentifier("4d042dc6-fe17-4698-a23f-ec6a8d1e98f4", "v-xinnitong-sdktest3668")).GetAppCertificates();
            var lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            var certificate = lro.Value;
            Assert.AreEqual(name, certificate.Data.Name);
            Assert.IsNull(certificate.Data.KeyVaultId);
        }

        [Test]
        [RecordedTest]
        public async Task CertificatesRoleAssignment()
        {
            var collection = Client.GetResourceGroupResource(ResourceGroupResource.CreateResourceIdentifier("4d042dc6-fe17-4698-a23f-ec6a8d1e98f4", "v-xinnitong-sdktest3668")).GetAppCertificates();
            var lro = await collection.GetAsync("aeronline.net#myfirstapp0102-null");
            var certificate = lro.Value;
            var roleAssignmentCollection = certificate.GetRoleAssignments();
        }

        [TestCase]
        [RecordedTest]
        [Ignore("Service request failed.Status: 500 (Internal Server Error)")]
        public async Task Get()
        {
            var container = await GetCertificatesCollectionAsync();
            var certificateName = Recording.GenerateAssetName("testCertificate-");
            var input = ResourceDataHelper.GetBasicCertificateData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(WaitUntil.Completed, certificateName, input);
            AppCertificateResource certificate1 = lro.Value;
            AppCertificateResource certificate2 = await container.GetAsync(certificateName);
            ResourceDataHelper.AssertCertificate(certificate1.Data, certificate2.Data);
        }

        [TestCase]
        [RecordedTest]
        [Ignore("Service request failed.Status: 500 (Internal Server Error)")]
        public async Task GetAll()
        {
            var container = await GetCertificatesCollectionAsync();
            var input = ResourceDataHelper.GetBasicCertificateData(DefaultLocation);
            _ = await container.CreateOrUpdateAsync(WaitUntil.Completed, Recording.GenerateAssetName("testCertificate-"), input);
            _ = await container.CreateOrUpdateAsync(WaitUntil.Completed, Recording.GenerateAssetName("testCertificate-"), input);
            int count = 0;
            await foreach (var certificate in container.GetAllAsync())
            {
                count++;
            }
            Assert.GreaterOrEqual(count, 2);
        }

        [TestCase]
        [RecordedTest]
        [Ignore("Service request failed.Status: 500 (Internal Server Error)")]
        public async Task Exists()
        {
            var container = await GetCertificatesCollectionAsync();
            var certificateName = Recording.GenerateAssetName("testCertificate-");
            var input = ResourceDataHelper.GetBasicCertificateData(DefaultLocation);
            var lro = await container.CreateOrUpdateAsync(WaitUntil.Completed, certificateName, input);
            AppCertificateResource certificate = lro.Value;
            Assert.IsTrue(await container.ExistsAsync(certificateName));
            Assert.IsFalse(await container.ExistsAsync(certificateName + "1"));

            Assert.ThrowsAsync<ArgumentNullException>(async () => _ = await container.ExistsAsync(null));
        }
    }
}
