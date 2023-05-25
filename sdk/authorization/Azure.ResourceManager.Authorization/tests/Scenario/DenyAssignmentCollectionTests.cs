// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Authorization.Tests.Scenario
{
    public class DenyAssignmentCollectionTests : AuthorizationManagementTestBase
    {
        public DenyAssignmentCollectionTests(bool isAsync)
                    : base(isAsync, RecordedTestMode.Record)
        {
        }

        public Pageable<DenyAssignmentResource> GetDenyAssignmentResource(GenericResource ga)
        {
            DenyAssignmentCollection data = ga.GetDenyAssignments();
            return data.GetAll();
        }

        [TestCase]
        public async Task DenyAssignmentTests()
        {
            var resourceGroup = await CreateResourceGroupAsync();
            AsyncPageable<GenericResource> resources = resourceGroup.GetGenericResourcesAsync();
            //var lro = resources.
            await foreach (GenericResource resource in resources)
            {
                Pageable<DenyAssignmentResource>  denyAssignments = GetDenyAssignmentResource(resource);
                foreach (DenyAssignmentResource assignment in denyAssignments)
                {
                    var denyResource = await assignment.GetAsync();
                    var type = denyResource.Value.Data.ResourceType;
                    Assert.AreEqual(typeof(DenyAssignmentResource), type);
                }
            }
        }
    }
}
