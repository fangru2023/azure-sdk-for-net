// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The roll up count summary of savings plans in each state. </summary>
    internal partial class SavingsPlanSummaryCount
    {
        /// <summary> Initializes a new instance of <see cref="SavingsPlanSummaryCount"/>. </summary>
        internal SavingsPlanSummaryCount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SavingsPlanSummaryCount"/>. </summary>
        /// <param name="succeededCount"> The number of savings plans in Succeeded state. </param>
        /// <param name="failedCount"> The number of savings plans in Failed state. </param>
        /// <param name="expiringCount"> The number of savings plans in Expiring state. </param>
        /// <param name="expiredCount"> The number of savings plans in Expired state. </param>
        /// <param name="pendingCount"> The number of savings plans in Pending state. </param>
        /// <param name="cancelledCount"> The number of savings plans in Cancelled state. </param>
        /// <param name="processingCount"> The number of savings plans in Processing state. </param>
        /// <param name="noBenefitCount"> The number of savings plans in No Benefit state. </param>
        /// <param name="warningCount"> The number of savings plans in Warning state. </param>
        internal SavingsPlanSummaryCount(float? succeededCount, float? failedCount, float? expiringCount, float? expiredCount, float? pendingCount, float? cancelledCount, float? processingCount, float? noBenefitCount, float? warningCount)
        {
            SucceededCount = succeededCount;
            FailedCount = failedCount;
            ExpiringCount = expiringCount;
            ExpiredCount = expiredCount;
            PendingCount = pendingCount;
            CancelledCount = cancelledCount;
            ProcessingCount = processingCount;
            NoBenefitCount = noBenefitCount;
            WarningCount = warningCount;
        }

        /// <summary> The number of savings plans in Succeeded state. </summary>
        public float? SucceededCount { get; }
        /// <summary> The number of savings plans in Failed state. </summary>
        public float? FailedCount { get; }
        /// <summary> The number of savings plans in Expiring state. </summary>
        public float? ExpiringCount { get; }
        /// <summary> The number of savings plans in Expired state. </summary>
        public float? ExpiredCount { get; }
        /// <summary> The number of savings plans in Pending state. </summary>
        public float? PendingCount { get; }
        /// <summary> The number of savings plans in Cancelled state. </summary>
        public float? CancelledCount { get; }
        /// <summary> The number of savings plans in Processing state. </summary>
        public float? ProcessingCount { get; }
        /// <summary> The number of savings plans in No Benefit state. </summary>
        public float? NoBenefitCount { get; }
        /// <summary> The number of savings plans in Warning state. </summary>
        public float? WarningCount { get; }
    }
}
