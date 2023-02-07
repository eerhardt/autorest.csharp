// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace SupersetInheritance.Models
{
    public partial class SupersetModel2 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ID))
            {
                writer.WritePropertyName("iD"u8);
                writer.WriteStringValue(ID);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(SupersetModel2Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(SupersetModel2Type);
            }
            if (Optional.IsDefined(New))
            {
                writer.WritePropertyName("new"u8);
                writer.WriteStringValue(New);
            }
            writer.WriteEndObject();
        }

        internal static SupersetModel2 DeserializeSupersetModel2(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> @new = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("iD"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("new"u8))
                {
                    @new = property.Value.GetString();
                    continue;
                }
            }
            return new SupersetModel2(id.Value, name.Value, type.Value, @new.Value);
        }
    }
}
