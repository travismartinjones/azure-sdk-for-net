namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    public static partial class SecurityRulesOperationsExtensions
    {
            /// <summary>
            /// The delete network security rule operation deletes the specified network
            /// security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            public static void Delete(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
            {
                Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).DeleteAsync(resourceGroupName, networkSecurityGroupName, securityRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete network security rule operation deletes the specified network
            /// security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsync( this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete network security rule operation deletes the specified network
            /// security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            public static void BeginDelete(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
            {
                Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).BeginDeleteAsync(resourceGroupName, networkSecurityGroupName, securityRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete network security rule operation deletes the specified network
            /// security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync( this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get NetworkSecurityRule operation retreives information about the
            /// specified network security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            public static SecurityRule Get(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).GetAsync(resourceGroupName, networkSecurityGroupName, securityRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get NetworkSecurityRule operation retreives information about the
            /// specified network security rule.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<SecurityRule> GetAsync( this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SecurityRule> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The Put network security rule operation creates/updates a security rule in
            /// the specified network security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='securityRuleParameters'>
            /// Parameters supplied to the create/update network security rule operation
            /// </param>
            public static SecurityRule CreateOrUpdate(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).CreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put network security rule operation creates/updates a security rule in
            /// the specified network security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='securityRuleParameters'>
            /// Parameters supplied to the create/update network security rule operation
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<SecurityRule> CreateOrUpdateAsync( this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SecurityRule> result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The Put network security rule operation creates/updates a security rule in
            /// the specified network security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='securityRuleParameters'>
            /// Parameters supplied to the create/update network security rule operation
            /// </param>
            public static SecurityRule BeginCreateOrUpdate(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put network security rule operation creates/updates a security rule in
            /// the specified network security group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='securityRuleName'>
            /// The name of the security rule.
            /// </param>
            /// <param name='securityRuleParameters'>
            /// Parameters supplied to the create/update network security rule operation
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<SecurityRule> BeginCreateOrUpdateAsync( this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRule securityRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SecurityRule> result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The List network security rule opertion retrieves all the security rules
            /// in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            public static SecurityRuleListResult List(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).ListAsync(resourceGroupName, networkSecurityGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List network security rule opertion retrieves all the security rules
            /// in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkSecurityGroupName'>
            /// The name of the network security group.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<SecurityRuleListResult> ListAsync( this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SecurityRuleListResult> result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The List network security rule opertion retrieves all the security rules
            /// in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static SecurityRuleListResult ListNext(this ISecurityRulesOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((ISecurityRulesOperations)s).ListNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List network security rule opertion retrieves all the security rules
            /// in a network security group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<SecurityRuleListResult> ListNextAsync( this ISecurityRulesOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SecurityRuleListResult> result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
