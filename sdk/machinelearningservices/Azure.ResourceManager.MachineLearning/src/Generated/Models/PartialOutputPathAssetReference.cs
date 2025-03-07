// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Reference to an asset via its path in a job output. </summary>
    public partial class PartialOutputPathAssetReference : PartialAssetReferenceBase
    {
        /// <summary> Initializes a new instance of PartialOutputPathAssetReference. </summary>
        public PartialOutputPathAssetReference()
        {
            ReferenceType = ReferenceType.OutputPath;
        }

        /// <summary> ARM resource ID of the job. </summary>
        public string JobId { get; set; }
        /// <summary> The path of the file/directory in the job output. </summary>
        public string Path { get; set; }
    }
}
