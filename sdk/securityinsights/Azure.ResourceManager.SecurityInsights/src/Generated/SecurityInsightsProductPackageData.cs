// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsProductPackage data model.
    /// Represents a Package in Azure Security Insights.
    /// </summary>
    public partial class SecurityInsightsProductPackageData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsProductPackageData"/>. </summary>
        public SecurityInsightsProductPackageData()
        {
            Providers = new ChangeTrackingList<string>();
            ThreatAnalysisTactics = new ChangeTrackingList<string>();
            ThreatAnalysisTechniques = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsProductPackageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="contentId"> The content id of the package. </param>
        /// <param name="contentProductId"> Unique ID for the content. It should be generated based on the contentId, contentKind and the contentVersion of the package. </param>
        /// <param name="contentKind"> The package kind. </param>
        /// <param name="contentSchemaVersion"> The version of the content schema. </param>
        /// <param name="isNew"> Flag indicates if this is a newly published package. </param>
        /// <param name="isPreview"> Flag indicates if this package is in preview. </param>
        /// <param name="isFeatured"> Flag indicates if this package is among the featured list. </param>
        /// <param name="isDeprecated"> Flag indicates if this template is deprecated. </param>
        /// <param name="version"> the latest version number of the package. </param>
        /// <param name="displayName"> The display name of the package. </param>
        /// <param name="description"> The description of the package. </param>
        /// <param name="publisherDisplayName"> The publisher display name of the package. </param>
        /// <param name="source"> The source of the package. </param>
        /// <param name="author"> The author of the package. </param>
        /// <param name="support"> The support tier of the package. </param>
        /// <param name="dependencies"> The support tier of the package. </param>
        /// <param name="providers"> Providers for the package item. </param>
        /// <param name="firstPublishOn"> first publish date package item. </param>
        /// <param name="lastPublishOn"> last publish date for the package item. </param>
        /// <param name="categories"> The categories of the package. </param>
        /// <param name="threatAnalysisTactics"> the tactics the resource covers. </param>
        /// <param name="threatAnalysisTechniques"> the techniques the resource covers, these have to be aligned with the tactics being used. </param>
        /// <param name="icon"> the icon identifier. this id can later be fetched from the content metadata. </param>
        /// <param name="installedVersion"> The version of the installed package, null or absent means not installed. </param>
        /// <param name="metadataResourceId"> The metadata resource id. </param>
        /// <param name="packagedContent"> The json of the ARM template to deploy. Expandable. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsProductPackageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string contentId, string contentProductId, SecurityInsightsMetadataPackageKind? contentKind, string contentSchemaVersion, SecurityInsightsMetadataFlag? isNew, SecurityInsightsMetadataFlag? isPreview, SecurityInsightsMetadataFlag? isFeatured, SecurityInsightsMetadataFlag? isDeprecated, string version, string displayName, string description, string publisherDisplayName, SecurityInsightsMetadataSource source, SecurityInsightsMetadataAuthor author, SecurityInsightsMetadataSupport support, SecurityInsightsMetadataDependencies dependencies, IList<string> providers, DateTimeOffset? firstPublishOn, DateTimeOffset? lastPublishOn, SecurityInsightsMetadataCategories categories, IList<string> threatAnalysisTactics, IList<string> threatAnalysisTechniques, string icon, string installedVersion, ResourceIdentifier metadataResourceId, BinaryData packagedContent, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ContentId = contentId;
            ContentProductId = contentProductId;
            ContentKind = contentKind;
            ContentSchemaVersion = contentSchemaVersion;
            IsNew = isNew;
            IsPreview = isPreview;
            IsFeatured = isFeatured;
            IsDeprecated = isDeprecated;
            Version = version;
            DisplayName = displayName;
            Description = description;
            PublisherDisplayName = publisherDisplayName;
            Source = source;
            Author = author;
            Support = support;
            Dependencies = dependencies;
            Providers = providers;
            FirstPublishOn = firstPublishOn;
            LastPublishOn = lastPublishOn;
            Categories = categories;
            ThreatAnalysisTactics = threatAnalysisTactics;
            ThreatAnalysisTechniques = threatAnalysisTechniques;
            Icon = icon;
            InstalledVersion = installedVersion;
            MetadataResourceId = metadataResourceId;
            PackagedContent = packagedContent;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The content id of the package. </summary>
        [WirePath("properties.contentId")]
        public string ContentId { get; set; }
        /// <summary> Unique ID for the content. It should be generated based on the contentId, contentKind and the contentVersion of the package. </summary>
        [WirePath("properties.contentProductId")]
        public string ContentProductId { get; set; }
        /// <summary> The package kind. </summary>
        [WirePath("properties.contentKind")]
        public SecurityInsightsMetadataPackageKind? ContentKind { get; set; }
        /// <summary> The version of the content schema. </summary>
        [WirePath("properties.contentSchemaVersion")]
        public string ContentSchemaVersion { get; set; }
        /// <summary> Flag indicates if this is a newly published package. </summary>
        [WirePath("properties.isNew")]
        public SecurityInsightsMetadataFlag? IsNew { get; set; }
        /// <summary> Flag indicates if this package is in preview. </summary>
        [WirePath("properties.isPreview")]
        public SecurityInsightsMetadataFlag? IsPreview { get; set; }
        /// <summary> Flag indicates if this package is among the featured list. </summary>
        [WirePath("properties.isFeatured")]
        public SecurityInsightsMetadataFlag? IsFeatured { get; set; }
        /// <summary> Flag indicates if this template is deprecated. </summary>
        [WirePath("properties.isDeprecated")]
        public SecurityInsightsMetadataFlag? IsDeprecated { get; set; }
        /// <summary> the latest version number of the package. </summary>
        [WirePath("properties.version")]
        public string Version { get; set; }
        /// <summary> The display name of the package. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> The description of the package. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> The publisher display name of the package. </summary>
        [WirePath("properties.publisherDisplayName")]
        public string PublisherDisplayName { get; set; }
        /// <summary> The source of the package. </summary>
        [WirePath("properties.source")]
        public SecurityInsightsMetadataSource Source { get; set; }
        /// <summary> The author of the package. </summary>
        [WirePath("properties.author")]
        public SecurityInsightsMetadataAuthor Author { get; set; }
        /// <summary> The support tier of the package. </summary>
        [WirePath("properties.support")]
        public SecurityInsightsMetadataSupport Support { get; set; }
        /// <summary> The support tier of the package. </summary>
        [WirePath("properties.dependencies")]
        public SecurityInsightsMetadataDependencies Dependencies { get; set; }
        /// <summary> Providers for the package item. </summary>
        [WirePath("properties.providers")]
        public IList<string> Providers { get; }
        /// <summary> first publish date package item. </summary>
        [WirePath("properties.firstPublishDate")]
        public DateTimeOffset? FirstPublishOn { get; set; }
        /// <summary> last publish date for the package item. </summary>
        [WirePath("properties.lastPublishDate")]
        public DateTimeOffset? LastPublishOn { get; set; }
        /// <summary> The categories of the package. </summary>
        [WirePath("properties.categories")]
        public SecurityInsightsMetadataCategories Categories { get; set; }
        /// <summary> the tactics the resource covers. </summary>
        [WirePath("properties.threatAnalysisTactics")]
        public IList<string> ThreatAnalysisTactics { get; }
        /// <summary> the techniques the resource covers, these have to be aligned with the tactics being used. </summary>
        [WirePath("properties.threatAnalysisTechniques")]
        public IList<string> ThreatAnalysisTechniques { get; }
        /// <summary> the icon identifier. this id can later be fetched from the content metadata. </summary>
        [WirePath("properties.icon")]
        public string Icon { get; set; }
        /// <summary> The version of the installed package, null or absent means not installed. </summary>
        [WirePath("properties.installedVersion")]
        public string InstalledVersion { get; set; }
        /// <summary> The metadata resource id. </summary>
        [WirePath("properties.metadataResourceId")]
        public ResourceIdentifier MetadataResourceId { get; set; }
        /// <summary>
        /// The json of the ARM template to deploy. Expandable.
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
        [WirePath("properties.packagedContent")]
        public BinaryData PackagedContent { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; set; }
    }
}
