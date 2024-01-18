// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Properties of subscription permission to create job validation response. </summary>
    public partial class SubscriptionIsAllowedToCreateJobValidationResult : DataBoxValidationInputResult
    {
        /// <summary> Initializes a new instance of <see cref="SubscriptionIsAllowedToCreateJobValidationResult"/>. </summary>
        internal SubscriptionIsAllowedToCreateJobValidationResult()
        {
            ValidationType = DataBoxValidationInputDiscriminator.ValidateSubscriptionIsAllowedToCreateJob;
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionIsAllowedToCreateJobValidationResult"/>. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        /// <param name="status"> Validation status of subscription permission to create job. </param>
        internal SubscriptionIsAllowedToCreateJobValidationResult(DataBoxValidationInputDiscriminator validationType, ResponseError error, DataBoxValidationStatus? status) : base(validationType, error)
        {
            Status = status;
            ValidationType = validationType;
        }

        /// <summary> Validation status of subscription permission to create job. </summary>
        public DataBoxValidationStatus? Status { get; }
    }
}
