// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtRenameRules;

namespace MgmtRenameRules.Models
{
    internal partial class VirtualMachineListResult
    {
        internal static VirtualMachineListResult DeserializeVirtualMachineListResult(JsonElement element)
        {
            IReadOnlyList<VirtualMachineData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<VirtualMachineData> array = new List<VirtualMachineData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineData.DeserializeVirtualMachineData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineListResult(value, nextLink.Value);
        }
    }
}
