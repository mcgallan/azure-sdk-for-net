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
            var assignments = Client.GetDenyAssignments(new Core.ResourceIdentifier("/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}"));
            AsyncPageable<GenericResource> resources = resourceGroup.GetGenericResourcesAsync();
            //var lro = resources.
            await foreach (GenericResource resource in resources)
            {
                var genericResourceData = resource.Data;
                Pageable<DenyAssignmentResource>  denyAssignments = GetDenyAssignmentResource(resource);
                int count = 0;
                foreach (DenyAssignmentResource assignment in denyAssignments)
                {
                    var denyResource = await assignment.GetAsync();
                    var denyType = denyResource.GetType;
                    count++;
                    var type = denyResource.Value.Data.ResourceType;
                    Assert.IsNotNull(type);
                    Assert.AreEqual(denyType, type);
                    Assert.AreEqual(typeof(DenyAssignmentResource), type);
                }
                Assert.GreaterOrEqual(count, 1);
            }
        }
    }
}
