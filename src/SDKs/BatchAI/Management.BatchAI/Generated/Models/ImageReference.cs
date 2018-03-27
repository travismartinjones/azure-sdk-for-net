// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The image reference.
    /// </summary>
    public partial class ImageReference
    {
        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        public ImageReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageReference class.
        /// </summary>
        /// <param name="publisher">Publisher of the image.</param>
        /// <param name="offer">Offer of the image.</param>
        /// <param name="sku">SKU of the image.</param>
        /// <param name="version">Version of the image.</param>
        /// <param name="virtualMachineImageId">The ARM resource identifier of
        /// the virtual machine image. Computes nodes of the cluster will be
        /// created using this custom image. This is of the form
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/images/{imageName}</param>
        public ImageReference(string publisher, string offer, string sku, string version = default(string), string virtualMachineImageId = default(string))
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            Version = version;
            VirtualMachineImageId = virtualMachineImageId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets publisher of the image.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets offer of the image.
        /// </summary>
        [JsonProperty(PropertyName = "offer")]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets SKU of the image.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets version of the image.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource identifier of the virtual machine
        /// image. Computes nodes of the cluster will be created using this
        /// custom image. This is of the form
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/images/{imageName}
        /// </summary>
        /// <remarks>
        /// The virtual machine image must be in the same region and
        /// subscription as the cluster. For information about the firewall
        /// settings for the Batch node agent to communicate with the Batch
        /// service see
        /// https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration.
        /// Note, you need to provide publisher, offer and sku of the base OS
        /// image of which the custom image has been derived from.
        /// </remarks>
        [JsonProperty(PropertyName = "virtualMachineImageId")]
        public string VirtualMachineImageId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Publisher == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Publisher");
            }
            if (Offer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Offer");
            }
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
        }
    }
}
