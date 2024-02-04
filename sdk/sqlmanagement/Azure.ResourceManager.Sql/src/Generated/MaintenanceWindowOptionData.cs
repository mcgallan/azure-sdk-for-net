// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the MaintenanceWindowOption data model.
    /// Maintenance window options.
    /// </summary>
    public partial class MaintenanceWindowOptionData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MaintenanceWindowOptionData"/>. </summary>
        public MaintenanceWindowOptionData()
        {
            MaintenanceWindowCycles = new ChangeTrackingList<MaintenanceWindowTimeRange>();
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceWindowOptionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isEnabled"> Whether maintenance windows are enabled for the database. </param>
        /// <param name="maintenanceWindowCycles"> Available maintenance cycles e.g. {Saturday, 0, 48*60}, {Wednesday, 0, 24*60}. </param>
        /// <param name="minDurationInMinutes"> Minimum duration of maintenance window. </param>
        /// <param name="defaultDurationInMinutes"> Default duration for maintenance window. </param>
        /// <param name="minCycles"> Minimum number of maintenance windows cycles to be set on the database. </param>
        /// <param name="timeGranularityInMinutes"> Time granularity in minutes for maintenance windows. </param>
        /// <param name="allowMultipleMaintenanceWindowsPerCycle"> Whether we allow multiple maintenance windows per cycle. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaintenanceWindowOptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isEnabled, IList<MaintenanceWindowTimeRange> maintenanceWindowCycles, int? minDurationInMinutes, int? defaultDurationInMinutes, int? minCycles, int? timeGranularityInMinutes, bool? allowMultipleMaintenanceWindowsPerCycle, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            IsEnabled = isEnabled;
            MaintenanceWindowCycles = maintenanceWindowCycles;
            MinDurationInMinutes = minDurationInMinutes;
            DefaultDurationInMinutes = defaultDurationInMinutes;
            MinCycles = minCycles;
            TimeGranularityInMinutes = timeGranularityInMinutes;
            AllowMultipleMaintenanceWindowsPerCycle = allowMultipleMaintenanceWindowsPerCycle;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Whether maintenance windows are enabled for the database. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Available maintenance cycles e.g. {Saturday, 0, 48*60}, {Wednesday, 0, 24*60}. </summary>
        public IList<MaintenanceWindowTimeRange> MaintenanceWindowCycles { get; }
        /// <summary> Minimum duration of maintenance window. </summary>
        public int? MinDurationInMinutes { get; set; }
        /// <summary> Default duration for maintenance window. </summary>
        public int? DefaultDurationInMinutes { get; set; }
        /// <summary> Minimum number of maintenance windows cycles to be set on the database. </summary>
        public int? MinCycles { get; set; }
        /// <summary> Time granularity in minutes for maintenance windows. </summary>
        public int? TimeGranularityInMinutes { get; set; }
        /// <summary> Whether we allow multiple maintenance windows per cycle. </summary>
        public bool? AllowMultipleMaintenanceWindowsPerCycle { get; set; }
    }
}
