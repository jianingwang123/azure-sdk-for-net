// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ManagedInstanceLongTermRetentionPolicyName. </summary>
    public readonly partial struct ManagedInstanceLongTermRetentionPolicyName : IEquatable<ManagedInstanceLongTermRetentionPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceLongTermRetentionPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedInstanceLongTermRetentionPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static ManagedInstanceLongTermRetentionPolicyName Default { get; } = new ManagedInstanceLongTermRetentionPolicyName(DefaultValue);
        /// <summary> Determines if two <see cref="ManagedInstanceLongTermRetentionPolicyName"/> values are the same. </summary>
        public static bool operator ==(ManagedInstanceLongTermRetentionPolicyName left, ManagedInstanceLongTermRetentionPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedInstanceLongTermRetentionPolicyName"/> values are not the same. </summary>
        public static bool operator !=(ManagedInstanceLongTermRetentionPolicyName left, ManagedInstanceLongTermRetentionPolicyName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedInstanceLongTermRetentionPolicyName"/>. </summary>
        public static implicit operator ManagedInstanceLongTermRetentionPolicyName(string value) => new ManagedInstanceLongTermRetentionPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedInstanceLongTermRetentionPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedInstanceLongTermRetentionPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
