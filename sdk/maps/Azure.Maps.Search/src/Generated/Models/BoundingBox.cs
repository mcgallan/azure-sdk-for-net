// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> The viewport that covers the result represented by the top-left and bottom-right coordinates of the viewport. </summary>
    internal partial class BoundingBox
    {
        /// <summary> Initializes a new instance of BoundingBox. </summary>
        internal BoundingBox()
        {
        }

        /// <summary> Initializes a new instance of BoundingBox. </summary>
        /// <param name="topLeft"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        /// <param name="bottomRight"> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </param>
        internal BoundingBox(LatLongPairAbbreviated topLeft, LatLongPairAbbreviated bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        /// <summary> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </summary>
        public LatLongPairAbbreviated TopLeft { get; }
        /// <summary> A location represented as a latitude and longitude using short names &apos;lat&apos; &amp; &apos;lon&apos;. </summary>
        public LatLongPairAbbreviated BottomRight { get; }
    }
}
