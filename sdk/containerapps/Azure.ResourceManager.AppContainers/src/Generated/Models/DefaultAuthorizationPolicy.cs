// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the Azure Active Directory default authorization policy. </summary>
    public partial class DefaultAuthorizationPolicy
    {
        /// <summary> Initializes a new instance of DefaultAuthorizationPolicy. </summary>
        public DefaultAuthorizationPolicy()
        {
            AllowedApplications = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DefaultAuthorizationPolicy. </summary>
        /// <param name="allowedPrincipals"> The configuration settings of the Azure Active Directory allowed principals. </param>
        /// <param name="allowedApplications"> The configuration settings of the Azure Active Directory allowed applications. </param>
        internal DefaultAuthorizationPolicy(AllowedPrincipals allowedPrincipals, IList<string> allowedApplications)
        {
            AllowedPrincipals = allowedPrincipals;
            AllowedApplications = allowedApplications;
        }

        /// <summary> The configuration settings of the Azure Active Directory allowed principals. </summary>
        public AllowedPrincipals AllowedPrincipals { get; set; }
        /// <summary> The configuration settings of the Azure Active Directory allowed applications. </summary>
        public IList<string> AllowedApplications { get; }
    }
}
