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

namespace CadlFirstTest
{
    /// <summary> The Demo service client. </summary>
    public partial class DemoClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of DemoClient for mocking. </summary>
        protected DemoClient()
        {
        }

        /// <summary> Initializes a new instance of DemoClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="apiVersion"> The String to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public DemoClient(Uri endpoint, string apiVersion) : this(endpoint, apiVersion, new DemoHelloworldClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DemoClient. </summary>
        /// <param name="endpoint"> The Uri to use. </param>
        /// <param name="apiVersion"> The String to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public DemoClient(Uri endpoint, string apiVersion, DemoHelloworldClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));
            options ??= new DemoHelloworldClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Thing>> SayHiValueAsync(CancellationToken cancellationToken = default)
        {
            using var scope = ClientDiagnostics.CreateScope("DemoClient.SayHiValue");
            scope.Start();
            try
            {
                RequestContext context = FromCancellationToken(cancellationToken);
                Response response = await SayHiAsync(context).ConfigureAwait(false);
                return Response.FromValue(Thing.FromResponse(response), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Thing> SayHiValue(CancellationToken cancellationToken = default)
        {
            using var scope = ClientDiagnostics.CreateScope("DemoClient.SayHiValue");
            scope.Start();
            try
            {
                RequestContext context = FromCancellationToken(cancellationToken);
                Response response = SayHi(context);
                return Response.FromValue(Thing.FromResponse(response), response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call SayHiAsync and parse the result.
        /// <code><![CDATA[
        /// var endpoint = new Uri("<https://my-service.azure.com>");
        /// var client = new DemoClient(endpoint, "<apiVersion>");
        /// 
        /// Response response = await client.SayHiAsync();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual async Task<Response> SayHiAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("DemoClient.SayHi");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSayHiRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call SayHi and parse the result.
        /// <code><![CDATA[
        /// var endpoint = new Uri("<https://my-service.azure.com>");
        /// var client = new DemoClient(endpoint, "<apiVersion>");
        /// 
        /// Response response = client.SayHi();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.GetProperty("name").ToString());
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for the response payload.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Thing</c>:
        /// <code>{
        ///   name: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Response SayHi(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("DemoClient.SayHi");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSayHiRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateSayHiRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            message.BufferResponse = false;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/partOfUri", false);
            uri.AppendPath("/hello", false);
            uri.AppendQuery("apiVersion", _apiVersion, true);
            request.Uri = uri;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (cancellationToken == CancellationToken.None)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}