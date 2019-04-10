// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An agreement resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Agreement : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Agreement class.
        /// </summary>
        public Agreement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Agreement class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="agreementLink">The link to the agreement.</param>
        /// <param name="effectiveDate">Effective date.</param>
        /// <param name="expirationDate">Expiration date.</param>
        /// <param name="participants">Participants or signer of the
        /// agreement.</param>
        /// <param name="status">The agreement status</param>
        public Agreement(string id = default(string), string name = default(string), string type = default(string), string agreementLink = default(string), System.DateTime? effectiveDate = default(System.DateTime?), System.DateTime? expirationDate = default(System.DateTime?), IList<Participants> participants = default(IList<Participants>), string status = default(string))
            : base(id, name, type)
        {
            AgreementLink = agreementLink;
            EffectiveDate = effectiveDate;
            ExpirationDate = expirationDate;
            Participants = participants;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the link to the agreement.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agreementLink")]
        public string AgreementLink { get; private set; }

        /// <summary>
        /// Gets effective date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.effectiveDate")]
        public System.DateTime? EffectiveDate { get; private set; }

        /// <summary>
        /// Gets expiration date.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationDate")]
        public System.DateTime? ExpirationDate { get; private set; }

        /// <summary>
        /// Gets or sets participants or signer of the agreement.
        /// </summary>
        [JsonProperty(PropertyName = "properties.participants")]
        public IList<Participants> Participants { get; set; }

        /// <summary>
        /// Gets the agreement status
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

    }
}
