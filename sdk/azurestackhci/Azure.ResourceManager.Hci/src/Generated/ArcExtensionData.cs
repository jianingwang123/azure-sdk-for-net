// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the ArcExtension data model.
    /// Details of a particular extension in HCI Cluster.
    /// </summary>
    public partial class ArcExtensionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ArcExtensionData"/>. </summary>
        public ArcExtensionData()
        {
            PerNodeExtensionDetails = new ChangeTrackingList<PerNodeExtensionState>();
        }

        /// <summary> Initializes a new instance of <see cref="ArcExtensionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the Extension proxy resource. </param>
        /// <param name="aggregateState"> Aggregate state of Arc Extensions across the nodes in this HCI cluster. </param>
        /// <param name="perNodeExtensionDetails"> State of Arc Extension in each of the nodes. </param>
        /// <param name="managedBy"> Indicates if the extension is managed by azure or the user. </param>
        /// <param name="forceUpdateTag"> How the extension handler should be forced to update even if the extension configuration has not changed. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="arcExtensionType"> Specifies the type of the extension; an example is "CustomScriptExtension". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. Latest version would be used if not specified. </param>
        /// <param name="shouldAutoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> Protected settings (may contain secrets). </param>
        /// <param name="enableAutomaticUpgrade"> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArcExtensionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, HciProvisioningState? provisioningState, ArcExtensionAggregateState? aggregateState, IReadOnlyList<PerNodeExtensionState> perNodeExtensionDetails, ArcExtensionManagedBy? managedBy, string forceUpdateTag, string publisher, string arcExtensionType, string typeHandlerVersion, bool? shouldAutoUpgradeMinorVersion, BinaryData settings, BinaryData protectedSettings, bool? enableAutomaticUpgrade, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            AggregateState = aggregateState;
            PerNodeExtensionDetails = perNodeExtensionDetails;
            ManagedBy = managedBy;
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            ArcExtensionType = arcExtensionType;
            TypeHandlerVersion = typeHandlerVersion;
            ShouldAutoUpgradeMinorVersion = shouldAutoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            EnableAutomaticUpgrade = enableAutomaticUpgrade;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning state of the Extension proxy resource. </summary>
        [WirePath("properties.provisioningState")]
        public HciProvisioningState? ProvisioningState { get; }
        /// <summary> Aggregate state of Arc Extensions across the nodes in this HCI cluster. </summary>
        [WirePath("properties.aggregateState")]
        public ArcExtensionAggregateState? AggregateState { get; }
        /// <summary> State of Arc Extension in each of the nodes. </summary>
        [WirePath("properties.perNodeExtensionDetails")]
        public IReadOnlyList<PerNodeExtensionState> PerNodeExtensionDetails { get; }
        /// <summary> Indicates if the extension is managed by azure or the user. </summary>
        [WirePath("properties.managedBy")]
        public ArcExtensionManagedBy? ManagedBy { get; }
        /// <summary> How the extension handler should be forced to update even if the extension configuration has not changed. </summary>
        [WirePath("properties.forceUpdateTag")]
        public string ForceUpdateTag { get; set; }
        /// <summary> The name of the extension handler publisher. </summary>
        [WirePath("properties.publisher")]
        public string Publisher { get; set; }
        /// <summary> Specifies the type of the extension; an example is "CustomScriptExtension". </summary>
        [WirePath("properties.type")]
        public string ArcExtensionType { get; set; }
        /// <summary> Specifies the version of the script handler. Latest version would be used if not specified. </summary>
        [WirePath("properties.typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }
        /// <summary> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </summary>
        [WirePath("properties.autoUpgradeMinorVersion")]
        public bool? ShouldAutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Json formatted public settings for the extension.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("properties.settings")]
        public BinaryData Settings { get; set; }
        /// <summary>
        /// Protected settings (may contain secrets).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("properties.protectedSettings")]
        public BinaryData ProtectedSettings { get; set; }
        /// <summary> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version available. </summary>
        [WirePath("properties.enableAutomaticUpgrade")]
        public bool? EnableAutomaticUpgrade { get; set; }
    }
}
