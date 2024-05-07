// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Models
{
    internal static partial class CreateTranslationRequestResponseFormatExtensions
    {
        public static string ToSerialString(this CreateTranslationRequestResponseFormat value) => value switch
        {
            CreateTranslationRequestResponseFormat.Json => "json",
            CreateTranslationRequestResponseFormat.Text => "text",
            CreateTranslationRequestResponseFormat.Srt => "srt",
            CreateTranslationRequestResponseFormat.VerboseJson => "verbose_json",
            CreateTranslationRequestResponseFormat.Vtt => "vtt",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CreateTranslationRequestResponseFormat value.")
        };

        public static CreateTranslationRequestResponseFormat ToCreateTranslationRequestResponseFormat(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "json")) return CreateTranslationRequestResponseFormat.Json;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "text")) return CreateTranslationRequestResponseFormat.Text;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "srt")) return CreateTranslationRequestResponseFormat.Srt;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "verbose_json")) return CreateTranslationRequestResponseFormat.VerboseJson;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "vtt")) return CreateTranslationRequestResponseFormat.Vtt;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CreateTranslationRequestResponseFormat value.");
        }
    }
}
