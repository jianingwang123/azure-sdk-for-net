// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Metric Id on which the throttle limit should be set, MetricId can be discovered by hovering over Metric in the Metrics section of Event Hub Namespace inside Azure Portal. </summary>
    public readonly partial struct EventHubsMetricId : IEquatable<EventHubsMetricId>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventHubsMetricId"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventHubsMetricId(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IncomingBytesValue = "IncomingBytes";
        private const string OutgoingBytesValue = "OutgoingBytes";
        private const string IncomingMessagesValue = "IncomingMessages";
        private const string OutgoingMessagesValue = "OutgoingMessages";

        /// <summary> IncomingBytes. </summary>
        public static EventHubsMetricId IncomingBytes { get; } = new EventHubsMetricId(IncomingBytesValue);
        /// <summary> OutgoingBytes. </summary>
        public static EventHubsMetricId OutgoingBytes { get; } = new EventHubsMetricId(OutgoingBytesValue);
        /// <summary> IncomingMessages. </summary>
        public static EventHubsMetricId IncomingMessages { get; } = new EventHubsMetricId(IncomingMessagesValue);
        /// <summary> OutgoingMessages. </summary>
        public static EventHubsMetricId OutgoingMessages { get; } = new EventHubsMetricId(OutgoingMessagesValue);
        /// <summary> Determines if two <see cref="EventHubsMetricId"/> values are the same. </summary>
        public static bool operator ==(EventHubsMetricId left, EventHubsMetricId right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventHubsMetricId"/> values are not the same. </summary>
        public static bool operator !=(EventHubsMetricId left, EventHubsMetricId right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventHubsMetricId"/>. </summary>
        public static implicit operator EventHubsMetricId(string value) => new EventHubsMetricId(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventHubsMetricId other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventHubsMetricId other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
