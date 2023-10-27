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
using _Azure.Lro.RpcLegacy;
using _Azure.Lro.RpcLegacy.Models;

namespace _Azure.Lro.RpcLegacy.Samples
{
    public partial class Samples_LegacyClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateJob_ShortVersion()
        {
            LegacyClient client = new LegacyClient();

            using RequestContent content = RequestContent.Create(new
            {
                comment = "<comment>",
            });
            Operation<BinaryData> operation = client.CreateJob(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("comment").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateJob_ShortVersion_Async()
        {
            LegacyClient client = new LegacyClient();

            using RequestContent content = RequestContent.Create(new
            {
                comment = "<comment>",
            });
            Operation<BinaryData> operation = await client.CreateJobAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("comment").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateJob_ShortVersion_Convenience()
        {
            LegacyClient client = new LegacyClient();

            JobData jobData = new JobData("<comment>");
            Operation<JobResult> operation = client.CreateJob(WaitUntil.Completed, jobData);
            JobResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateJob_ShortVersion_Convenience_Async()
        {
            LegacyClient client = new LegacyClient();

            JobData jobData = new JobData("<comment>");
            Operation<JobResult> operation = await client.CreateJobAsync(WaitUntil.Completed, jobData);
            JobResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateJob_AllParameters()
        {
            LegacyClient client = new LegacyClient();

            using RequestContent content = RequestContent.Create(new
            {
                comment = "<comment>",
            });
            Operation<BinaryData> operation = client.CreateJob(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("comment").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("error").GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateJob_AllParameters_Async()
        {
            LegacyClient client = new LegacyClient();

            using RequestContent content = RequestContent.Create(new
            {
                comment = "<comment>",
            });
            Operation<BinaryData> operation = await client.CreateJobAsync(WaitUntil.Completed, content);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("comment").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("error").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("error").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("error").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors")[0].GetProperty("error").GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("results")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateJob_AllParameters_Convenience()
        {
            LegacyClient client = new LegacyClient();

            JobData jobData = new JobData("<comment>");
            Operation<JobResult> operation = client.CreateJob(WaitUntil.Completed, jobData);
            JobResult responseData = operation.Value;
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateJob_AllParameters_Convenience_Async()
        {
            LegacyClient client = new LegacyClient();

            JobData jobData = new JobData("<comment>");
            Operation<JobResult> operation = await client.CreateJobAsync(WaitUntil.Completed, jobData);
            JobResult responseData = operation.Value;
        }
    }
}