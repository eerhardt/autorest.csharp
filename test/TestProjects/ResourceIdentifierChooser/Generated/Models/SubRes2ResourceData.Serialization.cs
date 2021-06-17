// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    public partial class SubRes2ResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(New))
            {
                writer.WritePropertyName("new");
                writer.WriteStringValue(New);
            }
            writer.WriteEndObject();
        }

        internal static SubRes2ResourceData DeserializeSubRes2ResourceData(JsonElement element)
        {
            Optional<string> @new = default;
            TenantResourceIdentifier id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("new"))
                {
                    @new = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new SubRes2ResourceData(id, @new.Value);
        }
    }
}