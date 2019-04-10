// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InvoiceSectionBillingRoleAssignmentOperations.
    /// </summary>
    public static partial class InvoiceSectionBillingRoleAssignmentOperationsExtensions
    {
            /// <summary>
            /// Get the role assignment for the caller on the invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            public static BillingRoleAssignment Get(this IInvoiceSectionBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName)
            {
                return operations.GetAsync(billingAccountName, invoiceSectionName, billingRoleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the role assignment for the caller on the invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> GetAsync(this IInvoiceSectionBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingRoleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the role assignment on this invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            public static BillingRoleAssignment Delete(this IInvoiceSectionBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName)
            {
                return operations.DeleteAsync(billingAccountName, invoiceSectionName, billingRoleAssignmentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the role assignment on this invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='billingRoleAssignmentName'>
            /// role assignment id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignment> DeleteAsync(this IInvoiceSectionBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, string billingRoleAssignmentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(billingAccountName, invoiceSectionName, billingRoleAssignmentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the role assignments on the invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static BillingRoleAssignmentListResult List(this IInvoiceSectionBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName)
            {
                return operations.ListAsync(billingAccountName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the role assignments on the invoice Section
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignmentListResult> ListAsync(this IInvoiceSectionBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(billingAccountName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to add a role assignment to a invoice Section.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            public static BillingRoleAssignmentListResult Add(this IInvoiceSectionBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName)
            {
                return operations.AddAsync(billingAccountName, invoiceSectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to add a role assignment to a invoice Section.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='invoiceSectionName'>
            /// InvoiceSection Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BillingRoleAssignmentListResult> AddAsync(this IInvoiceSectionBillingRoleAssignmentOperations operations, string billingAccountName, string invoiceSectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(billingAccountName, invoiceSectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}