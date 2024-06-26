// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Pricing information about the sku. </summary>
    public partial class ReservationCatalogMsrp
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReservationCatalogMsrp"/>. </summary>
        internal ReservationCatalogMsrp()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationCatalogMsrp"/>. </summary>
        /// <param name="p1Y"> Amount in pricing currency. Tax not included. </param>
        /// <param name="p3Y"> Amount in pricing currency. Tax not included. </param>
        /// <param name="p5Y"> Amount in pricing currency. Tax not included. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationCatalogMsrp(PurchasePrice p1Y, PurchasePrice p3Y, PurchasePrice p5Y, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            P1Y = p1Y;
            P3Y = p3Y;
            P5Y = p5Y;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Amount in pricing currency. Tax not included. </summary>
        public PurchasePrice P1Y { get; }
        /// <summary> Amount in pricing currency. Tax not included. </summary>
        public PurchasePrice P3Y { get; }
        /// <summary> Amount in pricing currency. Tax not included. </summary>
        public PurchasePrice P5Y { get; }
    }
}
