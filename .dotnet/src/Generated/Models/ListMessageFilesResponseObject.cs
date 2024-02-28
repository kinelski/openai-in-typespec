// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The ListMessageFilesResponse_object. </summary>
    internal readonly partial struct ListMessageFilesResponseObject : IEquatable<ListMessageFilesResponseObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ListMessageFilesResponseObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ListMessageFilesResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static ListMessageFilesResponseObject List { get; } = new ListMessageFilesResponseObject(ListValue);
        /// <summary> Determines if two <see cref="ListMessageFilesResponseObject"/> values are the same. </summary>
        public static bool operator ==(ListMessageFilesResponseObject left, ListMessageFilesResponseObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ListMessageFilesResponseObject"/> values are not the same. </summary>
        public static bool operator !=(ListMessageFilesResponseObject left, ListMessageFilesResponseObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ListMessageFilesResponseObject"/>. </summary>
        public static implicit operator ListMessageFilesResponseObject(string value) => new ListMessageFilesResponseObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListMessageFilesResponseObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ListMessageFilesResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
