// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConnectionTypeOperations.
    /// </summary>
    public static partial class ConnectionTypeOperationsExtensions
    {
            /// <summary>
            /// Delete the connection type.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='connectionTypeName'>
            /// The name of connection type.
            /// </param>
            public static void Delete(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccountName, string connectionTypeName)
            {
                operations.DeleteAsync(resourceGroupName, automationAccountName, connectionTypeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the connection type.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='connectionTypeName'>
            /// The name of connection type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccountName, string connectionTypeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, automationAccountName, connectionTypeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve the connection type identified by connection type name.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='connectionTypeName'>
            /// The name of connection type.
            /// </param>
            public static ConnectionType Get(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccountName, string connectionTypeName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, connectionTypeName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the connection type identified by connection type name.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='connectionTypeName'>
            /// The name of connection type.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionType> GetAsync(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccountName, string connectionTypeName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, connectionTypeName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a connection type.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='connectionTypeName'>
            /// The parameters supplied to the create or update connection type operation.
            /// </param>
            /// <param name='parameters'>
            /// The parameters supplied to the create or update connection type operation.
            /// </param>
            public static ConnectionType CreateOrUpdate(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccountName, string connectionTypeName, ConnectionTypeCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, automationAccountName, connectionTypeName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a connection type.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='connectionTypeName'>
            /// The parameters supplied to the create or update connection type operation.
            /// </param>
            /// <param name='parameters'>
            /// The parameters supplied to the create or update connection type operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionType> CreateOrUpdateAsync(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccountName, string connectionTypeName, ConnectionTypeCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, automationAccountName, connectionTypeName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of connection types.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            public static IPage<ConnectionType> ListByAutomationAccount(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccountName)
            {
                return operations.ListByAutomationAccountAsync(resourceGroupName, automationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of connection types.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConnectionType>> ListByAutomationAccountAsync(this IConnectionTypeOperations operations, string resourceGroupName, string automationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(resourceGroupName, automationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of connection types.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConnectionType> ListByAutomationAccountNext(this IConnectionTypeOperations operations, string nextPageLink)
            {
                return operations.ListByAutomationAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of connection types.
            /// <see href="http://aka.ms/azureautomationsdk/connectiontypeoperations" />
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
            public static async Task<IPage<ConnectionType>> ListByAutomationAccountNextAsync(this IConnectionTypeOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}