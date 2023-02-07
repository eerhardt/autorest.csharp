// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace ApiVersionInCadl.Models
{
    public partial class DetectionResult
    {
        internal static DetectionResult DeserializeDetectionResult(JsonElement element)
        {
            string resultId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resultId"u8))
                {
                    resultId = property.Value.GetString();
                    continue;
                }
            }
            return new DetectionResult(resultId);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DetectionResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDetectionResult(document.RootElement);
        }
    }
}
