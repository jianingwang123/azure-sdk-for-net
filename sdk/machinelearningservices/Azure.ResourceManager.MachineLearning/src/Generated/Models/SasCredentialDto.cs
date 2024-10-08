// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The SasCredentialDto. </summary>
    public partial class SasCredentialDto : PendingUploadCredentialDto
    {
        /// <summary> Initializes a new instance of <see cref="SasCredentialDto"/>. </summary>
        internal SasCredentialDto()
        {
            CredentialType = PendingUploadCredentialType.Sas;
        }

        /// <summary> Initializes a new instance of <see cref="SasCredentialDto"/>. </summary>
        /// <param name="credentialType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sasUri"> Full SAS Uri, including the storage, container/blob path and SAS token. </param>
        internal SasCredentialDto(PendingUploadCredentialType credentialType, IDictionary<string, BinaryData> serializedAdditionalRawData, Uri sasUri) : base(credentialType, serializedAdditionalRawData)
        {
            SasUri = sasUri;
            CredentialType = credentialType;
        }

        /// <summary> Full SAS Uri, including the storage, container/blob path and SAS token. </summary>
        [WirePath("sasUri")]
        public Uri SasUri { get; }
    }
}
