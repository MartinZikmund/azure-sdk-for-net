// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Description of a CheckAvailibility resource.
    /// </summary>
    public partial class CheckAvailabilityResource
    {
        /// <summary>
        /// Initializes a new instance of the CheckAvailabilityResource class.
        /// </summary>
        public CheckAvailabilityResource() { }

        /// <summary>
        /// Initializes a new instance of the CheckAvailabilityResource class.
        /// </summary>
        public CheckAvailabilityResource(string id = default(string), string location = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), bool? isAvailiable = default(bool?))
        {
            Id = id;
            Location = location;
            Name = name;
            Type = type;
            Tags = tags;
            IsAvailiable = isAvailiable;
        }

        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets datacenter location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets true if the name is available and can be used to
        /// create new Namespace/NotificationHub. Otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "isAvailiable")]
        public bool? IsAvailiable { get; set; }

    }
}
