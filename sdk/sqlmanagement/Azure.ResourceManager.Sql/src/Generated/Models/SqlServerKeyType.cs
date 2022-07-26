// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The encryption protector type like &apos;ServiceManaged&apos;, &apos;AzureKeyVault&apos;. </summary>
    public readonly partial struct SqlServerKeyType : IEquatable<SqlServerKeyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlServerKeyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlServerKeyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceManagedValue = "ServiceManaged";
        private const string AzureKeyVaultValue = "AzureKeyVault";

        /// <summary> ServiceManaged. </summary>
        public static SqlServerKeyType ServiceManaged { get; } = new SqlServerKeyType(ServiceManagedValue);
        /// <summary> AzureKeyVault. </summary>
        public static SqlServerKeyType AzureKeyVault { get; } = new SqlServerKeyType(AzureKeyVaultValue);
        /// <summary> Determines if two <see cref="SqlServerKeyType"/> values are the same. </summary>
        public static bool operator ==(SqlServerKeyType left, SqlServerKeyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlServerKeyType"/> values are not the same. </summary>
        public static bool operator !=(SqlServerKeyType left, SqlServerKeyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlServerKeyType"/>. </summary>
        public static implicit operator SqlServerKeyType(string value) => new SqlServerKeyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlServerKeyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlServerKeyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
