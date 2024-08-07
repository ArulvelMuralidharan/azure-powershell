// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Synapse notebook reference type.
    /// </summary>
    public partial class SynapseNotebookReference
    {
        /// <summary>
        /// Initializes a new instance of the SynapseNotebookReference class.
        /// </summary>
        public SynapseNotebookReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SynapseNotebookReference class.
        /// </summary>

        /// <param name="referenceName">Reference notebook name. Type: string (or Expression with resultType
        /// string).
        /// </param>
        public SynapseNotebookReference(object referenceName)

        {
            this.ReferenceName = referenceName;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for SynapseNotebookReference class.
        /// </summary>
        static SynapseNotebookReference()
        {
            Type = "NotebookReference";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets reference notebook name. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "referenceName")]
        public object ReferenceName {get; set; }
        /// <summary>
        /// Gets or sets synapse notebook reference type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public static string Type {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ReferenceName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ReferenceName");
            }


        }
    }
}