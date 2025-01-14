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

namespace Azure.ResourceManager.ElasticSan
{
    internal class ElasticSanVolumeGroupOperationSource : IOperationSource<ElasticSanVolumeGroupResource>
    {
        private readonly ArmClient _client;

        internal ElasticSanVolumeGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        ElasticSanVolumeGroupResource IOperationSource<ElasticSanVolumeGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ElasticSanVolumeGroupData.DeserializeElasticSanVolumeGroupData(document.RootElement);
            return new ElasticSanVolumeGroupResource(_client, data);
        }

        async ValueTask<ElasticSanVolumeGroupResource> IOperationSource<ElasticSanVolumeGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ElasticSanVolumeGroupData.DeserializeElasticSanVolumeGroupData(document.RootElement);
            return new ElasticSanVolumeGroupResource(_client, data);
        }
    }
}
