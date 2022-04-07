// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The platform object describes the platform which the image in the manifest runs on. A full list of valid operating system and architecture values are listed in the Go language documentation for $GOOS and $GOARCH. </summary>
    internal partial class Platform
    {
        /// <summary> Initializes a new instance of Platform. </summary>
        internal Platform()
        {
            OsFeatures = new ChangeTrackingList<string>();
            Features = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of Platform. </summary>
        /// <param name="architecture"> Specifies the CPU architecture, for example amd64 or ppc64le. </param>
        /// <param name="os"> The os field specifies the operating system, for example linux or windows. </param>
        /// <param name="osVersion"> The optional os.version field specifies the operating system version, for example 10.0.10586. </param>
        /// <param name="osFeatures"> The optional os.features field specifies an array of strings, each listing a required OS feature (for example on Windows win32k. </param>
        /// <param name="variant"> The optional variant field specifies a variant of the CPU, for example armv6l to specify a particular CPU variant of the ARM CPU. </param>
        /// <param name="features"> The optional features field specifies an array of strings, each listing a required CPU feature (for example sse4 or aes. </param>
        internal Platform(string architecture, string os, string osVersion, IReadOnlyList<string> osFeatures, string variant, IReadOnlyList<string> features)
        {
            Architecture = architecture;
            Os = os;
            OsVersion = osVersion;
            OsFeatures = osFeatures;
            Variant = variant;
            Features = features;
        }

        /// <summary> Specifies the CPU architecture, for example amd64 or ppc64le. </summary>
        public string Architecture { get; }
        /// <summary> The os field specifies the operating system, for example linux or windows. </summary>
        public string Os { get; }
        /// <summary> The optional os.version field specifies the operating system version, for example 10.0.10586. </summary>
        public string OsVersion { get; }
        /// <summary> The optional os.features field specifies an array of strings, each listing a required OS feature (for example on Windows win32k. </summary>
        public IReadOnlyList<string> OsFeatures { get; }
        /// <summary> The optional variant field specifies a variant of the CPU, for example armv6l to specify a particular CPU variant of the ARM CPU. </summary>
        public string Variant { get; }
        /// <summary> The optional features field specifies an array of strings, each listing a required CPU feature (for example sse4 or aes. </summary>
        public IReadOnlyList<string> Features { get; }
    }
}
