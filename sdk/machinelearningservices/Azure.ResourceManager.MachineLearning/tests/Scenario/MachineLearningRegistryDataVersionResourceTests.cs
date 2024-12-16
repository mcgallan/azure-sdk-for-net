// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.KeyVault;
using Azure.ResourceManager.MachineLearning;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources;
using NUnit.Framework;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.MachineLearning.Tests
{
    public class MachineLearningRegistryDataVersionResourceTests : MachineLearningTestBase
    {
        public MachineLearningRegistryDataVersionResourceTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task GetVersionResource()
        {
            var subscriptionId = "4d042dc6-fe17-4698-a23f-ec6a8d1e98f4";
            var resourceGroupName = "v-zihewangMLTest";
            var registryName = "mlregistry1213";
            var dataMlName = Recording.GenerateAssetName("datatestml");
            var machineLearningRegistryResourceId =
            MachineLearningRegistryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName);
            var machineLearningRegistry = Client.GetMachineLearningRegistryResource(machineLearningRegistryResourceId);

            var dataCollection = machineLearningRegistry.GetMachineLearningRegistryDataContainers();
            var property = new MachineLearningDataContainerProperties(MachineLearningDataType.Mltable);
            var datainput = new MachineLearningDataContainerData(property);
            var dataResource = await dataCollection.CreateOrUpdateAsync(WaitUntil.Completed, dataMlName, datainput);

            var versions = dataResource.Value.GetMachineLearningRegistryDataVersions();
            var versionproperties = new MachineLearningDataVersionProperties(new Uri("data"));
            var versiondata = new MachineLearningDataVersionData(versionproperties);
            var latestVersion = await versions.CreateOrUpdateAsync(WaitUntil.Completed, "v11.25", versiondata);
        }
    }
}
