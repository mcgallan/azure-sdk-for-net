// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;
using Azure.Core;
using System;
using System.Text;
using Azure.ResourceManager.Resources;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using System.IO;

namespace Azure.ResourceManager.Avs.Tests.ResourceHelpers
{
    public static class ResourceDataHelpers
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

        public static void AssertResource(ResourceData r1, ResourceData r2)
        {
            Assert.AreEqual(r1.Name, r2.Name);
            Assert.AreEqual(r1.Id, r2.Id);
            Assert.AreEqual(r1.ResourceType, r2.ResourceType);
        }

        #region AddonData
        public static void AssertAvsPrivateCloudAddonData(AvsPrivateCloudAddonData data1, AvsPrivateCloudAddonData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.Properties.AddonType, data2.Properties.AddonType);
        }
        public static AvsPrivateCloudAddonData GetAvsPrivateCloudAddonData()
        {
            var data = new AvsPrivateCloudAddonData()
            {
                Properties = new AddonHcxProperties("VMware MaaS Cloud Provider (Enterprise)")
            };
            return data;
        }
        #endregion

        #region AvsData
        public static void AssertAvsPrivateCloudData(AvsPrivateCloudData data1, AvsPrivateCloudData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.NetworkBlock, data2.NetworkBlock);
            Assert.AreEqual(data1.ManagementCluster, data2.ManagementCluster);
        }
        public static AvsPrivateCloudData GetAvsPrivateCloudData()
        {
            var data = new AvsPrivateCloudData(AzureLocation.WestUS2, new AvsSku("av36p"))
            {
               ManagementCluster = new AvsManagementCluster()
               {
                   ClusterSize = 3
               },
               NetworkBlock = "192.168.48.0/22",
            };
            return data;
        }
        #endregion

        #region AvsCloudLinkData
        public static void AssertAvsCloudLinkData(AvsCloudLinkData data1, AvsCloudLinkData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.Status, data2.Status);
            Assert.AreEqual(data1.LinkedCloud, data2.LinkedCloud);
        }
        public static AvsCloudLinkData GetAvsCloudLinkData()
        {
            var data = new AvsCloudLinkData()
            {
                LinkedCloud = new ResourceIdentifier("/subscriptions/ba75e79b-dd95-4025-9dbf-3a7ae8dff2b5/resourceGroups/mock-avs-fct-dogfood-conveyor-centralus/providers/Microsoft.AVS/privateClouds/fct-mock-centralus-45")
            };
            return data;
        }
        #endregion

        #region AvsPrivateCloudCluster
        public static void AssertAvsCloudClusterData(AvsPrivateCloudClusterData data1, AvsPrivateCloudClusterData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.Sku, data2.Sku);
            Assert.AreEqual(data1.ClusterSize, data2.ClusterSize);
        }
        public static AvsPrivateCloudClusterData GetAvsCloudClusterData()
        {
            var data = new AvsPrivateCloudClusterData(new AvsSku("av20"))
            {
                ClusterSize= 3
            };
            return data;
        }
        #endregion

        #region DataStoreData
        public static void AssertDataStoreData(AvsPrivateCloudDatastoreData data1, AvsPrivateCloudDatastoreData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.DiskPoolVolume, data2.DiskPoolVolume);
        }
        public static AvsPrivateCloudDatastoreData GetDataStoreData()
        {
            var data = new AvsPrivateCloudDatastoreData()
            {
                DiskPoolVolume = new DiskPoolVolume(new ResourceIdentifier("/subscriptions/11111111-1111-1111-1111-111111111111/resourceGroups/resourceGroupName/providers/Microsoft.StoragePool/diskPools/diskPoolName/iscsiTargets/targetName"), "mock-lun-name")
                {
                    MountOption = "MOUNT"
                }
            };
            return data;
        }
        #endregion

        #region GlobalReachConnectionData
        public static void AssertGlobalReachConnectionDataData(GlobalReachConnectionData data1, GlobalReachConnectionData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.PeerExpressRouteCircuit, data2.PeerExpressRouteCircuit);
            Assert.AreEqual(data1.AuthorizationKey, data2.AuthorizationKey);
            Assert.AreEqual(data1.CircuitConnectionStatus, data2.CircuitConnectionStatus);
            Assert.AreEqual(data1.AddressPrefix, data2.AddressPrefix);
            Assert.AreEqual(data1.ExpressRouteId, data2.ExpressRouteId);
        }
        public static GlobalReachConnectionData GetGlobalReachConnectionData()
        {
            var data = new GlobalReachConnectionData()
            {
                PeerExpressRouteCircuit = new ResourceIdentifier("/subscriptions/12341234-1234-1234-1234-123412341234/resourceGroups/mygroup/providers/Microsoft.Network/expressRouteCircuits/mypeer"),
                AuthorizationKey = "01010101-0101-0101-0101-010101010101"
            };
            return data;
        }
        #endregion

        #region ScrpitAllData
        public static void AssertScriptPackageData(ScriptPackageData data1, ScriptPackageData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.Company, data2.Company);
            Assert.AreEqual(data1.Description, data2.Description);
            Assert.AreEqual(data1.Version, data2.Version);
            Assert.AreEqual(data1.Uri, data2.Uri);
        }
        public static ScriptPackageData GetScriptPackageData()
        {
            var data = new ScriptPackageData()
            {
            };
            return data;
        }

        public static void AssertScriptCmeletData(ScriptCmdletData data1, ScriptCmdletData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.Parameters, data2.Parameters);
            Assert.AreEqual(data1.Description, data2.Description);
            Assert.AreEqual(data1.Timeout, data2.Timeout);
        }
        public static ScriptCmdletData GetScriptCmdletData()
        {
            var data = new ScriptCmdletData()
            {
            };
            return data;
        }

        public static void AssertScriptExecutionData(ScriptExecutionData data1, ScriptExecutionData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.Parameters, data2.Parameters);
            Assert.AreEqual(data1.Output, data2.Output);
            Assert.AreEqual(data1.Timeout, data2.Timeout);
        }
        public static ScriptExecutionData GetScriptExecutionData()
        {
            var data = new ScriptExecutionData()
            {
                Timeout = "PT1H",
                ScriptCmdletId = new ResourceIdentifier("JSDR.Configuration/1.0.16/invoke-preflightjetdrsystemcheck")
            };
            return data;
        }
        #endregion

        #region WorkloadNetorkworksData
        public static void AssertDhcpData(WorkloadNetworkDhcpData data1, WorkloadNetworkDhcpData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.Properties, data2.Properties);
        }
        public static WorkloadNetworkDhcpData GetDhcpData()
        {
            var data = new WorkloadNetworkDhcpData()
            {
                Properties = new WorkloadNetworkDhcpRelay()
                {
                    ServerAddresses =
                    {
                        "10.1.1.1",
                        "10.1.1.2"
                    }
                }
            };
            return data;
        }

        public static void AssertDnsData(WorkloadNetworkDnsZoneData data1, WorkloadNetworkDnsZoneData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.DnsServerIPs, data2.DnsServerIPs);
        }
        public static WorkloadNetworkDnsZoneData GetDnsData()
        {
            var data = new WorkloadNetworkDnsZoneData()
            {
                DnsServerIPs =
                {
                    new System.Net.IPAddress(new byte[4]
                    {
                        1,1,1,1
                    })
                },
                Domain = {},
            };
            return data;
        }

        public static void AssertSegmentData(WorkloadNetworkSegmentData data1, WorkloadNetworkSegmentData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.DisplayName, data2.DisplayName);
            Assert.AreEqual(data1.Subnet, data2.Subnet);
        }
        public static WorkloadNetworkSegmentData GetSegmentData()
        {
            var data = new WorkloadNetworkSegmentData()
            {
                DisplayName = "modifiedSegment",
                Subnet = new WorkloadNetworkSegmentSubnet()
                {
                    GatewayAddress = "10.2.3.1/24"
                }
            };
            return data;
        }

        public static void AssertPortMirroringData(WorkloadNetworkPortMirroringProfileData data1, WorkloadNetworkPortMirroringProfileData data2)
        {
            AssertResource(data1, data2);
            Assert.AreEqual(data1.DisplayName, data2.DisplayName);
            Assert.AreEqual(data1.Direction, data2.Direction);
        }
        public static WorkloadNetworkPortMirroringProfileData GetPortMirroringData()
        {
            var data = new WorkloadNetworkPortMirroringProfileData()
            {
                DisplayName = "modifiedPortMirroring",
                Direction = PortMirroringProfileDirection.Bidirectional
            };
            return data;
        }
        #endregion
    }
}
