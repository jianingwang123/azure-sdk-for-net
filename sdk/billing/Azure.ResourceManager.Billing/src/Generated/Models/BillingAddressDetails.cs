// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Address details. </summary>
    public partial class BillingAddressDetails
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

        /// <summary> Initializes a new instance of <see cref="BillingAddressDetails"/>. </summary>
        /// <param name="addressLine1"> Address line 1. </param>
        /// <param name="country"> Country code uses ISO 3166-1 Alpha-2 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="addressLine1"/> or <paramref name="country"/> is null. </exception>
        public BillingAddressDetails(string addressLine1, string country)
        {
            Argument.AssertNotNull(addressLine1, nameof(addressLine1));
            Argument.AssertNotNull(country, nameof(country));

            AddressLine1 = addressLine1;
            Country = country;
        }

        /// <summary> Initializes a new instance of <see cref="BillingAddressDetails"/>. </summary>
        /// <param name="addressLine1"> Address line 1. </param>
        /// <param name="addressLine2"> Address line 2. </param>
        /// <param name="addressLine3"> Address line 3. </param>
        /// <param name="city"> Address city. </param>
        /// <param name="companyName"> Company name. Optional for MCA Individual (Pay-as-you-go). </param>
        /// <param name="country"> Country code uses ISO 3166-1 Alpha-2 format. </param>
        /// <param name="district"> Address district. </param>
        /// <param name="email"> Email address. </param>
        /// <param name="firstName"> First name. Optional for MCA Enterprise. </param>
        /// <param name="lastName"> Last name. Optional for MCA Enterprise. </param>
        /// <param name="middleName"> Middle name. </param>
        /// <param name="phoneNumber"> Phone number. </param>
        /// <param name="postalCode"> Postal code. </param>
        /// <param name="region"> Address region. </param>
        /// <param name="isValidAddress"> Indicates if the address is incomplete. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingAddressDetails(string addressLine1, string addressLine2, string addressLine3, string city, string companyName, string country, string district, string email, string firstName, string lastName, string middleName, string phoneNumber, string postalCode, string region, bool? isValidAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            City = city;
            CompanyName = companyName;
            Country = country;
            District = district;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PhoneNumber = phoneNumber;
            PostalCode = postalCode;
            Region = region;
            IsValidAddress = isValidAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BillingAddressDetails"/> for deserialization. </summary>
        internal BillingAddressDetails()
        {
        }

        /// <summary> Address line 1. </summary>
        [WirePath("addressLine1")]
        public string AddressLine1 { get; set; }
        /// <summary> Address line 2. </summary>
        [WirePath("addressLine2")]
        public string AddressLine2 { get; set; }
        /// <summary> Address line 3. </summary>
        [WirePath("addressLine3")]
        public string AddressLine3 { get; set; }
        /// <summary> Address city. </summary>
        [WirePath("city")]
        public string City { get; set; }
        /// <summary> Company name. Optional for MCA Individual (Pay-as-you-go). </summary>
        [WirePath("companyName")]
        public string CompanyName { get; set; }
        /// <summary> Country code uses ISO 3166-1 Alpha-2 format. </summary>
        [WirePath("country")]
        public string Country { get; set; }
        /// <summary> Address district. </summary>
        [WirePath("district")]
        public string District { get; set; }
        /// <summary> Email address. </summary>
        [WirePath("email")]
        public string Email { get; set; }
        /// <summary> First name. Optional for MCA Enterprise. </summary>
        [WirePath("firstName")]
        public string FirstName { get; set; }
        /// <summary> Last name. Optional for MCA Enterprise. </summary>
        [WirePath("lastName")]
        public string LastName { get; set; }
        /// <summary> Middle name. </summary>
        [WirePath("middleName")]
        public string MiddleName { get; set; }
        /// <summary> Phone number. </summary>
        [WirePath("phoneNumber")]
        public string PhoneNumber { get; set; }
        /// <summary> Postal code. </summary>
        [WirePath("postalCode")]
        public string PostalCode { get; set; }
        /// <summary> Address region. </summary>
        [WirePath("region")]
        public string Region { get; set; }
        /// <summary> Indicates if the address is incomplete. </summary>
        [WirePath("isValidAddress")]
        public bool? IsValidAddress { get; set; }
    }
}
