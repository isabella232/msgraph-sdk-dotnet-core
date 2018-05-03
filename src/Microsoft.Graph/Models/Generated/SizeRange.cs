// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type SizeRange.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SizeRange
    {
    
        /// <summary>
        /// Gets or sets minimumSize.
        /// The minimum size (in kilobytes) that an incoming message must have in order for a condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumSize", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MinimumSize { get; set; }
    
        /// <summary>
        /// Gets or sets maximumSize.
        /// The maximum size (in kilobytes) that an incoming message must have in order for a condition or exception to apply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumSize", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaximumSize { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
