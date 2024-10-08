// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningFeatureStoreEntityContainerCollectionGetAllOptions. </summary>
    public partial class MachineLearningFeatureStoreEntityContainerCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningFeatureStoreEntityContainerCollectionGetAllOptions"/>. </summary>
        public MachineLearningFeatureStoreEntityContainerCollectionGetAllOptions()
        {
        }

        /// <summary> Continuation token for pagination. </summary>
        [WirePath("skip")]
        public string Skip { get; set; }
        /// <summary> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </summary>
        [WirePath("tags")]
        public string Tags { get; set; }
        /// <summary> [ListViewType.ActiveOnly, ListViewType.ArchivedOnly, ListViewType.All]View type for including/excluding (for example) archived entities. </summary>
        [WirePath("listViewType")]
        public MachineLearningListViewType? ListViewType { get; set; }
        /// <summary> page size. </summary>
        [WirePath("pageSize")]
        public int? PageSize { get; set; }
        /// <summary> name for the featurestore entity. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> description for the featurestore entity. </summary>
        [WirePath("description")]
        public string Description { get; set; }
        /// <summary> createdBy user name. </summary>
        [WirePath("createdBy")]
        public string CreatedBy { get; set; }
    }
}
