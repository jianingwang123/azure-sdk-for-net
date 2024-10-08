// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The type of token. </summary>
    public readonly partial struct ContentKeyPolicyRestrictionTokenType : IEquatable<ContentKeyPolicyRestrictionTokenType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyRestrictionTokenType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentKeyPolicyRestrictionTokenType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string SwtValue = "Swt";
        private const string JwtValue = "Jwt";

        /// <summary> Represents a ContentKeyPolicyRestrictionTokenType that is unavailable in current API version. </summary>
        public static ContentKeyPolicyRestrictionTokenType Unknown { get; } = new ContentKeyPolicyRestrictionTokenType(UnknownValue);
        /// <summary> Simple Web Token. </summary>
        public static ContentKeyPolicyRestrictionTokenType Swt { get; } = new ContentKeyPolicyRestrictionTokenType(SwtValue);
        /// <summary> JSON Web Token. </summary>
        public static ContentKeyPolicyRestrictionTokenType Jwt { get; } = new ContentKeyPolicyRestrictionTokenType(JwtValue);
        /// <summary> Determines if two <see cref="ContentKeyPolicyRestrictionTokenType"/> values are the same. </summary>
        public static bool operator ==(ContentKeyPolicyRestrictionTokenType left, ContentKeyPolicyRestrictionTokenType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContentKeyPolicyRestrictionTokenType"/> values are not the same. </summary>
        public static bool operator !=(ContentKeyPolicyRestrictionTokenType left, ContentKeyPolicyRestrictionTokenType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContentKeyPolicyRestrictionTokenType"/>. </summary>
        public static implicit operator ContentKeyPolicyRestrictionTokenType(string value) => new ContentKeyPolicyRestrictionTokenType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentKeyPolicyRestrictionTokenType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContentKeyPolicyRestrictionTokenType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
