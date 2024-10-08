// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Monitor
{
    internal class PipelineGroupOperationSource : IOperationSource<PipelineGroupResource>
    {
        private readonly ArmClient _client;

        internal PipelineGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        PipelineGroupResource IOperationSource<PipelineGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PipelineGroupData.DeserializePipelineGroupData(document.RootElement);
            return new PipelineGroupResource(_client, data);
        }

        async ValueTask<PipelineGroupResource> IOperationSource<PipelineGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PipelineGroupData.DeserializePipelineGroupData(document.RootElement);
            return new PipelineGroupResource(_client, data);
        }
    }
}
