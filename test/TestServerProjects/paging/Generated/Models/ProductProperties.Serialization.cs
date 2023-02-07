// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace paging.Models
{
    public partial class ProductProperties
    {
        internal static ProductProperties DeserializeProductProperties(JsonElement element)
        {
            Optional<int> id = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new ProductProperties(Optional.ToNullable(id), name.Value);
        }
    }
}
