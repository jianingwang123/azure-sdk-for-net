// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The action type of a NAT rule collection. </summary>
    public readonly partial struct AzureFirewallNatRCActionType : IEquatable<AzureFirewallNatRCActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureFirewallNatRCActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureFirewallNatRCActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SnatValue = "Snat";
        private const string DnatValue = "Dnat";

        /// <summary> Snat. </summary>
        public static AzureFirewallNatRCActionType Snat { get; } = new AzureFirewallNatRCActionType(SnatValue);
        /// <summary> Dnat. </summary>
        public static AzureFirewallNatRCActionType Dnat { get; } = new AzureFirewallNatRCActionType(DnatValue);
        /// <summary> Determines if two <see cref="AzureFirewallNatRCActionType"/> values are the same. </summary>
        public static bool operator ==(AzureFirewallNatRCActionType left, AzureFirewallNatRCActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureFirewallNatRCActionType"/> values are not the same. </summary>
        public static bool operator !=(AzureFirewallNatRCActionType left, AzureFirewallNatRCActionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AzureFirewallNatRCActionType"/>. </summary>
        public static implicit operator AzureFirewallNatRCActionType(string value) => new AzureFirewallNatRCActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureFirewallNatRCActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureFirewallNatRCActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
