// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> The result of the delay operation on this action. </summary>
    public readonly partial struct DevBoxActionDelayStatus : IEquatable<DevBoxActionDelayStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevBoxActionDelayStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevBoxActionDelayStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> The delay operation succeeded. </summary>
        public static DevBoxActionDelayStatus Succeeded { get; } = new DevBoxActionDelayStatus(SucceededValue);
        /// <summary> The delay operation failed. </summary>
        public static DevBoxActionDelayStatus Failed { get; } = new DevBoxActionDelayStatus(FailedValue);
        /// <summary> Determines if two <see cref="DevBoxActionDelayStatus"/> values are the same. </summary>
        public static bool operator ==(DevBoxActionDelayStatus left, DevBoxActionDelayStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevBoxActionDelayStatus"/> values are not the same. </summary>
        public static bool operator !=(DevBoxActionDelayStatus left, DevBoxActionDelayStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DevBoxActionDelayStatus"/>. </summary>
        public static implicit operator DevBoxActionDelayStatus(string value) => new DevBoxActionDelayStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevBoxActionDelayStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevBoxActionDelayStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
