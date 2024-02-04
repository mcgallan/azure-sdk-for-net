// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmServiceFabricModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ServiceFabric.ServiceFabricClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="addOnFeatures"> The list of add-on features to enable in the cluster. </param>
        /// <param name="availableClusterVersions"> The Service Fabric runtime versions available for this cluster. </param>
        /// <param name="azureActiveDirectory"> The AAD authentication settings of the cluster. </param>
        /// <param name="certificate"> The certificate to use for securing the cluster. The certificate provided will be used for node to node security within the cluster, SSL certificate for cluster management endpoint and default admin client. </param>
        /// <param name="certificateCommonNames"> Describes a list of server certificates referenced by common name that are used to secure the cluster. </param>
        /// <param name="clientCertificateCommonNames"> The list of client certificates referenced by common name that are allowed to manage the cluster. </param>
        /// <param name="clientCertificateThumbprints"> The list of client certificates referenced by thumbprint that are allowed to manage the cluster. </param>
        /// <param name="clusterCodeVersion"> The Service Fabric runtime version of the cluster. This property can only by set the user when **upgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](https://learn.microsoft.com/rest/api/servicefabric/cluster-versions/list). To get the list of available version for existing clusters use **availableClusterVersions**. </param>
        /// <param name="clusterEndpoint"> The Azure Resource Provider endpoint. A system service in the cluster connects to this  endpoint. </param>
        /// <param name="clusterId"> A service generated unique identifier for the cluster resource. </param>
        /// <param name="clusterState">
        /// The current state of the cluster.
        ///
        ///   - WaitingForNodes - Indicates that the cluster resource is created and the resource provider is waiting for Service Fabric VM extension to boot up and report to it.
        ///   - Deploying - Indicates that the Service Fabric runtime is being installed on the VMs. Cluster resource will be in this state until the cluster boots up and system services are up.
        ///   - BaselineUpgrade - Indicates that the cluster is upgrading to establishes the cluster version. This upgrade is automatically initiated when the cluster boots up for the first time.
        ///   - UpdatingUserConfiguration - Indicates that the cluster is being upgraded with the user provided configuration.
        ///   - UpdatingUserCertificate - Indicates that the cluster is being upgraded with the user provided certificate.
        ///   - UpdatingInfrastructure - Indicates that the cluster is being upgraded with the latest Service Fabric runtime version. This happens only when the **upgradeMode** is set to 'Automatic'.
        ///   - EnforcingClusterVersion - Indicates that cluster is on a different version than expected and the cluster is being upgraded to the expected version.
        ///   - UpgradeServiceUnreachable - Indicates that the system service in the cluster is no longer polling the Resource Provider. Clusters in this state cannot be managed by the Resource Provider.
        ///   - AutoScale - Indicates that the ReliabilityLevel of the cluster is being adjusted.
        ///   - Ready - Indicates that the cluster is in a stable state.
        ///
        /// </param>
        /// <param name="diagnosticsStorageAccountConfig"> The storage account information for storing Service Fabric diagnostic logs. </param>
        /// <param name="isEventStoreServiceEnabled"> Indicates if the event store service is enabled. </param>
        /// <param name="fabricSettings"> The list of custom fabric settings to configure the cluster. </param>
        /// <param name="managementEndpoint"> The http management endpoint of the cluster. </param>
        /// <param name="nodeTypes"> The list of node types in the cluster. </param>
        /// <param name="provisioningState"> The provisioning state of the cluster resource. </param>
        /// <param name="reliabilityLevel">
        /// The reliability level sets the replica set size of system services. Learn about [ReliabilityLevel](https://docs.microsoft.com/azure/service-fabric/service-fabric-cluster-capacity).
        ///
        ///   - None - Run the System services with a target replica set count of 1. This should only be used for test clusters.
        ///   - Bronze - Run the System services with a target replica set count of 3. This should only be used for test clusters.
        ///   - Silver - Run the System services with a target replica set count of 5.
        ///   - Gold - Run the System services with a target replica set count of 7.
        ///   - Platinum - Run the System services with a target replica set count of 9.
        ///
        /// </param>
        /// <param name="reverseProxyCertificate"> The server certificate used by reverse proxy. </param>
        /// <param name="reverseProxyCertificateCommonNames"> Describes a list of server certificates referenced by common name that are used to secure the cluster. </param>
        /// <param name="upgradeDescription"> The policy to use when upgrading the cluster. </param>
        /// <param name="upgradeMode"> The upgrade mode of the cluster when new Service Fabric runtime version is available. </param>
        /// <param name="maxUnusedVersionsToKeep"> The policy used to clean up unused versions. </param>
        /// <param name="vmImage"> The VM image VMSS has been configured with. Generic names such as Windows or Linux can be used. </param>
        /// <param name="serviceFabricZonalUpgradeMode"> This property controls the logical grouping of VMs in upgrade domains (UDs). This property can't be modified if a node type with multiple Availability Zones is already present in the cluster. </param>
        /// <param name="vmssZonalUpgradeMode"> This property defines the upgrade mode for the virtual machine scale set, it is mandatory if a node type with multiple Availability Zones is added. </param>
        /// <param name="isInfrastructureServiceManagerEnabled"> Indicates if infrastructure service manager is enabled. </param>
        /// <param name="upgradeWave"> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **upgradeMode** is set to 'Automatic'. </param>
        /// <param name="upgradePauseStartOn"> Indicates the start date and time to pause automatic runtime version upgrades on the cluster for an specific period of time on the cluster (UTC). </param>
        /// <param name="upgradePauseEndOn"> Indicates the end date and time to pause automatic runtime version upgrades on the cluster for an specific period of time on the cluster (UTC). </param>
        /// <param name="isWaveUpgradePaused"> Boolean to pause automatic runtime version upgrades to the cluster. </param>
        /// <param name="notifications"> Indicates a list of notification channels for cluster events. </param>
        /// <param name="isHttpGatewayExclusiveAuthModeEnabled"> If true, token-based authentication is not allowed on the HttpGatewayEndpoint. This is required to support TLS versions 1.3 and above. If token-based authentication is used, HttpGatewayTokenAuthEndpointPort must be defined. </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <returns> A new <see cref="ServiceFabric.ServiceFabricClusterData"/> instance for mocking. </returns>
        public static ServiceFabricClusterData ServiceFabricClusterData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IEnumerable<ClusterAddOnFeature> addOnFeatures = null, IEnumerable<ClusterVersionDetails> availableClusterVersions = null, ClusterAadSetting azureActiveDirectory = null, ClusterCertificateDescription certificate = null, ClusterServerCertificateCommonNames certificateCommonNames = null, IEnumerable<ClusterClientCertificateCommonName> clientCertificateCommonNames = null, IEnumerable<ClusterClientCertificateThumbprint> clientCertificateThumbprints = null, string clusterCodeVersion = null, Uri clusterEndpoint = null, Guid? clusterId = null, ServiceFabricClusterState? clusterState = null, DiagnosticsStorageAccountConfig diagnosticsStorageAccountConfig = null, bool? isEventStoreServiceEnabled = null, IEnumerable<SettingsSectionDescription> fabricSettings = null, Uri managementEndpoint = null, IEnumerable<ClusterNodeTypeDescription> nodeTypes = null, ServiceFabricProvisioningState? provisioningState = null, ClusterReliabilityLevel? reliabilityLevel = null, ClusterCertificateDescription reverseProxyCertificate = null, ClusterServerCertificateCommonNames reverseProxyCertificateCommonNames = null, ClusterUpgradePolicy upgradeDescription = null, ClusterUpgradeMode? upgradeMode = null, long? maxUnusedVersionsToKeep = null, string vmImage = null, SfZonalUpgradeMode? serviceFabricZonalUpgradeMode = null, VmssZonalUpgradeMode? vmssZonalUpgradeMode = null, bool? isInfrastructureServiceManagerEnabled = null, ClusterUpgradeCadence? upgradeWave = null, DateTimeOffset? upgradePauseStartOn = null, DateTimeOffset? upgradePauseEndOn = null, bool? isWaveUpgradePaused = null, IEnumerable<ClusterNotification> notifications = null, bool? isHttpGatewayExclusiveAuthModeEnabled = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();
            addOnFeatures ??= new List<ClusterAddOnFeature>();
            availableClusterVersions ??= new List<ClusterVersionDetails>();
            clientCertificateCommonNames ??= new List<ClusterClientCertificateCommonName>();
            clientCertificateThumbprints ??= new List<ClusterClientCertificateThumbprint>();
            fabricSettings ??= new List<SettingsSectionDescription>();
            nodeTypes ??= new List<ClusterNodeTypeDescription>();
            notifications ??= new List<ClusterNotification>();

            return new ServiceFabricClusterData(id, name, resourceType, systemData, tags, location, addOnFeatures?.ToList(), availableClusterVersions?.ToList(), azureActiveDirectory, certificate, certificateCommonNames, clientCertificateCommonNames?.ToList(), clientCertificateThumbprints?.ToList(), clusterCodeVersion, clusterEndpoint, clusterId, clusterState, diagnosticsStorageAccountConfig, isEventStoreServiceEnabled, fabricSettings?.ToList(), managementEndpoint, nodeTypes?.ToList(), provisioningState, reliabilityLevel, reverseProxyCertificate, reverseProxyCertificateCommonNames, upgradeDescription, upgradeMode, maxUnusedVersionsToKeep.HasValue ? new ApplicationTypeVersionsCleanupPolicy(maxUnusedVersionsToKeep.Value, serializedAdditionalRawData: null) : null, vmImage, serviceFabricZonalUpgradeMode, vmssZonalUpgradeMode, isInfrastructureServiceManagerEnabled, upgradeWave, upgradePauseStartOn, upgradePauseEndOn, isWaveUpgradePaused, notifications?.ToList(), isHttpGatewayExclusiveAuthModeEnabled, etag, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterVersionDetails"/>. </summary>
        /// <param name="codeVersion"> The Service Fabric runtime version of the cluster. </param>
        /// <param name="supportExpireOn"> The date of expiry of support of the version. </param>
        /// <param name="environment"> Indicates if this version is for Windows or Linux operating system. </param>
        /// <returns> A new <see cref="Models.ClusterVersionDetails"/> instance for mocking. </returns>
        public static ClusterVersionDetails ClusterVersionDetails(string codeVersion = null, DateTimeOffset? supportExpireOn = null, ClusterEnvironment? environment = null)
        {
            return new ClusterVersionDetails(codeVersion, supportExpireOn, environment, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ClusterCodeVersionsResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="codeVersion"> The Service Fabric runtime version of the cluster. </param>
        /// <param name="supportExpireOn"> The date of expiry of support of the version. </param>
        /// <param name="environment"> Indicates if this version is for Windows or Linux operating system. </param>
        /// <returns> A new <see cref="Models.ClusterCodeVersionsResult"/> instance for mocking. </returns>
        public static ClusterCodeVersionsResult ClusterCodeVersionsResult(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string codeVersion = null, DateTimeOffset? supportExpireOn = null, ClusterEnvironment? environment = null)
        {
            return new ClusterCodeVersionsResult(id, name, resourceType, systemData, codeVersion, supportExpireOn, environment, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UpgradableVersionPathResult"/>. </summary>
        /// <param name="supportedPath"></param>
        /// <returns> A new <see cref="Models.UpgradableVersionPathResult"/> instance for mocking. </returns>
        public static UpgradableVersionPathResult UpgradableVersionPathResult(IEnumerable<string> supportedPath = null)
        {
            supportedPath ??= new List<string>();

            return new UpgradableVersionPathResult(supportedPath?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabric.ServiceFabricVmSizeResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vmSize"> VM Size properties. </param>
        /// <returns> A new <see cref="ServiceFabric.ServiceFabricVmSizeResourceData"/> instance for mocking. </returns>
        public static ServiceFabricVmSizeResourceData ServiceFabricVmSizeResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string vmSize = null)
        {
            return new ServiceFabricVmSizeResourceData(id, name, resourceType, systemData, vmSize != null ? new VmSize(vmSize, serializedAdditionalRawData: null) : null, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabric.ServiceFabricApplicationTypeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <returns> A new <see cref="ServiceFabric.ServiceFabricApplicationTypeData"/> instance for mocking. </returns>
        public static ServiceFabricApplicationTypeData ServiceFabricApplicationTypeData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string provisioningState = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ServiceFabricApplicationTypeData(id, name, resourceType, systemData, tags, location, provisioningState, etag, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabric.ServiceFabricApplicationTypeVersionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="appPackageUri"> The URL to the application package. </param>
        /// <param name="defaultParameterList"> List of application type parameters that can be overridden when creating or updating the application. </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <returns> A new <see cref="ServiceFabric.ServiceFabricApplicationTypeVersionData"/> instance for mocking. </returns>
        public static ServiceFabricApplicationTypeVersionData ServiceFabricApplicationTypeVersionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string provisioningState = null, Uri appPackageUri = null, IReadOnlyDictionary<string, string> defaultParameterList = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();
            defaultParameterList ??= new Dictionary<string, string>();

            return new ServiceFabricApplicationTypeVersionData(id, name, resourceType, systemData, tags, location, provisioningState, appPackageUri, defaultParameterList, etag, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabric.ServiceFabricApplicationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Describes the managed identities for an Azure resource. </param>
        /// <param name="typeVersion"> The version of the application type as defined in the application manifest. </param>
        /// <param name="parameters"> List of application parameters with overridden values from their default values specified in the application manifest. </param>
        /// <param name="upgradePolicy"> Describes the policy for a monitored application upgrade. </param>
        /// <param name="minimumNodes"> The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property. </param>
        /// <param name="maximumNodes"> The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node. </param>
        /// <param name="removeApplicationCapacity"> Remove the current application capacity settings. </param>
        /// <param name="metrics"> List of application capacity metric description. </param>
        /// <param name="managedIdentities"> List of user assigned identities for the application, each mapped to a friendly name. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="typeName"> The application type name as defined in the application manifest. </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <returns> A new <see cref="ServiceFabric.ServiceFabricApplicationData"/> instance for mocking. </returns>
        public static ServiceFabricApplicationData ServiceFabricApplicationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, string typeVersion = null, IDictionary<string, string> parameters = null, ApplicationUpgradePolicy upgradePolicy = null, long? minimumNodes = null, long? maximumNodes = null, bool? removeApplicationCapacity = null, IEnumerable<ApplicationMetricDescription> metrics = null, IEnumerable<ApplicationUserAssignedIdentity> managedIdentities = null, string provisioningState = null, string typeName = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();
            parameters ??= new Dictionary<string, string>();
            metrics ??= new List<ApplicationMetricDescription>();
            managedIdentities ??= new List<ApplicationUserAssignedIdentity>();

            return new ServiceFabricApplicationData(id, name, resourceType, systemData, tags, location, identity, typeVersion, parameters, upgradePolicy, minimumNodes, maximumNodes, removeApplicationCapacity, metrics?.ToList(), managedIdentities?.ToList(), provisioningState, typeName, etag, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ServiceFabricApplicationPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="typeVersion"> The version of the application type as defined in the application manifest. </param>
        /// <param name="parameters"> List of application parameters with overridden values from their default values specified in the application manifest. </param>
        /// <param name="upgradePolicy"> Describes the policy for a monitored application upgrade. </param>
        /// <param name="minimumNodes"> The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property. </param>
        /// <param name="maximumNodes"> The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node. </param>
        /// <param name="removeApplicationCapacity"> Remove the current application capacity settings. </param>
        /// <param name="metrics"> List of application capacity metric description. </param>
        /// <param name="managedIdentities"> List of user assigned identities for the application, each mapped to a friendly name. </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <returns> A new <see cref="Models.ServiceFabricApplicationPatch"/> instance for mocking. </returns>
        public static ServiceFabricApplicationPatch ServiceFabricApplicationPatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string typeVersion = null, IDictionary<string, string> parameters = null, ApplicationUpgradePolicy upgradePolicy = null, long? minimumNodes = null, long? maximumNodes = null, bool? removeApplicationCapacity = null, IEnumerable<ApplicationMetricDescription> metrics = null, IEnumerable<ApplicationUserAssignedIdentity> managedIdentities = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();
            parameters ??= new Dictionary<string, string>();
            metrics ??= new List<ApplicationMetricDescription>();
            managedIdentities ??= new List<ApplicationUserAssignedIdentity>();

            return new ServiceFabricApplicationPatch(id, name, resourceType, systemData, tags, location, typeVersion, parameters, upgradePolicy, minimumNodes, maximumNodes, removeApplicationCapacity, metrics?.ToList(), managedIdentities?.ToList(), etag, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of ServiceFabricClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="addOnFeatures"> The list of add-on features to enable in the cluster. </param>
        /// <param name="availableClusterVersions"> The Service Fabric runtime versions available for this cluster. </param>
        /// <param name="azureActiveDirectory"> The AAD authentication settings of the cluster. </param>
        /// <param name="certificate"> The certificate to use for securing the cluster. The certificate provided will be used for node to node security within the cluster, SSL certificate for cluster management endpoint and default admin client. </param>
        /// <param name="certificateCommonNames"> Describes a list of server certificates referenced by common name that are used to secure the cluster. </param>
        /// <param name="clientCertificateCommonNames"> The list of client certificates referenced by common name that are allowed to manage the cluster. </param>
        /// <param name="clientCertificateThumbprints"> The list of client certificates referenced by thumbprint that are allowed to manage the cluster. </param>
        /// <param name="clusterCodeVersion"> The Service Fabric runtime version of the cluster. This property can only by set the user when **upgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](./ClusterVersion.md). To get the list of available version for existing clusters use **availableClusterVersions**. </param>
        /// <param name="clusterEndpoint"> The Azure Resource Provider endpoint. A system service in the cluster connects to this  endpoint. </param>
        /// <param name="clusterId"> A service generated unique identifier for the cluster resource. </param>
        /// <param name="clusterState">
        /// The current state of the cluster.
        /// - WaitingForNodes - Indicates that the cluster resource is created and the resource provider is waiting for Service Fabric VM extension to boot up and report to it.
        /// - Deploying - Indicates that the Service Fabric runtime is being installed on the VMs. Cluster resource will be in this state until the cluster boots up and system services are up.
        /// - BaselineUpgrade - Indicates that the cluster is upgrading to establishes the cluster version. This upgrade is automatically initiated when the cluster boots up for the first time.
        /// - UpdatingUserConfiguration - Indicates that the cluster is being upgraded with the user provided configuration.
        /// - UpdatingUserCertificate - Indicates that the cluster is being upgraded with the user provided certificate.
        /// - UpdatingInfrastructure - Indicates that the cluster is being upgraded with the latest Service Fabric runtime version. This happens only when the **upgradeMode** is set to 'Automatic'.
        /// - EnforcingClusterVersion - Indicates that cluster is on a different version than expected and the cluster is being upgraded to the expected version.
        /// - UpgradeServiceUnreachable - Indicates that the system service in the cluster is no longer polling the Resource Provider. Clusters in this state cannot be managed by the Resource Provider.
        /// - AutoScale - Indicates that the ReliabilityLevel of the cluster is being adjusted.
        /// - Ready - Indicates that the cluster is in a stable state.
        /// </param>
        /// <param name="diagnosticsStorageAccountConfig"> The storage account information for storing Service Fabric diagnostic logs. </param>
        /// <param name="isEventStoreServiceEnabled"> Indicates if the event store service is enabled. </param>
        /// <param name="fabricSettings"> The list of custom fabric settings to configure the cluster. </param>
        /// <param name="managementEndpoint"> The http management endpoint of the cluster. </param>
        /// <param name="nodeTypes"> The list of node types in the cluster. </param>
        /// <param name="provisioningState"> The provisioning state of the cluster resource. </param>
        /// <param name="reliabilityLevel">
        /// The reliability level sets the replica set size of system services. Learn about [ReliabilityLevel](https://docs.microsoft.com/azure/service-fabric/service-fabric-cluster-capacity).
        /// - None - Run the System services with a target replica set count of 1. This should only be used for test clusters.
        /// - Bronze - Run the System services with a target replica set count of 3. This should only be used for test clusters.
        /// - Silver - Run the System services with a target replica set count of 5.
        /// - Gold - Run the System services with a target replica set count of 7.
        /// - Platinum - Run the System services with a target replica set count of 9.
        /// </param>
        /// <param name="reverseProxyCertificate"> The server certificate used by reverse proxy. </param>
        /// <param name="reverseProxyCertificateCommonNames"> Describes a list of server certificates referenced by common name that are used to secure the cluster. </param>
        /// <param name="upgradeDescription"> The policy to use when upgrading the cluster. </param>
        /// <param name="upgradeMode"> The upgrade mode of the cluster when new Service Fabric runtime version is available. </param>
        /// <param name="maxUnusedVersionsToKeep"> The policy used to clean up unused versions. </param>
        /// <param name="vmImage"> The VM image VMSS has been configured with. Generic names such as Windows or Linux can be used. </param>
        /// <param name="serviceFabricZonalUpgradeMode"> This property controls the logical grouping of VMs in upgrade domains (UDs). This property can't be modified if a node type with multiple Availability Zones is already present in the cluster. </param>
        /// <param name="vmssZonalUpgradeMode"> This property defines the upgrade mode for the virtual machine scale set, it is mandatory if a node type with multiple Availability Zones is added. </param>
        /// <param name="isInfrastructureServiceManagerEnabled"> Indicates if infrastructure service manager is enabled. </param>
        /// <param name="upgradeWave"> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **upgradeMode** is set to 'Automatic'. </param>
        /// <param name="upgradePauseStartOn"> Indicates the start date and time to pause automatic runtime version upgrades on the cluster for an specific period of time on the cluster (UTC). </param>
        /// <param name="upgradePauseEndOn"> Indicates the end date and time to pause automatic runtime version upgrades on the cluster for an specific period of time on the cluster (UTC). </param>
        /// <param name="isWaveUpgradePaused"> Boolean to pause automatic runtime version upgrades to the cluster. </param>
        /// <param name="notifications"> Indicates a list of notification channels for cluster events. </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.ServiceFabric.ServiceFabricClusterData" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ServiceFabricClusterData ServiceFabricClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IEnumerable<ClusterAddOnFeature> addOnFeatures, IEnumerable<ClusterVersionDetails> availableClusterVersions, ClusterAadSetting azureActiveDirectory, ClusterCertificateDescription certificate, ClusterServerCertificateCommonNames certificateCommonNames, IEnumerable<ClusterClientCertificateCommonName> clientCertificateCommonNames, IEnumerable<ClusterClientCertificateThumbprint> clientCertificateThumbprints, string clusterCodeVersion, Uri clusterEndpoint, Guid? clusterId, ServiceFabricClusterState? clusterState, DiagnosticsStorageAccountConfig diagnosticsStorageAccountConfig, bool? isEventStoreServiceEnabled, IEnumerable<SettingsSectionDescription> fabricSettings, Uri managementEndpoint, IEnumerable<ClusterNodeTypeDescription> nodeTypes, ServiceFabricProvisioningState? provisioningState, ClusterReliabilityLevel? reliabilityLevel, ClusterCertificateDescription reverseProxyCertificate, ClusterServerCertificateCommonNames reverseProxyCertificateCommonNames, ClusterUpgradePolicy upgradeDescription, ClusterUpgradeMode? upgradeMode, long? maxUnusedVersionsToKeep, string vmImage, SfZonalUpgradeMode? serviceFabricZonalUpgradeMode, VmssZonalUpgradeMode? vmssZonalUpgradeMode, bool? isInfrastructureServiceManagerEnabled, ClusterUpgradeCadence? upgradeWave, DateTimeOffset? upgradePauseStartOn, DateTimeOffset? upgradePauseEndOn, bool? isWaveUpgradePaused, IEnumerable<ClusterNotification> notifications, ETag? etag)
        {
            return ServiceFabricClusterData(id: id, name: name, resourceType: resourceType, systemData: systemData, tags: tags, location: location, addOnFeatures: addOnFeatures, availableClusterVersions: availableClusterVersions, azureActiveDirectory: azureActiveDirectory, certificate: certificate, certificateCommonNames: certificateCommonNames, clientCertificateCommonNames: clientCertificateCommonNames, clientCertificateThumbprints: clientCertificateThumbprints, clusterCodeVersion: clusterCodeVersion, clusterEndpoint: clusterEndpoint, clusterId: clusterId, clusterState: clusterState, diagnosticsStorageAccountConfig: diagnosticsStorageAccountConfig, isEventStoreServiceEnabled: isEventStoreServiceEnabled, fabricSettings: fabricSettings, managementEndpoint: managementEndpoint, nodeTypes: nodeTypes, provisioningState: provisioningState, reliabilityLevel: reliabilityLevel, reverseProxyCertificate: reverseProxyCertificate, reverseProxyCertificateCommonNames: reverseProxyCertificateCommonNames, upgradeDescription: upgradeDescription, upgradeMode: upgradeMode, maxUnusedVersionsToKeep: maxUnusedVersionsToKeep, vmImage: vmImage, serviceFabricZonalUpgradeMode: serviceFabricZonalUpgradeMode, vmssZonalUpgradeMode: vmssZonalUpgradeMode, isInfrastructureServiceManagerEnabled: isInfrastructureServiceManagerEnabled, upgradeWave: upgradeWave, upgradePauseStartOn: upgradePauseStartOn, upgradePauseEndOn: upgradePauseEndOn, isWaveUpgradePaused: isWaveUpgradePaused, notifications: notifications, isHttpGatewayExclusiveAuthModeEnabled: default, etag: etag);
        }
    }
}
