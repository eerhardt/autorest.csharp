// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using CollapseRequestCondition_LowLevel;
using NUnit.Framework;

namespace CollapseRequestCondition_LowLevel.Tests
{
    public partial class MatchConditionCollapseClientTests : CollapseRequestCondition_LowLevelTestBase
    {
        public MatchConditionCollapseClientTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task CollapseGetWithHead_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            MatchConditionCollapseClient client = CreateMatchConditionCollapseClient(endpoint, credential);

            Response response = await client.CollapseGetWithHeadAsync();
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task CollapseGetWithHead_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            MatchConditionCollapseClient client = CreateMatchConditionCollapseClient(endpoint, credential);

            Response response = await client.CollapseGetWithHeadAsync(otherHeader: "<otherHeader>", matchConditions: null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task CollapsePut_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            MatchConditionCollapseClient client = CreateMatchConditionCollapseClient(endpoint, credential);

            using RequestContent content = null;
            Response response = await client.CollapsePutAsync(content);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task CollapsePut_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            MatchConditionCollapseClient client = CreateMatchConditionCollapseClient(endpoint, credential);

            using RequestContent content = RequestContent.Create("<body>");
            Response response = await client.CollapsePutAsync(content, matchConditions: null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task CollapseGet_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            MatchConditionCollapseClient client = CreateMatchConditionCollapseClient(endpoint, credential);

            Response response = await client.CollapseGetAsync();
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task CollapseGet_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            MatchConditionCollapseClient client = CreateMatchConditionCollapseClient(endpoint, credential);

            Response response = await client.CollapseGetAsync(matchConditions: null);
        }
    }
}