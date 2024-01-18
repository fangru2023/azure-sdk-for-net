// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CustomTargetRollingWindowSize. </summary>
    public partial class CustomTargetRollingWindowSize : TargetRollingWindowSize
    {
        /// <summary> Initializes a new instance of <see cref="CustomTargetRollingWindowSize"/>. </summary>
        /// <param name="value"> [Required] TargetRollingWindowSize value. </param>
        public CustomTargetRollingWindowSize(int value)
        {
            Value = value;
            Mode = TargetRollingWindowSizeMode.Custom;
        }

        /// <summary> Initializes a new instance of <see cref="CustomTargetRollingWindowSize"/>. </summary>
        /// <param name="mode"> [Required] TargetRollingWindowSiz detection mode. </param>
        /// <param name="value"> [Required] TargetRollingWindowSize value. </param>
        internal CustomTargetRollingWindowSize(TargetRollingWindowSizeMode mode, int value) : base(mode)
        {
            Value = value;
            Mode = mode;
        }

        /// <summary> [Required] TargetRollingWindowSize value. </summary>
        public int Value { get; set; }
    }
}
