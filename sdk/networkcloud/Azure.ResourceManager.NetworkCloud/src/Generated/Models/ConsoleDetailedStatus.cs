// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The more detailed status of the console. </summary>
    public readonly partial struct ConsoleDetailedStatus : IEquatable<ConsoleDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConsoleDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConsoleDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadyValue = "Ready";
        private const string ErrorValue = "Error";

        /// <summary> Ready. </summary>
        public static ConsoleDetailedStatus Ready { get; } = new ConsoleDetailedStatus(ReadyValue);
        /// <summary> Error. </summary>
        public static ConsoleDetailedStatus Error { get; } = new ConsoleDetailedStatus(ErrorValue);
        /// <summary> Determines if two <see cref="ConsoleDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(ConsoleDetailedStatus left, ConsoleDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConsoleDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(ConsoleDetailedStatus left, ConsoleDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConsoleDetailedStatus"/>. </summary>
        public static implicit operator ConsoleDetailedStatus(string value) => new ConsoleDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConsoleDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConsoleDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
