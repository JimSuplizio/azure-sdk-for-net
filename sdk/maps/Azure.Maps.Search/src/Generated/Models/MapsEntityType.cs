// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search.Models
{
    /// <summary> Entity type source of the bounding box. For reverse-geocoding this is always equal to position. </summary>
    public readonly partial struct MapsEntityType : IEquatable<MapsEntityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MapsEntityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MapsEntityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PositionValue = "position";

        /// <summary> Position entity. </summary>
        public static MapsEntityType Position { get; } = new MapsEntityType(PositionValue);
        /// <summary> Determines if two <see cref="MapsEntityType"/> values are the same. </summary>
        public static bool operator ==(MapsEntityType left, MapsEntityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MapsEntityType"/> values are not the same. </summary>
        public static bool operator !=(MapsEntityType left, MapsEntityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MapsEntityType"/>. </summary>
        public static implicit operator MapsEntityType(string value) => new MapsEntityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MapsEntityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MapsEntityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
