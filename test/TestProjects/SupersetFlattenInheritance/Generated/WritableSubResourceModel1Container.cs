// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing collection of WritableSubResourceModel1 and their operations over a ResourceGroup. </summary>
    public partial class WritableSubResourceModel1Container : ResourceContainerBase<ResourceGroupResourceIdentifier, WritableSubResourceModel1, WritableSubResourceModel1Data>
    {
        /// <summary> Initializes a new instance of the <see cref="WritableSubResourceModel1Container"/> class for mocking. </summary>
        protected WritableSubResourceModel1Container()
        {
        }

        /// <summary> Initializes a new instance of WritableSubResourceModel1Container class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WritableSubResourceModel1Container(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private WritableSubResourceModel1SRestOperations _restClient => new WritableSubResourceModel1SRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a WritableSubResourceModel1. Please note some properties can be set only during creation. </summary>
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel1 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<WritableSubResourceModel1> CreateOrUpdate(string writableSubResourceModel1SName, WritableSubResourceModel1Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel1Container.CreateOrUpdate");
            scope.Start();
            try
            {
                if (writableSubResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(writableSubResourceModel1SName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a WritableSubResourceModel1. Please note some properties can be set only during creation. </summary>
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel1 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<WritableSubResourceModel1>> CreateOrUpdateAsync(string writableSubResourceModel1SName, WritableSubResourceModel1Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel1Container.CreateOrUpdate");
            scope.Start();
            try
            {
                if (writableSubResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(writableSubResourceModel1SName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a WritableSubResourceModel1. Please note some properties can be set only during creation. </summary>
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel1 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public WritableSubResourceModel1SPutOperation StartCreateOrUpdate(string writableSubResourceModel1SName, WritableSubResourceModel1Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel1Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (writableSubResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(Id.ResourceGroupName, writableSubResourceModel1SName, parameters, cancellationToken: cancellationToken);
                return new WritableSubResourceModel1SPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a WritableSubResourceModel1. Please note some properties can be set only during creation. </summary>
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel1 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<WritableSubResourceModel1SPutOperation> StartCreateOrUpdateAsync(string writableSubResourceModel1SName, WritableSubResourceModel1Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel1Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (writableSubResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(Id.ResourceGroupName, writableSubResourceModel1SName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new WritableSubResourceModel1SPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public override Response<WritableSubResourceModel1> Get(string writableSubResourceModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel1Container.Get");
            scope.Start();
            try
            {
                if (writableSubResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, writableSubResourceModel1SName, cancellationToken: cancellationToken);
                return Response.FromValue(new WritableSubResourceModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async override Task<Response<WritableSubResourceModel1>> GetAsync(string writableSubResourceModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel1Container.Get");
            scope.Start();
            try
            {
                if (writableSubResourceModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, writableSubResourceModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new WritableSubResourceModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of WritableSubResourceModel1 for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel1Container.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WritableSubResourceModel1Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of WritableSubResourceModel1 for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("WritableSubResourceModel1Container.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(WritableSubResourceModel1Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, WritableSubResourceModel1, WritableSubResourceModel1Data> Construct() { }
    }
}