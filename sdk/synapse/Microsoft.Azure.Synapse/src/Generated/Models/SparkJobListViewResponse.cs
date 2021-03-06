// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SparkJobListViewResponse
    {
        /// <summary>
        /// Initializes a new instance of the SparkJobListViewResponse class.
        /// </summary>
        public SparkJobListViewResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SparkJobListViewResponse class.
        /// </summary>
        public SparkJobListViewResponse(int? nJobs = default(int?), IList<SparkJob> sparkJobs = default(IList<SparkJob>))
        {
            NJobs = nJobs;
            SparkJobs = sparkJobs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nJobs")]
        public int? NJobs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sparkJobs")]
        public IList<SparkJob> SparkJobs { get; set; }

    }
}
