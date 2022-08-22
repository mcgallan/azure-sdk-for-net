// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StorageSync
{
    internal class ServerEndpointOperationSource : IOperationSource<ServerEndpointResource>
    {
        private readonly ArmClient _client;

        internal ServerEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServerEndpointResource IOperationSource<ServerEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerEndpointData.DeserializeServerEndpointData(document.RootElement);
            return new ServerEndpointResource(_client, data);
        }

        async ValueTask<ServerEndpointResource> IOperationSource<ServerEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerEndpointData.DeserializeServerEndpointData(document.RootElement);
            return new ServerEndpointResource(_client, data);
        }
    }
}
