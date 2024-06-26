// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using System.Linq;

    /// <summary>
    /// The list of intermediate cluster code versions for an upgrade or downgrade.
    /// Or minimum and maximum upgradable version if no target was given
    /// </summary>
    public partial class UpgradableVersionPathResult
    {
        /// <summary>
        /// Initializes a new instance of the UpgradableVersionPathResult class.
        /// </summary>
        public UpgradableVersionPathResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpgradableVersionPathResult class.
        /// </summary>

        /// <param name="supportedPath">
        /// </param>
        public UpgradableVersionPathResult(System.Collections.Generic.IList<string> supportedPath = default(System.Collections.Generic.IList<string>))

        {
            this.SupportedPath = supportedPath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "supportedPath")]
        public System.Collections.Generic.IList<string> SupportedPath {get; set; }
    }
}