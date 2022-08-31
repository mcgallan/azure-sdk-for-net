﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;
using Azure.Core;
using System;
using System.Net.Http.Headers;

namespace Azure.ResourceManager.Batch.Tests.Helpers
{
    public static class ResourceDataHelper
    {
        public static IDictionary<string, string> ReplaceWith(this IDictionary<string, string> dest, IDictionary<string, string> src)
        {
            dest.Clear();
            foreach (var kv in src)
            {
                dest.Add(kv);
            }

            return dest;
        }

        public static void AssertResourceData(ResourceData r1, ResourceData r2)
        {
            Assert.AreEqual(r1.Name, r2.Name);
            Assert.AreEqual(r1.Id, r2.Id);
            Assert.AreEqual(r1.ResourceType, r2.ResourceType);
        }

        #region BatchAccountCertificate
        public static BatchAccountCertificateCreateOrUpdateContent GetBatchAccountCertificateData()
        {
            var data = new BatchAccountCertificateCreateOrUpdateContent()
            {
                Format = BatchAccountCertificateFormat.Pfx,
                ThumbprintAlgorithm = "sha1",
                Thumbprint = new BinaryData("cff2ab63c8c955aaf71989efa641b906558d9fb7"),
                Password = "nodesdk"
        };
            return data;
        }
        public static void AssertCertificate(BatchAccountCertificateCreateOrUpdateContent certificateData1, BatchAccountCertificateCreateOrUpdateContent certificateData2)
        {
            AssertResourceData(certificateData1, certificateData2);
            Assert.AreEqual(certificateData1.ETag, certificateData2.ETag);
        }
        #endregion

        #region Account
        public static BatchAccountCreateOrUpdateContent GetBatchAccountData()
        {
            var data = new BatchAccountCreateOrUpdateContent(AzureLocation.WestUS);
            return data;
        }
        public static void AssertAccount(BatchAccountCreateOrUpdateContent account1, BatchAccountCreateOrUpdateContent account2)
        {
            //AssertResourceData(account1, account2);
            Assert.AreEqual(account1.Tags, account2.Tags);
        }
        #endregion

        #region Detector
        public static BatchAccountDetectorData GetDetectorData()
        {
            return new BatchAccountDetectorData()
            {
                Value = "ew0KICAibWV0YWRhdGEiOiB7DQogICAgImlkIjogInBvb2xzQW5kTm9kZXMiLA0KICAgICJuYW1lIjogIlBvb2xzIGFuZCBOb2RlcyIsDQogICAgImRlc2NyaXB0aW9uIjogbnVsbCwNCiAgICAiYXV0aG9yIjogIiIsDQogICAgImNhdGVnb3J5IjogbnVsbCwNCiAgICAic3VwcG9ydFRvcGljTGlzdCI6IFsNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDc3IiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDYxIiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDY1IiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDY2IiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDY5IiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDcyIiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDc5IiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDgyIiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDkxIiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDkzIiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfSwNCiAgICAgIHsNCiAgICAgICAgImlkIjogIjMyNjM1MDk0IiwNCiAgICAgICAgInBlc0lkIjogIjE1NjE0IiwNCiAgICAgICAgInR5cGVJZCI6ICJEaWFnbm9zdGljcy5Nb2RlbHNBbmRVdGlscy5BdHRyaWJ1dGVzLlN1cHBvcnRUb3BpYywgRGlhZ25vc3RpY3MuTW9kZWxzQW5kVXRpbHMsIFZlcnNpb249MS4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1udWxsIg0KICAgICAgfQ0KICAgIF0sDQogICAgImFuYWx5c2lzVHlwZXMiOiBudWxsLA0KICAgICJ0eXBlIjogIkFuYWx5c2lzIiwNCiAgICAic2NvcmUiOiAwLjANCiAgfSwNCiAgImRhdGFzZXQiOiBbXSwNCiAgInN0YXR1cyI6IHsNCiAgICAibWVzc2FnZSI6IG51bGwsDQogICAgInN0YXR1c0lkIjogNA0KICB9LA0KICAiZGF0YVByb3ZpZGVyc01ldGFkYXRhIjogbnVsbCwNCiAgInN1Z2dlc3RlZFV0dGVyYW5jZXMiOiBudWxsDQp9"
            };
        }
        public static void AssertDetector(BatchAccountDetectorData detectorData1, BatchAccountDetectorData detectorData2)
        {
            AssertResourceData(detectorData1, detectorData2);
            Assert.AreEqual(detectorData1.ETag, detectorData2.ETag);
        }
        #endregion

