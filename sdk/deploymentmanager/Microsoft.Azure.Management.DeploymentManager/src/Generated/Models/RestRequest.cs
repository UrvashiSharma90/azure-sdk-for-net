// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeploymentManager.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties that make up a REST request
    /// </summary>
    public partial class RestRequest
    {
        /// <summary>
        /// Initializes a new instance of the RestRequest class.
        /// </summary>
        public RestRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestRequest class.
        /// </summary>
        /// <param name="method">The HTTP method to use for the request.
        /// Possible values include: 'GET', 'POST'</param>
        /// <param name="uri">The HTTP URI to use for the request.</param>
        /// <param name="authentication">The authentication information
        /// required in the request to the health provider.</param>
        public RestRequest(RestRequestMethod method, string uri, RestRequestAuthentication authentication)
        {
            Method = method;
            Uri = uri;
            Authentication = authentication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the HTTP method to use for the request. Possible
        /// values include: 'GET', 'POST'
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public RestRequestMethod Method { get; set; }

        /// <summary>
        /// Gets or sets the HTTP URI to use for the request.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the authentication information required in the request
        /// to the health provider.
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public RestRequestAuthentication Authentication { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
            if (Authentication == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Authentication");
            }
        }
    }
}