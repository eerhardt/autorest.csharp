// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtMockTest.Models
{
    /// <summary> The type of resource, Microsoft.KeyVault/vaults. </summary>
    public readonly partial struct EncryptionType : IEquatable<EncryptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EncryptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EncryptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftKeyVaultVaultsValue = "Microsoft.KeyVault/vaults";

        /// <summary> Microsoft.KeyVault/vaults. </summary>
        public static EncryptionType MicrosoftKeyVaultVaults { get; } = new EncryptionType(MicrosoftKeyVaultVaultsValue);
        /// <summary> Determines if two <see cref="EncryptionType"/> values are the same. </summary>
        public static bool operator ==(EncryptionType left, EncryptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EncryptionType"/> values are not the same. </summary>
        public static bool operator !=(EncryptionType left, EncryptionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EncryptionType"/>. </summary>
        public static implicit operator EncryptionType(string value) => new EncryptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EncryptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EncryptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}