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

namespace Azure.ResourceManager.AppContainers
{
    internal class SourceControlOperationSource : IOperationSource<SourceControlResource>
    {
        private readonly ArmClient _client;

        internal SourceControlOperationSource(ArmClient client)
        {
            _client = client;
        }

        SourceControlResource IOperationSource<SourceControlResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SourceControlData.DeserializeSourceControlData(document.RootElement);
            return new SourceControlResource(_client, data);
        }

        async ValueTask<SourceControlResource> IOperationSource<SourceControlResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SourceControlData.DeserializeSourceControlData(document.RootElement);
            return new SourceControlResource(_client, data);
        }
    }
}
