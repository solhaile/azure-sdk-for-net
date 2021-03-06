// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReceivedRoutesOperations.
    /// </summary>
    public static partial class ReceivedRoutesOperationsExtensions
    {
            /// <summary>
            /// Lists the prefixes received over the specified peering under the given
            /// subscription and resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='prefix'>
            /// The optional prefix that can be used to filter the routes.
            /// </param>
            /// <param name='asPath'>
            /// The optional AS path that can be used to filter the routes.
            /// </param>
            /// <param name='originAsValidationState'>
            /// The optional origin AS validation state that can be used to filter the
            /// routes.
            /// </param>
            /// <param name='rpkiValidationState'>
            /// The optional RPKI validation state that can be used to filter the routes.
            /// </param>
            /// <param name='skipToken'>
            /// The optional page continuation token that is used in the event of paginated
            /// result.
            /// </param>
            public static IPage<PeeringReceivedRoute> ListByPeering(this IReceivedRoutesOperations operations, string resourceGroupName, string peeringName, string prefix = default(string), string asPath = default(string), string originAsValidationState = default(string), string rpkiValidationState = default(string), string skipToken = default(string))
            {
                return operations.ListByPeeringAsync(resourceGroupName, peeringName, prefix, asPath, originAsValidationState, rpkiValidationState, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the prefixes received over the specified peering under the given
            /// subscription and resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='peeringName'>
            /// The name of the peering.
            /// </param>
            /// <param name='prefix'>
            /// The optional prefix that can be used to filter the routes.
            /// </param>
            /// <param name='asPath'>
            /// The optional AS path that can be used to filter the routes.
            /// </param>
            /// <param name='originAsValidationState'>
            /// The optional origin AS validation state that can be used to filter the
            /// routes.
            /// </param>
            /// <param name='rpkiValidationState'>
            /// The optional RPKI validation state that can be used to filter the routes.
            /// </param>
            /// <param name='skipToken'>
            /// The optional page continuation token that is used in the event of paginated
            /// result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PeeringReceivedRoute>> ListByPeeringAsync(this IReceivedRoutesOperations operations, string resourceGroupName, string peeringName, string prefix = default(string), string asPath = default(string), string originAsValidationState = default(string), string rpkiValidationState = default(string), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPeeringWithHttpMessagesAsync(resourceGroupName, peeringName, prefix, asPath, originAsValidationState, rpkiValidationState, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the prefixes received over the specified peering under the given
            /// subscription and resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PeeringReceivedRoute> ListByPeeringNext(this IReceivedRoutesOperations operations, string nextPageLink)
            {
                return operations.ListByPeeringNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the prefixes received over the specified peering under the given
            /// subscription and resource group.
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
            public static async Task<IPage<PeeringReceivedRoute>> ListByPeeringNextAsync(this IReceivedRoutesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByPeeringNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
