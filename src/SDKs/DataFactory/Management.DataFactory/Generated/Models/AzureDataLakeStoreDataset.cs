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
    /// Azure Data Lake Store dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDataLakeStoreFile")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureDataLakeStoreDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the AzureDataLakeStoreDataset class.
        /// </summary>
        public AzureDataLakeStoreDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureDataLakeStoreDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="folderPath">Path to the folder in the Azure Data Lake
        /// Store. Type: string (or Expression with resultType string).</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        /// <param name="fileName">The name of the file in the Azure Data Lake
        /// Store. Type: string (or Expression with resultType string).</param>
        /// <param name="format">The format of the Data Lake Store.</param>
        /// <param name="compression">The data compression method used for the
        /// item(s) in the Azure Data Lake Store.</param>
        public AzureDataLakeStoreDataset(LinkedServiceReference linkedServiceName, object folderPath, string description = default(string), object structure = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), object fileName = default(object), DatasetStorageFormat format = default(DatasetStorageFormat), DatasetCompression compression = default(DatasetCompression))
            : base(linkedServiceName, description, structure, parameters)
        {
            FolderPath = folderPath;
            FileName = fileName;
            Format = format;
            Compression = compression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path to the folder in the Azure Data Lake Store. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.folderPath")]
        public object FolderPath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file in the Azure Data Lake Store.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.fileName")]
        public object FileName { get; set; }

        /// <summary>
        /// Gets or sets the format of the Data Lake Store.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.format")]
        public DatasetStorageFormat Format { get; set; }

        /// <summary>
        /// Gets or sets the data compression method used for the item(s) in
        /// the Azure Data Lake Store.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compression")]
        public DatasetCompression Compression { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (FolderPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FolderPath");
            }
        }
    }
}