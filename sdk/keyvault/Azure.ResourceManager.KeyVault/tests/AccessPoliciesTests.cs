// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources.Models;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;

namespace Azure.ResourceManager.KeyVault.Tests
{
    public class AccessPoliciesTests : VaultOperationsTestsBase
    {
        public AccessPoliciesTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
        }

        [SetUp]
        public async Task ClearChallengeCacheforRecord()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                await Initialize().ConfigureAwait(false);
            }
        }

        [RecordedTest]
        public async Task UpdateAccessPolicies()
        {
            IgnoreTestInLiveMode();
            // Create a Vault first
            KeyVaultCreateOrUpdateContent parameters = new KeyVaultCreateOrUpdateContent(Location, VaultProperties);
            parameters.Tags.InitializeFrom(Tags);
            ArmOperation<KeyVaultResource> resource = await VaultCollection.CreateOrUpdateAsync(WaitUntil.Completed, VaultName, parameters).ConfigureAwait(false);
            KeyVaultResource vaultResource1 = resource.Value;
            Dictionary<string, string> updateTags = new Dictionary<string, string>()
            {
                { "updatetag1", "uopdatevalue1" }, { "updatetag2", "updatevalue2" }, { "updatetag3", "updatevalue3" }
            };
            //Update this Valut Tags
            parameters.Tags.InitializeFrom(updateTags);
            ArmOperation<KeyVaultResource> updateResource = await VaultCollection.CreateOrUpdateAsync(WaitUntil.Completed, vaultResource1.Data.Name, parameters).ConfigureAwait(false);
            KeyVaultResource updateVaultResource1 = resource.Value;
            Assert.GreaterOrEqual(updateVaultResource1.Data.Tags.Count, 0);
        }
    }
}
