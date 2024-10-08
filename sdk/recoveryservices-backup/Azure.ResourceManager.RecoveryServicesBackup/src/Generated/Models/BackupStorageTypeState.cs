// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Locked or Unlocked. Once a machine is registered against a resource, the storageTypeState is always Locked. </summary>
    public readonly partial struct BackupStorageTypeState : IEquatable<BackupStorageTypeState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupStorageTypeState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupStorageTypeState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string LockedValue = "Locked";
        private const string UnlockedValue = "Unlocked";

        /// <summary> Invalid. </summary>
        public static BackupStorageTypeState Invalid { get; } = new BackupStorageTypeState(InvalidValue);
        /// <summary> Locked. </summary>
        public static BackupStorageTypeState Locked { get; } = new BackupStorageTypeState(LockedValue);
        /// <summary> Unlocked. </summary>
        public static BackupStorageTypeState Unlocked { get; } = new BackupStorageTypeState(UnlockedValue);
        /// <summary> Determines if two <see cref="BackupStorageTypeState"/> values are the same. </summary>
        public static bool operator ==(BackupStorageTypeState left, BackupStorageTypeState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupStorageTypeState"/> values are not the same. </summary>
        public static bool operator !=(BackupStorageTypeState left, BackupStorageTypeState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BackupStorageTypeState"/>. </summary>
        public static implicit operator BackupStorageTypeState(string value) => new BackupStorageTypeState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupStorageTypeState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupStorageTypeState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
