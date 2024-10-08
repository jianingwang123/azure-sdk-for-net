// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The details of delete invoice section eligibility result. </summary>
    public partial class DeleteInvoiceSectionEligibilityDetail
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

        /// <summary> Initializes a new instance of <see cref="DeleteInvoiceSectionEligibilityDetail"/>. </summary>
        internal DeleteInvoiceSectionEligibilityDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeleteInvoiceSectionEligibilityDetail"/>. </summary>
        /// <param name="code"> Code for the delete invoice section validation. </param>
        /// <param name="message"> Validation message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeleteInvoiceSectionEligibilityDetail(DeleteInvoiceSectionEligibilityCode? code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Code for the delete invoice section validation. </summary>
        [WirePath("code")]
        public DeleteInvoiceSectionEligibilityCode? Code { get; }
        /// <summary> Validation message. </summary>
        [WirePath("message")]
        public string Message { get; }
    }
}
