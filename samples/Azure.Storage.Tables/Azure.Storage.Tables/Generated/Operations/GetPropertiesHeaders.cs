// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Storage.Tables
{
    internal class GetPropertiesHeaders
    {
        private readonly Azure.Response _response;
        public GetPropertiesHeaders(Azure.Response response)
        {
            _response = response;
        }
        public string XMsClientRequestId => _response.Headers.TryGetValue("x-ms-client-request-id", out string value) ? value : null;
        public string XMsRequestId => _response.Headers.TryGetValue("x-ms-request-id", out string value) ? value : null;
        public string XMsVersion => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
    }
}
