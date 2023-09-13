// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace ConfidentLevelsInTsp.Models
{
    internal partial class PollutedDog : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("woof"u8);
            writer.WriteStringValue(Woof);
            writer.WritePropertyName("color"u8);
            writer.WriteObjectValue(Color);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static PollutedDog DeserializePollutedDog(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string woof = default;
            object color = default;
            string kind = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("woof"u8))
                {
                    woof = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("color"u8))
                {
                    color = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PollutedDog(kind, name, woof, color);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new PollutedDog FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePollutedDog(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}