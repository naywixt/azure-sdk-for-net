// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.DigitalTwins.Core
{
    /// <summary> Parameter group. </summary>
    public partial class DigitalTwinsUpdateComponentOptions
    {
        /// <summary> Initializes a new instance of DigitalTwinsUpdateComponentOptions. </summary>
        public DigitalTwinsUpdateComponentOptions()
        {
        }

        /// <summary> Identifies the request in a distributed tracing system. </summary>
        public string Traceparent { get; set; }
        /// <summary> Provides vendor-specific trace identification information and is a companion to traceparent. </summary>
        public string Tracestate { get; set; }
        /// <summary> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </summary>
        public string IfMatch { get; set; }
    }
}
