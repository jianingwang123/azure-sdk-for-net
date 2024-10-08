// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsPackageResource"/> and their operations.
    /// Each <see cref="SecurityInsightsPackageResource"/> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// To get a <see cref="SecurityInsightsPackageCollection"/> instance call the GetSecurityInsightsPackages method from an instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// </summary>
    public partial class SecurityInsightsPackageCollection : ArmCollection, IEnumerable<SecurityInsightsPackageResource>, IAsyncEnumerable<SecurityInsightsPackageResource>
    {
        private readonly ClientDiagnostics _securityInsightsPackageContentPackageClientDiagnostics;
        private readonly ContentPackageRestOperations _securityInsightsPackageContentPackageRestClient;
        private readonly ClientDiagnostics _securityInsightsPackageContentPackagesClientDiagnostics;
        private readonly ContentPackagesRestOperations _securityInsightsPackageContentPackagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsPackageCollection"/> class for mocking. </summary>
        protected SecurityInsightsPackageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsPackageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsPackageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsPackageContentPackageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsPackageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsPackageResource.ResourceType, out string securityInsightsPackageContentPackageApiVersion);
            _securityInsightsPackageContentPackageRestClient = new ContentPackageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsPackageContentPackageApiVersion);
            _securityInsightsPackageContentPackagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsPackageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsPackageResource.ResourceType, out string securityInsightsPackageContentPackagesApiVersion);
            _securityInsightsPackageContentPackagesRestClient = new ContentPackagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsPackageContentPackagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Install a package to the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages/{packageId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackage_Install</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packageId"> package Id. </param>
        /// <param name="data"> Package installation properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsPackageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string packageId, SecurityInsightsPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageId, nameof(packageId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsPackageContentPackageClientDiagnostics.CreateScope("SecurityInsightsPackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsPackageContentPackageRestClient.InstallAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, data, cancellationToken).ConfigureAwait(false);
                var uri = _securityInsightsPackageContentPackageRestClient.CreateInstallRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsPackageResource>(Response.FromValue(new SecurityInsightsPackageResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Install a package to the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages/{packageId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackage_Install</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="packageId"> package Id. </param>
        /// <param name="data"> Package installation properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsPackageResource> CreateOrUpdate(WaitUntil waitUntil, string packageId, SecurityInsightsPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageId, nameof(packageId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsPackageContentPackageClientDiagnostics.CreateScope("SecurityInsightsPackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsPackageContentPackageRestClient.Install(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, data, cancellationToken);
                var uri = _securityInsightsPackageContentPackageRestClient.CreateInstallRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsPackageResource>(Response.FromValue(new SecurityInsightsPackageResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an installed packages by its id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages/{packageId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageId"> package Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageId"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsPackageResource>> GetAsync(string packageId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageId, nameof(packageId));

            using var scope = _securityInsightsPackageContentPackagesClientDiagnostics.CreateScope("SecurityInsightsPackageCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsPackageContentPackagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an installed packages by its id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages/{packageId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageId"> package Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageId"/> is null. </exception>
        public virtual Response<SecurityInsightsPackageResource> Get(string packageId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageId, nameof(packageId));

            using var scope = _securityInsightsPackageContentPackagesClientDiagnostics.CreateScope("SecurityInsightsPackageCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsPackageContentPackagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all installed packages.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsPackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsPackageResource> GetAllAsync(SecurityInsightsPackageCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SecurityInsightsPackageCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsPackageContentPackagesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.OrderBy, options.Search, options.Count, options.Top, options.Skip, options.SkipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsPackageContentPackagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.OrderBy, options.Search, options.Count, options.Top, options.Skip, options.SkipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsPackageResource(Client, SecurityInsightsPackageData.DeserializeSecurityInsightsPackageData(e)), _securityInsightsPackageContentPackagesClientDiagnostics, Pipeline, "SecurityInsightsPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all installed packages.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsPackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsPackageResource> GetAll(SecurityInsightsPackageCollectionGetAllOptions options, CancellationToken cancellationToken = default)
        {
            options ??= new SecurityInsightsPackageCollectionGetAllOptions();

            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsPackageContentPackagesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.OrderBy, options.Search, options.Count, options.Top, options.Skip, options.SkipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsPackageContentPackagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, options.Filter, options.OrderBy, options.Search, options.Count, options.Top, options.Skip, options.SkipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsPackageResource(Client, SecurityInsightsPackageData.DeserializeSecurityInsightsPackageData(e)), _securityInsightsPackageContentPackagesClientDiagnostics, Pipeline, "SecurityInsightsPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages/{packageId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageId"> package Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string packageId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageId, nameof(packageId));

            using var scope = _securityInsightsPackageContentPackagesClientDiagnostics.CreateScope("SecurityInsightsPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsPackageContentPackagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages/{packageId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageId"> package Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageId"/> is null. </exception>
        public virtual Response<bool> Exists(string packageId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageId, nameof(packageId));

            using var scope = _securityInsightsPackageContentPackagesClientDiagnostics.CreateScope("SecurityInsightsPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsPackageContentPackagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages/{packageId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageId"> package Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageId"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityInsightsPackageResource>> GetIfExistsAsync(string packageId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageId, nameof(packageId));

            using var scope = _securityInsightsPackageContentPackagesClientDiagnostics.CreateScope("SecurityInsightsPackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityInsightsPackageContentPackagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsPackageResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/contentPackages/{packageId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentPackages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="packageId"> package Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packageId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packageId"/> is null. </exception>
        public virtual NullableResponse<SecurityInsightsPackageResource> GetIfExists(string packageId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(packageId, nameof(packageId));

            using var scope = _securityInsightsPackageContentPackagesClientDiagnostics.CreateScope("SecurityInsightsPackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityInsightsPackageContentPackagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, packageId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsPackageResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsPackageResource> IEnumerable<SecurityInsightsPackageResource>.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll(options: null).GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsPackageResource> IAsyncEnumerable<SecurityInsightsPackageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(options: null, cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
