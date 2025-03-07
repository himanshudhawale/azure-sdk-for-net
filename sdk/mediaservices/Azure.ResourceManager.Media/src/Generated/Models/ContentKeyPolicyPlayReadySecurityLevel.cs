// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The security level. </summary>
    public readonly partial struct ContentKeyPolicyPlayReadySecurityLevel : IEquatable<ContentKeyPolicyPlayReadySecurityLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyPlayReadySecurityLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentKeyPolicyPlayReadySecurityLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string SL150Value = "SL150";
        private const string SL2000Value = "SL2000";
        private const string SL3000Value = "SL3000";

        /// <summary> Represents a SecurityLevel that is unavailable in current API version. </summary>
        public static ContentKeyPolicyPlayReadySecurityLevel Unknown { get; } = new ContentKeyPolicyPlayReadySecurityLevel(UnknownValue);
        /// <summary> For clients under development or test. No protection against unauthorized use. </summary>
        public static ContentKeyPolicyPlayReadySecurityLevel SL150 { get; } = new ContentKeyPolicyPlayReadySecurityLevel(SL150Value);
        /// <summary> For hardened devices and applications consuming commercial content. Software or hardware protection. </summary>
        public static ContentKeyPolicyPlayReadySecurityLevel SL2000 { get; } = new ContentKeyPolicyPlayReadySecurityLevel(SL2000Value);
        /// <summary> For hardened devices only. Hardware protection. </summary>
        public static ContentKeyPolicyPlayReadySecurityLevel SL3000 { get; } = new ContentKeyPolicyPlayReadySecurityLevel(SL3000Value);
        /// <summary> Determines if two <see cref="ContentKeyPolicyPlayReadySecurityLevel"/> values are the same. </summary>
        public static bool operator ==(ContentKeyPolicyPlayReadySecurityLevel left, ContentKeyPolicyPlayReadySecurityLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContentKeyPolicyPlayReadySecurityLevel"/> values are not the same. </summary>
        public static bool operator !=(ContentKeyPolicyPlayReadySecurityLevel left, ContentKeyPolicyPlayReadySecurityLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContentKeyPolicyPlayReadySecurityLevel"/>. </summary>
        public static implicit operator ContentKeyPolicyPlayReadySecurityLevel(string value) => new ContentKeyPolicyPlayReadySecurityLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentKeyPolicyPlayReadySecurityLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContentKeyPolicyPlayReadySecurityLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
