// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace BasicTypeSpec.Models
{
    /// <summary> this is a model with a projected name. </summary>
    public partial class ProjectedModel
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ProjectedModel(string name)
        {
            Name = name;
        }

        internal ProjectedModel(string name, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Name = name;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> name of the ModelWithProjectedName. </summary>
        public string Name { get; }
    }
}
