// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupJobExtendedInfo
    {
        internal static BackupJobExtendedInfo DeserializeBackupJobExtendedInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, string>> additionalDetails = default;
            Optional<string> backupInstanceState = default;
            Optional<double> dataTransferredInBytes = default;
            Optional<string> recoveryDestination = default;
            Optional<RestoreJobRecoveryPointDetails> sourceRecoverPoint = default;
            Optional<IReadOnlyList<BackupJobSubTask>> subTasks = default;
            Optional<RestoreJobRecoveryPointDetails> targetRecoverPoint = default;
            Optional<IReadOnlyList<UserFacingWarningDetail>> warningDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalDetails = dictionary;
                    continue;
                }
                if (property.NameEquals("backupInstanceState"u8))
                {
                    backupInstanceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataTransferredInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataTransferredInBytes = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("recoveryDestination"u8))
                {
                    recoveryDestination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRecoverPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRecoverPoint = RestoreJobRecoveryPointDetails.DeserializeRestoreJobRecoveryPointDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("subTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupJobSubTask> array = new List<BackupJobSubTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupJobSubTask.DeserializeBackupJobSubTask(item));
                    }
                    subTasks = array;
                    continue;
                }
                if (property.NameEquals("targetRecoverPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetRecoverPoint = RestoreJobRecoveryPointDetails.DeserializeRestoreJobRecoveryPointDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("warningDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserFacingWarningDetail> array = new List<UserFacingWarningDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserFacingWarningDetail.DeserializeUserFacingWarningDetail(item));
                    }
                    warningDetails = array;
                    continue;
                }
            }
            return new BackupJobExtendedInfo(Optional.ToDictionary(additionalDetails), backupInstanceState.Value, Optional.ToNullable(dataTransferredInBytes), recoveryDestination.Value, sourceRecoverPoint.Value, Optional.ToList(subTasks), targetRecoverPoint.Value, Optional.ToList(warningDetails));
        }
    }
}
