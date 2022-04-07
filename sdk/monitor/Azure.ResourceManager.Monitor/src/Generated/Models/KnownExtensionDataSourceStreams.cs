// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The KnownExtensionDataSourceStreams. </summary>
    internal readonly partial struct KnownExtensionDataSourceStreams : IEquatable<KnownExtensionDataSourceStreams>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KnownExtensionDataSourceStreams"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KnownExtensionDataSourceStreams(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftEventValue = "Microsoft-Event";
        private const string MicrosoftInsightsMetricsValue = "Microsoft-InsightsMetrics";
        private const string MicrosoftPerfValue = "Microsoft-Perf";
        private const string MicrosoftSyslogValue = "Microsoft-Syslog";
        private const string MicrosoftWindowsEventValue = "Microsoft-WindowsEvent";

        /// <summary> Microsoft-Event. </summary>
        public static KnownExtensionDataSourceStreams MicrosoftEvent { get; } = new KnownExtensionDataSourceStreams(MicrosoftEventValue);
        /// <summary> Microsoft-InsightsMetrics. </summary>
        public static KnownExtensionDataSourceStreams MicrosoftInsightsMetrics { get; } = new KnownExtensionDataSourceStreams(MicrosoftInsightsMetricsValue);
        /// <summary> Microsoft-Perf. </summary>
        public static KnownExtensionDataSourceStreams MicrosoftPerf { get; } = new KnownExtensionDataSourceStreams(MicrosoftPerfValue);
        /// <summary> Microsoft-Syslog. </summary>
        public static KnownExtensionDataSourceStreams MicrosoftSyslog { get; } = new KnownExtensionDataSourceStreams(MicrosoftSyslogValue);
        /// <summary> Microsoft-WindowsEvent. </summary>
        public static KnownExtensionDataSourceStreams MicrosoftWindowsEvent { get; } = new KnownExtensionDataSourceStreams(MicrosoftWindowsEventValue);
        /// <summary> Determines if two <see cref="KnownExtensionDataSourceStreams"/> values are the same. </summary>
        public static bool operator ==(KnownExtensionDataSourceStreams left, KnownExtensionDataSourceStreams right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KnownExtensionDataSourceStreams"/> values are not the same. </summary>
        public static bool operator !=(KnownExtensionDataSourceStreams left, KnownExtensionDataSourceStreams right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KnownExtensionDataSourceStreams"/>. </summary>
        public static implicit operator KnownExtensionDataSourceStreams(string value) => new KnownExtensionDataSourceStreams(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KnownExtensionDataSourceStreams other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KnownExtensionDataSourceStreams other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
