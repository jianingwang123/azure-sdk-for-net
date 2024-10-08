// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The SKU name of the container registry. Required for registry creation. </summary>
    public readonly partial struct ContainerRegistrySkuName : IEquatable<ContainerRegistrySkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistrySkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistrySkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClassicValue = "Classic";
        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> Classic. </summary>
        public static ContainerRegistrySkuName Classic { get; } = new ContainerRegistrySkuName(ClassicValue);
        /// <summary> Basic. </summary>
        public static ContainerRegistrySkuName Basic { get; } = new ContainerRegistrySkuName(BasicValue);
        /// <summary> Standard. </summary>
        public static ContainerRegistrySkuName Standard { get; } = new ContainerRegistrySkuName(StandardValue);
        /// <summary> Premium. </summary>
        public static ContainerRegistrySkuName Premium { get; } = new ContainerRegistrySkuName(PremiumValue);
        /// <summary> Determines if two <see cref="ContainerRegistrySkuName"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistrySkuName left, ContainerRegistrySkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistrySkuName"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistrySkuName left, ContainerRegistrySkuName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerRegistrySkuName"/>. </summary>
        public static implicit operator ContainerRegistrySkuName(string value) => new ContainerRegistrySkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistrySkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistrySkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
