// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Routing.Models
{
    /// <summary> The WindingnessLevel. </summary>
    public readonly partial struct WindingnessLevel : IEquatable<WindingnessLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WindingnessLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WindingnessLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowValue = "low";
        private const string NormalValue = "normal";
        private const string HighValue = "high";

        /// <summary> low. </summary>
        public static WindingnessLevel Low { get; } = new WindingnessLevel(LowValue);
        /// <summary> normal. </summary>
        public static WindingnessLevel Normal { get; } = new WindingnessLevel(NormalValue);
        /// <summary> high. </summary>
        public static WindingnessLevel High { get; } = new WindingnessLevel(HighValue);
        /// <summary> Determines if two <see cref="WindingnessLevel"/> values are the same. </summary>
        public static bool operator ==(WindingnessLevel left, WindingnessLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WindingnessLevel"/> values are not the same. </summary>
        public static bool operator !=(WindingnessLevel left, WindingnessLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WindingnessLevel"/>. </summary>
        public static implicit operator WindingnessLevel(string value) => new WindingnessLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WindingnessLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WindingnessLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
