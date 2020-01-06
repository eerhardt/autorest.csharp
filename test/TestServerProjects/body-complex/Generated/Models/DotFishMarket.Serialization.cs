// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models.V20160229
{
    public partial class DotFishMarket : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SampleSalmon != null)
            {
                writer.WritePropertyName("sampleSalmon");
                writer.WriteObjectValue(SampleSalmon);
            }
            if (Salmons != null)
            {
                writer.WritePropertyName("salmons");
                writer.WriteStartArray();
                foreach (var item in Salmons)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SampleFish != null)
            {
                writer.WritePropertyName("sampleFish");
                writer.WriteObjectValue(SampleFish);
            }
            if (Fishes != null)
            {
                writer.WritePropertyName("fishes");
                writer.WriteStartArray();
                foreach (var item in Fishes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static DotFishMarket DeserializeDotFishMarket(JsonElement element)
        {
            DotFishMarket result = new DotFishMarket();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sampleSalmon"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SampleSalmon = DotSalmon.DeserializeDotSalmon(property.Value);
                    continue;
                }
                if (property.NameEquals("salmons"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Salmons = new List<DotSalmon>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Salmons.Add(DotSalmon.DeserializeDotSalmon(item));
                    }
                    continue;
                }
                if (property.NameEquals("sampleFish"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SampleFish = DotFish.DeserializeDotFish(property.Value);
                    continue;
                }
                if (property.NameEquals("fishes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Fishes = new List<DotFish>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Fishes.Add(DotFish.DeserializeDotFish(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}