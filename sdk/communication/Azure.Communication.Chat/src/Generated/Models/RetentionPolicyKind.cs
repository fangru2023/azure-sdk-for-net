// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Chat
{
    /// <summary> Retention Policy Type. </summary>
    public readonly partial struct RetentionPolicyKind : IEquatable<RetentionPolicyKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RetentionPolicyKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RetentionPolicyKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadCreationDateValue = "threadCreationDate";

        /// <summary> Thread retention policy based on thread creation date. </summary>
        public static RetentionPolicyKind ThreadCreationDate { get; } = new RetentionPolicyKind(ThreadCreationDateValue);
        /// <summary> Determines if two <see cref="RetentionPolicyKind"/> values are the same. </summary>
        public static bool operator ==(RetentionPolicyKind left, RetentionPolicyKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RetentionPolicyKind"/> values are not the same. </summary>
        public static bool operator !=(RetentionPolicyKind left, RetentionPolicyKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RetentionPolicyKind"/>. </summary>
        public static implicit operator RetentionPolicyKind(string value) => new RetentionPolicyKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RetentionPolicyKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RetentionPolicyKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
