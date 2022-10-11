// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Models.Property.Types
{
    public partial class BooleanProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("property");
            writer.WriteBooleanValue(Property);
            writer.WriteEndObject();
        }

        internal static BooleanProperty DeserializeBooleanProperty(JsonElement element)
        {
            bool property = default;
            foreach (var property0 in element.EnumerateObject())
            {
                if (property0.NameEquals("property"))
                {
                    property = property0.Value.GetBoolean();
                    continue;
                }
            }
            return new BooleanProperty(property);
        }

        internal RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal static BooleanProperty FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBooleanProperty(document.RootElement);
        }
    }
}