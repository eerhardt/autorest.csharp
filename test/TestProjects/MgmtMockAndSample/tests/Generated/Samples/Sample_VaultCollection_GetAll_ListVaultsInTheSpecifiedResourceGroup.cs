// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtMockAndSample
{
    public partial class Sample_VaultCollection_GetAll_ListVaultsInTheSpecifiedResourceGroup
    {
        // List vaults in the specified resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "Vaults_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sample-group";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VaultResource
            MgmtMockAndSample.VaultCollection collection = resourceGroupResource.GetVaults();

            // invoke the operation and iterate over the result
            int? top = 1;
            await foreach (MgmtMockAndSample.VaultResource item in collection.GetAllAsync(top: top))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MgmtMockAndSample.VaultData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}