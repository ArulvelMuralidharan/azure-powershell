// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Response parameters for tiering cost info for rehydration
    /// </summary>
    [Newtonsoft.Json.JsonObject("TieringCostRehydrationInfo")]
    public partial class TieringCostRehydrationInfo : TieringCostInfo
    {
        /// <summary>
        /// Initializes a new instance of the TieringCostRehydrationInfo class.
        /// </summary>
        public TieringCostRehydrationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TieringCostRehydrationInfo class.
        /// </summary>

        /// <param name="rehydrationSizeInBytes">Rehydration size in bytes
        /// </param>

        /// <param name="retailRehydrationCostPerGbPerMonth">Source tier to target tier rehydration cost per GB per month
        /// </param>
        public TieringCostRehydrationInfo(long rehydrationSizeInBytes, double retailRehydrationCostPerGbPerMonth)

        {
            this.RehydrationSizeInBytes = rehydrationSizeInBytes;
            this.RetailRehydrationCostPerGbPerMonth = retailRehydrationCostPerGbPerMonth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets rehydration size in bytes
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rehydrationSizeInBytes")]
        public long RehydrationSizeInBytes {get; set; }

        /// <summary>
        /// Gets or sets source tier to target tier rehydration cost per GB per month
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retailRehydrationCostPerGBPerMonth")]
        public double RetailRehydrationCostPerGbPerMonth {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}