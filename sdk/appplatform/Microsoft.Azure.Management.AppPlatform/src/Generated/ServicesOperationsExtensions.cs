// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServicesOperations.
    /// </summary>
    public static partial class ServicesOperationsExtensions
    {
            /// <summary>
            /// Get a Service and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            public static ServiceResource Get(this IServicesOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.GetAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Service and its properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceResource> GetAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new Service or update an exiting Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='resource'>
            /// Parameters for the create or update operation
            /// </param>
            public static ServiceResource CreateOrUpdate(this IServicesOperations operations, string resourceGroupName, string serviceName, ServiceResource resource = default(ServiceResource))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, resource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new Service or update an exiting Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='resource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceResource> CreateOrUpdateAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, ServiceResource resource = default(ServiceResource), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, resource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            public static void Delete(this IServicesOperations operations, string resourceGroupName, string serviceName)
            {
                operations.DeleteAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Operation to update an exiting Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='resource'>
            /// Parameters for the update operation
            /// </param>
            public static ServiceResource Update(this IServicesOperations operations, string resourceGroupName, string serviceName, ServiceResource resource = default(ServiceResource))
            {
                return operations.UpdateAsync(resourceGroupName, serviceName, resource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to update an exiting Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='resource'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceResource> UpdateAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, ServiceResource resource = default(ServiceResource), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, resource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List test keys for a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            public static TestKeys ListTestKeys(this IServicesOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.ListTestKeysAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List test keys for a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestKeys> ListTestKeysAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListTestKeysWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate a test key for a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='regenerateTestKeyRequest'>
            /// Parameters for the operation
            /// </param>
            public static TestKeys RegenerateTestKey(this IServicesOperations operations, string resourceGroupName, string serviceName, RegenerateTestKeyRequestPayload regenerateTestKeyRequest = default(RegenerateTestKeyRequestPayload))
            {
                return operations.RegenerateTestKeyAsync(resourceGroupName, serviceName, regenerateTestKeyRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate a test key for a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='regenerateTestKeyRequest'>
            /// Parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestKeys> RegenerateTestKeyAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, RegenerateTestKeyRequestPayload regenerateTestKeyRequest = default(RegenerateTestKeyRequestPayload), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateTestKeyWithHttpMessagesAsync(resourceGroupName, serviceName, regenerateTestKeyRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            public static void DisableTestEndpoint(this IServicesOperations operations, string resourceGroupName, string serviceName)
            {
                operations.DisableTestEndpointAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DisableTestEndpointAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DisableTestEndpointWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            public static TestKeys EnableTestEndpoint(this IServicesOperations operations, string resourceGroupName, string serviceName)
            {
                return operations.EnableTestEndpointAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestKeys> EnableTestEndpointAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnableTestEndpointWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks that the resource name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// the region
            /// </param>
            /// <param name='availabilityParameters'>
            /// Parameters supplied to the operation.
            /// </param>
            public static NameAvailability CheckNameAvailability(this IServicesOperations operations, string location, NameAvailabilityParameters availabilityParameters)
            {
                return operations.CheckNameAvailabilityAsync(location, availabilityParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that the resource name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// the region
            /// </param>
            /// <param name='availabilityParameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NameAvailability> CheckNameAvailabilityAsync(this IServicesOperations operations, string location, NameAvailabilityParameters availabilityParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(location, availabilityParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ServiceResource> ListBySubscription(this IServicesOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceResource>> ListBySubscriptionAsync(this IServicesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static IPage<ServiceResource> List(this IServicesOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceResource>> ListAsync(this IServicesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new Service or update an exiting Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='resource'>
            /// Parameters for the create or update operation
            /// </param>
            public static ServiceResource BeginCreateOrUpdate(this IServicesOperations operations, string resourceGroupName, string serviceName, ServiceResource resource = default(ServiceResource))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceName, resource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new Service or update an exiting Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='resource'>
            /// Parameters for the create or update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceResource> BeginCreateOrUpdateAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, ServiceResource resource = default(ServiceResource), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, resource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Operation to delete a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            public static void BeginDelete(this IServicesOperations operations, string resourceGroupName, string serviceName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to delete a Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Operation to update an exiting Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='resource'>
            /// Parameters for the update operation
            /// </param>
            public static ServiceResource BeginUpdate(this IServicesOperations operations, string resourceGroupName, string serviceName, ServiceResource resource = default(ServiceResource))
            {
                return operations.BeginUpdateAsync(resourceGroupName, serviceName, resource).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Operation to update an exiting Service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the Service resource.
            /// </param>
            /// <param name='resource'>
            /// Parameters for the update operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceResource> BeginUpdateAsync(this IServicesOperations operations, string resourceGroupName, string serviceName, ServiceResource resource = default(ServiceResource), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, resource, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceResource> ListBySubscriptionNext(this IServicesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceResource>> ListBySubscriptionNextAsync(this IServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceResource> ListNext(this IServicesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Handles requests to list all resources in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceResource>> ListNextAsync(this IServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}