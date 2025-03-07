// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="PartnerNamespacePrivateLinkResource" /> and their operations.
    /// Each <see cref="PartnerNamespacePrivateLinkResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PartnerNamespacePrivateLinkResourceCollection" /> instance call the GetPartnerNamespacePrivateLinkResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PartnerNamespacePrivateLinkResourceCollection : ArmCollection
    {
        private readonly ClientDiagnostics _privateLinkResourcesClientDiagnostics;
        private readonly PrivateLinkResourcesRestOperations _privateLinkResourcesRestClient;
        private readonly string _parentName;

        /// <summary> Initializes a new instance of the <see cref="PartnerNamespacePrivateLinkResourceCollection"/> class for mocking. </summary>
        protected PartnerNamespacePrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerNamespacePrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        internal PartnerNamespacePrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id, string parentName) : base(client, id)
        {
            _parentName = parentName;
            _privateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _privateLinkResourcesRestClient = new PrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get properties of a private link resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="privateLinkResourceName"> The name of private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> or <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<EventGridPrivateLinkResourceData>> GetAsync(string parentName, string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, privateLinkResourceName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a private link resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="privateLinkResourceName"> The name of private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> or <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<EventGridPrivateLinkResourceData> Get(string parentName, string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _privateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, privateLinkResourceName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the private link resources under a topic, domain, or partner namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_ListByResource
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the &apos;name&apos; property only and with limited number of OData operations. These operations are: the &apos;contains&apos; function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, &apos;PATTERN&apos;) and name ne &apos;PATTERN-1&apos;. The following is not a valid filter example: $filter=location eq &apos;westus&apos;. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        /// <returns> An async collection of <see cref="EventGridPrivateLinkResourceData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventGridPrivateLinkResourceData> GetAllAsync(string parentName, string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));

            async Task<Page<EventGridPrivateLinkResourceData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkResourcesRestClient.ListByResourceAsync(Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventGridPrivateLinkResourceData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateLinkResourcesRestClient.ListByResourceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List all the private link resources under a topic, domain, or partner namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateLinkResources
        /// Operation Id: PrivateLinkResources_ListByResource
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the &apos;name&apos; property only and with limited number of OData operations. These operations are: the &apos;contains&apos; function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, &apos;PATTERN&apos;) and name ne &apos;PATTERN-1&apos;. The following is not a valid filter example: $filter=location eq &apos;westus&apos;. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        /// <returns> A collection of <see cref="EventGridPrivateLinkResourceData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventGridPrivateLinkResourceData> GetAll(string parentName, string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));

            Page<EventGridPrivateLinkResourceData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkResourcesRestClient.ListByResource(Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventGridPrivateLinkResourceData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateLinkResourcesRestClient.ListByResourceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="privateLinkResourceName"> The name of private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> or <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string parentName, string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _privateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, privateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{parentType}/{parentName}/privateLinkResources/{privateLinkResourceName}
        /// Operation Id: PrivateLinkResources_Get
        /// </summary>
        /// <param name="parentName"> The name of the parent resource (namely, either, the topic name, domain name, or partner namespace name). </param>
        /// <param name="privateLinkResourceName"> The name of private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="parentName"/> or <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string parentName, string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(parentName, nameof(parentName));
            Argument.AssertNotNullOrEmpty(privateLinkResourceName, nameof(privateLinkResourceName));

            using var scope = _privateLinkResourcesClientDiagnostics.CreateScope("PartnerNamespacePrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _privateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "partnerNamespaces", parentName, privateLinkResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
