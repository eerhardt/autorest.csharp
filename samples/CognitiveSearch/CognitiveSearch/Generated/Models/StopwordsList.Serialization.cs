// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    internal static class StopwordsListExtensions
    {
        public static string ToSerialString(this StopwordsList value) => value switch
        {
            StopwordsList.Arabic => "arabic",
            StopwordsList.Armenian => "armenian",
            StopwordsList.Basque => "basque",
            StopwordsList.Brazilian => "brazilian",
            StopwordsList.Bulgarian => "bulgarian",
            StopwordsList.Catalan => "catalan",
            StopwordsList.Czech => "czech",
            StopwordsList.Danish => "danish",
            StopwordsList.Dutch => "dutch",
            StopwordsList.English => "english",
            StopwordsList.Finnish => "finnish",
            StopwordsList.French => "french",
            StopwordsList.Galician => "galician",
            StopwordsList.German => "german",
            StopwordsList.Greek => "greek",
            StopwordsList.Hindi => "hindi",
            StopwordsList.Hungarian => "hungarian",
            StopwordsList.Indonesian => "indonesian",
            StopwordsList.Irish => "irish",
            StopwordsList.Italian => "italian",
            StopwordsList.Latvian => "latvian",
            StopwordsList.Norwegian => "norwegian",
            StopwordsList.Persian => "persian",
            StopwordsList.Portuguese => "portuguese",
            StopwordsList.Romanian => "romanian",
            StopwordsList.Russian => "russian",
            StopwordsList.Sorani => "sorani",
            StopwordsList.Spanish => "spanish",
            StopwordsList.Swedish => "swedish",
            StopwordsList.Thai => "thai",
            StopwordsList.Turkish => "turkish",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StopwordsList value.")
        };

        public static StopwordsList ToStopwordsList(this string value) => value switch
        {
            "arabic" => StopwordsList.Arabic,
            "armenian" => StopwordsList.Armenian,
            "basque" => StopwordsList.Basque,
            "brazilian" => StopwordsList.Brazilian,
            "bulgarian" => StopwordsList.Bulgarian,
            "catalan" => StopwordsList.Catalan,
            "czech" => StopwordsList.Czech,
            "danish" => StopwordsList.Danish,
            "dutch" => StopwordsList.Dutch,
            "english" => StopwordsList.English,
            "finnish" => StopwordsList.Finnish,
            "french" => StopwordsList.French,
            "galician" => StopwordsList.Galician,
            "german" => StopwordsList.German,
            "greek" => StopwordsList.Greek,
            "hindi" => StopwordsList.Hindi,
            "hungarian" => StopwordsList.Hungarian,
            "indonesian" => StopwordsList.Indonesian,
            "irish" => StopwordsList.Irish,
            "italian" => StopwordsList.Italian,
            "latvian" => StopwordsList.Latvian,
            "norwegian" => StopwordsList.Norwegian,
            "persian" => StopwordsList.Persian,
            "portuguese" => StopwordsList.Portuguese,
            "romanian" => StopwordsList.Romanian,
            "russian" => StopwordsList.Russian,
            "sorani" => StopwordsList.Sorani,
            "spanish" => StopwordsList.Spanish,
            "swedish" => StopwordsList.Swedish,
            "thai" => StopwordsList.Thai,
            "turkish" => StopwordsList.Turkish,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StopwordsList value.")
        };
    }
}