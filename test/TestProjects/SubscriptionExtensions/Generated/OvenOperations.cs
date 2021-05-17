// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Core;

namespace SubscriptionExtensions
{
    /// <summary> A class representing the operations that can be performed over a specific Oven. </summary>
    public partial class OvenOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, Oven>
    {
        /// <summary> Initializes a new instance of the <see cref="OvenOperations"/> class for mocking. </summary>
        protected OvenOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OvenOperations"/> class. </summary>
        /// <param name="genericOperations"> An instance of <see cref="GenericResourceOperations"/> that has an id for a Oven. </param>
        internal OvenOperations(GenericResourceOperations genericOperations) : base(genericOperations, genericOperations.Id)
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OvenOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected OvenOperations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
        }

        public static readonly ResourceType ResourceType = "Microsoft.Compute/virtualMachines";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public override Response<Oven> Get(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override Task<Response<Oven>> GetAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of location that may take multiple service requests to iterate over. </returns>
        /// <exception cref="InvalidOperationException"> The default subscription id is null. </exception>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken);
        }
    }
}