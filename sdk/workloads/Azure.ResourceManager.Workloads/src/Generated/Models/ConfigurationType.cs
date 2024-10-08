// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The type of file share config. </summary>
    internal readonly partial struct ConfigurationType : IEquatable<ConfigurationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfigurationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfigurationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SkipValue = "Skip";
        private const string CreateAndMountValue = "CreateAndMount";
        private const string MountValue = "Mount";

        /// <summary> Skip. </summary>
        public static ConfigurationType Skip { get; } = new ConfigurationType(SkipValue);
        /// <summary> CreateAndMount. </summary>
        public static ConfigurationType CreateAndMount { get; } = new ConfigurationType(CreateAndMountValue);
        /// <summary> Mount. </summary>
        public static ConfigurationType Mount { get; } = new ConfigurationType(MountValue);
        /// <summary> Determines if two <see cref="ConfigurationType"/> values are the same. </summary>
        public static bool operator ==(ConfigurationType left, ConfigurationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfigurationType"/> values are not the same. </summary>
        public static bool operator !=(ConfigurationType left, ConfigurationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConfigurationType"/>. </summary>
        public static implicit operator ConfigurationType(string value) => new ConfigurationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfigurationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfigurationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
