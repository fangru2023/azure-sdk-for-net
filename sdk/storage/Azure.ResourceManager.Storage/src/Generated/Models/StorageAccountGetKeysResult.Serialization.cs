// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountGetKeysResult
    {
        internal static StorageAccountGetKeysResult DeserializeStorageAccountGetKeysResult(JsonElement element)
        {
            Optional<IReadOnlyList<StorageAccountKey>> keys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StorageAccountKey> array = new List<StorageAccountKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageAccountKey.DeserializeStorageAccountKey(item));
                    }
                    keys = array;
                    continue;
                }
            }
            return new StorageAccountGetKeysResult(Optional.ToList(keys));
        }
    }
}
