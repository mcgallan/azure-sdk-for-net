// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the AppServiceDomain data model. </summary>
    public partial class AppServiceDomainData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AppServiceDomainData. </summary>
        /// <param name="location"> The location. </param>
        public AppServiceDomainData(AzureLocation location) : base(location)
        {
            NameServers = new ChangeTrackingList<string>();
            ManagedHostNames = new ChangeTrackingList<HostName>();
            DomainNotRenewableReasons = new ChangeTrackingList<AppServiceDomainPropertiesDomainNotRenewableReasonsItem>();
        }

        /// <summary> Initializes a new instance of AppServiceDomainData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="contactAdmin"> Administrative contact. </param>
        /// <param name="contactBilling"> Billing contact. </param>
        /// <param name="contactRegistrant"> Registrant contact. </param>
        /// <param name="contactTech"> Technical contact. </param>
        /// <param name="registrationStatus"> Domain registration status. </param>
        /// <param name="provisioningState"> Domain provisioning state. </param>
        /// <param name="nameServers"> Name servers. </param>
        /// <param name="privacy"> &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="createdOn"> Domain creation timestamp. </param>
        /// <param name="expirationOn"> Domain expiration timestamp. </param>
        /// <param name="lastRenewedOn"> Timestamp when the domain was renewed last time. </param>
        /// <param name="autoRenew"> &lt;code&gt;true&lt;/code&gt; if the domain should be automatically renewed; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="readyForDnsRecordManagement">
        /// &lt;code&gt;true&lt;/code&gt; if Azure can assign this domain to App Service apps; otherwise, &lt;code&gt;false&lt;/code&gt;. This value will be &lt;code&gt;true&lt;/code&gt; if domain registration status is active and 
        ///  it is hosted on name servers Azure has programmatic access to.
        /// </param>
        /// <param name="managedHostNames"> All hostnames derived from the domain and assigned to Azure resources. </param>
        /// <param name="consent"> Legal agreement consent. </param>
        /// <param name="domainNotRenewableReasons"> Reasons why domain is not renewable. </param>
        /// <param name="dnsType"> Current DNS type. </param>
        /// <param name="dnsZoneId"> Azure DNS Zone to use. </param>
        /// <param name="targetDnsType"> Target DNS type (would be used for migration). </param>
        /// <param name="authCode"></param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppServiceDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ContactInformation contactAdmin, ContactInformation contactBilling, ContactInformation contactRegistrant, ContactInformation contactTech, DomainStatus? registrationStatus, ProvisioningState? provisioningState, IReadOnlyList<string> nameServers, bool? privacy, DateTimeOffset? createdOn, DateTimeOffset? expirationOn, DateTimeOffset? lastRenewedOn, bool? autoRenew, bool? readyForDnsRecordManagement, IReadOnlyList<HostName> managedHostNames, DomainPurchaseConsent consent, IReadOnlyList<AppServiceDomainPropertiesDomainNotRenewableReasonsItem> domainNotRenewableReasons, DnsType? dnsType, string dnsZoneId, DnsType? targetDnsType, string authCode, string kind) : base(id, name, resourceType, systemData, tags, location)
        {
            ContactAdmin = contactAdmin;
            ContactBilling = contactBilling;
            ContactRegistrant = contactRegistrant;
            ContactTech = contactTech;
            RegistrationStatus = registrationStatus;
            ProvisioningState = provisioningState;
            NameServers = nameServers;
            Privacy = privacy;
            CreatedOn = createdOn;
            ExpirationOn = expirationOn;
            LastRenewedOn = lastRenewedOn;
            AutoRenew = autoRenew;
            ReadyForDnsRecordManagement = readyForDnsRecordManagement;
            ManagedHostNames = managedHostNames;
            Consent = consent;
            DomainNotRenewableReasons = domainNotRenewableReasons;
            DnsType = dnsType;
            DnsZoneId = dnsZoneId;
            TargetDnsType = targetDnsType;
            AuthCode = authCode;
            Kind = kind;
        }

        /// <summary> Administrative contact. </summary>
        public ContactInformation ContactAdmin { get; set; }
        /// <summary> Billing contact. </summary>
        public ContactInformation ContactBilling { get; set; }
        /// <summary> Registrant contact. </summary>
        public ContactInformation ContactRegistrant { get; set; }
        /// <summary> Technical contact. </summary>
        public ContactInformation ContactTech { get; set; }
        /// <summary> Domain registration status. </summary>
        public DomainStatus? RegistrationStatus { get; }
        /// <summary> Domain provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Name servers. </summary>
        public IReadOnlyList<string> NameServers { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if domain privacy is enabled for this domain; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? Privacy { get; set; }
        /// <summary> Domain creation timestamp. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Domain expiration timestamp. </summary>
        public DateTimeOffset? ExpirationOn { get; }
        /// <summary> Timestamp when the domain was renewed last time. </summary>
        public DateTimeOffset? LastRenewedOn { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the domain should be automatically renewed; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? AutoRenew { get; set; }
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if Azure can assign this domain to App Service apps; otherwise, &lt;code&gt;false&lt;/code&gt;. This value will be &lt;code&gt;true&lt;/code&gt; if domain registration status is active and 
        ///  it is hosted on name servers Azure has programmatic access to.
        /// </summary>
        public bool? ReadyForDnsRecordManagement { get; }
        /// <summary> All hostnames derived from the domain and assigned to Azure resources. </summary>
        public IReadOnlyList<HostName> ManagedHostNames { get; }
        /// <summary> Legal agreement consent. </summary>
        public DomainPurchaseConsent Consent { get; set; }
        /// <summary> Reasons why domain is not renewable. </summary>
        public IReadOnlyList<AppServiceDomainPropertiesDomainNotRenewableReasonsItem> DomainNotRenewableReasons { get; }
        /// <summary> Current DNS type. </summary>
        public DnsType? DnsType { get; set; }
        /// <summary> Azure DNS Zone to use. </summary>
        public string DnsZoneId { get; set; }
        /// <summary> Target DNS type (would be used for migration). </summary>
        public DnsType? TargetDnsType { get; set; }
        /// <summary> Gets or sets the auth code. </summary>
        public string AuthCode { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
