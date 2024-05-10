// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using NoDocsTypeSpec.Models;

namespace NoDocsTypeSpec
{
    // Data plane generated sub-client.
    public partial class Entity
    {
        private const string AuthorizationHeader = "x-ms-api-key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://api.example.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        internal ClientDiagnostics ClientDiagnostics { get; }

        public virtual HttpPipeline Pipeline => _pipeline;

        protected Entity()
        {
        }

        internal Entity(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential keyCredential, TokenCredential tokenCredential, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
        }

        public virtual async Task<Response<Thing>> DoSomethingAsync(string p2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(p2, nameof(p2));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await DoSomethingAsync(p2, context).ConfigureAwait(false);
            return Response.FromValue(Thing.FromResponse(response), response);
        }

        public virtual Response<Thing> DoSomething(string p2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(p2, nameof(p2));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = DoSomething(p2, context);
            return Response.FromValue(Thing.FromResponse(response), response);
        }

        public virtual async Task<Response> DoSomethingAsync(string p2, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(p2, nameof(p2));

            using var scope = ClientDiagnostics.CreateScope("Entity.DoSomething");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDoSomethingRequest(p2, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        public virtual Response DoSomething(string p2, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(p2, nameof(p2));

            using var scope = ClientDiagnostics.CreateScope("Entity.DoSomething");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDoSomethingRequest(p2, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateDoSomethingRequest(string p2, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/entity/doSomething/", false);
            uri.AppendPath(p2, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}