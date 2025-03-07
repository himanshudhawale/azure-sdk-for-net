﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.Identity.Client;

namespace Azure.Identity
{
    /// <summary>
    /// Enables authentication of an AAD service principal using a signed client assertion.
    /// </summary>
    public class ClientAssertionCredential : TokenCredential
    {
        private readonly string[] _additionallyAllowedTenantIds;

        internal string TenantId { get; }
        internal string ClientId { get; }
        internal MsalConfidentialClient Client { get; }
        internal CredentialPipeline Pipeline { get; }
        internal bool AllowMultiTenantAuthentication { get; }

        /// <summary>
        /// Protected constructor for mocking.
        /// </summary>
        protected ClientAssertionCredential()
        { }

        /// <summary>
        /// Creates an instance of the ClientCertificateCredential with an asynchronous callback that provides a signed client assertion to authenticate against Azure Active Directory.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant (directory) Id of the service principal.</param>
        /// <param name="clientId">The client (application) ID of the service principal</param>
        /// <param name="assertionCallback">An asynchronous callback returning a valid client assertion used to authenticate the service principal.</param>
        /// <param name="options">Options that allow to configure the management of the requests sent to the Azure Active Directory service.</param>
        public ClientAssertionCredential(string tenantId, string clientId, Func<CancellationToken, Task<string>> assertionCallback, ClientAssertionCredentialOptions options = default)
        {
            Argument.AssertNotNull(clientId, nameof(clientId));

            TenantId = Validations.ValidateTenantId(tenantId, nameof(tenantId));
            ClientId = clientId;

            Client = options?.MsalClient ?? new MsalConfidentialClient(options?.Pipeline ?? CredentialPipeline.GetInstance(options), tenantId, clientId, assertionCallback, options);
            Pipeline = options?.Pipeline ?? Client.Pipeline;
            _additionallyAllowedTenantIds = TenantIdResolver.ResolveAddionallyAllowedTenantIds(options?.AdditionallyAllowedTenantsCore);
        }

        /// <summary>
        /// Creates an instance of the ClientCertificateCredential with a synchronous callback that provides a signed client assertion to authenticate against Azure Active Directory.
        /// </summary>
        /// <param name="tenantId">The Azure Active Directory tenant (directory) Id of the service principal.</param>
        /// <param name="clientId">The client (application) ID of the service principal</param>
        /// <param name="assertionCallback">A synchronous callback returning a valid client assertion used to authenticate the service principal.</param>
        /// <param name="options">Options that allow to configure the management of the requests sent to the Azure Active Directory service.</param>
        public ClientAssertionCredential(string tenantId, string clientId, Func<string> assertionCallback, ClientAssertionCredentialOptions options = default)
        {
            Argument.AssertNotNull(clientId, nameof(clientId));

            TenantId = Validations.ValidateTenantId(tenantId, nameof(tenantId));
            ClientId = clientId;

            Client = options?.MsalClient ?? new MsalConfidentialClient(options?.Pipeline ?? CredentialPipeline.GetInstance(options), tenantId, clientId, assertionCallback, options);
            Pipeline = options?.Pipeline ?? Client.Pipeline;
            _additionallyAllowedTenantIds = TenantIdResolver.ResolveAddionallyAllowedTenantIds(options?.AdditionallyAllowedTenantsCore);
        }

        /// <summary>
        ///  Obtains a token from the Azure Active Directory service, by calling the assertionCallback specified when constructing the credential to obtain a client assertion for authentication.
        /// </summary>
        /// <param name="requestContext">The details of the authentication request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An <see cref="AccessToken"/> which can be used to authenticate service client calls.</returns>
        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            using CredentialDiagnosticScope scope = Pipeline.StartGetTokenScope("ClientAssertionCredential.GetToken", requestContext);

            try
            {
                var tenantId = TenantIdResolver.Resolve(TenantId, requestContext, _additionallyAllowedTenantIds);

                AuthenticationResult result = Client.AcquireTokenForClientAsync(requestContext.Scopes, tenantId, false, cancellationToken).EnsureCompleted();

                return scope.Succeeded(new AccessToken(result.AccessToken, result.ExpiresOn));
            }
            catch (Exception e)
            {
                throw scope.FailWrapAndThrow(e);
            }
        }

        /// <summary>
        ///  Obtains a token from the Azure Active Directory service, by calling the assertionCallback specified when constructing the credential to obtain a client assertion for authentication.
        /// </summary>
        /// <param name="requestContext">The details of the authentication request.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> controlling the request lifetime.</param>
        /// <returns>An <see cref="AccessToken"/> which can be used to authenticate service client calls.</returns>
        public async override ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            using CredentialDiagnosticScope scope = Pipeline.StartGetTokenScope("ClientAssertionCredential.GetToken", requestContext);

            try
            {
                var tenantId = TenantIdResolver.Resolve(TenantId, requestContext, _additionallyAllowedTenantIds);

                AuthenticationResult result = await Client.AcquireTokenForClientAsync(requestContext.Scopes, tenantId, true, cancellationToken).ConfigureAwait(false);

                return scope.Succeeded(new AccessToken(result.AccessToken, result.ExpiresOn));
            }
            catch (Exception e)
            {
                throw scope.FailWrapAndThrow(e);
            }
        }
    }
}
