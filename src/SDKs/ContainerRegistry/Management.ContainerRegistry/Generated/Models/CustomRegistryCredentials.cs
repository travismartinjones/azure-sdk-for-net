// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the credentials that will be used to access a custom registry
    /// during a run.
    /// </summary>
    public partial class CustomRegistryCredentials
    {
        /// <summary>
        /// Initializes a new instance of the CustomRegistryCredentials class.
        /// </summary>
        public CustomRegistryCredentials()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomRegistryCredentials class.
        /// </summary>
        /// <param name="userName">The username for logging into the custom
        /// registry.</param>
        /// <param name="password">The password for logging into the custom
        /// registry. The password is a secret
        /// object that allows multiple ways of providing the value for
        /// it.</param>
        public CustomRegistryCredentials(SecretObject userName = default(SecretObject), SecretObject password = default(SecretObject))
        {
            UserName = userName;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the username for logging into the custom registry.
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public SecretObject UserName { get; set; }

        /// <summary>
        /// Gets or sets the password for logging into the custom registry. The
        /// password is a secret
        /// object that allows multiple ways of providing the value for it.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public SecretObject Password { get; set; }

    }
}
