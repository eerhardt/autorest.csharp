// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using Authentication.Http.Custom;
using NUnit.Framework;

namespace Authentication.Http.Custom.Tests
{
    public partial class CustomClientTests
    {
        [Test]
        public void SmokeTest()
        {
            KeyCredential credential = new KeyCredential(Environment.GetEnvironmentVariable("CustomClient_KEY"));
            CustomClient client = new CustomClient(credential);
            Assert.IsNotNull(client);
        }
    }
}
