// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The product documentation.
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product() { }

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product(string productId = default(string), string description = default(string), string displayName = default(string), string capacity = default(string), string image = default(string))
        {
            ProductId = productId;
            Description = description;
            DisplayName = displayName;
            Capacity = capacity;
            Image = image;
        }

        /// <summary>
        /// Unique identifier representing a specific product for a given
        /// latitude &amp; longitude. For example, uberX in San Francisco
        /// will have a different product_id than uberX in Los Angeles.
        /// </summary>
        [JsonProperty(PropertyName = "product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// Description of product.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Display name of product.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Capacity of product. For example, 4 people.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public string Capacity { get; set; }

        /// <summary>
        /// Image URL representing the product.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

    }
}