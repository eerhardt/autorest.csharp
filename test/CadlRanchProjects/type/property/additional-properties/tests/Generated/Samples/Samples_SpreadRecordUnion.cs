// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace _Type.Property.AdditionalProperties.Samples
{
    public partial class Samples_SpreadRecordUnion
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordUnion_GetSpreadRecordUnion_ShortVersion()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response response = client.GetSpreadRecordUnion(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordUnion_GetSpreadRecordUnion_ShortVersion_Async()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response response = await client.GetSpreadRecordUnionAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordUnion_GetSpreadRecordUnion_ShortVersion_Convenience()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response<IReadOnlyDictionary<string, BinaryData>> response = client.GetSpreadRecordUnion();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordUnion_GetSpreadRecordUnion_ShortVersion_Convenience_Async()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response<IReadOnlyDictionary<string, BinaryData>> response = await client.GetSpreadRecordUnionAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordUnion_GetSpreadRecordUnion_AllParameters()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response response = client.GetSpreadRecordUnion(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordUnion_GetSpreadRecordUnion_AllParameters_Async()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response response = await client.GetSpreadRecordUnionAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordUnion_GetSpreadRecordUnion_AllParameters_Convenience()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response<IReadOnlyDictionary<string, BinaryData>> response = client.GetSpreadRecordUnion();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordUnion_GetSpreadRecordUnion_AllParameters_Convenience_Async()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response<IReadOnlyDictionary<string, BinaryData>> response = await client.GetSpreadRecordUnionAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordUnion_Put_ShortVersion()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = "<body>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordUnion_Put_ShortVersion_Async()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = "<body>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordUnion_Put_ShortVersion_Convenience()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response response = client.Put(new Dictionary<string, BinaryData>
            {
                ["key"] = BinaryData.FromObjectAsJson("<body>")
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordUnion_Put_ShortVersion_Convenience_Async()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response response = await client.PutAsync(new Dictionary<string, BinaryData>
            {
                ["key"] = BinaryData.FromObjectAsJson("<body>")
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordUnion_Put_AllParameters()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = "<body>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordUnion_Put_AllParameters_Async()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            using RequestContent content = RequestContent.Create(new
            {
                key = "<body>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SpreadRecordUnion_Put_AllParameters_Convenience()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response response = client.Put(new Dictionary<string, BinaryData>
            {
                ["key"] = BinaryData.FromObjectAsJson("<body>")
            });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SpreadRecordUnion_Put_AllParameters_Convenience_Async()
        {
            SpreadRecordUnion client = new AdditionalPropertiesClient().GetSpreadRecordUnionClient();

            Response response = await client.PutAsync(new Dictionary<string, BinaryData>
            {
                ["key"] = BinaryData.FromObjectAsJson("<body>")
            });
        }
    }
}