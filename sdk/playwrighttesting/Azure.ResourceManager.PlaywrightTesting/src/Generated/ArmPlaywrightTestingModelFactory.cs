// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PlaywrightTesting;

namespace Azure.ResourceManager.PlaywrightTesting.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPlaywrightTestingModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="PlaywrightTesting.PlaywrightTestingAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="dashboardUri"> The Playwright testing dashboard URI for the account resource. </param>
        /// <param name="regionalAffinity"> This property sets the connection region for Playwright client workers to cloud-hosted browsers. If enabled, workers connect to browsers in the closest Azure region, ensuring lower latency. If disabled, workers connect to browsers in the Azure region in which the workspace was initially created. </param>
        /// <param name="scalableExecution"> When enabled, Playwright client workers can connect to cloud-hosted browsers. This can increase the number of parallel workers for a test run, significantly minimizing test completion durations. </param>
        /// <param name="reporting"> When enabled, this feature allows the workspace to upload and display test results, including artifacts like traces and screenshots, in the Playwright portal. This enables faster and more efficient troubleshooting. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="PlaywrightTesting.PlaywrightTestingAccountData"/> instance for mocking. </returns>
        public static PlaywrightTestingAccountData PlaywrightTestingAccountData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, Uri dashboardUri = null, EnablementStatus? regionalAffinity = null, EnablementStatus? scalableExecution = null, EnablementStatus? reporting = null, PlaywrightTestingProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PlaywrightTestingAccountData(id, name, resourceType, systemData, tags, location, dashboardUri, regionalAffinity, scalableExecution, reporting, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="PlaywrightTesting.PlaywrightTestingQuotaData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="freeTrial"> The free-trial quota. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <returns> A new <see cref="PlaywrightTesting.PlaywrightTestingQuotaData"/> instance for mocking. </returns>
        public static PlaywrightTestingQuotaData PlaywrightTestingQuotaData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, FreeTrialProperties freeTrial = null, PlaywrightTestingProvisioningState? provisioningState = null)
        {
            return new PlaywrightTestingQuotaData(id, name, resourceType, systemData, freeTrial, provisioningState, serializedAdditionalRawData: null);
        }
    }
}
