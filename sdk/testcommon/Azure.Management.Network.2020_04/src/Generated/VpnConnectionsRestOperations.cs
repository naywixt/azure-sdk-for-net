// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    internal partial class VpnConnectionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of VpnConnectionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public VpnConnectionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string gatewayName, string connectionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnGateways/", false);
            uri.AppendPath(gatewayName, true);
            uri.AppendPath("/vpnConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves the details of a vpn connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public async Task<Response<VpnConnection>> GetAsync(string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var message = CreateGetRequest(resourceGroupName, gatewayName, connectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnConnection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VpnConnection.DeserializeVpnConnection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves the details of a vpn connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public Response<VpnConnection> Get(string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var message = CreateGetRequest(resourceGroupName, gatewayName, connectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnConnection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VpnConnection.DeserializeVpnConnection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string gatewayName, string connectionName, VpnConnection vpnConnectionParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnGateways/", false);
            uri.AppendPath(gatewayName, true);
            uri.AppendPath("/vpnConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Headers.Add("Accept", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(vpnConnectionParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a vpn connection to a scalable vpn gateway if it doesn&apos;t exist else updates the existing connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="vpnConnectionParameters"> Parameters supplied to create or Update a VPN Connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/>, or <paramref name="vpnConnectionParameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string gatewayName, string connectionName, VpnConnection vpnConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (vpnConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnConnectionParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, gatewayName, connectionName, vpnConnectionParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a vpn connection to a scalable vpn gateway if it doesn&apos;t exist else updates the existing connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="vpnConnectionParameters"> Parameters supplied to create or Update a VPN Connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/>, or <paramref name="vpnConnectionParameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string gatewayName, string connectionName, VpnConnection vpnConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (vpnConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnConnectionParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, gatewayName, connectionName, vpnConnectionParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string gatewayName, string connectionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnGateways/", false);
            uri.AppendPath(gatewayName, true);
            uri.AppendPath("/vpnConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a vpn connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, gatewayName, connectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a vpn connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, or <paramref name="connectionName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, gatewayName, connectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVpnGatewayRequest(string resourceGroupName, string gatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnGateways/", false);
            uri.AppendPath(gatewayName, true);
            uri.AppendPath("/vpnConnections", false);
            uri.AppendQuery("api-version", "2020-04-01", true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves all vpn connections for a particular virtual wan vpn gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="gatewayName"/> is null. </exception>
        public async Task<Response<ListVpnConnectionsResult>> ListByVpnGatewayAsync(string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var message = CreateListByVpnGatewayRequest(resourceGroupName, gatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnConnectionsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnConnectionsResult.DeserializeListVpnConnectionsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves all vpn connections for a particular virtual wan vpn gateway. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="gatewayName"/> is null. </exception>
        public Response<ListVpnConnectionsResult> ListByVpnGateway(string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var message = CreateListByVpnGatewayRequest(resourceGroupName, gatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnConnectionsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnConnectionsResult.DeserializeListVpnConnectionsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVpnGatewayNextPageRequest(string nextLink, string resourceGroupName, string gatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves all vpn connections for a particular virtual wan vpn gateway. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="gatewayName"/> is null. </exception>
        public async Task<Response<ListVpnConnectionsResult>> ListByVpnGatewayNextPageAsync(string nextLink, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var message = CreateListByVpnGatewayNextPageRequest(nextLink, resourceGroupName, gatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnConnectionsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnConnectionsResult.DeserializeListVpnConnectionsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves all vpn connections for a particular virtual wan vpn gateway. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="gatewayName"/> is null. </exception>
        public Response<ListVpnConnectionsResult> ListByVpnGatewayNextPage(string nextLink, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (gatewayName == null)
            {
                throw new ArgumentNullException(nameof(gatewayName));
            }

            using var message = CreateListByVpnGatewayNextPageRequest(nextLink, resourceGroupName, gatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnConnectionsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnConnectionsResult.DeserializeListVpnConnectionsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
