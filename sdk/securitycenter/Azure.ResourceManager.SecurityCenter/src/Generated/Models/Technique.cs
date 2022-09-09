// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Techniques of the assessment. </summary>
    public readonly partial struct Technique : IEquatable<Technique>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Technique"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Technique(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AbuseElevationControlMechanismValue = "Abuse Elevation Control Mechanism";
        private const string AccessTokenManipulationValue = "Access Token Manipulation";
        private const string AccountDiscoveryValue = "Account Discovery";
        private const string AccountManipulationValue = "Account Manipulation";
        private const string ActiveScanningValue = "Active Scanning";
        private const string ApplicationLayerProtocolValue = "Application Layer Protocol";
        private const string AudioCaptureValue = "Audio Capture";
        private const string BootOrLogonAutostartExecutionValue = "Boot or Logon Autostart Execution";
        private const string BootOrLogonInitializationScriptsValue = "Boot or Logon Initialization Scripts";
        private const string BruteForceValue = "Brute Force";
        private const string CloudInfrastructureDiscoveryValue = "Cloud Infrastructure Discovery";
        private const string CloudServiceDashboardValue = "Cloud Service Dashboard";
        private const string CloudServiceDiscoveryValue = "Cloud Service Discovery";
        private const string CommandAndScriptingInterpreterValue = "Command and Scripting Interpreter";
        private const string CompromiseClientSoftwareBinaryValue = "Compromise Client Software Binary";
        private const string CompromiseInfrastructureValue = "Compromise Infrastructure";
        private const string ContainerAndResourceDiscoveryValue = "Container and Resource Discovery";
        private const string CreateAccountValue = "Create Account";
        private const string CreateOrModifySystemProcessValue = "Create or Modify System Process";
        private const string CredentialsFromPasswordStoresValue = "Credentials from Password Stores";
        private const string DataDestructionValue = "Data Destruction";
        private const string DataEncryptedForImpactValue = "Data Encrypted for Impact";
        private const string DataFromCloudStorageObjectValue = "Data from Cloud Storage Object";
        private const string DataFromConfigurationRepositoryValue = "Data from Configuration Repository";
        private const string DataFromInformationRepositoriesValue = "Data from Information Repositories";
        private const string DataFromLocalSystemValue = "Data from Local System";
        private const string DataManipulationValue = "Data Manipulation";
        private const string DataStagedValue = "Data Staged";
        private const string DefacementValue = "Defacement";
        private const string DeobfuscateDecodeFilesOrInformationValue = "Deobfuscate/Decode Files or Information";
        private const string DiskWipeValue = "Disk Wipe";
        private const string DomainTrustDiscoveryValue = "Domain Trust Discovery";
        private const string DriveByCompromiseValue = "Drive-by Compromise";
        private const string DynamicResolutionValue = "Dynamic Resolution";
        private const string EndpointDenialOfServiceValue = "Endpoint Denial of Service";
        private const string EventTriggeredExecutionValue = "Event Triggered Execution";
        private const string ExfiltrationOverAlternativeProtocolValue = "Exfiltration Over Alternative Protocol";
        private const string ExploitPublicFacingApplicationValue = "Exploit Public-Facing Application";
        private const string ExploitationForClientExecutionValue = "Exploitation for Client Execution";
        private const string ExploitationForCredentialAccessValue = "Exploitation for Credential Access";
        private const string ExploitationForDefenseEvasionValue = "Exploitation for Defense Evasion";
        private const string ExploitationForPrivilegeEscalationValue = "Exploitation for Privilege Escalation";
        private const string ExploitationOfRemoteServicesValue = "Exploitation of Remote Services";
        private const string ExternalRemoteServicesValue = "External Remote Services";
        private const string FallbackChannelsValue = "Fallback Channels";
        private const string FileAndDirectoryDiscoveryValue = "File and Directory Discovery";
        private const string GatherVictimNetworkInformationValue = "Gather Victim Network Information";
        private const string HideArtifactsValue = "Hide Artifacts";
        private const string HijackExecutionFlowValue = "Hijack Execution Flow";
        private const string ImpairDefensesValue = "Impair Defenses";
        private const string ImplantContainerImageValue = "Implant Container Image";
        private const string IndicatorRemovalOnHostValue = "Indicator Removal on Host";
        private const string IndirectCommandExecutionValue = "Indirect Command Execution";
        private const string IngressToolTransferValue = "Ingress Tool Transfer";
        private const string InputCaptureValue = "Input Capture";
        private const string InterProcessCommunicationValue = "Inter-Process Communication";
        private const string LateralToolTransferValue = "Lateral Tool Transfer";
        private const string ManInTheMiddleValue = "Man-in-the-Middle";
        private const string MasqueradingValue = "Masquerading";
        private const string ModifyAuthenticationProcessValue = "Modify Authentication Process";
        private const string ModifyRegistryValue = "Modify Registry";
        private const string NetworkDenialOfServiceValue = "Network Denial of Service";
        private const string NetworkServiceScanningValue = "Network Service Scanning";
        private const string NetworkSniffingValue = "Network Sniffing";
        private const string NonApplicationLayerProtocolValue = "Non-Application Layer Protocol";
        private const string NonStandardPortValue = "Non-Standard Port";
        private const string ObtainCapabilitiesValue = "Obtain Capabilities";
        private const string ObfuscatedFilesOrInformationValue = "Obfuscated Files or Information";
        private const string OfficeApplicationStartupValue = "Office Application Startup";
        private const string OSCredentialDumpingValue = "OS Credential Dumping";
        private const string PermissionGroupsDiscoveryValue = "Permission Groups Discovery";
        private const string PhishingValue = "Phishing";
        private const string PreOSBootValue = "Pre-OS Boot";
        private const string ProcessDiscoveryValue = "Process Discovery";
        private const string ProcessInjectionValue = "Process Injection";
        private const string ProtocolTunnelingValue = "Protocol Tunneling";
        private const string ProxyValue = "Proxy";
        private const string QueryRegistryValue = "Query Registry";
        private const string RemoteAccessSoftwareValue = "Remote Access Software";
        private const string RemoteServiceSessionHijackingValue = "Remote Service Session Hijacking";
        private const string RemoteServicesValue = "Remote Services";
        private const string RemoteSystemDiscoveryValue = "Remote System Discovery";
        private const string ResourceHijackingValue = "Resource Hijacking";
        private const string ScheduledTaskJobValue = "Scheduled Task/Job";
        private const string ScreenCaptureValue = "Screen Capture";
        private const string SearchVictimOwnedWebsitesValue = "Search Victim-Owned Websites";
        private const string ServerSoftwareComponentValue = "Server Software Component";
        private const string ServiceStopValue = "Service Stop";
        private const string SignedBinaryProxyExecutionValue = "Signed Binary Proxy Execution";
        private const string SoftwareDeploymentToolsValue = "Software Deployment Tools";
        private const string SQLStoredProceduresValue = "SQL Stored Procedures";
        private const string StealOrForgeKerberosTicketsValue = "Steal or Forge Kerberos Tickets";
        private const string SubvertTrustControlsValue = "Subvert Trust Controls";
        private const string SupplyChainCompromiseValue = "Supply Chain Compromise";
        private const string SystemInformationDiscoveryValue = "System Information Discovery";
        private const string TaintSharedContentValue = "Taint Shared Content";
        private const string TrafficSignalingValue = "Traffic Signaling";
        private const string TransferDataToCloudAccountValue = "Transfer Data to Cloud Account";
        private const string TrustedRelationshipValue = "Trusted Relationship";
        private const string UnsecuredCredentialsValue = "Unsecured Credentials";
        private const string UserExecutionValue = "User Execution";
        private const string ValidAccountsValue = "Valid Accounts";
        private const string WindowsManagementInstrumentationValue = "Windows Management Instrumentation";
        private const string FileAndDirectoryPermissionsModificationValue = "File and Directory Permissions Modification";

        /// <summary> Abuse Elevation Control Mechanism. </summary>
        public static Technique AbuseElevationControlMechanism { get; } = new Technique(AbuseElevationControlMechanismValue);
        /// <summary> Access Token Manipulation. </summary>
        public static Technique AccessTokenManipulation { get; } = new Technique(AccessTokenManipulationValue);
        /// <summary> Account Discovery. </summary>
        public static Technique AccountDiscovery { get; } = new Technique(AccountDiscoveryValue);
        /// <summary> Account Manipulation. </summary>
        public static Technique AccountManipulation { get; } = new Technique(AccountManipulationValue);
        /// <summary> Active Scanning. </summary>
        public static Technique ActiveScanning { get; } = new Technique(ActiveScanningValue);
        /// <summary> Application Layer Protocol. </summary>
        public static Technique ApplicationLayerProtocol { get; } = new Technique(ApplicationLayerProtocolValue);
        /// <summary> Audio Capture. </summary>
        public static Technique AudioCapture { get; } = new Technique(AudioCaptureValue);
        /// <summary> Boot or Logon Autostart Execution. </summary>
        public static Technique BootOrLogonAutostartExecution { get; } = new Technique(BootOrLogonAutostartExecutionValue);
        /// <summary> Boot or Logon Initialization Scripts. </summary>
        public static Technique BootOrLogonInitializationScripts { get; } = new Technique(BootOrLogonInitializationScriptsValue);
        /// <summary> Brute Force. </summary>
        public static Technique BruteForce { get; } = new Technique(BruteForceValue);
        /// <summary> Cloud Infrastructure Discovery. </summary>
        public static Technique CloudInfrastructureDiscovery { get; } = new Technique(CloudInfrastructureDiscoveryValue);
        /// <summary> Cloud Service Dashboard. </summary>
        public static Technique CloudServiceDashboard { get; } = new Technique(CloudServiceDashboardValue);
        /// <summary> Cloud Service Discovery. </summary>
        public static Technique CloudServiceDiscovery { get; } = new Technique(CloudServiceDiscoveryValue);
        /// <summary> Command and Scripting Interpreter. </summary>
        public static Technique CommandAndScriptingInterpreter { get; } = new Technique(CommandAndScriptingInterpreterValue);
        /// <summary> Compromise Client Software Binary. </summary>
        public static Technique CompromiseClientSoftwareBinary { get; } = new Technique(CompromiseClientSoftwareBinaryValue);
        /// <summary> Compromise Infrastructure. </summary>
        public static Technique CompromiseInfrastructure { get; } = new Technique(CompromiseInfrastructureValue);
        /// <summary> Container and Resource Discovery. </summary>
        public static Technique ContainerAndResourceDiscovery { get; } = new Technique(ContainerAndResourceDiscoveryValue);
        /// <summary> Create Account. </summary>
        public static Technique CreateAccount { get; } = new Technique(CreateAccountValue);
        /// <summary> Create or Modify System Process. </summary>
        public static Technique CreateOrModifySystemProcess { get; } = new Technique(CreateOrModifySystemProcessValue);
        /// <summary> Credentials from Password Stores. </summary>
        public static Technique CredentialsFromPasswordStores { get; } = new Technique(CredentialsFromPasswordStoresValue);
        /// <summary> Data Destruction. </summary>
        public static Technique DataDestruction { get; } = new Technique(DataDestructionValue);
        /// <summary> Data Encrypted for Impact. </summary>
        public static Technique DataEncryptedForImpact { get; } = new Technique(DataEncryptedForImpactValue);
        /// <summary> Data from Cloud Storage Object. </summary>
        public static Technique DataFromCloudStorageObject { get; } = new Technique(DataFromCloudStorageObjectValue);
        /// <summary> Data from Configuration Repository. </summary>
        public static Technique DataFromConfigurationRepository { get; } = new Technique(DataFromConfigurationRepositoryValue);
        /// <summary> Data from Information Repositories. </summary>
        public static Technique DataFromInformationRepositories { get; } = new Technique(DataFromInformationRepositoriesValue);
        /// <summary> Data from Local System. </summary>
        public static Technique DataFromLocalSystem { get; } = new Technique(DataFromLocalSystemValue);
        /// <summary> Data Manipulation. </summary>
        public static Technique DataManipulation { get; } = new Technique(DataManipulationValue);
        /// <summary> Data Staged. </summary>
        public static Technique DataStaged { get; } = new Technique(DataStagedValue);
        /// <summary> Defacement. </summary>
        public static Technique Defacement { get; } = new Technique(DefacementValue);
        /// <summary> Deobfuscate/Decode Files or Information. </summary>
        public static Technique DeobfuscateDecodeFilesOrInformation { get; } = new Technique(DeobfuscateDecodeFilesOrInformationValue);
        /// <summary> Disk Wipe. </summary>
        public static Technique DiskWipe { get; } = new Technique(DiskWipeValue);
        /// <summary> Domain Trust Discovery. </summary>
        public static Technique DomainTrustDiscovery { get; } = new Technique(DomainTrustDiscoveryValue);
        /// <summary> Drive-by Compromise. </summary>
        public static Technique DriveByCompromise { get; } = new Technique(DriveByCompromiseValue);
        /// <summary> Dynamic Resolution. </summary>
        public static Technique DynamicResolution { get; } = new Technique(DynamicResolutionValue);
        /// <summary> Endpoint Denial of Service. </summary>
        public static Technique EndpointDenialOfService { get; } = new Technique(EndpointDenialOfServiceValue);
        /// <summary> Event Triggered Execution. </summary>
        public static Technique EventTriggeredExecution { get; } = new Technique(EventTriggeredExecutionValue);
        /// <summary> Exfiltration Over Alternative Protocol. </summary>
        public static Technique ExfiltrationOverAlternativeProtocol { get; } = new Technique(ExfiltrationOverAlternativeProtocolValue);
        /// <summary> Exploit Public-Facing Application. </summary>
        public static Technique ExploitPublicFacingApplication { get; } = new Technique(ExploitPublicFacingApplicationValue);
        /// <summary> Exploitation for Client Execution. </summary>
        public static Technique ExploitationForClientExecution { get; } = new Technique(ExploitationForClientExecutionValue);
        /// <summary> Exploitation for Credential Access. </summary>
        public static Technique ExploitationForCredentialAccess { get; } = new Technique(ExploitationForCredentialAccessValue);
        /// <summary> Exploitation for Defense Evasion. </summary>
        public static Technique ExploitationForDefenseEvasion { get; } = new Technique(ExploitationForDefenseEvasionValue);
        /// <summary> Exploitation for Privilege Escalation. </summary>
        public static Technique ExploitationForPrivilegeEscalation { get; } = new Technique(ExploitationForPrivilegeEscalationValue);
        /// <summary> Exploitation of Remote Services. </summary>
        public static Technique ExploitationOfRemoteServices { get; } = new Technique(ExploitationOfRemoteServicesValue);
        /// <summary> External Remote Services. </summary>
        public static Technique ExternalRemoteServices { get; } = new Technique(ExternalRemoteServicesValue);
        /// <summary> Fallback Channels. </summary>
        public static Technique FallbackChannels { get; } = new Technique(FallbackChannelsValue);
        /// <summary> File and Directory Discovery. </summary>
        public static Technique FileAndDirectoryDiscovery { get; } = new Technique(FileAndDirectoryDiscoveryValue);
        /// <summary> Gather Victim Network Information. </summary>
        public static Technique GatherVictimNetworkInformation { get; } = new Technique(GatherVictimNetworkInformationValue);
        /// <summary> Hide Artifacts. </summary>
        public static Technique HideArtifacts { get; } = new Technique(HideArtifactsValue);
        /// <summary> Hijack Execution Flow. </summary>
        public static Technique HijackExecutionFlow { get; } = new Technique(HijackExecutionFlowValue);
        /// <summary> Impair Defenses. </summary>
        public static Technique ImpairDefenses { get; } = new Technique(ImpairDefensesValue);
        /// <summary> Implant Container Image. </summary>
        public static Technique ImplantContainerImage { get; } = new Technique(ImplantContainerImageValue);
        /// <summary> Indicator Removal on Host. </summary>
        public static Technique IndicatorRemovalOnHost { get; } = new Technique(IndicatorRemovalOnHostValue);
        /// <summary> Indirect Command Execution. </summary>
        public static Technique IndirectCommandExecution { get; } = new Technique(IndirectCommandExecutionValue);
        /// <summary> Ingress Tool Transfer. </summary>
        public static Technique IngressToolTransfer { get; } = new Technique(IngressToolTransferValue);
        /// <summary> Input Capture. </summary>
        public static Technique InputCapture { get; } = new Technique(InputCaptureValue);
        /// <summary> Inter-Process Communication. </summary>
        public static Technique InterProcessCommunication { get; } = new Technique(InterProcessCommunicationValue);
        /// <summary> Lateral Tool Transfer. </summary>
        public static Technique LateralToolTransfer { get; } = new Technique(LateralToolTransferValue);
        /// <summary> Man-in-the-Middle. </summary>
        public static Technique ManInTheMiddle { get; } = new Technique(ManInTheMiddleValue);
        /// <summary> Masquerading. </summary>
        public static Technique Masquerading { get; } = new Technique(MasqueradingValue);
        /// <summary> Modify Authentication Process. </summary>
        public static Technique ModifyAuthenticationProcess { get; } = new Technique(ModifyAuthenticationProcessValue);
        /// <summary> Modify Registry. </summary>
        public static Technique ModifyRegistry { get; } = new Technique(ModifyRegistryValue);
        /// <summary> Network Denial of Service. </summary>
        public static Technique NetworkDenialOfService { get; } = new Technique(NetworkDenialOfServiceValue);
        /// <summary> Network Service Scanning. </summary>
        public static Technique NetworkServiceScanning { get; } = new Technique(NetworkServiceScanningValue);
        /// <summary> Network Sniffing. </summary>
        public static Technique NetworkSniffing { get; } = new Technique(NetworkSniffingValue);
        /// <summary> Non-Application Layer Protocol. </summary>
        public static Technique NonApplicationLayerProtocol { get; } = new Technique(NonApplicationLayerProtocolValue);
        /// <summary> Non-Standard Port. </summary>
        public static Technique NonStandardPort { get; } = new Technique(NonStandardPortValue);
        /// <summary> Obtain Capabilities. </summary>
        public static Technique ObtainCapabilities { get; } = new Technique(ObtainCapabilitiesValue);
        /// <summary> Obfuscated Files or Information. </summary>
        public static Technique ObfuscatedFilesOrInformation { get; } = new Technique(ObfuscatedFilesOrInformationValue);
        /// <summary> Office Application Startup. </summary>
        public static Technique OfficeApplicationStartup { get; } = new Technique(OfficeApplicationStartupValue);
        /// <summary> OS Credential Dumping. </summary>
        public static Technique OSCredentialDumping { get; } = new Technique(OSCredentialDumpingValue);
        /// <summary> Permission Groups Discovery. </summary>
        public static Technique PermissionGroupsDiscovery { get; } = new Technique(PermissionGroupsDiscoveryValue);
        /// <summary> Phishing. </summary>
        public static Technique Phishing { get; } = new Technique(PhishingValue);
        /// <summary> Pre-OS Boot. </summary>
        public static Technique PreOSBoot { get; } = new Technique(PreOSBootValue);
        /// <summary> Process Discovery. </summary>
        public static Technique ProcessDiscovery { get; } = new Technique(ProcessDiscoveryValue);
        /// <summary> Process Injection. </summary>
        public static Technique ProcessInjection { get; } = new Technique(ProcessInjectionValue);
        /// <summary> Protocol Tunneling. </summary>
        public static Technique ProtocolTunneling { get; } = new Technique(ProtocolTunnelingValue);
        /// <summary> Proxy. </summary>
        public static Technique Proxy { get; } = new Technique(ProxyValue);
        /// <summary> Query Registry. </summary>
        public static Technique QueryRegistry { get; } = new Technique(QueryRegistryValue);
        /// <summary> Remote Access Software. </summary>
        public static Technique RemoteAccessSoftware { get; } = new Technique(RemoteAccessSoftwareValue);
        /// <summary> Remote Service Session Hijacking. </summary>
        public static Technique RemoteServiceSessionHijacking { get; } = new Technique(RemoteServiceSessionHijackingValue);
        /// <summary> Remote Services. </summary>
        public static Technique RemoteServices { get; } = new Technique(RemoteServicesValue);
        /// <summary> Remote System Discovery. </summary>
        public static Technique RemoteSystemDiscovery { get; } = new Technique(RemoteSystemDiscoveryValue);
        /// <summary> Resource Hijacking. </summary>
        public static Technique ResourceHijacking { get; } = new Technique(ResourceHijackingValue);
        /// <summary> Scheduled Task/Job. </summary>
        public static Technique ScheduledTaskJob { get; } = new Technique(ScheduledTaskJobValue);
        /// <summary> Screen Capture. </summary>
        public static Technique ScreenCapture { get; } = new Technique(ScreenCaptureValue);
        /// <summary> Search Victim-Owned Websites. </summary>
        public static Technique SearchVictimOwnedWebsites { get; } = new Technique(SearchVictimOwnedWebsitesValue);
        /// <summary> Server Software Component. </summary>
        public static Technique ServerSoftwareComponent { get; } = new Technique(ServerSoftwareComponentValue);
        /// <summary> Service Stop. </summary>
        public static Technique ServiceStop { get; } = new Technique(ServiceStopValue);
        /// <summary> Signed Binary Proxy Execution. </summary>
        public static Technique SignedBinaryProxyExecution { get; } = new Technique(SignedBinaryProxyExecutionValue);
        /// <summary> Software Deployment Tools. </summary>
        public static Technique SoftwareDeploymentTools { get; } = new Technique(SoftwareDeploymentToolsValue);
        /// <summary> SQL Stored Procedures. </summary>
        public static Technique SQLStoredProcedures { get; } = new Technique(SQLStoredProceduresValue);
        /// <summary> Steal or Forge Kerberos Tickets. </summary>
        public static Technique StealOrForgeKerberosTickets { get; } = new Technique(StealOrForgeKerberosTicketsValue);
        /// <summary> Subvert Trust Controls. </summary>
        public static Technique SubvertTrustControls { get; } = new Technique(SubvertTrustControlsValue);
        /// <summary> Supply Chain Compromise. </summary>
        public static Technique SupplyChainCompromise { get; } = new Technique(SupplyChainCompromiseValue);
        /// <summary> System Information Discovery. </summary>
        public static Technique SystemInformationDiscovery { get; } = new Technique(SystemInformationDiscoveryValue);
        /// <summary> Taint Shared Content. </summary>
        public static Technique TaintSharedContent { get; } = new Technique(TaintSharedContentValue);
        /// <summary> Traffic Signaling. </summary>
        public static Technique TrafficSignaling { get; } = new Technique(TrafficSignalingValue);
        /// <summary> Transfer Data to Cloud Account. </summary>
        public static Technique TransferDataToCloudAccount { get; } = new Technique(TransferDataToCloudAccountValue);
        /// <summary> Trusted Relationship. </summary>
        public static Technique TrustedRelationship { get; } = new Technique(TrustedRelationshipValue);
        /// <summary> Unsecured Credentials. </summary>
        public static Technique UnsecuredCredentials { get; } = new Technique(UnsecuredCredentialsValue);
        /// <summary> User Execution. </summary>
        public static Technique UserExecution { get; } = new Technique(UserExecutionValue);
        /// <summary> Valid Accounts. </summary>
        public static Technique ValidAccounts { get; } = new Technique(ValidAccountsValue);
        /// <summary> Windows Management Instrumentation. </summary>
        public static Technique WindowsManagementInstrumentation { get; } = new Technique(WindowsManagementInstrumentationValue);
        /// <summary> File and Directory Permissions Modification. </summary>
        public static Technique FileAndDirectoryPermissionsModification { get; } = new Technique(FileAndDirectoryPermissionsModificationValue);
        /// <summary> Determines if two <see cref="Technique"/> values are the same. </summary>
        public static bool operator ==(Technique left, Technique right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Technique"/> values are not the same. </summary>
        public static bool operator !=(Technique left, Technique right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Technique"/>. </summary>
        public static implicit operator Technique(string value) => new Technique(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Technique other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Technique other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
