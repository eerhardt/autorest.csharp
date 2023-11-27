// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Union;
using _Type.Union.Models;

namespace _Type.Union.Samples
{
    public partial class Samples_MixedLiterals
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMixedLiteral_ShortVersion()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response response = client.GetMixedLiteral(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").GetProperty("stringLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("intLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("floatLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("booleanLiteral").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMixedLiteral_ShortVersion_Async()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response response = await client.GetMixedLiteralAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").GetProperty("stringLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("intLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("floatLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("booleanLiteral").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMixedLiteral_ShortVersion_Convenience()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response<object> response = client.GetMixedLiteral();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMixedLiteral_ShortVersion_Convenience_Async()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response<object> response = await client.GetMixedLiteralAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMixedLiteral_AllParameters()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response response = client.GetMixedLiteral(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").GetProperty("stringLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("intLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("floatLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("booleanLiteral").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMixedLiteral_AllParameters_Async()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response response = await client.GetMixedLiteralAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("prop").GetProperty("stringLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("intLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("floatLiteral").ToString());
            Console.WriteLine(result.GetProperty("prop").GetProperty("booleanLiteral").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMixedLiteral_AllParameters_Convenience()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response<object> response = client.GetMixedLiteral();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMixedLiteral_AllParameters_Convenience_Async()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response<object> response = await client.GetMixedLiteralAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Send_ShortVersion()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                prop = "a",
            });
            Response response = client.Send(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Send_ShortVersion_Async()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                prop = "a",
            });
            Response response = await client.SendAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Send_ShortVersion_Convenience()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response response = client.Send(SendRequestProp.A);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Send_ShortVersion_Convenience_Async()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response response = await client.SendAsync(SendRequestProp.A);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Send_AllParameters()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                prop = "a",
            });
            Response response = client.Send(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Send_AllParameters_Async()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new
            {
                prop = "a",
            });
            Response response = await client.SendAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Send_AllParameters_Convenience()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response response = client.Send(SendRequestProp.A);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Send_AllParameters_Convenience_Async()
        {
            MixedLiterals client = new UnionClient().GetMixedLiteralsClient(apiVersion: "1.0.0");

            Response response = await client.SendAsync(SendRequestProp.A);
        }
    }
}