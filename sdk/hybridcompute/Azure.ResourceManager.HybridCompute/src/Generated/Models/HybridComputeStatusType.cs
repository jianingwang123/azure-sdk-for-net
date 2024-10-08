// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> The status of the hybrid machine agent. </summary>
    public readonly partial struct HybridComputeStatusType : IEquatable<HybridComputeStatusType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HybridComputeStatusType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HybridComputeStatusType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConnectedValue = "Connected";
        private const string DisconnectedValue = "Disconnected";
        private const string ErrorValue = "Error";

        /// <summary> Connected. </summary>
        public static HybridComputeStatusType Connected { get; } = new HybridComputeStatusType(ConnectedValue);
        /// <summary> Disconnected. </summary>
        public static HybridComputeStatusType Disconnected { get; } = new HybridComputeStatusType(DisconnectedValue);
        /// <summary> Error. </summary>
        public static HybridComputeStatusType Error { get; } = new HybridComputeStatusType(ErrorValue);
        /// <summary> Determines if two <see cref="HybridComputeStatusType"/> values are the same. </summary>
        public static bool operator ==(HybridComputeStatusType left, HybridComputeStatusType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HybridComputeStatusType"/> values are not the same. </summary>
        public static bool operator !=(HybridComputeStatusType left, HybridComputeStatusType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HybridComputeStatusType"/>. </summary>
        public static implicit operator HybridComputeStatusType(string value) => new HybridComputeStatusType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HybridComputeStatusType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HybridComputeStatusType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
