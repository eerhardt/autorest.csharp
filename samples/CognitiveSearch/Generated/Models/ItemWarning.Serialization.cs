// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ItemWarning
    {
        internal static ItemWarning DeserializeItemWarning(JsonElement element)
        {
            Optional<string> key = default;
            string message = default;
            Optional<string> name = default;
            Optional<string> details = default;
            Optional<string> documentationLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    details = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentationLink"))
                {
                    documentationLink = property.Value.GetString();
                    continue;
                }
            }
            return new ItemWarning(key.Value, message, name.Value, details.Value, documentationLink.Value);
        }
    }
}