// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The status of the device. If the status disabled, a device cannot connect to the service. </summary>
    public readonly partial struct DeviceStatus : IEquatable<DeviceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeviceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeviceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "enabled";
        private const string DisabledValue = "disabled";

        /// <summary> enabled. </summary>
        public static DeviceStatus Enabled { get; } = new DeviceStatus(EnabledValue);
        /// <summary> disabled. </summary>
        public static DeviceStatus Disabled { get; } = new DeviceStatus(DisabledValue);
        /// <summary> Determines if two <see cref="DeviceStatus"/> values are the same. </summary>
        public static bool operator ==(DeviceStatus left, DeviceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeviceStatus"/> values are not the same. </summary>
        public static bool operator !=(DeviceStatus left, DeviceStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeviceStatus"/>. </summary>
        public static implicit operator DeviceStatus(string value) => new DeviceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeviceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeviceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
