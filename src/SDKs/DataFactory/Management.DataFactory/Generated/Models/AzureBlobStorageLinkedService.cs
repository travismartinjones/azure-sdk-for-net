// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The azure blob storage linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureBlobStorage")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureBlobStorageLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureBlobStorageLinkedService
        /// class.
        /// </summary>
        public AzureBlobStorageLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBlobStorageLinkedService
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="connectionString">The connection string. It is
        /// mutually exclusive with sasUri, serviceEndpoint property. Type:
        /// string, SecureString or AzureKeyVaultSecretReference.</param>
        /// <param name="accountKey">The Azure key vault secret reference of
        /// accountKey in connection string.</param>
        /// <param name="sasUri">SAS URI of the Azure Blob Storage resource. It
        /// is mutually exclusive with connectionString, serviceEndpoint
        /// property. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.</param>
        /// <param name="sasToken">The Azure key vault secret reference of
        /// sasToken in sas uri.</param>
        /// <param name="serviceEndpoint">Blob service endpoint of the Azure
        /// Blob Storage resource. It is mutually exclusive with
        /// connectionString, sasUri property.</param>
        /// <param name="servicePrincipalId">The ID of the service principal
        /// used to authenticate against Azure SQL Data Warehouse. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="servicePrincipalKey">The key of the service principal
        /// used to authenticate against Azure SQL Data Warehouse.</param>
        /// <param name="tenant">The name or ID of the tenant to which the
        /// service principal belongs. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AzureBlobStorageLinkedService(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object connectionString = default(object), AzureKeyVaultSecretReference accountKey = default(AzureKeyVaultSecretReference), object sasUri = default(object), AzureKeyVaultSecretReference sasToken = default(AzureKeyVaultSecretReference), string serviceEndpoint = default(string), object servicePrincipalId = default(object), SecretBase servicePrincipalKey = default(SecretBase), object tenant = default(object), string encryptedCredential = default(string))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            ConnectionString = connectionString;
            AccountKey = accountKey;
            SasUri = sasUri;
            SasToken = sasToken;
            ServiceEndpoint = serviceEndpoint;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string. It is mutually exclusive with
        /// sasUri, serviceEndpoint property. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of accountKey in
        /// connection string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accountKey")]
        public AzureKeyVaultSecretReference AccountKey { get; set; }

        /// <summary>
        /// Gets or sets SAS URI of the Azure Blob Storage resource. It is
        /// mutually exclusive with connectionString, serviceEndpoint property.
        /// Type: string, SecureString or AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sasUri")]
        public object SasUri { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of sasToken in
        /// sas uri.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sasToken")]
        public AzureKeyVaultSecretReference SasToken { get; set; }

        /// <summary>
        /// Gets or sets blob service endpoint of the Azure Blob Storage
        /// resource. It is mutually exclusive with connectionString, sasUri
        /// property.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.serviceEndpoint")]
        public string ServiceEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against Azure SQL Data Warehouse. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against Azure SQL Data Warehouse.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (AccountKey != null)
            {
                AccountKey.Validate();
            }
            if (SasToken != null)
            {
                SasToken.Validate();
            }
        }
    }
}
