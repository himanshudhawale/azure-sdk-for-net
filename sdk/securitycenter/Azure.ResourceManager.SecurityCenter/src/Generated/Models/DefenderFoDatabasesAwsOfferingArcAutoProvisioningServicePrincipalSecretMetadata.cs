// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Metadata of Service Principal secret for autoprovisioning. </summary>
    public partial class DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata
    {
        /// <summary> Initializes a new instance of DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata. </summary>
        public DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata()
        {
        }

        /// <summary> Initializes a new instance of DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata. </summary>
        /// <param name="expiryOn"> expiration date of service principal secret. </param>
        /// <param name="parameterStoreRegion"> region of parameter store where secret is kept. </param>
        /// <param name="parameterNameInStore"> name of secret resource in parameter store. </param>
        internal DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata(DateTimeOffset? expiryOn, string parameterStoreRegion, string parameterNameInStore)
        {
            ExpiryOn = expiryOn;
            ParameterStoreRegion = parameterStoreRegion;
            ParameterNameInStore = parameterNameInStore;
        }

        /// <summary> expiration date of service principal secret. </summary>
        public DateTimeOffset? ExpiryOn { get; set; }
        /// <summary> region of parameter store where secret is kept. </summary>
        public string ParameterStoreRegion { get; set; }
        /// <summary> name of secret resource in parameter store. </summary>
        public string ParameterNameInStore { get; set; }
    }
}
