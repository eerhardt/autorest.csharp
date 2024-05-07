// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Models
{
    internal static partial class FineTuneStatusExtensions
    {
        public static string ToSerialString(this FineTuneStatus value) => value switch
        {
            FineTuneStatus.Created => "created",
            FineTuneStatus.Running => "running",
            FineTuneStatus.Succeeded => "succeeded",
            FineTuneStatus.Failed => "failed",
            FineTuneStatus.Cancelled => "cancelled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FineTuneStatus value.")
        };

        public static FineTuneStatus ToFineTuneStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "created")) return FineTuneStatus.Created;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "running")) return FineTuneStatus.Running;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "succeeded")) return FineTuneStatus.Succeeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "failed")) return FineTuneStatus.Failed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "cancelled")) return FineTuneStatus.Cancelled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FineTuneStatus value.");
        }
    }
}
