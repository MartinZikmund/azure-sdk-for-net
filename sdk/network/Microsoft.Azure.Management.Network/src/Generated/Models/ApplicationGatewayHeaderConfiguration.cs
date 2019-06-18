// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Header configuration of the Actions set in Application Gateway.
    /// </summary>
    public partial class ApplicationGatewayHeaderConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayHeaderConfiguration class.
        /// </summary>
        public ApplicationGatewayHeaderConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayHeaderConfiguration class.
        /// </summary>
        /// <param name="headerName">Header name of the header
        /// configuration.</param>
        /// <param name="headerValue">Header value of the header
        /// configuration.</param>
        public ApplicationGatewayHeaderConfiguration(string headerName = default(string), string headerValue = default(string))
        {
            HeaderName = headerName;
            HeaderValue = headerValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets header name of the header configuration.
        /// </summary>
        [JsonProperty(PropertyName = "headerName")]
        public string HeaderName { get; set; }

        /// <summary>
        /// Gets or sets header value of the header configuration.
        /// </summary>
        [JsonProperty(PropertyName = "headerValue")]
        public string HeaderValue { get; set; }

    }
}