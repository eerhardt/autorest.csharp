// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AppConfiguration.Models
{
    internal partial class Error
    {
        internal static Error DeserializeError(JsonElement element)
        {
            Optional<string> type = default;
            Optional<string> title = default;
            Optional<string> name = default;
            Optional<string> detail = default;
            Optional<int> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detail"u8))
                {
                    detail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetInt32();
                    continue;
                }
            }
            return new Error(type.Value, title.Value, name.Value, detail.Value, Optional.ToNullable(status));
        }
    }
}
