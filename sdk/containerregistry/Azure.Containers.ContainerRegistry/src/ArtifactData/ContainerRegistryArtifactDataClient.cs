﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Containers.ContainerRegistry.ResumableStorage;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    /// <summary>
    /// </summary>
    public class ContainerRegistryArtifactDataClient
    {
        private readonly Uri _endpoint;
        private readonly string _registryName;
        private readonly HttpPipeline _pipeline;
        private readonly HttpPipeline _acrAuthPipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ContainerRegistryRestClient _restClient;
        private readonly AuthenticationRestClient _acrAuthClient;
        private readonly ContainerRegistryBlobRestClient _blobRestClient;

        private readonly string _repositoryName = "";

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRegistryClient"/> for managing container images and artifacts.
        /// </summary>
        /// <param name="endpoint">The URI endpoint of the container registry.  This is likely to be similar
        /// to "https://{registry-name}.azurecr.io".</param>
        /// <param name="credential">The API key credential used to authenticate requests
        /// against the container registry.  </param>
        /// <exception cref="ArgumentNullException"> Thrown when the <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ContainerRegistryArtifactDataClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ContainerRegistryClientOptions())
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContainerRegistryClient for managing container images and artifacts.
        /// </summary>
        /// <param name="endpoint">The URI endpoint of the container registry.  This is likely to be similar
        /// to "https://{registry-name}.azurecr.io".</param>
        /// <param name="credential">The API key credential used to authenticate requests
        /// against the container registry.  </param>
        /// <param name="options">Client configuration options for connecting to Azure Container Registry.</param>
        /// <exception cref="ArgumentNullException"> Thrown when the <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ContainerRegistryArtifactDataClient(Uri endpoint, TokenCredential credential, ContainerRegistryClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(options, nameof(options));

            _endpoint = endpoint;
            _registryName = endpoint.Host.Split('.')[0];
            _clientDiagnostics = new ClientDiagnostics(options);

            _acrAuthPipeline = HttpPipelineBuilder.Build(options);
            _acrAuthClient = new AuthenticationRestClient(_clientDiagnostics, _acrAuthPipeline, endpoint.AbsoluteUri);

            _pipeline = HttpPipelineBuilder.Build(options, new ContainerRegistryChallengeAuthenticationPolicy(credential, options.AuthenticationScope, _acrAuthClient));
            _restClient = new ContainerRegistryRestClient(_clientDiagnostics, _pipeline, _endpoint.AbsoluteUri);
            _blobRestClient = new ContainerRegistryBlobRestClient(_clientDiagnostics, _pipeline, _endpoint.AbsoluteUri);
        }

        /// <summary> Initializes a new instance of RepositoryClient for mocking. </summary>
        protected ContainerRegistryArtifactDataClient()
        {
        }

        #region File Upload/Download

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<UploadManifestResult> UploadManifest(Stream stream, UploadManifestOptions options = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async virtual Task<Response<UploadManifestResult>> UploadManifestAsync(Stream stream, UploadManifestOptions options = default, CancellationToken cancellationToken = default)
        {
            options ??= new UploadManifestOptions();

            string digest = ContentDescriptor.ComputeDigest(stream);
            ResponseWithHeaders<ContainerRegistryCreateManifestHeaders> response = await _restClient.CreateManifestAsync(_repositoryName, digest, stream, cancellationToken).ConfigureAwait(false);

            return Response.FromValue(new UploadManifestResult(), response.GetRawResponse());
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<UploadBlobResult> UploadBlob(Stream stream, UploadBlobOptions options = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<UploadBlobResult>> UploadBlobAsync(Stream stream, UploadBlobOptions options = default, CancellationToken cancellationToken = default)
        {
            options ??= new UploadBlobOptions();

            string digest = ContentDescriptor.ComputeDigest(stream);

            ResponseWithHeaders<ContainerRegistryBlobStartUploadHeaders> startUploadResult =
                await _blobRestClient.StartUploadAsync(_repositoryName, cancellationToken).ConfigureAwait(false);

            ResponseWithHeaders<ContainerRegistryBlobUploadChunkHeaders> uploadChunkResult =
                await _blobRestClient.UploadChunkAsync(startUploadResult.Headers.Location, stream, cancellationToken).ConfigureAwait(false);

            ResponseWithHeaders<ContainerRegistryBlobCompleteUploadHeaders> completeUploadResult =
                await _blobRestClient.CompleteUploadAsync(digest, uploadChunkResult.Headers.Location, null, cancellationToken).ConfigureAwait(false);

            return Response.FromValue(new UploadBlobResult(), completeUploadResult.GetRawResponse());
        }

        /// <summary>
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<DownloadManifestResult> DownloadManifest(string digest, DownloadManifestOptions options = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<DownloadManifestResult>> DownloadManifestAsync(string digest, DownloadManifestOptions options = default, CancellationToken cancellationToken = default)
        {
            options ??= new DownloadManifestOptions();

            // TODO: Options could expose platform: arch/os to select for manifest list

            Response<ArtifactManifestProperties> properties = await _restClient.GetManifestPropertiesAsync(_repositoryName, digest, cancellationToken).ConfigureAwait(false);
            Response<ManifestWrapper> manifestWrapper = await _restClient.GetManifestAsync(_repositoryName, digest, properties.Value.MediaType, cancellationToken).ConfigureAwait(false);

            Stream stream = manifestWrapper.GetRawResponse().ContentStream;
            stream.Position = 0;
            return Response.FromValue(new DownloadManifestResult(stream, GetArtifactFiles(properties.Value.MediaType, manifestWrapper.Value)), manifestWrapper.GetRawResponse());
        }

        private IReadOnlyList<ArtifactBlobProperties> GetArtifactFiles(string mediaType, ManifestWrapper manifest)
        {
            List<ArtifactBlobProperties> artifactFiles = new List<ArtifactBlobProperties>();

            // TODO: Implement for each of the manifest schemas
            // TODO: internal extensible enum for possible media types?
            // DO we always have media type, or will we need to get this from Content-Type header?
            if (mediaType == "application/vnd.docker.distribution.manifest.v2+json")
            {
                // If has config, add config
                if (manifest.Config != null)
                {
                    artifactFiles.Add(new ArtifactBlobProperties(_repositoryName, manifest.Config.Digest, "config.json"));
                }

                // Add layers
                foreach (var layer in manifest.Layers)
                {
                    artifactFiles.Add(new ArtifactBlobProperties(_repositoryName, layer.Digest));
                }
            }

            return artifactFiles;
        }

        /// <summary>
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response<DownloadBlobResult> DownloadBlob(string digest, DownloadBlobOptions options = default, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual async Task<Response<DownloadBlobResult>> DownloadBlobAsync(string digest, DownloadBlobOptions options = default, CancellationToken cancellationToken = default)
        {
            options ??= new DownloadBlobOptions();
            ResponseWithHeaders<Stream, ContainerRegistryBlobGetBlobHeaders> blobResult = await _blobRestClient.GetBlobAsync(_repositoryName, digest, cancellationToken).ConfigureAwait(false);
            return Response.FromValue(new DownloadBlobResult(digest, blobResult.Value), blobResult.GetRawResponse());
        }

        #endregion
    }
}
