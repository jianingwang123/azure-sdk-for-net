// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Details of storage account to be used for the Registry. </summary>
    public partial class StorageAccountDetails
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

        /// <summary> Initializes a new instance of <see cref="StorageAccountDetails"/>. </summary>
        public StorageAccountDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountDetails"/>. </summary>
        /// <param name="systemCreatedStorageAccount"> Details of system created storage account to be used for the registry. </param>
        /// <param name="userCreatedStorageAccount"> Details of user created storage account to be used for the registry. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountDetails(SystemCreatedStorageAccount systemCreatedStorageAccount, UserCreatedStorageAccount userCreatedStorageAccount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SystemCreatedStorageAccount = systemCreatedStorageAccount;
            UserCreatedStorageAccount = userCreatedStorageAccount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Details of system created storage account to be used for the registry. </summary>
        [WirePath("systemCreatedStorageAccount")]
        public SystemCreatedStorageAccount SystemCreatedStorageAccount { get; set; }
        /// <summary> Details of user created storage account to be used for the registry. </summary>
        internal UserCreatedStorageAccount UserCreatedStorageAccount { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        [WirePath("userCreatedStorageAccount.armResourceId.resourceId")]
        public ResourceIdentifier ArmResourceId
        {
            get => UserCreatedStorageAccount is null ? default : UserCreatedStorageAccount.ArmResourceId;
            set
            {
                if (UserCreatedStorageAccount is null)
                    UserCreatedStorageAccount = new UserCreatedStorageAccount();
                UserCreatedStorageAccount.ArmResourceId = value;
            }
        }
    }
}
