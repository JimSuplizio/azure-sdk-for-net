// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> Represents the speed entity resolution model. </summary>
    public partial class SpeedResolution : ResolutionBase
    {
        /// <summary> Initializes a new instance of <see cref="SpeedResolution"/>. </summary>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"> The speed Unit of measurement. </param>
        internal SpeedResolution(double value, SpeedUnit unit)
        {
            ResolutionKind = ResolutionKind.SpeedResolution;
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="SpeedResolution"/>. </summary>
        /// <param name="resolutionKind"> The entity resolution object kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"> The numeric value that the extracted text denotes. </param>
        /// <param name="unit"> The speed Unit of measurement. </param>
        internal SpeedResolution(ResolutionKind resolutionKind, IDictionary<string, BinaryData> serializedAdditionalRawData, double value, SpeedUnit unit) : base(resolutionKind, serializedAdditionalRawData)
        {
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="SpeedResolution"/> for deserialization. </summary>
        internal SpeedResolution()
        {
        }

        /// <summary> The numeric value that the extracted text denotes. </summary>
        public double Value { get; }
        /// <summary> The speed Unit of measurement. </summary>
        public SpeedUnit Unit { get; }
    }
}
