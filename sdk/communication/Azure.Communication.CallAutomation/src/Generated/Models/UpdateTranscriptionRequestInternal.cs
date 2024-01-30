// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The UpdateTranscriptionRequest. </summary>
    internal partial class UpdateTranscriptionRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="UpdateTranscriptionRequestInternal"/>. </summary>
        /// <param name="locale"> Defines new locale for transcription. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locale"/> is null. </exception>
        public UpdateTranscriptionRequestInternal(string locale)
        {
            Argument.AssertNotNull(locale, nameof(locale));

            Locale = locale;
        }

        /// <summary> Defines new locale for transcription. </summary>
        public string Locale { get; }
    }
}
