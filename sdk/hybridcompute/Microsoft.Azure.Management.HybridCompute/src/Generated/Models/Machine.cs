// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridCompute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a hybrid machine.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Machine : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Machine class.
        /// </summary>
        public Machine()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Machine class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="type1">The identity type.</param>
        /// <param name="principalId">The identity's principal id.</param>
        /// <param name="tenantId">The identity's tenant id.</param>
        /// <param name="osProfile">Specifies the operating system settings for
        /// the hybrid machine.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="status">The status of the hybrid machine agent.
        /// Possible values include: 'Connected', 'Disconnected',
        /// 'Error'</param>
        /// <param name="lastStatusChange">The time of the last status
        /// change.</param>
        /// <param name="errorDetails">Details about the error state.</param>
        /// <param name="agentVersion">The hybrid machine agent full
        /// version.</param>
        /// <param name="vmId">Specifies the hybrid machine unique ID.</param>
        /// <param name="displayName">Specifies the hybrid machine display
        /// name.</param>
        /// <param name="machineFqdn">Specifies the hybrid machine
        /// FQDN.</param>
        /// <param name="physicalLocation">Resource's Physical Location</param>
        /// <param name="clientPublicKey">Public Key that the client provides
        /// to be used during initial resource onboarding</param>
        /// <param name="osName">The Operating System running on the hybrid
        /// machine.</param>
        /// <param name="osVersion">The version of Operating System running on
        /// the hybrid machine.</param>
        /// <param name="extensions">Machine Extensions information</param>
        public Machine(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string type1 = default(string), string principalId = default(string), string tenantId = default(string), OSProfile osProfile = default(OSProfile), string provisioningState = default(string), StatusTypes? status = default(StatusTypes?), System.DateTime? lastStatusChange = default(System.DateTime?), IList<ErrorDetail> errorDetails = default(IList<ErrorDetail>), string agentVersion = default(string), string vmId = default(string), string displayName = default(string), string machineFqdn = default(string), string physicalLocation = default(string), string clientPublicKey = default(string), string osName = default(string), string osVersion = default(string), IList<MachineExtensionInstanceView> extensions = default(IList<MachineExtensionInstanceView>))
            : base(location, id, name, type, tags, type1, principalId, tenantId)
        {
            OsProfile = osProfile;
            ProvisioningState = provisioningState;
            Status = status;
            LastStatusChange = lastStatusChange;
            ErrorDetails = errorDetails;
            AgentVersion = agentVersion;
            VmId = vmId;
            DisplayName = displayName;
            MachineFqdn = machineFqdn;
            PhysicalLocation = physicalLocation;
            ClientPublicKey = clientPublicKey;
            OsName = osName;
            OsVersion = osVersion;
            Extensions = extensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the operating system settings for the hybrid
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osProfile")]
        public OSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the status of the hybrid machine agent. Possible values
        /// include: 'Connected', 'Disconnected', 'Error'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public StatusTypes? Status { get; private set; }

        /// <summary>
        /// Gets the time of the last status change.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastStatusChange")]
        public System.DateTime? LastStatusChange { get; private set; }

        /// <summary>
        /// Gets details about the error state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorDetails")]
        public IList<ErrorDetail> ErrorDetails { get; private set; }

        /// <summary>
        /// Gets the hybrid machine agent full version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentVersion")]
        public string AgentVersion { get; private set; }

        /// <summary>
        /// Gets specifies the hybrid machine unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmId")]
        public string VmId { get; private set; }

        /// <summary>
        /// Gets specifies the hybrid machine display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets specifies the hybrid machine FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "properties.machineFqdn")]
        public string MachineFqdn { get; private set; }

        /// <summary>
        /// Gets or sets resource's Physical Location
        /// </summary>
        [JsonProperty(PropertyName = "properties.physicalLocation")]
        public string PhysicalLocation { get; set; }

        /// <summary>
        /// Gets or sets public Key that the client provides to be used during
        /// initial resource onboarding
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientPublicKey")]
        public string ClientPublicKey { get; set; }

        /// <summary>
        /// Gets the Operating System running on the hybrid machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osName")]
        public string OsName { get; private set; }

        /// <summary>
        /// Gets the version of Operating System running on the hybrid machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osVersion")]
        public string OsVersion { get; private set; }

        /// <summary>
        /// Gets or sets machine Extensions information
        /// </summary>
        [JsonProperty(PropertyName = "properties.extensions")]
        public IList<MachineExtensionInstanceView> Extensions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ErrorDetails != null)
            {
                foreach (var element in ErrorDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}