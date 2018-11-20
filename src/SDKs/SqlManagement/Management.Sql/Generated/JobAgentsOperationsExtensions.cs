// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobAgentsOperations.
    /// </summary>
    public static partial class JobAgentsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of job agents in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static IPage<JobAgent> ListByServer(this IJobAgentsOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of job agents in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobAgent>> ListByServerAsync(this IJobAgentsOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be retrieved.
            /// </param>
            public static JobAgent Get(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName)
            {
                return operations.GetAsync(resourceGroupName, serverName, jobAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobAgent> GetAsync(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// The requested job agent resource state.
            /// </param>
            public static JobAgent CreateOrUpdate(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, JobAgent parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// The requested job agent resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobAgent> CreateOrUpdateAsync(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, JobAgent parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be deleted.
            /// </param>
            public static void Delete(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, jobAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The update to the job agent.
            /// </param>
            public static JobAgent Update(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, JobAgentUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serverName, jobAgentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The update to the job agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobAgent> UpdateAsync(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, JobAgentUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// The requested job agent resource state.
            /// </param>
            public static JobAgent BeginCreateOrUpdate(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, JobAgent parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// The requested job agent resource state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobAgent> BeginCreateOrUpdateAsync(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, JobAgent parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be deleted.
            /// </param>
            public static void BeginDelete(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, jobAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The update to the job agent.
            /// </param>
            public static JobAgent BeginUpdate(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, JobAgentUpdate parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, serverName, jobAgentName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a job agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent to be updated.
            /// </param>
            /// <param name='parameters'>
            /// The update to the job agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobAgent> BeginUpdateAsync(this IJobAgentsOperations operations, string resourceGroupName, string serverName, string jobAgentName, JobAgentUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of job agents in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobAgent> ListByServerNext(this IJobAgentsOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of job agents in a server.
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
            public static async Task<IPage<JobAgent>> ListByServerNextAsync(this IJobAgentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}