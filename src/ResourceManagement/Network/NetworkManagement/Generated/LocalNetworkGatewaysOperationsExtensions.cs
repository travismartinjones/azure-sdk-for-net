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

    public static partial class LocalNetworkGatewaysOperationsExtensions
    {
            /// <summary>
            /// The Put LocalNetworkGateway operation creates/updates a local network
            /// gateway in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Create or update Local Network Gateway
            /// operation through Network resource provider.
            /// </param>
            public static LocalNetworkGateway CreateOrUpdate(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).CreateOrUpdateAsync(resourceGroupName, localNetworkGatewayName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put LocalNetworkGateway operation creates/updates a local network
            /// gateway in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Create or update Local Network Gateway
            /// operation through Network resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> CreateOrUpdateAsync( this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<LocalNetworkGateway> result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The Put LocalNetworkGateway operation creates/updates a local network
            /// gateway in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Create or update Local Network Gateway
            /// operation through Network resource provider.
            /// </param>
            public static LocalNetworkGateway BeginCreateOrUpdate(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, localNetworkGatewayName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put LocalNetworkGateway operation creates/updates a local network
            /// gateway in the specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Begin Create or update Local Network Gateway
            /// operation through Network resource provider.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> BeginCreateOrUpdateAsync( this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<LocalNetworkGateway> result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The Get LocalNetworkGateway operation retrieves information about the
            /// specified local network gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static LocalNetworkGateway Get(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).GetAsync(resourceGroupName, localNetworkGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get LocalNetworkGateway operation retrieves information about the
            /// specified local network gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<LocalNetworkGateway> GetAsync( this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<LocalNetworkGateway> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The Delete LocalNetworkGateway operation deletes the specifed local
            /// network Gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static void Delete(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).DeleteAsync(resourceGroupName, localNetworkGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete LocalNetworkGateway operation deletes the specifed local
            /// network Gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsync( this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Delete LocalNetworkGateway operation deletes the specifed local
            /// network Gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            public static void BeginDelete(this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName)
            {
                Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).BeginDeleteAsync(resourceGroupName, localNetworkGatewayName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete LocalNetworkGateway operation deletes the specifed local
            /// network Gateway through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='localNetworkGatewayName'>
            /// The name of the local network gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync( this ILocalNetworkGatewaysOperations operations, string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, localNetworkGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The List LocalNetworkGateways opertion retrieves all the local network
            /// gateways stored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static LocalNetworkGatewayListResult List(this ILocalNetworkGatewaysOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List LocalNetworkGateways opertion retrieves all the local network
            /// gateways stored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<LocalNetworkGatewayListResult> ListAsync( this ILocalNetworkGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<LocalNetworkGatewayListResult> result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The List LocalNetworkGateways opertion retrieves all the local network
            /// gateways stored.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static LocalNetworkGatewayListResult ListNext(this ILocalNetworkGatewaysOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((ILocalNetworkGatewaysOperations)s).ListNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List LocalNetworkGateways opertion retrieves all the local network
            /// gateways stored.
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
            public static async Task<LocalNetworkGatewayListResult> ListNextAsync( this ILocalNetworkGatewaysOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<LocalNetworkGatewayListResult> result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
