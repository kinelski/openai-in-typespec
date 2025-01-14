// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.VectorStores
{
    /// <summary> Enum for code in VectorStoreFileAssociationError. </summary>
    public readonly partial struct VectorStoreFileAssociationErrorCode : IEquatable<VectorStoreFileAssociationErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreFileAssociationErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreFileAssociationErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InternalErrorValue = "internal_error";
        private const string FileNotFoundValue = "file_not_found";
        private const string ParsingErrorValue = "parsing_error";
        private const string UnhandledMimeTypeValue = "unhandled_mime_type";

        /// <summary> internal_error. </summary>
        public static VectorStoreFileAssociationErrorCode InternalError { get; } = new VectorStoreFileAssociationErrorCode(InternalErrorValue);
        /// <summary> file_not_found. </summary>
        public static VectorStoreFileAssociationErrorCode FileNotFound { get; } = new VectorStoreFileAssociationErrorCode(FileNotFoundValue);
        /// <summary> parsing_error. </summary>
        public static VectorStoreFileAssociationErrorCode ParsingError { get; } = new VectorStoreFileAssociationErrorCode(ParsingErrorValue);
        /// <summary> unhandled_mime_type. </summary>
        public static VectorStoreFileAssociationErrorCode UnhandledMimeType { get; } = new VectorStoreFileAssociationErrorCode(UnhandledMimeTypeValue);
        /// <summary> Determines if two <see cref="VectorStoreFileAssociationErrorCode"/> values are the same. </summary>
        public static bool operator ==(VectorStoreFileAssociationErrorCode left, VectorStoreFileAssociationErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreFileAssociationErrorCode"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreFileAssociationErrorCode left, VectorStoreFileAssociationErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VectorStoreFileAssociationErrorCode"/>. </summary>
        public static implicit operator VectorStoreFileAssociationErrorCode(string value) => new VectorStoreFileAssociationErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreFileAssociationErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreFileAssociationErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
