// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Slot Config names azure resource
    /// </summary>
    public partial class SlotConfigNamesResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SlotConfigNamesResource class.
        /// </summary>
        public SlotConfigNamesResource() { }

        /// <summary>
        /// Initializes a new instance of the SlotConfigNamesResource class.
        /// </summary>
        public SlotConfigNamesResource(IList<string> connectionStringNames = default(IList<string>), IList<string> appSettingNames = default(IList<string>))
        {
            ConnectionStringNames = connectionStringNames;
            AppSettingNames = appSettingNames;
        }

        /// <summary>
        /// List of connection string names
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionStringNames")]
        public IList<string> ConnectionStringNames { get; set; }

        /// <summary>
        /// List of application settings names
        /// </summary>
        [JsonProperty(PropertyName = "properties.appSettingNames")]
        public IList<string> AppSettingNames { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
