// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Amazon Marketplace Web Service linked service properties.
    /// </summary>
    public partial class AmazonMWSLinkedServiceTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the AmazonMWSLinkedServiceTypeProperties class.
        /// </summary>
        public AmazonMWSLinkedServiceTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AmazonMWSLinkedServiceTypeProperties class.
        /// </summary>

        /// <param name="endpoint">The endpoint of the Amazon MWS server, (i.e. mws.amazonservices.com)
        /// </param>

        /// <param name="marketplaceId">The Amazon Marketplace ID you want to retrieve data from. To retrieve data
        /// from multiple Marketplace IDs, separate them with a comma (,). (i.e.
        /// A2EUQ1WTGCTBG2)
        /// </param>

        /// <param name="sellerId">The Amazon seller ID.
        /// </param>

        /// <param name="mwsAuthToken">The Amazon MWS authentication token.
        /// </param>

        /// <param name="accessKeyId">The access key id used to access data.
        /// </param>

        /// <param name="secretKey">The secret key used to access data.
        /// </param>

        /// <param name="useEncryptedEndpoints">Specifies whether the data source endpoints are encrypted using HTTPS. The
        /// default value is true.
        /// </param>

        /// <param name="useHostVerification">Specifies whether to require the host name in the server&#39;s certificate to
        /// match the host name of the server when connecting over SSL. The default
        /// value is true.
        /// </param>

        /// <param name="usePeerVerification">Specifies whether to verify the identity of the server when connecting over
        /// SSL. The default value is true.
        /// </param>

        /// <param name="encryptedCredential">The encrypted credential used for authentication. Credentials are encrypted
        /// using the integration runtime credential manager. Type: string.
        /// </param>
        public AmazonMWSLinkedServiceTypeProperties(object endpoint, object marketplaceId, object sellerId, object accessKeyId, SecretBase mwsAuthToken = default(SecretBase), SecretBase secretKey = default(SecretBase), object useEncryptedEndpoints = default(object), object useHostVerification = default(object), object usePeerVerification = default(object), string encryptedCredential = default(string))

        {
            this.Endpoint = endpoint;
            this.MarketplaceId = marketplaceId;
            this.SellerId = sellerId;
            this.MwsAuthToken = mwsAuthToken;
            this.AccessKeyId = accessKeyId;
            this.SecretKey = secretKey;
            this.UseEncryptedEndpoints = useEncryptedEndpoints;
            this.UseHostVerification = useHostVerification;
            this.UsePeerVerification = usePeerVerification;
            this.EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the endpoint of the Amazon MWS server, (i.e.
        /// mws.amazonservices.com)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endpoint")]
        public object Endpoint {get; set; }

        /// <summary>
        /// Gets or sets the Amazon Marketplace ID you want to retrieve data from. To
        /// retrieve data from multiple Marketplace IDs, separate them with a comma
        /// (,). (i.e. A2EUQ1WTGCTBG2)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "marketplaceID")]
        public object MarketplaceId {get; set; }

        /// <summary>
        /// Gets or sets the Amazon seller ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sellerID")]
        public object SellerId {get; set; }

        /// <summary>
        /// Gets or sets the Amazon MWS authentication token.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mwsAuthToken")]
        public SecretBase MwsAuthToken {get; set; }

        /// <summary>
        /// Gets or sets the access key id used to access data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accessKeyId")]
        public object AccessKeyId {get; set; }

        /// <summary>
        /// Gets or sets the secret key used to access data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secretKey")]
        public SecretBase SecretKey {get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are encrypted
        /// using HTTPS. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "useEncryptedEndpoints")]
        public object UseEncryptedEndpoints {get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require the host name in the server&#39;s
        /// certificate to match the host name of the server when connecting over SSL.
        /// The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "useHostVerification")]
        public object UseHostVerification {get; set; }

        /// <summary>
        /// Gets or sets specifies whether to verify the identity of the server when
        /// connecting over SSL. The default value is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "usePeerVerification")]
        public object UsePeerVerification {get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication. Credentials
        /// are encrypted using the integration runtime credential manager. Type:
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptedCredential")]
        public string EncryptedCredential {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Endpoint == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Endpoint");
            }
            if (this.MarketplaceId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "MarketplaceId");
            }
            if (this.SellerId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SellerId");
            }
            if (this.AccessKeyId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AccessKeyId");
            }










        }
    }
}