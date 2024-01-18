// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> A span object that represents a detected object and its bounding box information. </summary>
    public partial class AzureGroundingEnhancementLineSpan
    {
        /// <summary> Initializes a new instance of <see cref="AzureGroundingEnhancementLineSpan"/>. </summary>
        /// <param name="text"> The text content of the span that represents the detected object. </param>
        /// <param name="offset">
        /// The character offset within the text where the span begins. This offset is defined as the position of the first
        /// character of the span, counting from the start of the text as Unicode codepoints.
        /// </param>
        /// <param name="length"> The length of the span in characters, measured in Unicode codepoints. </param>
        /// <param name="polygon"> An array of objects representing points in the polygon that encloses the detected object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="polygon"/> is null. </exception>
        internal AzureGroundingEnhancementLineSpan(string text, int offset, int length, IEnumerable<AzureGroundingEnhancementCoordinatePoint> polygon)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(polygon, nameof(polygon));

            Text = text;
            Offset = offset;
            Length = length;
            Polygon = polygon.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AzureGroundingEnhancementLineSpan"/>. </summary>
        /// <param name="text"> The text content of the span that represents the detected object. </param>
        /// <param name="offset">
        /// The character offset within the text where the span begins. This offset is defined as the position of the first
        /// character of the span, counting from the start of the text as Unicode codepoints.
        /// </param>
        /// <param name="length"> The length of the span in characters, measured in Unicode codepoints. </param>
        /// <param name="polygon"> An array of objects representing points in the polygon that encloses the detected object. </param>
        internal AzureGroundingEnhancementLineSpan(string text, int offset, int length, IReadOnlyList<AzureGroundingEnhancementCoordinatePoint> polygon)
        {
            Text = text;
            Offset = offset;
            Length = length;
            Polygon = polygon;
        }

        /// <summary> The text content of the span that represents the detected object. </summary>
        public string Text { get; }
        /// <summary>
        /// The character offset within the text where the span begins. This offset is defined as the position of the first
        /// character of the span, counting from the start of the text as Unicode codepoints.
        /// </summary>
        public int Offset { get; }
        /// <summary> The length of the span in characters, measured in Unicode codepoints. </summary>
        public int Length { get; }
        /// <summary> An array of objects representing points in the polygon that encloses the detected object. </summary>
        public IReadOnlyList<AzureGroundingEnhancementCoordinatePoint> Polygon { get; }
    }
}
