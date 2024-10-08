// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using System.Linq;

    /// <summary>
    /// Subscription State object.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SubscriptionState
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionState class.
        /// </summary>
        public SubscriptionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionState class.
        /// </summary>

        /// <param name="state">State of Azure Subscription
        /// Possible values include: &#39;Registered&#39;, &#39;Unregistered&#39;, &#39;Warned&#39;,
        /// &#39;Suspended&#39;, &#39;Deleted&#39;</param>

        /// <param name="istransitioning">Is Transitioning
        /// </param>

        /// <param name="properties">Subscription state properties.
        /// </param>
        public SubscriptionState(string state = default(string), bool? istransitioning = default(bool?), object properties = default(object))

        {
            this.State = state;
            this.Istransitioning = istransitioning;
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets state of Azure Subscription Possible values include: &#39;Registered&#39;, &#39;Unregistered&#39;, &#39;Warned&#39;, &#39;Suspended&#39;, &#39;Deleted&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public string State {get; set; }

        /// <summary>
        /// Gets is Transitioning
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "istransitioning")]
        public bool? Istransitioning {get; private set; }

        /// <summary>
        /// Gets or sets subscription state properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public object Properties {get; set; }
    }
}