// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Paged instance of ClassificationPolicy. </summary>
    public partial class ClassificationPolicyItem
    {
        /// <summary> Initializes a new instance of ClassificationPolicyItem. </summary>
        /// <param name="classificationPolicy"> A container for the rules that govern how jobs are classified. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classificationPolicy"/> or <paramref name="etag"/> is null. </exception>
        internal ClassificationPolicyItem(ClassificationPolicy classificationPolicy, string etag)
        {
            Argument.AssertNotNull(classificationPolicy, nameof(classificationPolicy));
            Argument.AssertNotNull(etag, nameof(etag));

            ClassificationPolicy = classificationPolicy;
            _etag = etag;
        }

        /// <summary> A container for the rules that govern how jobs are classified. </summary>
        public ClassificationPolicy ClassificationPolicy { get; }
    }
}
