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
    /// Object representing a metric for any resource
    /// </summary>
    public partial class ResourceMetric
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetric class.
        /// </summary>
        public ResourceMetric() { }

        /// <summary>
        /// Initializes a new instance of the ResourceMetric class.
        /// </summary>
        public ResourceMetric(ResourceMetricName name = default(ResourceMetricName), string unit = default(string), string timeGrain = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), string resourceId = default(string), IList<ResourceMetricValue> metricValues = default(IList<ResourceMetricValue>), IList<KeyValuePairStringString> properties = default(IList<KeyValuePairStringString>))
        {
            Name = name;
            Unit = unit;
            TimeGrain = timeGrain;
            StartTime = startTime;
            EndTime = endTime;
            ResourceId = resourceId;
            MetricValues = metricValues;
            Properties = properties;
        }

        /// <summary>
        /// Name of metric
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public ResourceMetricName Name { get; set; }

        /// <summary>
        /// Metric unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Metric granularity. E.g PT1H, PT5M, P1D
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; set; }

        /// <summary>
        /// Metric start time
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Metric end time
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Metric resource Id
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Metric values
        /// </summary>
        [JsonProperty(PropertyName = "metricValues")]
        public IList<ResourceMetricValue> MetricValues { get; set; }

        /// <summary>
        /// Properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<KeyValuePairStringString> Properties { get; set; }

    }
}
