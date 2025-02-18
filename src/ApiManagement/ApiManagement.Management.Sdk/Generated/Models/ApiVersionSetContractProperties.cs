// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of an API Version Set.
    /// </summary>
    public partial class ApiVersionSetContractProperties : ApiVersionSetEntityBase
    {
        /// <summary>
        /// Initializes a new instance of the ApiVersionSetContractProperties class.
        /// </summary>
        public ApiVersionSetContractProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiVersionSetContractProperties class.
        /// </summary>

        /// <param name="description">Description of API Version Set.
        /// </param>

        /// <param name="versionQueryName">Name of query parameter that indicates the API Version if versioningScheme
        /// is set to `query`.
        /// </param>

        /// <param name="versionHeaderName">Name of HTTP header parameter that indicates the API Version if
        /// versioningScheme is set to `header`.
        /// </param>

        /// <param name="displayName">Name of API Version Set
        /// </param>

        /// <param name="versioningScheme">An value that determines where the API Version identifier will be located
        /// in a HTTP request.
        /// Possible values include: &#39;Segment&#39;, &#39;Query&#39;, &#39;Header&#39;</param>
        public ApiVersionSetContractProperties(string displayName, string versioningScheme, string description = default(string), string versionQueryName = default(string), string versionHeaderName = default(string))

        : base(description, versionQueryName, versionHeaderName)
        {
            this.DisplayName = displayName;
            this.VersioningScheme = versioningScheme;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of API Version Set
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName {get; set; }

        /// <summary>
        /// Gets or sets an value that determines where the API Version identifier will
        /// be located in a HTTP request. Possible values include: &#39;Segment&#39;, &#39;Query&#39;, &#39;Header&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "versioningScheme")]
        public string VersioningScheme {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.DisplayName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DisplayName");
            }
            if (this.VersioningScheme == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "VersioningScheme");
            }
            if (this.DisplayName != null)
            {
                if (this.DisplayName.Length > 100)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxLength, "DisplayName", 100);
                }
                if (this.DisplayName.Length < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MinLength, "DisplayName", 1);
                }
            }

        }
    }
}