        #region Pool
        public static BatchAccountPoolData GetBatchAccountPoolData()
        {
            var data = new BatchAccountPoolData()
            {
                DisplayName = "test_pool",
                VmSize = "small",
                DeploymentConfiguration = new BatchDeploymentConfiguration()
                {
                    CloudServiceConfiguration = new BatchCloudServiceConfiguration("s")
                },
                StartTask = new BatchAccountPoolStartTask()
                {
                    CommandLine = "cmd.exe /c \"echo hello world\"",
                    ResourceFiles =
                    {
                        new BatchResourceFile()
                        {
                            HttpUri = new Uri("https://blobsource.com"),
                            FilePath = "filename.txt",
                            Identity = new ComputeNodeIdentityReference()
                        }
                    },
                    EnvironmentSettings =
                    {
                        new BatchEnvironmentSetting("ENV_VAR")
                        {
                            Value = "env_value"
                        }
                    },
                    UserIdentity = new BatchUserIdentity()
                    {
                        AutoUser = new BatchAutoUserSpecification()
                        {
                            ElevationLevel = BatchUserAccountElevationLevel.Admin,
                        }
                    }
                },
                UserAccounts =
                {
                    new BatchUserAccount("username", "randompasswd")
                },
                ScaleSettings = new BatchAccountPoolScaleSettings()
                {
                    FixedScale = new BatchAccountFixedScaleSettings()
                    {
                        TargetDedicatedNodes = 0,
                        TargetLowPriorityNodes = 0
                    }
                }
            };
            return (BatchAccountPoolData)data;
        }
        public static void AssertPoolData(BatchAccountPoolData poolData1, BatchAccountPoolData poolData2)
        {
            AssertResourceData(poolData1, poolData2);
            Assert.AreEqual(poolData1.ETag, poolData2.ETag);
        }
        #endregion

        #region Application
        public static BatchApplicationData GetBatchApplicationData()
        {
            return new BatchApplicationData()
            {
                AllowUpdates = true,
                DisplayName = "displayName",
                DefaultVersion = "blah"
            };
        }
        public static void AssertApplicationData(BatchApplicationData applicationData1, BatchApplicationData applicationData2)
        {
            AssertResourceData(applicationData1, applicationData2);
            Assert.AreEqual(applicationData1.ETag, applicationData2.ETag);
        }
        #endregion

        #region ApplicationPackage
        public static BatchApplicationPackageData GetBatchApplicationPackageData()
        {
            var packageData = new BatchApplicationPackageData()
            {
            };
            return packageData;
        }
        public static void AssertApplicationPckageData(BatchApplicationPackageData packageData1, BatchApplicationPackageData packageData2)
        {
            AssertResourceData(packageData1, packageData2);
            Assert.AreEqual(packageData1.ETag, packageData2.ETag);
        }
        #endregion

        #region PrivateLink
        public static BatchPrivateLinkResourceData GetBatchPrivateLinkResourceData()
        {
            var privateLinkData = new BatchPrivateLinkResourceData()
            {
            };
            return privateLinkData;
        }
        public static void AssertLinkData(BatchPrivateLinkResourceData batchPrivateLinkResourceData1, BatchPrivateLinkResourceData batchPrivateLinkResourceData2)
        {
            AssertResourceData(batchPrivateLinkResourceData2, batchPrivateLinkResourceData1);
            Assert.AreEqual(batchPrivateLinkResourceData2.ETag, batchPrivateLinkResourceData2.ETag);
        }
        #endregion
    }
}
