// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Column data type. </summary>
    public readonly partial struct ColumnTypeEnum : IEquatable<ColumnTypeEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ColumnTypeEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ColumnTypeEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "string";
        private const string IntValue = "int";
        private const string LongValue = "long";
        private const string RealValue = "real";
        private const string BooleanValue = "boolean";
        private const string DateTimeValue = "dateTime";
        private const string GuidValue = "guid";
        private const string DynamicValue = "dynamic";

        /// <summary> string. </summary>
        public static ColumnTypeEnum String { get; } = new ColumnTypeEnum(StringValue);
        /// <summary> int. </summary>
        public static ColumnTypeEnum Int { get; } = new ColumnTypeEnum(IntValue);
        /// <summary> long. </summary>
        public static ColumnTypeEnum Long { get; } = new ColumnTypeEnum(LongValue);
        /// <summary> real. </summary>
        public static ColumnTypeEnum Real { get; } = new ColumnTypeEnum(RealValue);
        /// <summary> boolean. </summary>
        public static ColumnTypeEnum Boolean { get; } = new ColumnTypeEnum(BooleanValue);
        /// <summary> dateTime. </summary>
        public static ColumnTypeEnum DateTime { get; } = new ColumnTypeEnum(DateTimeValue);
        /// <summary> guid. </summary>
        public static ColumnTypeEnum Guid { get; } = new ColumnTypeEnum(GuidValue);
        /// <summary> dynamic. </summary>
        public static ColumnTypeEnum Dynamic { get; } = new ColumnTypeEnum(DynamicValue);
        /// <summary> Determines if two <see cref="ColumnTypeEnum"/> values are the same. </summary>
        public static bool operator ==(ColumnTypeEnum left, ColumnTypeEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ColumnTypeEnum"/> values are not the same. </summary>
        public static bool operator !=(ColumnTypeEnum left, ColumnTypeEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ColumnTypeEnum"/>. </summary>
        public static implicit operator ColumnTypeEnum(string value) => new ColumnTypeEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ColumnTypeEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ColumnTypeEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
