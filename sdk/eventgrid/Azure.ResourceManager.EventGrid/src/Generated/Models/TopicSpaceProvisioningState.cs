// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the TopicSpace resource. </summary>
    public readonly partial struct TopicSpaceProvisioningState : IEquatable<TopicSpaceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TopicSpaceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TopicSpaceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string DeletedValue = "Deleted";

        /// <summary> Creating. </summary>
        public static TopicSpaceProvisioningState Creating { get; } = new TopicSpaceProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static TopicSpaceProvisioningState Updating { get; } = new TopicSpaceProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static TopicSpaceProvisioningState Deleting { get; } = new TopicSpaceProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static TopicSpaceProvisioningState Succeeded { get; } = new TopicSpaceProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static TopicSpaceProvisioningState Canceled { get; } = new TopicSpaceProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static TopicSpaceProvisioningState Failed { get; } = new TopicSpaceProvisioningState(FailedValue);
        /// <summary> Deleted. </summary>
        public static TopicSpaceProvisioningState Deleted { get; } = new TopicSpaceProvisioningState(DeletedValue);
        /// <summary> Determines if two <see cref="TopicSpaceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(TopicSpaceProvisioningState left, TopicSpaceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TopicSpaceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(TopicSpaceProvisioningState left, TopicSpaceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TopicSpaceProvisioningState"/>. </summary>
        public static implicit operator TopicSpaceProvisioningState(string value) => new TopicSpaceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TopicSpaceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TopicSpaceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
